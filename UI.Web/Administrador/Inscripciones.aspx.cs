using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class Inscripciones : ABM
    {

        private BusinessEntity.States _estado;

        public BusinessEntity.States Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        private static List<Business.Entities.Personas> _alumnos = new List<Business.Entities.Personas>();

        public List<Business.Entities.Personas> Alumnos
        {
            get { return _alumnos; }
            set { _alumnos = value; }
        }

        private List<AlumnoInscripcion> _inscripciones = new List<AlumnoInscripcion>();

        public List<AlumnoInscripcion> Inscrip
        {
            get { return _inscripciones; }
            set { _inscripciones = value; }
        }

        private List<Curso> _cursos = new List<Curso>();

        public List<Curso> Cursos
        {
            get { return _cursos; }
            set { _cursos = value; }
        }
        
        private AlumnoInscripcionLogic _insLogic;

        public AlumnoInscripcionLogic InscLogic
        {
            get
            {
                if (_insLogic == null)
                {
                    _insLogic = new AlumnoInscripcionLogic();
                }
                return _insLogic;
            }
        }

        private AlumnoInscripcion Entity
        {
            set;
            get;
        }


        #region Metodos
        
        private void ClearForm()
        {
            ddlCondicion.SelectedIndex = -1;
            ddlNotas.SelectedIndex = -1;
        }

        private void HabilitarControles(bool condicion)
        {
            ddlCondicion.Enabled = condicion;
            ddlNotas.Enabled = condicion;
        }

        private void SaveEntity(AlumnoInscripcion Alu)
        {
            Entity.State = Estado;
            //agregar datos a entity
        }
        private void LoadEntity(AlumnoInscripcion alu)
        {
            // no se uso todavia
        }
        private void DeleteEntity(int id)
        {
            this.InscLogic.Delete(id);
        }
        
        protected void cargarCursos()
        {
            List<Object> lista = new List<Object>();
            MateriaLogic ml = new MateriaLogic();
            ComisionLogic coml = new ComisionLogic();

            foreach (Curso c in Cursos)
            {
                Object obj = new
                {
                    ID = c.ID,
                    materia = ml.GetOne(c.IDMateria).Descripcion,
                    comision = coml.GetOne(c.IDComision).Descripcion,
                    anio_curso = c.AnioCalendario.ToString(),
                    cupo_curso = c.Cupo.ToString()
                    
                };
                lista.Add(obj);
                
            }
            grvCursos.DataSource = lista;
            grvCursos.DataBind(); 

        }

        protected void cargaInscripciones(int idAlu)
        {
            MateriaLogic ml = new MateriaLogic();
            ComisionLogic coml = new ComisionLogic();
            AlumnoInscripcionLogic ail = new AlumnoInscripcionLogic();
            List<Object> listaInscripciones = new List<Object>(); //será tipo anónimo
            Inscrip = ail.GetAll(idAlu);

            foreach (AlumnoInscripcion alumInsc in Inscrip)
            {
                foreach (Curso cur in Cursos) //recuperar datos del curso
                {
                    if (cur.ID == alumInsc.IdCurso)
                    {
                        //Armo el tipo anonimo
                        listaInscripciones.Add(new
                        {
                            ID = alumInsc.ID,
                            materiaDesc = ml.GetOne(cur.IDMateria).Descripcion,
                            año = cur.AnioCalendario,
                            comisionDesc = coml.GetOne(cur.IDComision).Descripcion,
                            condicion = alumInsc.Condicion,
                            nota= alumInsc.Nota
                        });
                        break;
                    }
                }
            }
            grvInscripciones.DataSource = listaInscripciones;
            grvInscripciones.DataBind();

        }

        public void GuardarCambios()
        {
            if(FormMode == FormModes.Alta)
            {
                this.SaveEntity(Entity);
            }
            if (FormMode == FormModes.Modificacion)
            {
                Entity.State = Estado;
                this.SaveEntity(Entity);
            }
            if (FormMode == FormModes.Baja)
            {
                this.DeleteEntity(Entity.ID);
            }
        }
    
        #endregion

        #region Eventos

        protected override void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string si = "menuInscripciones";
                Session["Menu"] = si;

                PersonaLogic plog = new PersonaLogic();
                Alumnos = plog.GetAll(Business.Entities.Personas.TiposPersonas.Alumno);
                grvAlumnos.DataSource = Alumnos;
                grvAlumnos.DataBind();

                CursoLogic clog = new CursoLogic();
                Cursos = clog.GetAll();
                cargarCursos();

                ddlNotas.Items.Add("");
                for (int i = 0; i <= 10; i++)
                {
                    ddlNotas.Items.Add(i.ToString());
                }

                ddlCondicion.Items.Add("");
                ddlCondicion.Items.Add(AlumnoInscripcion.TiposCondiciones.Inscripto.ToString());
                ddlCondicion.Items.Add(AlumnoInscripcion.TiposCondiciones.Cursando.ToString());
                ddlCondicion.Items.Add(AlumnoInscripcion.TiposCondiciones.Regular.ToString());
                ddlCondicion.Items.Add(AlumnoInscripcion.TiposCondiciones.Promocionado.ToString());
                ddlCondicion.Items.Add(AlumnoInscripcion.TiposCondiciones.Aprobado.ToString());
                ddlCondicion.Items.Add(AlumnoInscripcion.TiposCondiciones.Libre.ToString());
            }

        }
        
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~Administrador/Inscripciones.aspx");
            this.panelControlesInscripciones.Visible = false;
            this.panelGrillaInscripciones.Visible = false;
            this.panelGrillaCursos.Visible = false;
            this.panelControlesInscripciones.Visible = false;

        }

        protected void grvAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Elegis el alumno y lista las inscripciones que tiene
            if (grvAlumnos.SelectedIndex != -1)
            {
                this.panelGrillaInscripciones.Visible = true;
                cargaInscripciones(Alumnos[grvAlumnos.SelectedIndex].ID);
                this.panelControlesInscripciones.Visible = true;
                lblAlumno.Visible = false;
            }
        }

        protected void grvInscripciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Trae datos del curso
            if (grvInscripciones.SelectedIndex != -1)
            {
                panelGrillaCursos.Visible = true;
                this.cargarCursos();
            }
        }

        protected void btnAgregarInscripcion_Click(object sender, EventArgs e)
        {
            if (grvAlumnos.SelectedIndex != -1)
            {
                this.FormMode = FormModes.Alta;
                panelABMInscripciones.Visible = true;
                panelGrillaCursos.Visible = true;
                btnAceptar.Text = "Agregar";
                lblInscripcion.Visible = false;
                Estado = BusinessEntity.States.New;
            }
            else
            {
                lblInscripcion.Visible = true;
                lblInscripcion.Text = "Debe seleccionar un alumno para agregar una inscripción";
            }
        }

        protected void btnEditarInscripcion_Click(object sender, EventArgs e)
        {
            if (grvInscripciones.SelectedIndex != -1)
            {
                this.FormMode = FormModes.Modificacion;
                lblInscripcion.Visible = false;
                panelGrillaCursos.Visible = true;
                panelABMInscripciones.Visible = true;
                HabilitarControles(true);
                btnAceptar.Text = "Guardar";
                Estado = BusinessEntity.States.Modified;
            }
            else
            {
                lblInscripcion.Visible = true;
                lblInscripcion.Text = "Debe seleccionar una inscripción para editarla";
            }
        }

        protected void btnEliminarInscripcion_Click(object sender, EventArgs e)
        {
            if (grvInscripciones.SelectedIndex != -1)
            {
                this.FormMode = FormModes.Baja;
                lblInscripcion.Visible = false;
                panelABMInscripciones.Visible = true;
                HabilitarControles(false);
                btnAceptar.Text = "Eliminar";
                Estado = BusinessEntity.States.Deleted;
            }
            else
            {
                panelABMInscripciones.Visible = false;
                lblInscripcion.Text = "Debe selecionar una inscripción para eliminarla";
            }
        }

        protected void btnCancelar_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/Administrador/Inscripciones.aspx");
            this.panelABMInscripciones.Visible = false;
            this.panelGrillaInscripciones.Visible = false;
            this.panelGrillaCursos.Visible = false;
            this.panelControlesInscripciones.Visible = false;
        }

        protected void btnAceptar_Click1(object sender, EventArgs e)
        {
            if (grvCursos.SelectedIndex != -1)
            {
                lblCurso.Visible = false;
                //GuardarCambios();
            }
            else
            {
                lblCurso.Visible = true;
            }
        }
        

        #endregion

        
    }
}