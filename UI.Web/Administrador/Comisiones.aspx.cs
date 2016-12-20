using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web.Administrador
{
    public partial class Comisiones : ABM
    {

        private ComisionLogic _ComLog;
        public ComisionLogic Comlog
        {
            get
            {
                if (_ComLog == null)
                { _ComLog = new ComisionLogic(); }
                return _ComLog;
            }

        }
        public Comision Entity
        {
            set;
            get;
        }

       
        private void LoadGrid()
        {
            this.grvComisiones.DataSource = Comlog.GetAll();
            this.grvComisiones.DataBind();
            PlanLogic PlanLogic = new PlanLogic();
            List<Plan> listaPlanes = new List<Plan>();
            listaPlanes = PlanLogic.GetAll();

            ddlPlanes.Items.Add("");
            foreach (Plan x in listaPlanes)
            {
                ddlPlanes.Items.Add(x.ID.ToString());
            }

        }
        private void ClearForm()
        {
            this.txtDescripcion.Text = string.Empty;
            this.txtDescripcionPlan.Text = string.Empty;
            this.txtAnio.Text = string.Empty;
            ddlPlanes.ClearSelection();
        }
        private void LoadForm(int id)
        {
            this.Entity = Comlog.GetOne(id);
            this.txtDescripcion.Text = Entity.Descripcion;
            this.txtAnio.Text = Entity.AnioEspecialidad.ToString();
            PlanLogic pl = new PlanLogic();
            Plan plan = new Plan();
            plan = pl.GetOne(Entity.IdPlan);
         

            this.ddlPlanes.SelectedValue = this.Entity.IdPlan.ToString();
            this.txtDescripcionPlan.Text = plan.Descripcion;
        
        }
        private void EnabledForm(bool enable)
        {
            this.txtDescripcion.Enabled = enable;
            this.txtDescripcionPlan.Enabled = enable;
            this.txtAnio.Enabled = enable;
            ddlPlanes.Enabled = enable;
        }

        private void DeleteEntity(int id)
        {
            Comlog.Delete(id);
        }
        private void LoadEntity(Comision com)
        {
            com.Descripcion = txtDescripcion.Text;
            com.AnioEspecialidad = int.Parse(this.txtAnio.Text);
            com.IdPlan = int.Parse(this.ddlPlanes.SelectedValue);




        }
        private void SaveEntity(Comision Com)
        {
            Comlog.Save(Com);
        }







        protected override void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string si = "menuComisiones";
                Session["Menu"] = si;

              


                this.LoadGrid();
            }
        }

        protected void grvComisiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.grvComisiones.SelectedValue;
            panelInsert.Visible = false;
        }

        protected void ddlPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Plan unPlan = new Plan();
            PlanLogic PlanLog = new PlanLogic();
            unPlan = PlanLog.GetOne(Convert.ToInt32(ddlPlanes.SelectedValue));
            this.txtDescripcionPlan.Text = unPlan.Descripcion;
        }

        protected void linkNuevo_Click(object sender, EventArgs e)
        {
            this.panelInsert.Visible = true;

            this.FormMode = FormModes.Alta;
            this.ClearForm();
            EnabledForm(true);

        }

        protected void linkEditar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.panelInsert.Visible = true;

                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
                this.EnabledForm(true);
            }
        }

        protected void linkEliminar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.panelInsert.Visible = true;
                this.FormMode = FormModes.Baja;
                this.LoadForm(this.SelectedID);
                this.EnabledForm(false);
            }

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Alta:
                    Entity = new Comision();
                    this.LoadEntity(Entity);
                    this.Entity.State = BusinessEntity.States.New;
                    this.SaveEntity(Entity);
                    this.LoadGrid();
                    break;

                case FormModes.Modificacion:
                    Entity = new Comision();
                    Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(Entity);
                    this.SaveEntity(Entity);
                    this.LoadGrid();
                    break;

                case FormModes.Baja:
                    this.DeleteEntity(this.SelectedID);
                    this.LoadGrid();
                    break;

                default:
                    break;

            }
            this.panelInsert.Visible = false;

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Administrador/Comisiones.aspx");
            this.panelInsert.Visible = false;


        }

    }
}
