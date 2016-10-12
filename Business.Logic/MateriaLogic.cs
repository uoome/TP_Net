using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class MateriaLogic: BusinessLogic
    {
        private MateriaAdapter _materiaData;

        public MateriaAdapter MateriaData
        {
            get { return _materiaData; }
            set { _materiaData = value; }
        }
        public MateriaLogic()
        {
            MateriaData = new MateriaAdapter();
        }
        public List<Materia> GetAll()
        {
            return MateriaData.GetAll();
        }
        public Materia GetOne(int IDMateria)
        {
            return MateriaData.GetOne(IDMateria);
        }
        public void Delete(int IDMateria)
        {
            MateriaData.Delete(IDMateria);
        }
        public void Save(Materia materia)
        {
            MateriaData.Save(materia);
        }
    }
}
