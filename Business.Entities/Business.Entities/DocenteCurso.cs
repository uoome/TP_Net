using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class DocenteCurso : BusinessEntity
    {
        public enum TiposCargos { Titular = 1, Auxiliar = 2 } ;
        private TiposCargos _cargo;
        private int _idCurso;
        private int _idDocente;

        public TiposCargos Cargo
        {
            get
            {
                return _cargo;
            }

            set
            {
                _cargo = value;
            }
        }

        public int IDcurso
        {
            get
            {
                return _idCurso;

            }

            set
            {
                _idCurso = value;

            }
        }

        public int IDdocente
        {
            get
            {
                return _idDocente;
            }

            set
            {
                _idDocente = value;
            }
        }
    }
}