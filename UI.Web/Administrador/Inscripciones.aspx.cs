﻿using System;
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
            this.txtCondicion.Enabled = enable;
            this.ddlCursos.Enabled = enable;
            this.ddlAlumno.Enabled = enable;
            this.txtNota.Enabled = enable;
        }
        private void ClearForm()
        {
            this.txtNota.Text = string.Empty;
            this.ddlAlumno.SelectedIndex = -1;
            this.ddlCursos.SelectedIndex = -1;
            this.txtCondicion.Text = string.Empty;
        }
        private void SaveEntity(AlumnoInscripcion Alu)
        {
            this.InscLogic.Save(Alu);
        }
        private void LoadEntity(AlumnoInscripcion alu)
        {
            alu.IdAlumno = Convert.ToInt32(this.ddlAlumno.SelectedValue);
            alu.IdCurso = Convert.ToInt32(this.ddlCursos.SelectedValue);
            alu.Nota = int.Parse(this.txtNota.Text);
            alu.Condicion = this.txtCondicion.Text;
            
        }
        private void DeleteEntity(int id)
        {
            this.InscLogic.Delete(id);
        }

        private void LoadGrid()
        {
            this.grvInscripciones.DataSource = InscLogic.GetAll();
            this.grvInscripciones.DataBind();
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

        #endregion

        #region Eventos
      
        protected override void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string si = "menuInscripciones";
                Session["Menu"] = si;
                this.LoadGrid();
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
            this.panelBotones.Visible = false;
            this.panelConfirmacion.Visible = false;
        }

        protected void linkbtnEditar_Click(object sender, EventArgs e)
        {
           
            if (this.IsEntitySelected)
            {
                EnableForm(true);
                this.panelConfirmacion.Visible = true;
                this.panelBotones.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
            }
        }

        protected void linkbtnEliminar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.panelConfirmacion.Visible = true;
                this.panelBotones.Visible = true;
                this.FormMode = FormModes.Baja;
                this.EnableForm(false);
                this.LoadForm(this.SelectedID);

            }
        }

        protected void linkbtnNuevo_Click(object sender, EventArgs e)
        {
            this.panelBotones.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.panelConfirmacion.Visible = true;
            this.EnableForm(true);


        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Inscripciones.aspx");
            this.panelConfirmacion.Visible = false;
            this.panelBotones.Visible = false;
        }

        protected void grvInscripciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.grvInscripciones.SelectedValue;
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

        protected void ddlCursos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}