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
    public partial class Personas : ABM
    {
        private PersonaLogic _perLogic;

        public PersonaLogic PersLogic
        {
            get {
                if (_perLogic == null)
                    _perLogic = new PersonaLogic();
                return _perLogic;
            }
        }

        private Business.Entities.Personas Entity
        {
            set; get;
        }

        #region Métodos

        private void EnableForm(bool enable)
        {
            txtApellido.Enabled = enable;
            txtNombre.Enabled = enable;
            txtFeNac.Enabled = enable;
            txtDirec.Enabled = enable;
            txtEmail.Enabled = enable;
            txtLegajo.Enabled = enable;
            txtTelef.Enabled = enable;
            txtUsuario.Enabled = enable;
            txtClave.Enabled = enable;
            txtCambiaClave.Enabled = enable;
            ddlEspecialidades.Enabled = enable;
            ddlPlanes.Enabled = enable;
            ddlTipoPers.Enabled = enable;

        }

        private void ClearForm()
        {
            txtApellido.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDirec.Text = string.Empty;
            txtFeNac.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelef.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtClave.Text = string.Empty;
            txtCambiaClave.Text = string.Empty;
            txtLegajo.Text = string.Empty;
            chbxHabilitado.Checked = false;
            ddlEspecialidades.SelectedIndex = -1;
            ddlPlanes.SelectedIndex = 0;
            ddlTipoPers.SelectedIndex = 0;
        }

        private void SaveEntity(Business.Entities.Personas p)
        {
            this.PersLogic.Save(p);
        }

        private void LoadEntity(Business.Entities.Personas p)
        {
            p.Apellido = txtApellido.Text;
            p.Nombre = txtNombre.Text;
            p.NombreUsuario = txtUsuario.Text;
            p.Clave = txtClave.Text;
            p.CambiaCLave = txtCambiaClave.Text;
            p.Direccion = txtDirec.Text;
            p.Email = txtEmail.Text;
            p.Legajo = int.Parse(txtLegajo.Text);
            p.Telefono = txtTelef.Text;
            p.Habilitado = chbxHabilitado.Checked;

            //Cargo los DropDownList
            p.TipoPersona = new PersonaLogic().GetOne(p.ID).TipoPersona;
            p.IDPlan = new PlanLogic().GetOne(ddlEspecialidades.Text, int.Parse(ddlPlanes.Text)).ID;

        }

        private void DeleteEntity(int ID)
        {
            this.PersLogic.Delete(ID);
        }

        private void LoadGrid()
        {
            grillaPersonas.DataSource = PersLogic.GetAll();
            grillaPersonas.DataBind();
        }

        private void LoadForm(int ID)
        {
            Entity = PersLogic.GetOne(ID);

            txtID_Pers.Text = Entity.ID.ToString();
            txtApellido.Text = Entity.Apellido;
            txtNombre.Text = Entity.Nombre;
            txtUsuario.Text = Entity.NombreUsuario;
            txtClave.Text = Entity.Clave;
            txtCambiaClave.Text = Entity.CambiaCLave;
            txtTelef.Text = Entity.Telefono;
            txtEmail.Text = Entity.Email;
            txtDirec.Text = Entity.Direccion;
            txtLegajo.Text = Entity.Legajo.ToString();
            chbxHabilitado.Checked = Entity.Habilitado;

            //Cargo los DropDownList
            
            EspecialidadLogic espe = new EspecialidadLogic();
            List<Especialidad> listaEspeci = new List<Especialidad>();
            listaEspeci = espe.GetAll();

            ddlEspecialidades.Items.Add("");
            foreach (Especialidad e in listaEspeci)
            {
                ddlEspecialidades.Items.Add(e.Descripcion);
            }
            
            ddlTipoPers.Items.Add("");
            ddlTipoPers.Items.Add(Business.Entities.Personas.TiposPersonas.Administrador.ToString());
            ddlTipoPers.Items.Add(Business.Entities.Personas.TiposPersonas.Alumno.ToString());
            ddlTipoPers.Items.Add(Business.Entities.Personas.TiposPersonas.Docente.ToString());

        }


        #endregion

        #region Eventos

        protected override void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.LoadGrid();
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case ABM.FormModes.Alta:
                    Entity = new Business.Entities.Personas();
                    this.LoadEntity(Entity);
                    Entity.State = BusinessEntity.States.New;
                    this.SaveEntity(Entity);
                    this.LoadGrid();
                    break;

                case ABM.FormModes.Modificacion:
                    Entity = new Business.Entities.Personas();
                    Entity.ID = SelectedID;
                    Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(Entity);
                    this.SaveEntity(Entity);
                    this.LoadGrid();
                    break;

                case ABM.FormModes.Baja:
                    this.DeleteEntity(SelectedID);
                    this.LoadGrid();
                    break;

                default: break;
            }
            
            this.panelFormulario.Visible = false;
            this.panelConfirmacion.Visible = false;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Personas.aspx");
            this.panelConfirmacion.Visible = false;
            this.panelFormulario.Visible = false;
        }

        protected void lnkButtonNuevo_Click(object sender, EventArgs e)
        {
            this.panelFormulario.Visible = true;
            this.panelConfirmacion.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);
        }

        protected void lnkButtonEditar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.panelFormulario.Visible = true;
                this.panelConfirmacion.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
                this.EnableForm(true);
            } 
        }

        protected void lnkButtonEliminar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.panelConfirmacion.Visible = true;
                this.panelConfirmacion.Visible = true;
                this.EnableForm(false);
                this.FormMode = FormModes.Baja;
                this.LoadForm(this.SelectedID);
            }
        }

        protected void grillaPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.grillaPersonas.SelectedValue;
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