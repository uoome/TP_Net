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

        public void LoadGrid()
        {
            MateriaLogic matlog = new MateriaLogic();
            this.grvMaterias.DataSource = matlog.GetAll();
            this.grvMaterias.DataBind();
        }
        protected override void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string si = "menuInscripcionCursado";
                Session["Menu"] = si;
                this.LoadGrid();
            }
        }

        protected void grvMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)grvMaterias.SelectedValue;
            panelComisiones.Visible = true;
            this.LoadGridComisiones(this.SelectedID);
        }
       public void LoadGridComisiones(int id)
        {
            ComisionLogic com = new ComisionLogic();
            grvComisiones.DataSource = com.GetAllComisionesMaterias(id);
            grvComisiones.DataBind();

        }

        protected void grvComisiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)grvComisiones.SelectedValue;
          
        }

        protected void btnInscribirse_Click(object sender, EventArgs e)
        {
            AlumnoInscripcion Alu = new AlumnoInscripcion();
            Alu.IdAlumno = (int)Session["id_persona"];
            Alu.IdCurso = SelectedID;
            Alu.Condicion = AlumnoInscripcion.TiposCondiciones.Inscripto;
            Alu.Nota = 0;
            AlumnoInscripcionLogic Allog = new AlumnoInscripcionLogic();
            Alu.State = BusinessEntity.States.New;
            Allog.Save(Alu);
            lblCurso.Visible = true;

        }
    }
}