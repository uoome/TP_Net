using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Comision : BusinessEntity
    {
        private int _AnioEspecialidad;
        private string _Descripcion;
        private int _IdPlan;

        public int AnioEspecialidad
        {
            get { return _AnioEspecialidad;  }
            set { _AnioEspecialidad = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion;  }
            set { _Descripcion = value; }
        }

        public int IDPlan
        {
            get { return _IdPlan;  }
            set { _IdPlan = value; }
        }
    }
}