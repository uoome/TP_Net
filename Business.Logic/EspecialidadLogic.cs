using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
   public class EspecialidadLogic : BusinessLogic 
    {
        private EspecialidadAdapter _especialidadData;
        public EspecialidadAdapter EspecialidadData
        {
            set { _especialidadData = value; }
            get { return _especialidadData; }
        }
        public EspecialidadLogic()
        {
            EspecialidadData = new EspecialidadAdapter();
        }
        public List<Especialidad> GetAll()
        {
            return EspecialidadData.GetAll();
        }
        public Especialidad GetOne(int ID)
        {
            return EspecialidadData.GetOne(ID);
        }
        public Especialidad GetOne(string descrip)
        {
            return EspecialidadData.GetOne(descrip);
        }
        public void Delete(int ID)
        {
            EspecialidadData.Delete(ID);
        }
        public void Save(Especialidad esp)
        {
            EspecialidadData.Save(esp);
        }







    }
}


