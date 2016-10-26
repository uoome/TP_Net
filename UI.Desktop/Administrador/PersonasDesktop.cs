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
        private List<Personas> listaPersonas;

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
            this.txtLegajo.Text = PersonaActual.Legajo.ToString();
            this.txtNombre.Text = PersonaActual.Nombre;
            this.txtApellido.Text = PersonaActual.Apellido;
            this.txtNombUs.Text = PersonaActual.NombreUsuario;
            this.txtClave.Text = PersonaActual.Clave;
            this.txtCambiaClave.Text = PersonaActual.CambiaCLave;
            this.txtDireccion.Text = PersonaActual.Direccion;
            this.txtEmail.Text = PersonaActual.Email;
            this.txtFecha_Nac.Text = PersonaActual.FechaDeNacimiento.ToString();
            this.txtID_Plan.Text = PersonaActual.IDPlan.ToString();
            this.chbxHabilitado.Checked = PersonaActual.Habilitado;
            this.txtTelefono.Text = PersonaActual.Telefono;
            this.cbxTipoPers.Text = PersonaActual.TipoPersona.ToString();

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
                PersonaActual.Legajo = int.Parse(this.txtLegajo.Text);
                PersonaActual.Nombre = this.txtNombre.Text;
                PersonaActual.Apellido= this.txtApellido.Text; 
                PersonaActual.NombreUsuario= this.txtNombUs.Text;
                PersonaActual.Clave= this.txtClave.Text;
                PersonaActual.CambiaCLave= this.txtCambiaClave.Text;
                PersonaActual.Direccion= this.txtDireccion.Text;
                PersonaActual.Email= this.txtEmail.Text;
                PersonaActual.FechaDeNacimiento= DateTime.Parse(this.txtFecha_Nac.Text);
                PersonaActual.IDPlan= int.Parse(this.txtID_Plan.Text.Trim());
                PersonaActual.Habilitado= chbxHabilitado.Checked;
                PersonaActual.Telefono= this.txtTelefono.Text;
                PersonaActual.TipoPersona = new PersonaLogic().GetOne(PersonaActual.ID).TipoPersona;

                //Siendo Alta no tiene ID inicial, por eso verificamos
                if (Modo == ModoForm.Modificacion)
                {
                    this.txbID_Pers.Text = this.PersonaActual.ID.ToString();
                    PersonaActual.State = Personas.States.Modified;
                }
            }
            if (Modo == ModoForm.Eliminar)
            {
                PersonaActual.State = Personas.States.Deleted;
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
            if (txtNombre.Text.Trim().Equals(""))
            {
                msj += "El nombre no puede estar vacío" + "\n";
                txtNombre.BackColor = Color.Red;
            }
            if (txtApellido.Text.Trim().Equals(""))
            {
                msj += "El apellido no puede estar vacío" + "\n";
                txtApellido.BackColor = Color.Red;
            }
            if (txtNombUs.Text.Trim().Equals(""))
            {
                msj += "El nombre de usuario no puede estar vacío" + "\n";
                txtNombUs.BackColor = Color.Red;
            }
            if (txtClave.Text.Trim().Equals(""))
            {
                msj += "La clave no puede estar vacía" + "\n";
                txtClave.BackColor = Color.Red;
            }

            //Validar que la clave no tenga menos de 8 caracteres
            if (txtClave.Text.Trim().Length < 8)
            {
                msj += "La clave no puede tener menos de 8 caracteres" + "\n";
                txtClave.BackColor = Color.Red;
            }

            //Validar que la confirmación de la clave no tenga espacios vacíos y coincida con la clave
            if (txtCambiaClave.Text.Trim().Equals(""))
            {
                msj += "La confirmación de la clave no debe estar vacía" + "\n";
                txtCambiaClave.BackColor = Color.Red;
            }
            else if (!txtCambiaClave.Text.Trim().Equals(txtClave.Text.Trim()))
                msj += "La confirmación de la clave debe coincidir con la clave" + "\n";
                txtCambiaClave.BackColor = Color.Red;


            if (this.txtID_Plan.Text.Trim().Equals(""))
            {
                msj += "El ID Plan no puede estar vacío \n";
                txtID_Plan.BackColor = Color.Red;
            }
            if (this.txtTelefono.Text.Trim().Equals(""))
            {
                msj += "El telefono no puede estar vacío \n";
                txtTelefono.BackColor = Color.Red;
            }
            if (this.txtLegajo.Text.Trim().Equals(""))
            {
                msj += "El legajo no puede estar vacío \n";
                txtLegajo.BackColor = Color.Red;
            }
            if (this.txtDireccion.Text.Trim().Equals(""))
            {
                msj += "La dirección no puede estar vacía \n";
                txtDireccion.BackColor = Color.Red;
            }
            if (!(cbxTipoPers.SelectedIndex > 0))
            {
                msj += "Debe seleccionar que tipo de persona es \n";
                cbxTipoPers.BackColor = Color.Red;
            }

            //Controlar que la direccion de email sea válida 
            if (this.txtEmail.Text.Trim().Equals(""))
            {
                msj += "El email no puede estar vacío";
                txtEmail.BackColor = Color.Red;
            } 
            
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

        private void PersonasDesktop_Load(object sender, EventArgs e)
        {
            //Inicializo comboBox de tipo de personas
            cbxTipoPers.Items.Add(Personas.TiposPersonas.Administrador);
            cbxTipoPers.Items.Add(Personas.TiposPersonas.Alumno);
            cbxTipoPers.Items.Add(Personas.TiposPersonas.Docente);
        }
    }
}
