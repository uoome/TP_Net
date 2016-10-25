using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class PersonasDesktop : ApplicationForm
    {
        private Personas _personaActual;

        public Personas PersonaActual
        {
            get { return _personaActual; }
            set { _personaActual = value; }
        }

        #region Constructores
        public PersonasDesktop()
        {
            InitializeComponent();
        }

        public PersonasDesktop(ApplicationForm.ModoForm modo) :this()
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

        public PersonasDesktop(ApplicationForm.ModoForm modo, int ID) : this()
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

            PersonaLogic persLog = new PersonaLogic();
            PersonaActual= persLog.GetOne(ID);
            MapearDeDatos();
        }

        #endregion

        #region Metodos
        public override void MapearDeDatos()
        {
            this.txbID_Pers.Text = PersonaActual.ID.ToString();
            this.txbLegajo.Text = PersonaActual.Legajo.ToString();
            this.txbNombre.Text = PersonaActual.Nombre;
            this.txbApellido.Text = PersonaActual.Apellido;
            this.txbNombUs.Text = PersonaActual.NombreUsuario;
            this.txbClave.Text = PersonaActual.Clave;
            this.txbCambiaClave.Text = PersonaActual.CambiaCLave;
            this.txbDireccion.Text = PersonaActual.Direccion;
            this.txbEmail.Text = PersonaActual.Email;
            this.txbFecha_Nac.Text = PersonaActual.FechaDeNacimiento.ToString();
            this.txbID_Plan.Text = PersonaActual.IDPlan.ToString();
            this.chbxHabilitado.Checked = PersonaActual.Habilitado;
            this.txbTelefono.Text = PersonaActual.Telefono;
            //falta el comboBox

        }
        
        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                PersonaActual = new Personas();
                PersonaActual.State = Personas.States.New;

            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                //PersonaActual.Legajo = Convert.ToInt32(this.txbLegajo.Text);
                PersonaActual.Nombre = this.txbNombre.Text;
                PersonaActual.Apellido= this.txbApellido.Text; 
                PersonaActual.NombreUsuario= this.txbNombUs.Text;
                PersonaActual.Clave= this.txbClave.Text;
                PersonaActual.CambiaCLave= this.txbCambiaClave.Text;
                PersonaActual.Direccion= this.txbDireccion.Text;
                PersonaActual.Email= this.txbEmail.Text;
                PersonaActual.FechaDeNacimiento= Convert.ToDateTime(this.txbFecha_Nac.Text);
                PersonaActual.IDPlan= Convert.ToInt32(this.txbID_Plan.Text.Trim());
                PersonaActual.Habilitado= chbxHabilitado.Checked;
                PersonaActual.Telefono= this.txbTelefono.Text;
                //falta el comboBox

                //Siendo Alta no tiene ID inicial, por eso verificamos
                if (Modo == ModoForm.Modificacion)
                {
                    this.txbID_Pers.Text = this.PersonaActual.ID.ToString();
                    PersonaActual.State = Usuario.States.Modified;
                }
            }
            if (Modo == ModoForm.Eliminar)
            {
                PersonaActual.State = Usuario.States.Deleted;
            }

        }
        public override void GuardarCambios()
        {
            this.MapearADatos();
            PersonaLogic persLogic = new PersonaLogic();
            persLogic.Save(PersonaActual);
        }

        public override bool Validar()
        {
            string msj = "";

            //Validar espacios vacíos
            if (txbNombre.Text.Trim().Equals(""))
                msj += "El nombre no puede estar vacío" + "\n";
            if (txbApellido.Text.Trim().Equals(""))
                msj += "El apellido no puede estar vacío" + "\n";
            if (txbNombUs.Text.Trim().Equals(""))
                msj += "El nombre de usuario no puede estar vacío" + "\n";
            if (txbClave.Text.Trim().Equals(""))
                msj += "La clave no puede estar vacía" + "\n";

            //Validar que la clave no tenga menos de 8 caracteres
            if (txbClave.Text.Trim().Length < 8)
                msj += "La clave no puede tener menos de 8 caracteres" + "\n";

            //Validar que la confirmación de la clave no tenga espacios vacíos y coincida con la clave
            if (txbCambiaClave.Text.Trim().Equals(""))
            {
                msj += "La confirmación de la clave no debe estar vacía" + "\n";
            }
            else if (!txbCambiaClave.Text.Trim().Equals(txbClave.Text.Trim()))
                msj += "La confirmación de la clave debe coincidir con la clave" + "\n";

            if (this.txbID_Plan.Text.Trim().Equals(""))
                msj += "El ID Plan no puede estar vacío";
            if (this.txbTelefono.Text.Trim().Equals(""))
                msj += "El telefono no puede estar vacío";
            if (this.txbLegajo.Text.Trim().Equals(""))
                msj += "El legajo no puede estar vacío";
            if (this.txbDireccion.Text.Trim().Equals(""))
                msj += "La dirección no puede estar vacía";
            //Falta validar el comboBox

            //Controlar que la direccion de email sea válida 
            if (this.txbEmail.Text.Trim().Equals(""))
            {
                msj += "El email no puede estar vacío";
            } //else { msj+= validarMail(); } //Metodo que valida sintaxis del mail
            

            //Configurar mensaje de error y devolución del método
            if (string.IsNullOrEmpty(msj))
            {
                return true;
            }
            else
            {
                this.Notificar(msj, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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
