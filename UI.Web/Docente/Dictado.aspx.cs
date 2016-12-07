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
    public partial class Dictado : ABM
    {
        private DocenteCursologic _dictadoLog;

        public DocenteCursologic DictadoLog
        {
            get
            {
                if (_dictadoLog == null)
                    _dictadoLog = new DocenteCursologic();
                return _dictadoLog;
            }
            set { _dictadoLog = value; }
        }

        private DocenteCurso _entity;
        public DocenteCurso Entity { get; set; }

        private List<DocenteCurso> _listaDictados;
        public List<DocenteCurso> listaDictados { get { return _listaDictados; } set { _listaDictados = value; } }

        private List<Curso> _listaCursos;
        public List<Curso> listaCursos { get { return _listaCursos; } set { _listaCursos = value; } }

        private List<Materia> _listaMaterias;
        public List<Materia> listaMaterias { get { return _listaMaterias; } set { _listaMaterias = value; } }

        private List<Comision> _listaComi;
        public List<Comision> listaComi { get { return _listaComi; } set { _listaComi = value; } }
        
        private List<Object> _listaGrilla;
        public List<Object> listaGrilla { get { return _listaGrilla; } set { _listaGrilla = value; } }


        #region Metodos

        public void HabilitarControles(bool e)
        {
            ddlCargos.Enabled = e;
            ddlCursos.Enabled = e;
            ddlDocentes.Enabled = e;
        }

        public void LimpiarFormulario()
        {
            txtIDdictado.Text = string.Empty;
            ddlDocentes.ClearSelection();
            ddlCursos.ClearSelection();
            ddlDocentes.ClearSelection();
            txtIDdocente.Text = string.Empty;

        }

        public void LoadForm(int ID)
        {
            Entity = DictadoLog.GetOne(ID);
            txtIDdictado.Text = Entity.ID.ToString();
            ddlCargos.Text = Entity.Cargo.ToString();
            ddlCursos.Text = Entity.IdCurso.ToString();
            PersonaLogic plog = new PersonaLogic();
            Business.Entities.Personas p = plog.GetOne(Entity.IdDocente);
            ddlDocentes.Text = p.Apellido + " " + p.Nombre;
            txtIDdocente.Text = Entity.IdDocente.ToString();
        }

        public void LoadEntity(DocenteCurso dc)
        {
            dc.IdCurso = int.Parse(ddlCursos.Text);
            dc.Cargo = (DocenteCurso.TiposCargos)ddlCargos.SelectedIndex;
            dc.IdDocente = int.Parse(txtIDdocente.Text);
        }

        public void SaveEntity(DocenteCurso dc)
        {
            this.DictadoLog.Save(dc);
        }

        #endregion

        #region Eventos

        protected override void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string si = "menuDictados";
                Session["Menu"] = si;

                CursoLogic curLog = new CursoLogic();
                listaCursos = curLog.GetAll();
                MateriaLogic marLog = new MateriaLogic();
                listaMaterias = marLog.GetAll();
                ComisionLogic comLog = new ComisionLogic();
                listaComi = comLog.GetAll();
                DocenteCursologic dictLog= new DocenteCursologic();
                listaDictados = dictLog.GetAll();


                ddlCursos.Items.Add("");
                foreach (Curso c in listaCursos)
                {
                    ddlCursos.Items.Add(c.ID.ToString());
                }

                PersonaLogic plog = new PersonaLogic();
                List<Business.Entities.Personas> listadoPersonas = plog.GetAll();
                ddlDocentes.Items.Add("");
                foreach(Business.Entities.Personas p in listadoPersonas)
                {
                    if(p.TipoPersona == Business.Entities.Personas.TiposPersonas.Docente)
                    {
                        ddlDocentes.Items.Add(p.Apellido + " " + p.Nombre);
                    }
                }

                ddlCargos.Items.Add("");
                ddlCargos.Items.Add(DocenteCurso.TiposCargos.Titular.ToString());
                ddlCargos.Items.Add(DocenteCurso.TiposCargos.Auxiliar.ToString());
            }

        }

        protected void grvDictados_Load(object sender, EventArgs e)
        {
            string doc = "";
            listaGrilla = new List<Object>();

            foreach (DocenteCurso dc in listaDictados) //Busco los cursos del docente logueado
            {
                if (dc.IdDocente == (int)Session["id_persona"])
                {
                    PersonaLogic plog = new PersonaLogic();
                    Business.Entities.Personas p = plog.GetOne(dc.IdDocente);
                    doc = p.Apellido + " " + p.Nombre;

                    // Armo el tipo anonimo
                    listaGrilla.Add(new
                    {
                        ID = dc.ID,
                        cur = dc.IdCurso,
                        docente = doc,
                        cargo = dc.Cargo.ToString()
                    });

                }
            }

            grvDictados.DataSource = listaGrilla;
            grvDictados.DataBind();

        }
        
        protected void grvDictados_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.grvDictados.SelectedValue;
        }

        protected void ddlDocentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonaLogic perlog = new PersonaLogic();
            txtIDdocente.Text = perlog.TraerDocente(ddlDocentes.Text).ToString();

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            HabilitarControles(true);
            FormMode = FormModes.Alta;
            lblCartel.Visible = false;
            LimpiarFormulario();
            panelFormulario.Visible = true;

        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            if (IsEntitySelected)
            {
                HabilitarControles(true);
                FormMode = FormModes.Modificacion;
                lblCartel.Visible = false;
                panelFormulario.Visible = true;
                LoadForm(this.SelectedID);
            }
            else
            {
                lblCartel.Visible = true;
                lblCartel.Text = "Debe seleccionar un dictado para modificarlo";
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (IsEntitySelected)
            {
                HabilitarControles(false);
                FormMode = FormModes.Baja;
                LoadForm(this.SelectedID);
                panelFormulario.Visible = true;
                lblCartel.Visible = false;
            }
            else
            {
                lblCartel.Visible = true;
                lblCartel.Text = "Debe seleccionar un dictado para eliminarlo";
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Docente/Dictado.aspx");
            panelFormulario.Visible = false;

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (FormMode)
            {
                case FormModes.Alta:
                    Entity = new DocenteCurso();
                    Entity.State = BusinessEntity.States.New;
                    LoadEntity(Entity);
                    SaveEntity(Entity);
                    lblCartel.Visible = true;
                    lblCartel.Text = "Se ha agregado el dictado";
                    break;

                case FormModes.Modificacion:
                    Entity = new DocenteCurso();
                    Entity.State = BusinessEntity.States.Modified;
                    LoadEntity(Entity);
                    SaveEntity(Entity);
                    lblCartel.Visible = true;
                    lblCartel.Text = "Se ha modificado el dictado";
                    break;

                case FormModes.Baja:
                    //probando 2 formas
                    //con el metodo Delete o usando el Save comun que nunca se usa

                    //this.Delete(SelectedID);
                    Entity = new DocenteCurso();
                    Entity.State = BusinessEntity.States.Deleted;
                    LoadEntity(Entity);
                    SaveEntity(Entity);
                    lblCartel.Visible = true;
                    lblCartel.Text = "Se ha eliminado el dictado";
                    break;
            }

            panelFormulario.Visible = false;
        }

        #endregion


    }
}