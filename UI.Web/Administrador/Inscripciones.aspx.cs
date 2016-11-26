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
        private void EnableForm(bool enable)
        {
            ddlCondicion.Enabled = enable;
            txtNota.Enabled = enable;
        }

        private void ClearForm()
        {
            ddlCondicion.SelectedIndex = -1;
            txtNota.Text.Equals("0");
        }
        private void SaveEntity(AlumnoInscripcion Alu)
        {

        }
        private void LoadEntity(AlumnoInscripcion alu)
        {
            
        }
        private void DeleteEntity(int id)
        {
            this.InscLogic.Delete(id);
        }

        

        private void LoadForm(int id)
        {
            this.Entity = InscLogic.GetOne(id);
            this.txtCondicion.Text = this.Entity.Condicion;
            this.ddlCursos.SelectedValue = this.Entity.IdCurso.ToString();
            this.ddlAlumno.SelectedValue = this.Entity.IdAlumno.ToString();
            this.txtNota.Text = this.Entity.Nota.ToString();

            PersonaLogic per = new PersonaLogic();
            CursoLogic cur = new CursoLogic();
            List<Curso> curs = new List<Curso>();
            List<Business.Entities.Personas> pers = new List<Business.Entities.Personas>();

            curs = cur.GetAll();
            foreach (Curso cu in curs)
            {
                ddlCursos.Items.Add(cu.ID.ToString());
            }
            pers = per.GetAll();

            foreach (Business.Entities.Personas pe in pers)
            {
                if (pe.TipoPersona == Business.Entities.Personas.TiposPersonas.Alumno)
                {
                    this.ddlAlumno.Items.Add(pe.ID.ToString());
                }
            }
           
        }

        protected void cargarCursos()
        {
            List<Object> lista = new List<Object>();
            MateriaLogic ml = new MateriaLogic();
            ComisionLogic coml = new ComisionLogic();

            foreach (Curso c in Cursos)
            {
                lista.Add(new
                {
                    materia = ml.GetOne(c.IDMateria).Descripcion,
                    comision = coml.GetOne(c.IDComision).Descripcion,
                    anio_curso = c.AnioCalendario.ToString(),
                    cupo_curso = c.Cupo.ToString(),
                });
            }

            grvCursos.DataSource = lista;
            grvCursos.DataBind();

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

            }

        }
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case ABM.FormModes.Alta:
                    this.Entity = new AlumnoInscripcion();
                    this.LoadEntity(this.Entity);
                    this.Entity.State = BusinessEntity.States.New;
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                  
                    break;

                case ABM.FormModes.Baja:
                    this.DeleteEntity(this.SelectedID);
                    this.LoadGrid();
                    break;

                case FormModes.Modificacion:
                    this.Entity = new AlumnoInscripcion();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                default: break;
                    
            }
            this.panelGrillaInscripciones.Visible = false;
            this.panelControlesInscripciones.Visible = false;
        }

        protected void linkbtnEditar_Click(object sender, EventArgs e)
        {
           
            if (this.IsEntitySelected)
            {
                EnableForm(true);
                this.panelControlesInscripciones.Visible = true;
                this.panelGrillaInscripciones.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
            }
        }

        protected void linkbtnEliminar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.panelControlesInscripciones.Visible = true;
                this.panelGrillaInscripciones.Visible = true;
                this.FormMode = FormModes.Baja;
                this.EnableForm(false);
                this.LoadForm(this.SelectedID);

            }
        }

        protected void linkbtnNuevo_Click(object sender, EventArgs e)
        {
            this.panelGrillaInscripciones.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.panelControlesInscripciones.Visible = true;
            this.EnableForm(true);


        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Inscripciones.aspx");
            this.panelControlesInscripciones.Visible = false;
            this.panelGrillaInscripciones.Visible = false;
        }

        protected void grvInscripciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.grvAlumnos.SelectedValue;
            panelGrillaInscripciones.Visible = true;

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Business.Entities.Personas pers = new Business.Entities.Personas();
            PersonaLogic persL = new PersonaLogic();
            pers = persL.GetOne(Convert.ToInt32(ddlAlumno.SelectedValue));
            this.txtNombre.Text = pers.Nombre;
            this.txtApellido.Text = pers.Apellido;
        }

        #endregion


    }
}