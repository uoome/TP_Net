using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class ModuloUsuario : BusinessEntity
    {


        private int _idusuario, _idmodulo;
        private bool _permitealta, _permitebaja, _permitemodificacion, _permiteconsulta;
            
        public bool PermiteAlta
        {
            get { return _permitealta; }
            set { _permitealta = value; }
        }
        public bool PermiteBaja
        {
            get { return _permitebaja; }
            set { _permitebaja = value; }
        }
        public bool PermiteModificacion
        {
            get { return _permitemodificacion; }
            set { _permitemodificacion = value; }
        }
        public bool PermiteConsulta
        {
            get { return _permiteconsulta; }
            set { _permiteconsulta = value; }
        }
        public int IdUsuario
        {
            get { return _idusuario; }
            set { _idusuario = value; }
        }
        public int IdModulo
        {
            get { return _idmodulo; }
            set { _idmodulo = value; }
        }
    }
}
