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
    public partial class Materias : ABM
    {
        protected override void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string si = "menuMaterias";
                Session["Menu"] = si;
                this.LoadGrid();
            }
        }

        private MateriaLogic _mat;
        public MateriaLogic Materia
        {
            get
            {
                if(_mat ==null)
                {
                    _mat = new MateriaLogic();
                }
                return _mat;
            }
        }
        private Materia Entity
        {
            set;
            get;
        }
        #region Metodos


        private void LoadGrid()
        {
            this.grvMaterias.DataSource = Materia.GetAll();
            
           
            PlanLogic PlLog = new PlanLogic();
            List < Plan > ListaPlanes = new List<Plan>();
            ListaPlanes = PlLog.GetAll();
            foreach (Plan pe in ListaPlanes)
            {
                ddlIdPlan.Items.Add(pe.ID.ToString());
            }
            this.grvMaterias.DataBind();
        }
        private void ClearForm()
        {
            this.txtDescripcion.Text = string.Empty;
            this.txtHsSemanales.Text = string.Empty;
            this.txtHsTotales.Text = string.Empty;
            this.ddlIdPlan.SelectedIndex = -1;
        }
        private void LoadEntity(Materia mt)
        {
            mt.IDplan = int.Parse(this.ddlIdPlan.SelectedValue);
            mt.HSSemanales = int.Parse(this.txtHsSemanales.Text);
            mt.HSTotales = int.Parse(this.txtHsTotales.Text);
            mt.Descripcion = this.txtDescripcion.Text;

        }
        private void DeleteEntity(int id)
        {
            Materia.Delete(id);
        }
        private void SaveEntity(Materia mt)
        {
            Materia.Save(mt);
        }
        private void LoadForm(int id)
        {
            Entity = Materia.GetOne(id);
            txtDescripcion.Text = Entity.Descripcion;
            txtHsSemanales.Text = Entity.HSSemanales.ToString();
            txtHsTotales.Text = Entity.HSTotales.ToString();
            ddlIdPlan.SelectedValue = Entity.IDplan.ToString();
        }
        private void EnabledForm(bool enabled)
        {
            this.txtDescripcion.Enabled = enabled;
            this.txtHsSemanales.Enabled = enabled;
            this.txtHsTotales.Enabled = enabled;
            this.ddlIdPlan.Enabled = enabled;

       }


        #endregion
        #region Eventos
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Materias.aspx");
            this.panelConfirmacion.Visible = false;
            this.panelLabels.Visible = false;
        }

        protected void linkbtnEliminar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.panelLabels.Visible = true;
                this.panelConfirmacion.Visible = true;
                EnabledForm(false);
                this.FormMode = FormModes.Baja;
                this.LoadForm(SelectedID);
            }
        }


        protected void linkbtnEditar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.panelConfirmacion.Visible = true;
                this.panelLabels.Visible = true;
                EnabledForm(true);
                this.FormMode = FormModes.Modificacion;
                LoadForm(SelectedID);
            }
        }

        protected void linkbtnNuevo_Click(object sender, EventArgs e)
        {

           
                this.panelConfirmacion.Visible = true;

                this.panelLabels.Visible = true;
                this.ClearForm();
                EnabledForm(true);
                this.FormMode = FormModes.Alta;
                LoadForm(SelectedID);
            
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case ABM.FormModes.Alta:
                    this.Entity = new Materia();
                    this.LoadEntity(Entity);
                    Entity.State = BusinessEntity.States.New;
                    SaveEntity(Entity);
                    this.LoadGrid();
                    break;
                case ABM.FormModes.Modificacion:

                    this.Entity = new Materia();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                case ABM.FormModes.Baja:
                    this.DeleteEntity(SelectedID);
                    this.LoadGrid();
                    break;
                default: break;

            }
            this.panelLabels.Visible = false;
            this.panelConfirmacion.Visible = false;
        }

        protected void grvMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)grvMaterias.SelectedValue;
        }

        #endregion

        protected void ddlIdPlan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}