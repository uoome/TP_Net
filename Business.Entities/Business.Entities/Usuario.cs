using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
   public class Usuario : BusinessEntity
    {
       private string _nombre;
 
       private string _nombreusuario;
       private string _apellido;
       private string _clave;
       private bool _habilitado;
       private string _Email;
       public string Email { get { return _Email; } set { _Email = value; } }
       public string Nombre { get { return _nombre; } set { _nombre = value; } }
       public string Apellido { get { return _apellido ; } set { _apellido = value; } }
       public string NombreUsuario { get { return _nombreusuario; } set { _nombreusuario = value; } }
       public string Clave { get { return _clave; } set { _clave = value; } }
       public bool Habilitado { get { return _habilitado; } set { _habilitado = value; } }
     
    }
   
}
