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
        private int _CupoDis;
        public int AnioCalendario
        {
            get { return _AnioCalendario; }
            set { _AnioCalendario = value; }
        }
        public int CupoDis
        {
            set { _CupoDis = value; }
            get { return _CupoDis; }
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
        public int IDMateria
        {
            get { return _IdMateria; }
            set { _IdMateria = value; }
        }

        public int IDComision
        {
            get { return _IdComision; }
            set { _IdComision = value; }
        }
    }
}