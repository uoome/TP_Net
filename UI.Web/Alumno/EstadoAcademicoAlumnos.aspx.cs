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
    public partial class EstadoAcademicoAlumnos : ABM
    {
      
        public void LoadGrid(List<Object> lista)
        {
            gvEstadoAcademico.DataSource = lista;
            gvEstadoAcademico.DataBind();
        }

        protected override void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                string si = "menuEstado";
                Session["Menu"] = si;

                }
        }

        protected void gvEstadoAcademico_Load(object sender, EventArgs e)
        { List <Object> Listaa = new List<Object>();
            PersonaLogic perlog = new PersonaLogic();
            Listaa = perlog.GetAllEstados((int)Session["id_persona"]);
               this.LoadGrid(Listaa);
            }

        
    }
    
}