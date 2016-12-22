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
        private string _nota;
        private string _cond;
        public string Cond
        {
            get { return _cond; }
            set { _cond = value; }
        }
        public string Nota
        {
            get { return _nota; }
            set { _nota = value; }
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
            ddlCondicion.ClearSelection();
            ddlNotas.ClearSelection();
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
          
            Alu.Nota = ddlNotas.Text ;
            Alu.Condicion = (AlumnoInscripcion.TiposCondiciones)ddlCondicion.SelectedIndex;
        }
        private void DeleteEntity(int id)
        {
            this.InscLogic.Delete(id);
        }
        
    

        protected void cargaInscripciones(int idAlu)
        {
          
            CursoLogic cur = new CursoLogic();
            List<Object> ListaCursos = new List<Object>();
            ListaCursos = cur.GetAllEstadosCursos(idAlu);
            grvInscripciones.DataSource = ListaCursos;
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
            
        }

        protected void grvAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Elegis el alumno y lista las inscripciones que tiene
            if (grvAlumnos.SelectedIndex != -1)
            {
                cargaInscripciones(Alumnos[grvAlumnos.SelectedIndex].ID);
                this.panelControlesInscripciones.Visible = true;
            
                
            }
        }

        protected void grvInscripciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Trae datos del curso
            if (grvInscripciones.SelectedIndex != -1)
            {
                SelectedID = (int)grvInscripciones.SelectedValue;
                //panelGrillaCursos.Visible = true;               
                int m;
                m = grvInscripciones.SelectedIndex;
               
             //   lblInscripcion2.Text = grvInscripciones.Rows[m].Cells[4].Text;
              Nota = grvInscripciones.Rows[m].Cells[5].Text;
                Cond = grvInscripciones.Rows[m].Cells[4].Text;
                //  PARA SELECCIONAR EL VALOR DE LAS COLUMNAS DE UNA FILA    
                lblInscripcion.Text = Nota;
                lblInscripcion2.Text = Cond;
                //FALTA TERMINAR
            }
        }

        protected void btnAgregarInscripcion_Click(object sender, EventArgs e)
        {
          /*  if (grvAlumnos.SelectedIndex != -1)
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
            }*/
        }

        protected void btnEditarInscripcion_Click(object sender, EventArgs e)
        {
            if (grvInscripciones.SelectedIndex != -1)
            {   
                this.FormMode = FormModes.Modificacion;
                panelABMInscripciones.Visible = true;
                HabilitarControles(true);
                btnAceptar.Text = "Guardar";
            }
            else
            {
                panelABMInscripciones.Visible = false;
                lblInscripcion.Text = "Debe seleccionar una inscripción para editarla";
            }
        }

        protected void btnEliminarInscripcion_Click(object sender, EventArgs e)
        {
          if (grvInscripciones.SelectedIndex != -1)
            {
              
                this.FormMode = FormModes.Baja;
                ddlNotas.Items.Add(Nota);
                ddlNotas.Text = Nota;
                ddlCondicion.Items.Add(Cond);
                ddlCondicion.Text = Cond;
                // NO APARECEN EN EL DDL
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
          
        }

        protected void btnAceptar_Click1(object sender, EventArgs e)
        {
           switch(this.FormMode)
            {  
                case FormModes.Modificacion:

                    {
                        Entity = new AlumnoInscripcion();
                        AlumnoInscripcionLogic aluLog = new AlumnoInscripcionLogic();
                        Entity.ID = aluLog.GetID(SelectedID, Alumnos[grvAlumnos.SelectedIndex].ID);
                        Entity.State = BusinessEntity.States.Modified;
                        Entity.Condicion = (AlumnoInscripcion.TiposCondiciones)ddlCondicion.SelectedIndex;
                        Entity.Nota = (ddlNotas.SelectedIndex - 1).ToString();
                        Entity.IdAlumno = Alumnos[grvAlumnos.SelectedIndex].ID;
                        aluLog.UpdateInscr(Entity);
                  //    this.SaveEntity(Entity);
                  // TUVE QUE HACER UN NUEVO UPDAT E PORQUE ME TIRABA ERROR CON FK EN ID_CURSO (PERO NO MODIFICABA NI SIQUIERA EL CURSO, NO SE PORQUE)
                        panelABMInscripciones.Visible = false;
                        panelControlesInscripciones.Visible = false;                      
                        break;
                    }
                case FormModes.Baja:
                    {
                        int x;
                        x = InscLogic.GetID(SelectedID, Alumnos[grvAlumnos.SelectedIndex].ID );

                        DeleteEntity(x);
                        panelABMInscripciones.Visible = false;
                        panelControlesInscripciones.Visible = false;
                        panelGrillaInscripciones.Visible = false;
                       
                        break;
                    }
                default: break;
            }
            
        }
        

        #endregion

        
    }
}