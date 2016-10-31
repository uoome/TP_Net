using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;

namespace UI.Desktop
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formMain());
        }

        private static Personas _usuarioSesion; 
        //Variable que indica si ya se ha iniciado sesion en el sistema. 

        public static Personas UsuarioSesion
        {
            get { return _usuarioSesion; }
            set { _usuarioSesion = value; }
        }
    }
}
