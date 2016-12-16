using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class SiteDocentes : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id_persona"] != null)
            {

                Menu = Session["Menu"].ToString();
            }
        }

        private string MenuROjo;
        public string Menu
        {
            set
            {
                MenuROjo = value;
                if (MenuROjo == "menuDictado")
                {
                   menuDictado.Attributes["class"] = "active-menu";
                }
                if (MenuROjo == "menuInicio")
                {
                   menuInicio.Attributes["class"] = "active-menu";
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
                Response.Redirect("~/UtilWeb/Login.aspx");
            }

         }
   
          
        

       }
}