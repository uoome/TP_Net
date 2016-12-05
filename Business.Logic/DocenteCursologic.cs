using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class DocenteCursologic: BusinessLogic
    {
        private DocenteCursoAdapter _docenteCursoData;

        public DocenteCursoAdapter DocenteCursoData
        {
            get { return _docenteCursoData; }
            set { _docenteCursoData = value; }
        }

        public DocenteCursologic()
        {
            DocenteCursoData = new DocenteCursoAdapter();
        }

        public List<DocenteCurso> GetAll()
        {
            return DocenteCursoData.GetAll();
        }

        public DocenteCurso GetOne(int idDictado)
        {
            return DocenteCursoData.GetOne(idDictado);
        }

        public void Save(DocenteCurso dc)
        {
            DocenteCursoData.Save(dc);
        }   

    }
}
