using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;
using Data.Database;

namespace Business.Logic
{
    public class PlanLogic : BusinessLogic 
    {
        private Data.Database.PlanAdapter _PlanData;
        public Data.Database.PlanAdapter PlanData
        {
            get { return _PlanData; }
            set { _PlanData = value; }
        }
        public PlanLogic()
        {
            PlanData = new Data.Database.PlanAdapter (); 
        }

        public List<Plan> GetAll()
        {
            return PlanData.GetAll();
        }

        public Plan GetOne(int ID)
        {
            return PlanData.GetOne(ID); 
        }
        
        public Plan GetOne(string de, string dp)
        {
            EspecialidadLogic el = new EspecialidadLogic();
            Especialidad espe = el.GetOne(de);
            return PlanData.GetOne(dp, espe.ID);
        }

        public void Delete(int ID)
        {
            PlanData.Delete(ID);
        }
        public void Save(Plan plan)
        {
            PlanData.Save(plan);
        }

        public int TraerSiguienteID()
        {
            return PlanData.TraerSiguienteID();
        }
    } 
}
