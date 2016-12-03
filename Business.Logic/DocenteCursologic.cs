using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    class DocenteCursologic: BusinessLogic
    {
        private DocenteCursoAdapter _docenteCursoData;

        public DocenteCursoAdapter DocenteCursoData
        {
            get { return _docenteCursoData; }
            set { _docenteCursoData = value; }
        }


            

    }
}
