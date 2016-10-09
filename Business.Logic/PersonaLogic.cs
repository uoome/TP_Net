using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    class PersonaLogic : BusinessLogic
    {
        private Data.Database.PersonaAdapter _PersonaData;

        public Data.Database.PersonaAdapter PersonaData
        {
            set { _PersonaData = value; }
            get { return _PersonaData; }
        }
    }
}
