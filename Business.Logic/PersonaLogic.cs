using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class PersonaLogic : BusinessLogic
    {
        private Data.Database.PersonaAdapter _PersonaData;

        public Data.Database.PersonaAdapter PersonaData
        {
            set { _PersonaData = value; }
            get { return _PersonaData; }
        }

        public PersonaLogic()
        {
            PersonaData = new PersonaAdapter();
        }

        #region Metodos
        public List<Personas> GetAll()
        {
            return PersonaData.GetAll();
        }
        public List<Personas> GetAll(Personas.TiposPersonas tipoPers)
        {
            return PersonaData.GetAll(tipoPers);
        }
        public List<Object> GetAllEstados(int ID)
        {
            return _PersonaData.GetAllEstados(ID);
        }
        public Personas GetOne(int ID)
        {
            return PersonaData.GetOne(ID);
        }
        public Personas GetOne(string nombUs)
        {
            return PersonaData.GetOne(nombUs);
        }
        public int TraerDocente(string nombreDocente)
        {
            return PersonaData.TraerDocente(nombreDocente);
        }
        public void Delete(int ID)
        {
            PersonaData.Delete(ID);
        }
        public void Save(Personas pers)
        {
            PersonaData.Save(pers);
        }

        public bool ExisteUs(string nombUs)
        {
            return PersonaData.ValidarUsuario(nombUs);
        }

        #endregion
    }
}
