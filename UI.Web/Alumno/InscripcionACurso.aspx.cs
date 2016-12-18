using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web.Alumno
{
    public partial class InscripcionACurso : ABM
    {

        public void LoadGrid(List<Object> lista)
        {
            grvComisiones.DataSource = lista;
            grvComisiones.DataBind();
        }
        protected override void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string si = "menuInscripcionCursado";
                Session["Menu"] = si;
                List<Object> Listaa = new List<Object>();
                ComisionLogic comlog = new ComisionLogic();
                Listaa = comlog.GetAllComisionesMaterias();
                this.LoadGrid(Listaa);
            }
        }

        protected void grvCursos_Load(object sender, EventArgs e)
        {
           List<Object> Listaa = new List<Object>();
           ComisionLogic comlog = new ComisionLogic();
            Listaa = comlog.GetAllComisionesMaterias();
            this.LoadGrid(Listaa); 
        }
    }
}