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
    public partial class Login : ABM
    {
        protected override void Page_Load(object sender, EventArgs e)
        {
           /* if (!IsPostBack)
            {
                Session.Abandon();
            } */

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {

            PersonaLogic persLogic = new PersonaLogic();
            Business.Entities.Personas per;

            if (persLogic.ExisteUs(this.txtUsuario.Text))
            {
                per = persLogic.GetOne(this.txtUsuario.Text);
                if (per.Clave == this.txtClave.Text)
                {
                    if (per.Habilitado)
                    {
                        Session.Add("id_persona", per.ID);
                        Session.Add("id_plan", per.IDPlan);
                        Session.Add("apellido", per.Apellido);
                        Session.Add("nombre", per.Nombre);
                        Session.Add("tipo_persona", per.TipoPersona.ToString());
                        Session.Add("id_usuario", per.ID);
                        Session.Timeout = 1;
                        //Para probar que pasa si expira la session

                        if (per.TipoPersona == Business.Entities.Personas.TiposPersonas.Alumno)
                            Response.Redirect("~/Alumno/DefaultAlumnos.aspx");
                            //Response.Redirect("~/Administrador/Default.aspx");

                        else
                        {
                            if (per.TipoPersona == Business.Entities.Personas.TiposPersonas.Docente)
                                Response.Redirect("~/Docente/DefaultDocentes.aspx");

                            else { Response.Redirect("~/Administrador/Default.aspx"); }
                        }
                    }
                    else { lblLogin.Text = "El usuario no esta Habilitado"; }
                }
                else { lblLogin.Text = "Contraseña invalida"; }
            }
            else { lblLogin.Text = "No existe el usuario"; }
        }

        protected void lnkRecordarClave_Click(object sender, EventArgs e)
        {
            lblLogin.Text = "Intente recordar, por el momento no contamos con servicio de recuperacion de contraseña";
            lblLogin.Visible = true;
        }
    }
}