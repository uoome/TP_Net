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
            set
            {
                _PlanData = value;
            }
            get
            {
                return _PlanData;
            }
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

        public void Delete(int ID)
        {
            PlanData.Delete(ID);
        }
        public void Save(Plan plan)
        {
            PlanData.Save(plan);
        }
    } 
}
