using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
using Business.Entities;

namespace UI.Web
{
    public partial class Planes : ABM
    {
        private PlanLogic _planlog;
        
        public Plan Entity { get; set; }

        public PlanLogic PlanLog
        {
            get
            {
                if (_planlog == null)
                    _planlog = new PlanLogic();
                return _planlog;
            }
        }

        #region Metodos
        private void LoadGrid()
        {
            grvPlanes.DataSource = PlanLog.GetAll();
            grvPlanes.DataBind();
        }

        private void LimparFormulario()
        {
            txtIDPlan.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            ddlEspecialidades.ClearSelection();
        }

        private void HabilitarControles(bool enable)
        {
            txtDescripcion.Enabled = enable;
            ddlEspecialidades.Enabled = enable;
        }

        private void Delete(int ID)
        {
            PlanLog.Delete(ID);
        }

        private void GuardarCambios()
        {
            switch (this.FormMode)
            {
                case ABM.FormModes.Alta:
                    this.Entity = new Plan();
                    Entity.State = BusinessEntity.States.New;
                    this.LoadEntity(Entity);
                    SaveEntity(Entity);
                    lblCartel.Visible = true;
                    lblCartel.Text = "Se ha agregado el nuevo Plan";
                    this.LoadGrid();
                    panelFormulario.Visible = false;
                    break;

                case ABM.FormModes.Modificacion:
                    this.Entity = new Plan();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    lblCartel.Visible = true;
                    lblCartel.Text = "Se ha modificado el plan";
                    this.LoadGrid();
                    panelFormulario.Visible = false;
                    break;

                case ABM.FormModes.Baja:
                    this.DeleteEntity(SelectedID);
                    lblCartel.Visible = true;
                    lblCartel.Text = "Se ha eliminado el plan";
                    this.LoadGrid();
                    panelFormulario.Visible = false;
                    break;

                default:
                    break;

            }
        }

        private void LoadForm(int id)
        {
            Entity = PlanLog.GetOne(id);

            txtDescripcion.Text = Entity.Descripcion;
            txtIDPlan.Text = Entity.ID.ToString();
            ddlEspecialidades.Text = new EspecialidadLogic().GetOne(Entity.IDEspecialidad).Descripcion;

        }

        private void SaveEntity(Plan p)
        {
            PlanLog.Save(p);
        }

        private void DeleteEntity(int id)
        {
            PlanLog.Delete(id);
        }

        private void LoadEntity(Plan p)
        {
            p.Descripcion = txtDescripcion.Text;
            p.IDEspecialidad = new EspecialidadLogic().GetOne(ddlEspecialidades.Text).ID;
        }

        #endregion

        #region Eventos
        protected override void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string si = "menuPlanes";
                Session["Menu"] = si;

                EspecialidadLogic espe = new EspecialidadLogic();
                List<Especialidad> listaEspeci = new List<Especialidad>();
                listaEspeci = espe.GetAll();

                ddlEspecialidades.Items.Add("");
                foreach (Especialidad x in listaEspeci)
                {
                    ddlEspecialidades.Items.Add(x.Descripcion);
                }

                this.LoadGrid();
            }
        }
       
        protected void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.panelControles.Visible = true;
                lblCartel.Visible = false;
                this.HabilitarControles(true);
                FormMode = FormModes.Modificacion;
                this.panelFormulario.Visible = true;
                this.LoadForm(this.SelectedID);
            }
            else
            {
                lblCartel.Visible = true;
                lblCartel.Text = "Debe seleccionar un plan de la lista";
            }
        }
        
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
                lblCartel.Visible = false;
                panelControles.Visible = true;
                panelFormulario.Visible = true;
                HabilitarControles(true);
                LimparFormulario();
                FormMode = FormModes.Alta;
            
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                lblCartel.Visible = false;
                panelFormulario.Visible = true;
                this.FormMode = FormModes.Baja;
                this.HabilitarControles(false);
                this.LoadForm(this.SelectedID);
            }
            else
            {
                lblCartel.Visible = true;
                lblCartel.Text = "Debe seleccionar un plan de la lista";
            }

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Administrador/Planes.aspx");
        }
        
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
        }

        protected void grvPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)grvPlanes.SelectedValue;
        }

        #endregion
        
    }
}