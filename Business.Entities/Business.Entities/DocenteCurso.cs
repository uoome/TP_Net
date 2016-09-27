using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class DocenteCurso : BusinessEntity
    {
        public enum TiposCargos { Titular = 1, Auxiliar = 2 } ;
        private TiposCargos _Cargo;
        private int _IdCurso;
        private int _IdDocente;

        public TiposCargos Cargo
        {
            get { return _Cargo; }
            set { _Cargo = value; }
        }
        public int IdCurso
        {
            get { return _IdCurso; }
            set { _IdCurso = value; }
        }

        public int IdDocente
        {
            get { return _IdDocente; }
            set { _IdDocente = value; }
        }
    }
}