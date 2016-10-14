using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class UsuarioDesktop : ApplicationForm
    {
        private Usuario _usuarioActual;

        public Usuario UsuarioActual
        {
            set { _usuarioActual = value; }
            get { return _usuarioActual; }
        }

        #region Constructores
        public UsuarioDesktop()
        {
            InitializeComponent();
        }
        public UsuarioDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                this.btnAceptar.Text = "Guardar";
            }
            if (Modo == ModoForm.Eliminar)
            {
                this.btnAceptar.Text = "Eliminar";
            }
            
        }
        public UsuarioDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                this.btnAceptar.Text = "Guardar";
            }
            if (Modo == ModoForm.Eliminar)
            {
                this.btnAceptar.Text = "Eliminar";
            }
            UsuarioLogic usLog = new UsuarioLogic();
            UsuarioActual = usLog.GetOne(ID);
            MapearDeDatos();
        }

        #endregion

        #region Metodos
        public override void MapearDeDatos()
        {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            txtApellido.Text = this.UsuarioActual.Apellido;
            txtClave.Text = this.UsuarioActual.Clave;
            txtConfirmarClave.Text = this.UsuarioActual.Clave;
            txtEmail.Text = this.UsuarioActual.Email;
            txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            
        }
        public override void MapearADatos()
        {
            if(Modo == ModoForm.Alta)
            {
                UsuarioActual = new Usuario();
                UsuarioActual.State = Usuario.States.New;
                
            }
            if (Modo==ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                this.UsuarioActual.Nombre = this.txtNombre.Text ;
                this.UsuarioActual.Apellido = this.txtApellido.Text ;
                this.UsuarioActual.Clave= this.txtClave.Text ;
                this.UsuarioActual.Clave = this.txtConfirmarClave.Text;
                this.UsuarioActual.Email = this.txtEmail.Text;
                UsuarioActual.NombreUsuario = txtUsuario.Text;
                UsuarioActual.Habilitado = chkHabilitado.Checked;

                //Siendo Alta no tiene ID inicial, por eso verificamos
                if (Modo == ModoForm.Modificacion)
                {
                    this.txtID.Text = this.UsuarioActual.ID.ToString();
                    UsuarioActual.State = Usuario.States.Modified;
                }
            }
            if (Modo == ModoForm.Eliminar)
            {
                UsuarioActual.State = Usuario.States.Deleted;
            }

        }
        public override void GuardarCambios()
        {
            this.MapearADatos();
            UsuarioLogic usLogic = new UsuarioLogic();
            usLogic.Save(UsuarioActual);
        }

        public override bool Validar()
        {
            string msj="";

            //Validar espacios vacíos
            if (txtNombre.Text.Trim().Equals(""))
                msj += "El nombre no puede estar vacío"+"\n"; 
            if (txtApellido.Text.Trim().Equals("") )
                msj += "El apellido no puede estar vacío" + "\n"; 
            if (txtUsuario.Text.Trim().Equals(""))
                msj += "El usuario no puede estar vacío" + "\n"; 
            if (txtClave.Text.Trim().Equals(""))
                msj += "La clave no puede estar vacía" + "\n"; 

            //Validar que la clave no tenga menos de 8 caracteres
            if (txtClave.Text.Trim().Length < 8)
               msj += "La clave no puede tener menos de 8 caracteres" + "\n";

            //Validar que la confirmación de la clave no tenga espacios vacíos y coincida con la clave
            if (txtConfirmarClave.Text.Trim().Equals("")) { 
                msj += "La confirmación de la clave no debe estar vacía" + "\n";
            } else if (!txtConfirmarClave.Text.Trim().Equals(txtClave.Text.Trim()))
                        msj += "La confirmación de la clave debe coincidir con la clave" + "\n";

            //Controlar que la direccion de email sea válida 
            if (this.txtEmail.Text.Trim().Equals(""))
            {
                msj += "El email no puede estar vacío";
            } //else { msj+= validarMail(); } //Metodo que valida sintaxis del mail

            //Configurar mensaje de error y devolución del método
            if (string.IsNullOrEmpty(msj))
            {
                return true;
            } else
                {
                    this.Notificar(msj, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                } 
        }
        private String validarMail() //Metodo que valida la sintaxis del mail
        {
            int contArrob = 0, contPunt = 0;
            string mensaje = "";

            for (int i = 0; i < this.txtEmail.Text.Length; i++)
            {
                if (this.txtEmail.Text.ElementAt(i).Equals("@"))
                {
                    contArrob++;
                }
                if (this.txtEmail.Text.ElementAt(i).Equals("."))
                {
                    contPunt++;
                }
            }
            if (contArrob != 1)
            {
                mensaje += "El email debe tener un solo '@'";
            }
            if (contPunt != 1)
            {
                mensaje += "El mensaje debe tener un solo '.'";
            }
            
            return mensaje;
        }  
        public new void Notificar(string titulo, string mensaje, MessageBoxButtons
        botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        public new void Notificar(string mensaje, MessageBoxButtons botones,
        MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }

        #endregion

        #region Eventos
        private void UsuarioDesktop_Load(object sender, EventArgs e)
        {

        }
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                this.GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
