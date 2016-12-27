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
    public partial class ComisionDesktop : ApplicationForm
    {
        
        private Comision _comActual;
        public Comision ComActual
        {
            set { _comActual = value; }
            get { return _comActual; }
        }

        private List<Plan> listaPlanes;

        #region Constructores

        public ComisionDesktop()
        {
            InitializeComponent();

            //Cargo como planes
            PlanLogic plog = new PlanLogic();
            listaPlanes = plog.GetAll();

            cbxPlanes.Items.Add("");
            foreach (Plan p in listaPlanes)
                cbxPlanes.Items.Add(p.ID);

        }

        public ComisionDesktop(ModoForm modo):this()
        {
            Modo = modo;

            if (Modo == ModoForm.Alta)
            {
                this.btnAceptar.Text = "Guardar";
                ComisionLogic clog = new ComisionLogic();
                txtIDComi.Text = clog.TraerSiguienteID().ToString();
            }
            if (Modo == ModoForm.Eliminar)
            {
                this.btnAceptar.Text = "Eliminar";
            }
        }

        public ComisionDesktop(int ID, ModoForm modo):this()
        {
            Modo = modo;

            if (Modo == ModoForm.Modificacion)
            {
                btnAceptar.Text = "Guardar";
            }
            if (Modo == ModoForm.Eliminar)
            {
                this.btnAceptar.Text = "Eliminar";
            }

           ComisionLogic ComLog = new ComisionLogic();
           ComActual = ComLog.GetOne(ID);
           MapearDeDatos();
        }

        #endregion

        #region Metodos

        public override void MapearDeDatos()
        {
            txtIDComi.Text = ComActual.ID.ToString();
            txtDescripcion.Text = ComActual.Descripcion;
            txtAnioEsp.Text = ComActual.AnioEspecialidad.ToString();

            PlanLogic plog = new PlanLogic();
            Plan p = plog.GetOne(ComActual.IDPlan);
            cbxPlanes.Text = p.ID.ToString();
            lblDescPlan.Text = p.Descripcion;
            lblDescPlan.Visible = true;
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
               ComActual = new Comision();
               ComActual.State = BusinessEntity.States.New;

            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo == ModoForm.Modificacion)
                {
                    txtIDComi.Text = ComActual.ID.ToString();
                    ComActual.State = BusinessEntity.States.Modified;
                }

                ComActual.Descripcion = txtDescripcion.Text;
                ComActual.AnioEspecialidad = int.Parse(txtAnioEsp.Text);
                ComActual.IDPlan = int.Parse(cbxPlanes.Text);
            }

            if (Modo == ModoForm.Eliminar)
            {
                ComActual.State = BusinessEntity.States.Deleted;
            }

        }
        public override void GuardarCambios()
        {
           this.MapearADatos();
           ComisionLogic comLog = new ComisionLogic();
           comLog.Save(ComActual);
        }

        public override bool Validar()
        {
            string msj = "";

            if (txtAnioEsp.Text.Trim().Equals(""))
            {
                msj += "El año de especialidad no puede estar vacio \n";
                txtAnioEsp.BackColor = Color.Red;
            }
            else { txtAnioEsp.BackColor = Color.White; }

            if (txtDescripcion.Text.Trim().Equals(""))
            {
                msj += "La comision debe tener una descripcion \n";
                txtDescripcion.BackColor = Color.Red;
            }
            else { txtDescripcion.BackColor = Color.White; }

            if (cbxPlanes.SelectedIndex == 0)
            {
                msj += "Debe seleccionar un plan \n";
                cbxPlanes.BackColor = Color.Red;
            }
            else { cbxPlanes.BackColor = Color.White; }

            if (string.IsNullOrEmpty(msj))
                return true;
            else
            {
                this.Notificar("Datos incorrectos", msj, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                this.GuardarCambios();
                this.Close();
            }
        }

        private void cbxPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlanLogic plog = new PlanLogic();
            lblDescPlan.Text = plog.GetOne(int.Parse(cbxPlanes.Text)).Descripcion;
            lblDescPlan.Visible = true;
        }

        #endregion region


    }
}
