using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class AlumnoInscripcion : BusinessEntity
    {
        public enum TiposCondiciones
        {
            Inscripto = 1,
            Cursando = 2,
            Regular = 3,
            Promocionado = 4,
            Aprobado = 5,
            Libre = 6
        }

        private TiposCondiciones _condicion;
        private int _IdAlumno;
        private int _IdCurso;
        private int _Nota;

        public TiposCondiciones Condicion
        {
            get { return _condicion; }
            set { _condicion = value; }
        }

        public int IdAlumno
        {
            get { return _IdAlumno; }
            set { _IdAlumno = value; }
        }

        public int IdCurso
        {
            get { return _IdCurso; }
            set { _IdCurso = value; }
        }

        public int Nota
        {
            get { return _Nota; }
            set { _Nota = value; }
        }
    }
}