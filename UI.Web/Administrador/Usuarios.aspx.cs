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
    public partial class Usuarios : ABM
    {
     
        protected override void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.LoadGrid();
            }
        }
        private UsuarioLogic _usuarioLog;
        public UsuarioLogic UsuarioLog
        {

            get
            {
                if (_usuarioLog == null)
                {
                    _usuarioLog = new UsuarioLogic();
                }
                return _usuarioLog;
            }
        }
        public void LoadGrid()
        {
            this.grvUsuarios.DataSource = this.UsuarioLog.GetAll();
            this.grvUsuarios.DataBind();
        }

        protected void grvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.grvUsuarios.SelectedValue;
        }

        protected void grvUsuarios_Load(object sender, EventArgs e)
        {

        }

        protected void Panel1_Load(object sender, EventArgs e)
        {

        }

        private Usuario Entity
        {
            get;
            set;
        }
        protected void LoadForm(int id)
        {
            this.Entity = this.UsuarioLog.GetOne(id);
            this.txtNombre.Text = this.Entity.Nombre.ToString();
            this.txtApellido.Text = this.Entity.Apellido;
            this.txtEmail.Text = this.Entity.Email;
            this.txtNombreUsuario.Text = this.Entity.NombreUsuario;
            this.chbHabilitado.Checked = this.Entity.Habilitado;
            this.txtClave.Text = this.Entity.Clave;
        }

        protected void EditarLinkBtn_Click(object sender, EventArgs e)
        {
            EnableForm(true);
            if (this.IsEntitySelected)
            {
                this.Panel3.Visible = true;
                this.Panel1.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
            }
        }
        private void LoadEntity(Usuario Usr)
        {
            Usr.Nombre = this.txtNombre.Text;
            Usr.Email = this.txtEmail.Text;
            Usr.NombreUsuario = this.txtNombreUsuario.Text;
            Usr.Apellido = this.txtApellido.Text;
            Usr.Habilitado = this.chbHabilitado.Checked;
            Usr.Clave = this.txtClave.Text;
        }
        private void SaveEntity(Usuario usr)
        {
            this.UsuarioLog.Save(usr);
        }

        protected void AceptarLinkBtn_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Baja:
                    this.DeleteEntity(this.SelectedID);
                    this.LoadGrid();
                    break;
                case FormModes.Modificacion:

                    this.Entity = new Usuario();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                case FormModes.Alta:
                    this.Entity = new Usuario();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;

                default: break;
            }

            this.Panel1.Visible = false;

        }
        protected void EnableForm(bool enable)
        {
            this.txtNombre.Enabled = enable;
            this.txtApellido.Enabled = enable;
            this.txtEmail.Enabled = enable;
            this.txtNombreUsuario.Enabled = enable;
            this.chbHabilitado.Enabled = enable;
            this.txtClave.Enabled = enable;

        }

        protected void EliminarLinkBtn_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.Panel3.Visible = true;
                this.Panel1.Visible = true;
                this.FormMode = FormModes.Baja;
                this.EnableForm(false);
                this.LoadForm(this.SelectedID);
                
            }
        }
        private void DeleteEntity(int id)
        {
            this.UsuarioLog.Delete(id);
        }

        protected void NuevoLinkBtn_Click(object sender, EventArgs e)
        {
            this.Panel1.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.Panel3.Visible = true;
            this.EnableForm(true);
        }
        private void ClearForm()
        {
            this.txtNombre.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtNombreUsuario.Text = string.Empty;
            this.chbHabilitado.Checked = false;
            this.txtClave.Text = string.Empty;
        }

        protected void CancelarLinkBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Administrador/Usuarios.aspx");
        }
    }
}