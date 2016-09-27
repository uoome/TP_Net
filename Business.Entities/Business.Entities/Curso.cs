using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Curso : BusinessEntity
    {
        private int _AnioCalendario;
        private int _Cupo;
        private string _Descripcion;
        private int _IdComision;
        private int _IdMateria;

        public int AnioCalendario
        {
            get { return _AnioCalendario; }
            set { _AnioCalendario = value; }
        }
        public int Cupo
        {
            get { return _Cupo; }
            set { _Cupo = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        public int IDmateria
        {
            get { return _IdMateria; }
            set { _IdMateria = value; }
        }

        public int IDcomision
        {
            get { return _IdComision; }
            set { _IdComision = value; }
        }
    }
}