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
        public PersonasDesktop(ModoForm modo): this()
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

        public PersonasDesktop(ModoForm modo, int ID): this()
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
            PersonaActual = persLog.GetOne(ID);
            MapearDeDatos();
        }

        #endregion

        #region Metodos

        public override void MapearDeDatos()
        {
            this.txtID_Persona.Text = PersonaActual.ID.ToString();
            this.txtNombre.Text = PersonaActual.Nombre;
            this.txtApellido.Text = PersonaActual.Apellido;
            this.txtDireccion.Text = PersonaActual.Direccion;
            this.txtTelefono.Text = PersonaActual.Telefono;
            this.txtFecha_nac.Text = PersonaActual.FechaDeNacimiento.ToString();
            this.txtEmail.Text = PersonaActual.Email;
            //Faltan los combobox.
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
                PersonaActual.Nombre = this.txtNombre.Text;
                PersonaActual.Apellido = this.txtApellido.Text;
                PersonaActual.Direccion = this.txtDireccion.Text;
                PersonaActual.Email = this.txtEmail.Text;
                PersonaActual.Telefono = this.txtTelefono.Text;

                //Como convertir a enteros con string ? 
                //PersonaActual.Legajo = this.txtLegajo.Text;
                //PersonaActual.IDPlan = this.cbTipoPers.Text;

                //Como pasar de string a DateTime
                //PersonaActual.FechaDeNacimiento = this.txtFecha_nac;

                //Siendo Alta no tiene ID inicial, por eso verificamos
                if (Modo == ModoForm.Modificacion)
                {
                    this.txtID_Persona.Text = this.PersonaActual.ID.ToString();
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
            PersonaLogic persLog = new PersonaLogic();
            persLog.Save(PersonaActual);
        }
        public override bool Validar()
        {
            string msj= "";

            //Validar campos en blanco
            if (txtNombre.Text.Trim().Equals(""))
                msj += "El nombre no puede estar vacío \n";
            if (txtApellido.Text.Trim().Equals(""))
                msj += "El apellido no puede estar vacío \n";
            if (txtEmail.Text.Trim().Equals(""))
                msj += "El email no puede estar vacío \n";
            if (txtTelefono.Text.Trim().Equals(""))
                msj += "El telefono no puede estar vacío \n";
            if (txtDireccion.Text.Trim().Equals(""))
                msj += "La dirección no puede estar vacía \n";
            if (txtFecha_nac.Text.Trim().Equals(""))
                msj += "La fecha de nacimiento no puede estar vacío \n";
            if (txtLegajo.Text.Trim().Equals(""))
                msj += "El legajo no puede estar vacío";

            //Falta validar los combobox

            //Validar salida
            if (string.IsNullOrEmpty(msj))
            {
                return true;
            } else
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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void PersonasDesktop_Load(object sender, EventArgs e)
        {

        }

        private void txtFecha_nac_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                this.GuardarCambios();
                this.Close();
            }
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
