using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
 public  class ComisionLogic : BusinessLogic 
    {
        public ComisionLogic()
        {
            ComAdap = new ComisionAdapter();
        }
        private ComisionAdapter _comAdap;
        public ComisionAdapter ComAdap
        {
            set { _comAdap = value; }
            get { return _comAdap; }
        }


        public void Save(Comision com)
        {
            ComAdap.Save(com);
        }
        public void Delete(int id)
        {
            ComAdap.Delete(id);
        }
        public List<Comision> GetAll()
        {
            return ComAdap.GetAll();
        }
        public Comision GetOne(int id)
        {
            return ComAdap.GetOne(id);
         }

    }
}
