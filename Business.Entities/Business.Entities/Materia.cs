using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Materia : BusinessEntity
    {
        private string _descripcion;
        private int _hsSemanales;
        private int _hsTotales;
        private int _idPlan;

        public string Descripcion
        {
            get
            {
                return _descripcion;
            }

            set
            {
                _descripcion = value;

            }
        }

        public int HSSemanales
        {
            get
            {
                return _hsSemanales;
            }

            set
            {
                _hsSemanales = value;
            }
        }

        public int HSTotales
        {
            get
            {
                return _hsTotales;
            }

            set
            {
                _hsTotales = value;
            }
        }

        public int IDplan
        {
            get
            {
                return _idPlan;
            }

            set
            {
                _idPlan = value;
            }
        }
    }
}