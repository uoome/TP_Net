using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;


namespace Util
{
    public class ValidacionCurso
    {
        public static bool validarCupo(Curso curso)
        {
            if (curso.CupoDis > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
