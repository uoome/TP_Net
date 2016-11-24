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

        private Personas Entity
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

        } 

        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}