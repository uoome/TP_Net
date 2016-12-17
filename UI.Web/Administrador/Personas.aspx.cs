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
            ddlEspecialidades.ClearSelection();
            ddlPlanes.ClearSelection();
            ddlTipoPers.ClearSelection();
        }

        private void SaveEntity(Business.Entities.Personas p)
        {
            this.PersLogic.Save(p);
        }

        private void LoadEntity(Business.Entities.Personas p)
        {
            string variable;
            variable = ddlTipoPers.SelectedValue;
            if ("Alumno" == variable)
            {
                p.TipoPersona = Business.Entities.Personas.TiposPersonas.Alumno;
            }
            if (variable == "Docente")
            {
              p.TipoPersona = Business.Entities.Personas.TiposPersonas.Docente;
            }
            if (variable == "Administrador")
            {
                p.TipoPersona = Business.Entities.Personas.TiposPersonas.Administrador;
            }
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
            p.FechaDeNacimiento = DateTime.Parse(txtFeNac.Text);         
                               
            p.IDPlan = new PlanLogic().GetOne(ddlEspecialidades.Text, ddlPlanes.Text).ID;

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
            txtFeNac.Text = Entity.FechaDeNacimiento.ToString();
            ddlTipoPers.Text = Entity.TipoPersona.ToString();
            PlanLogic pl = new PlanLogic();
            Plan planPersona = pl.GetOne(Entity.IDPlan);
           ddlEspecialidades.Text = new EspecialidadLogic().GetOne(planPersona.IDEspecialidad).Descripcion;
            ddlPlanes.Items.Add(planPersona.Descripcion);
            ddlPlanes.Text = planPersona.Descripcion;

            
        }


        #endregion

        #region Eventos

        protected override void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string si = "menuPersonas";
                Session["Menu"] = si;

                EspecialidadLogic espe = new EspecialidadLogic();
                List<Especialidad> listaEspeci = new List<Especialidad>();
                listaEspeci = espe.GetAll();
                
                ddlEspecialidades.Items.Add("");
                foreach (Especialidad x in listaEspeci)
                {
                    ddlEspecialidades.Items.Add(x.Descripcion);
                }

                ddlTipoPers.Items.Add("");
                ddlTipoPers.Items.Add(Business.Entities.Personas.TiposPersonas.Administrador.ToString());
                ddlTipoPers.Items.Add(Business.Entities.Personas.TiposPersonas.Alumno.ToString());
                ddlTipoPers.Items.Add(Business.Entities.Personas.TiposPersonas.Docente.ToString());

                this.LoadGrid();
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Alta:
                    Entity = new Business.Entities.Personas();
                    this.LoadEntity(Entity);
                    Entity.State = BusinessEntity.States.New;
                    this.SaveEntity(Entity);
                    lblResultado.Text = "Se ha agregado la persona";
                    this.LoadGrid();
                    break;

                case FormModes.Modificacion:
                    Entity = new Business.Entities.Personas();
                    Entity.ID = SelectedID;
                    Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(Entity);
                    this.SaveEntity(Entity);
                    lblResultado.Text = "Se ha modificado el registro";
                    this.LoadGrid();
                    break;

                case FormModes.Baja:
                    this.DeleteEntity(SelectedID);
                    lblResultado.Text = "Se ha elimado el registro";
                    this.LoadGrid();
                    break;

                default: break;
            }
            
            this.panelFormulario.Visible = false;
            this.panelConfirmacion.Visible = false;
            lblResultado.Visible = true;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Administrador/Personas.aspx");
            this.panelConfirmacion.Visible = false;
            this.panelFormulario.Visible = false;
        }

        protected void lnkButtonNuevo_Click(object sender, EventArgs e)
        {
            lblRegistro.Visible = false;
            lblResultado.Visible = false;
            this.panelFormulario.Visible = true;
            this.panelConfirmacion.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            EnableForm(true);
            
        }

        protected void lnkButtonEditar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                lblRegistro.Visible = false;
                lblResultado.Visible = false;
                this.panelFormulario.Visible = true;
                this.panelConfirmacion.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
                this.EnableForm(true);

            }
            else lblRegistro.Visible = true;
        }

        protected void lnkButtonEliminar_Click(object sender, EventArgs e)
        {
           
            if (this.IsEntitySelected)
            {
                lblResultado.Visible = false;
                panelFormulario.Visible = true;
                this.lblRegistro.Visible = false;
                this.panelConfirmacion.Visible = true;
                this.panelConfirmacion.Visible = true;
                this.FormMode = FormModes.Baja;
                this.LoadForm(this.SelectedID);
                this.EnableForm(false);
               
               
                
            }
            else lblRegistro.Visible = true; 
        }

        protected void grillaPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.grillaPersonas.SelectedValue;
            panelFormulario.Visible = false;
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

        protected void ddlTipoPers_SelectedIndexChanged(object sender, EventArgs e)
        {
          
               
            
        }
    }
}