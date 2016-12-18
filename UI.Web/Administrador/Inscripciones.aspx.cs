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
            this.InscLogic.Save(Alu);
        }
        private void LoadEntity(AlumnoInscripcion Alu)
        {
            Alu.IdAlumno = Alumnos[grvAlumnos.SelectedIndex].ID;
            Alu.IdCurso = Cursos[grvCursos.SelectedIndex].ID;
            Alu.Nota = int.Parse(ddlNotas.Text);
            Alu.Condicion = (AlumnoInscripcion.TiposCondiciones)ddlCondicion.SelectedIndex;
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
                //this.panelControlesInscripciones.Visible = true;
                lblAlumno.Visible = false;
                grvInscripciones.Visible = true;
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
            switch (FormMode)
            {
                case FormModes.Alta: 
                    if(grvCursos.SelectedIndex != -1)
                    {
                        Entity = new AlumnoInscripcion();
                        this.LoadEntity(Entity);
                        Entity.State = BusinessEntity.States.New;
                        this.SaveEntity(Entity);
                        lblCurso.Visible = false;
                        panelABMInscripciones.Visible = false;
                        panelControlesInscripciones.Visible = false;
                        panelGrillaInscripciones.Visible = false;
                        panelGrillaCursos.Visible = false;
                    }
                    else
                    {
                        lblCurso.Visible = true;
                    }
                    break;

                case FormModes.Modificacion:
                    if (grvCursos.SelectedIndex != -1)
                    {
                        Entity = new AlumnoInscripcion();
                        Entity.ID = SelectedID;
                        Entity.State = BusinessEntity.States.Modified;
                        this.SaveEntity(Entity);
                        lblCurso.Visible = false;
                        panelABMInscripciones.Visible = false;
                        panelControlesInscripciones.Visible = false;
                        panelGrillaInscripciones.Visible = false;
                        panelGrillaCursos.Visible = false;
                    }
                    else
                    {
                        lblCurso.Visible = true;
                    }
                    break;

                case FormModes.Baja:
                    lblCurso.Visible = false;
                    DeleteEntity(SelectedID);
                    panelABMInscripciones.Visible = false;
                    panelControlesInscripciones.Visible = false;
                    panelGrillaInscripciones.Visible = false;
                    panelGrillaCursos.Visible = false;
                    break;

                default: break;
            }
            
        }
        

        #endregion

        
    }
}