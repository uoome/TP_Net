﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class FinalizoSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Abandon();
            }

        }

        protected void btnIniciarSession_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UtilWeb/Login.aspx");
        }
    }
}