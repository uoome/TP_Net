﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class SiteAlumnos : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {  if (!IsPostBack)
            {
              /*  if (Session.Timeout > 2)
                {
                    Response.Redirect("~/Login.aspx");
                } */
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
                Response.Redirect("~/Login.aspx");
            }
        }
    }
}