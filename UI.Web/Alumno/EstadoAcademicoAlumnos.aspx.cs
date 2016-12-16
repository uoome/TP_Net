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
        private static List<AlumnoInscripcion> _listaInscripciones;
        public List<AlumnoInscripcion> listaInscripciones
        {
            get { return _listaInscripciones; }
            set { _listaInscripciones = value; }
        }

        private static List<Materia> _listaMaterias;
        public List<Materia> listaMaterias
        {
            get { return _listaMaterias; }
            set { _listaMaterias = value; }
        }

        private static List<Plan> _listaPlanes;
        public List<Plan> listaPlanes
        {
            get { return _listaPlanes; }
            set { _listaPlanes = value; }
        }

        private static List<Curso> _listaCursos;
        public List<Curso> listaCursos
        {
            get { return _listaCursos; }
            set { _listaCursos = value; }
        }

        private static List<Object> _listaGrilla;
        public List<Object> listaGrilla
        {
            get { return _listaGrilla; }
            set { _listaGrilla = value; }
        }
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

                AlumnoInscripcionLogic ail = new AlumnoInscripcionLogic();
                listaInscripciones = ail.GetAll();
                MateriaLogic ml = new MateriaLogic();
                listaMaterias = ml.GetAll();
                PlanLogic pl = new PlanLogic();
                listaPlanes = pl.GetAll();
                CursoLogic cl = new CursoLogic();
                listaCursos = cl.GetAll();
            }
        }

        protected void gvEstadoAcademico_Load(object sender, EventArgs e)
        {
            {
                string c, p, n, est;
                listaGrilla = new List<Object>();
                foreach (Materia materia in listaMaterias)
                {
                    if (materia.IDplan == (int)Session["id_plan"])
                    {
                        c = "";
                        p = "";
                        n = "";
                        est = "";
                        foreach (Plan plan in listaPlanes)
                        {
                            if (plan.ID == materia.IDplan)
                            {
                                p = plan.Descripcion;
                                break;
                            }
                        }
                        foreach (AlumnoInscripcion alu in listaInscripciones)
                        {
                            if (alu.IdAlumno == (int)Session["id_persona"])
                            {
                                foreach (Curso curso in listaCursos)
                                {
                                    if (curso.IDMateria == materia.ID && alu.IdCurso == curso.ID)
                                    {
                                        c = alu.Condicion.ToString();
                                        n = alu.Nota.ToString();
                                        break;
                                    }
                                }
                            }
                            if (c.Equals(AlumnoInscripcion.TiposCondiciones.Cursando) || c.Equals(AlumnoInscripcion.TiposCondiciones.Libre))
                                est = c;
                            else est = c + "con " + n;

                        }


                        listaGrilla.Add(new
                        {
                            año = 2016,
                            desc_materia = materia.Descripcion,
                            estado= est,
                            desc_plan = p
                        });
                    }
                }
                this.LoadGrid(listaGrilla);
            }
        }
    }
}