﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
using Business.Entities;

namespace UI.Web
{
    public partial class Cursos : ABM
    {
        private Curso Entity
        {
            set;
            get;
        }
        private CursoLogic _curLog;
        public CursoLogic CurLog
        {

            get
            {
                if (_curLog == null)
                {
                    _curLog = new CursoLogic();

                }
                return _curLog;
            }
        }

        #region Metodos

        private void LoadGrid()
        {
            this.grvCursos.DataSource = CurLog.GetAll();
            this.grvCursos.DataBind();
         
        }

        private void LoadForm(int id)
        {
            this.Entity = CurLog.GetOne(id);
            this.txtAnioCalendario.Text = this.Entity.AnioCalendario.ToString();
            this.txtCupo.Text = this.Entity.Cupo.ToString();
            this.txtCupoDis.Text = this.Entity.CupoDis.ToString();
        
          
            Materia mat = new Materia();
            MateriaLogic matl = new MateriaLogic();
            mat = matl.GetOne(Entity.IDMateria);
            this.txtDescripcion.Text = mat.Descripcion;


            this.ddlComision.SelectedValue = this.Entity.IDComision.ToString();
            this.ddlMateria.SelectedValue = this.Entity.IDMateria.ToString();
        }

        private void Enable(bool enable)
        {
            this.txtAnioCalendario.Enabled = enable;
            this.txtCupo.Enabled = enable;
            this.txtDescripcion.Enabled = enable;
            this.txtCupoDis.Enabled = enable;
            this.ddlComision.Enabled = enable;
            this.ddlMateria.Enabled = enable;

        }

        private void LoadEntity(Curso Cur)
        {
            Cur.AnioCalendario = int.Parse(this.txtAnioCalendario.Text);
            Cur.Cupo = int.Parse(this.txtCupo.Text);
            Cur.Descripcion = this.txtDescripcion.Text;
            Cur.CupoDis = int.Parse(this.txtCupoDis.Text);
            Cur.IDComision = int.Parse(this.ddlComision.SelectedValue);
            Cur.IDMateria = int.Parse(this.ddlMateria.SelectedValue);
        }

        private void SaveEntity(Curso cur)
        {
            this.CurLog.Save(cur);
        }

        private void ClearForm()
        {
            this.txtAnioCalendario.Text = string.Empty;
            //Dudas sobre el Empty con campo entero
            this.txtCupo.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.ddlComision.SelectedIndex = 0;
            this.ddlMateria.SelectedIndex = 0;
            this.txtCupoDis.Text = string.Empty;
        }

        private void DeleteEntity(int id)
        {
            CurLog.Delete(id);
        }

        #endregion
        
        #region Eventos
        
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Alta:
                    Entity = new Curso();
                    this.LoadEntity(Entity);
                    this.Entity.State = BusinessEntity.States.New;
                    this.SaveEntity(Entity);
                    this.LoadGrid();
                    lblCartel.Text = "Se ha agregado un nuevo curso";
                    lblCartel.Visible = true;
                    break;

                case FormModes.Modificacion:
                    Entity = new Curso();
                    Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(Entity);
                    this.SaveEntity(Entity);
                    this.LoadGrid();
                    lblCartel.Text = "Se ha agregado modificado el curso";
                    lblCartel.Visible = true;
                    break;

                case FormModes.Baja:
                    this.DeleteEntity(this.SelectedID);
                    this.LoadGrid();
                    lblCartel.Text = "Se ha eliminado el curso";
                    lblCartel.Visible = true;
                    break;

                default:
                    break;

            }
            this.panelControles.Visible = false;
            this.panelConfirmacion.Visible = false;
        }

        protected void linkBtnEliminar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.panelControles.Visible = true;
                this.panelConfirmacion.Visible = true;
                this.FormMode = FormModes.Baja;
                this.LoadForm(this.SelectedID);
                this.Enable(false);
                lblCartel.Visible = false;
            }
            else
            {
                lblCartel.Visible = true;
                lblCartel.Text = "Debe seleccionar un curso para poder eliminarlo";
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Administrador/Cursos.aspx");
            this.panelConfirmacion.Visible = false;
            this.panelControles.Visible = false;
        }

        protected void grvCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.grvCursos.SelectedValue;
            panelControles.Visible = false;
            panelConfirmacion.Visible = false;
        }

        protected void ddlMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Materia mat = new Materia();
            MateriaLogic matL = new MateriaLogic();
            mat = matL.GetOne(Convert.ToInt32(ddlMateria.SelectedValue));
            this.txtDescripcion.Text = mat.Descripcion;
        }

        protected void linkBtnEditar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.panelControles.Visible = true;
                this.panelConfirmacion.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
                this.Enable(true);
            }
            else
            {
                lblCartel.Visible = true;
                lblCartel.Text = "Debe seleccionar un curso para poder modificarlo";
            }
        }

        protected override void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string si = "menuCursos";
                Session["Menu"] = si;
                this.LoadGrid();

                MateriaLogic mat = new MateriaLogic();
                ComisionLogic com = new ComisionLogic();
                Business.Logic.ComisionLogic cl = new ComisionLogic();

                List<Comision> listacursos = new List<Comision>();
                listacursos = cl.GetAll();
                ddlComision.Items.Add("");
                foreach (Comision comi in listacursos)
                {
                    ddlComision.Items.Add(comi.ID.ToString());
                }

                List<Materia> listaMateria = new List<Materia>();
                listaMateria = mat.GetAll();
                ddlMateria.Items.Add("");
                foreach (Materia mate in listaMateria)
                {
                    ddlMateria.Items.Add(mate.ID.ToString());
                }

            }
        }

        protected void linkBtnNuevo_Click(object sender, EventArgs e)
        {
            this.panelControles.Visible = true;
            this.panelConfirmacion.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            Enable(true);
        }

        #endregion
        
    }
}