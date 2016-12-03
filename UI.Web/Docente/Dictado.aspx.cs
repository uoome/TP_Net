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
    public partial class Dictado : ABM
    {
        private DocenteCurso _dictado;

        public DocenteCurso Dictados
        {
            get
            {
                if (_dictado == null)
                    _dictado = new DocenteCurso();
                return _dictado;
            }
            set { _dictado = value; }
        }

        private DocenteCurso _entity;

        public DocenteCurso Entity { get; set; }

        private List<DocenteCurso> _listaDictados;
        public List<DocenteCurso> listaDictados { get { return _listaDictados; } set { _listaDictados = value; } }

        private List<Curso> _listaCursos;
        public List<Curso> listaCursos { get { return _listaCursos; } set { _listaCursos = value; } }

        private List<Materia> _listaMaterias;
        public List<Materia> listaMaterias { get { return _listaMaterias; } set { _listaMaterias = value; } }

        private List<Comision> _listaComi;
        public List<Comision> listaComi { get { return _listaComi; } set { _listaComi = value; } }
        
        private List<Object> _listaGrilla;
        public List<Object> listaGrilla { get { return _listaGrilla; } set { _listaGrilla = value; } }


        #region Metodos

        #endregion

        #region Eventos

        protected override void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string si = "menuDictados";
                Session["Menu"] = si;

                CursoLogic curLog = new CursoLogic();
                listaCursos = curLog.GetAll();
                MateriaLogic marLog = new MateriaLogic();
                listaMaterias = marLog.GetAll();
                ComisionLogic comLog = new ComisionLogic();
                listaComi = comLog.GetAll();
                //DocenteCursoLogic dictLog= new DocenteCursoLogic();
                //listaDictados = dictLog.GetAll();
            }

        }

        protected void grvDictados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion

        protected void grvDictados_Load(object sender, EventArgs e)
        {
            string comi = "", mat = "", anio = "", cupo = "";
            listaGrilla = new List<Object>();

            foreach(DocenteCurso dc in listaDictados)
            {
                if(dc.IdDocente == (int)Session["id_persona"])
                {
                    
                }
            }



        }
    }
}