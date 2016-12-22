using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;
using Util;

namespace Business.Logic
{
    public class CursoLogic : BusinessLogic
    {
        private CursoAdapter _cursoData;

        public CursoAdapter CursoData
        {
            get { return _cursoData; }
            set { _cursoData = value; }
        }

        public CursoLogic()
        {
            CursoData = new CursoAdapter();
        }

        public List<Curso> GetAll()
        {
            return CursoData.GetAll();
        }

        public Curso GetOne(int ID)
        {
            return CursoData.GetOne(ID);
        }

        public void Delete(int ID)
        {
            CursoData.Delete(ID);
        }

        public void Save(Curso curso)
        {
            CursoData.Save(curso);
        }
        public bool validarCupo(Curso Cur)
        {
            return ValidacionCurso.validarCupo(Cur);

        }
        public List<Object> GetAllEstadosCursos(int id)
        {
            return CursoData.GetAllEstadosCursos(id);
        }
    }
}
