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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {

            PersonaLogic persLogic = new PersonaLogic();
            Personas per;

            if (persLogic.ExisteUs(this.txtUsuario.Text))
            {
                per = persLogic.GetOne(this.txtUsuario.Text);
                if (per.Clave == this.txtClave.Text)
                {
                    if (per.Habilitado)
                    {

                        Response.Redirect("~/Default.aspx");
                    }

                    else
                    {
                        lblLogin.Text = "El usuario no esta Habilitado";
                    }
                }
                else
                {
                    lblLogin.Text = "Contraseña invalida";
                }
            }
            else
            {
                lblLogin.Text = "No existe el usuario";
            }
        }

        protected void lnkRecordarClave_Click(object sender, EventArgs e)
        {
            lblLogin.Text = "Intente recordar, por el momento no contamos con servicio de recuperacion de contraseña";
            lblLogin.Visible = true;
        }
    }
}