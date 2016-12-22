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
            lblCurso.Text = SelectedID.ToString();
          
        }

        protected void btnInscribirse_Click(object sender, EventArgs e)
        { 
            Curso Cur = new Curso();
            CursoLogic curlog = new CursoLogic();
            Cur = curlog.GetOne(SelectedID);
            if ( curlog.validarCupo(Cur)  )
            {
                AlumnoInscripcion Alu = new AlumnoInscripcion();
                Alu.IdAlumno = (int)Session["id_persona"];
                Alu.IdCurso = SelectedID;
                Alu.Condicion = AlumnoInscripcion.TiposCondiciones.Inscripto;
                Alu.Nota = "Sin nota";
                AlumnoInscripcionLogic Allog = new AlumnoInscripcionLogic();
                Alu.State = BusinessEntity.States.New;
                Allog.Save(Alu);
                Cur.CupoDis = Cur.CupoDis - 1;
                Cur.State = BusinessEntity.States.Modified;
                 curlog.Save(Cur);
            
            /*    lblCurso.Text = Cur.CupoDis.ToString();
                lblCurso.Visible = true;
                PARA SABER CUANTOS CUPOS DISPONIBLES QUEDAN
                */
            }
            else
            {
                lblCurso.Text = "No hay cupos disponibles";
                lblCurso.Visible = true;
            }

        }
    }
}