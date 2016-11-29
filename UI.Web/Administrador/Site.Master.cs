using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id_persona"] != null)
            {

                Menu = Session["Menu"].ToString();
            }

        }

        protected void bodyContentPlaceHolder_Load(object sender, EventArgs e)
        {

        }
        private string MenuROjo;
        public string Menu
        {
            set
            {
                MenuROjo = value;
                if (MenuROjo == "menuEspecialidades")
                {
                    activarrojo.Attributes["class"] = "active-menu";
                } 
                if(MenuROjo =="menuUsuarios")
                {
                    menuUsuarios.Attributes["class"] = "active-menu";
                }
                if (MenuROjo == "menuInicio")
                { 
                    menuInicio.Attributes["class"] = "active-menu";
                }
                if (MenuROjo == "menuPersonas")
                {
                    menuPersonas.Attributes["class"] = "active-menu";
                }
                if (MenuROjo == "menuInscripciones")
                {
                    menuInscripciones.Attributes["class"] = "active-menu";
                }
                if (MenuROjo == "menuCursos")
                {
                    menuCursos.Attributes["class"] = "active-menu";
                }
                if (MenuROjo == "menuMaterias")
                {
                    menuMaterias.Attributes["class"] = "active-menu";
                }
                if(MenuROjo == "menuEstadoAcademico")
                {
                    menuMaterias.Attributes["class"] = "active-menu";
                }
                if (MenuROjo == "menuPlanes")
                {
                    menuMaterias.Attributes["class"] = "active-menu";
                }
            }
        }

        protected void lblPersona_Init(object sender, EventArgs e)
        {
            if (Session["id_persona"] != null)
            {
               
                lblPersona.Text = Session["nombre"].ToString() + " " + Session["apellido"].ToString();
                lblPersona.Visible = true;

            }
            else
            {
                Response.Redirect("~/Administrador/FinalizoSession.aspx");
            }
        }

    }
}