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
            this.grvMaterias.DataBind();
        }
        private void ClearForm()
        {
            this.txtDescripcion.Text = string.Empty;
            this.txtHsSemanales.Text = string.Empty;
            this.txtHsTotales.Text = string.Empty;
            this.ddlPlanes.SelectedIndex = -1;
            this.ddlEspecialidades.SelectedIndex = -1;
            this.txtAnio.Text = string.Empty;
        }
        private void LoadEntity(Materia mt)
        {
            mt.IDplan = new PlanLogic().GetOne(ddlEspecialidades.Text, ddlPlanes.Text).ID;
            mt.HSSemanales = int.Parse(this.txtHsSemanales.Text);
            mt.HSTotales = int.Parse(this.txtHsTotales.Text);
            mt.Descripcion = this.txtDescripcion.Text;
            mt.Anio = int.Parse(txtAnio.Text);

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
            txtAnio.Text = Entity.Anio.ToString();
            txtDescripcion.Text = Entity.Descripcion;
            txtHsSemanales.Text = Entity.HSSemanales.ToString();
            txtHsTotales.Text = Entity.HSTotales.ToString();
            Plan p = new Plan();
            p = new PlanLogic().GetOne(Entity.IDplan);
            ddlEspecialidades.Text = new EspecialidadLogic().GetOne(p.IDEspecialidad).Descripcion;
            ddlPlanes.Items.Add(p.Descripcion);
            ddlPlanes.Text = p.Descripcion;
            //No se muestra la descripcion del plan en el ddl al ejecutar.
            //ARREGLADO
        }
        private void EnabledForm(bool enabled)
        {
            this.txtDescripcion.Enabled = enabled;
            this.txtHsSemanales.Enabled = enabled;
            this.txtHsTotales.Enabled = enabled;
            this.ddlPlanes.Enabled = enabled;
            this.ddlEspecialidades.Enabled = enabled;
            this.txtAnio.Enabled = enabled;
       }


        #endregion

        #region Eventos

        protected override void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string si = "menuMaterias";
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
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Administrador/Materias.aspx");
            this.panelConfirmacion.Visible = false;
            this.panelFormulario.Visible = false;
        }

        protected void linkbtnEliminar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.panelFormulario.Visible = true;
                this.panelConfirmacion.Visible = true;
                EnabledForm(false);
                this.FormMode = FormModes.Baja;
                this.LoadForm(SelectedID);

            }
            else
            {
                lblCartel.Visible = true;
                lblCartel.Text = "Debe seleccionar una materia de la lista";
            }

        }

        protected void linkbtnEditar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.lblCartel.Visible = false;
                this.panelConfirmacion.Visible = true;
                this.panelFormulario.Visible = true;
                EnabledForm(true);
                this.FormMode = FormModes.Modificacion;
                LoadForm(SelectedID);
            }
            else
            {
                lblCartel.Visible = true;
                lblCartel.Text = "Debe seleccionar una materia de la lista";
            }
        }

        protected void linkbtnNuevo_Click(object sender, EventArgs e)
        {
            
            this.panelConfirmacion.Visible = true;
            this.panelFormulario.Visible = true;
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
                    lblCartel.Text = "Se a agregado la materia";
                    break;

                case ABM.FormModes.Modificacion:
                    this.Entity = new Materia();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    lblCartel.Text = "Se ha eliminado la materia";
                    break;

                case ABM.FormModes.Baja:
                    this.DeleteEntity(SelectedID);
                    lblCartel.Text = "Se ha eliminado la materia";
                    break;
                default: break;

            }
            this.LoadGrid();
            this.panelFormulario.Visible = false;
            this.panelConfirmacion.Visible = false;
        }

        protected void grvMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelFormulario.Visible = false;
            panelConfirmacion.Visible = false;
            this.SelectedID = (int)grvMaterias.SelectedValue;
        }

        protected void ddlEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlanLogic plan = new PlanLogic();
            List<Plan> listaPlanes = new List<Plan>();
            listaPlanes = plan.GetAll();

            ddlPlanes.Items.Clear();
            ddlPlanes.Items.Add("");
            if (ddlEspecialidades.SelectedIndex > 0) //Si hay una especialidad del combo elegida
            {
                foreach (Plan p in listaPlanes)
                {
                    if (p.IDEspecialidad == ddlEspecialidades.SelectedIndex)
                        ddlPlanes.Items.Add(p.Descripcion);
                }
                ddlPlanes.SelectedIndex = 0;
            }
        }

        #endregion


    }
}