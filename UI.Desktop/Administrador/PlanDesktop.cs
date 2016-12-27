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
    public partial class PlanDesktop : ApplicationForm 
    {
        private Plan _PlanActual;
        
        public Plan PlanActual
        {
            set { _PlanActual = value; }
            get { return _PlanActual; }
        }

        private List<Especialidad> listaEspecialidades;

        #region Constructores
        public PlanDesktop()
        {
            InitializeComponent();

            //Cargo lista de especialidades
            EspecialidadLogic esplog = new EspecialidadLogic();
            listaEspecialidades = esplog.GetAll();

            cbxEspecialidades.Items.Add("");
            foreach (Especialidad e in listaEspecialidades)
                cbxEspecialidades.Items.Add(e.Descripcion);

        }
        public PlanDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            if (Modo == ModoForm.Alta)
            {
                this.btnAceptar.Text = "Guardar";
                PlanLogic plog = new PlanLogic();
                txtID.Text = plog.TraerSiguienteID().ToString();
            }

            if (Modo == ModoForm.Eliminar)
            {
                this.btnAceptar.Text = "Eliminar";
            }

        }
        public PlanDesktop(int ID, ModoForm modo):this()
        {
            Modo = modo;
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                this.btnAceptar.Text = "Guardar";
            }
            else if (Modo == ModoForm.Eliminar)
            {
                this.btnAceptar.Text = "Eliminar";
            }

            PlanLogic planLog = new PlanLogic();
            PlanActual = planLog.GetOne(ID);
            MapearDeDatos();
        }

        #endregion

        #region Metodos
        public override void MapearDeDatos()
        {
            txtID.Text = PlanActual.ID.ToString();
            txtDescripcion.Text = PlanActual.Descripcion;
            EspecialidadLogic elog = new EspecialidadLogic();
            cbxEspecialidades.Text = elog.GetOne(PlanActual.IDEspecialidad).Descripcion;
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
               PlanActual = new Plan();
               PlanActual.State = Especialidad.States.New;
            }

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo == ModoForm.Modificacion)
                {
                    this.PlanActual.ID = Convert.ToInt32(this.txtID.Text.Trim());
                    PlanActual.State = Especialidad.States.Modified;
                }

                this.PlanActual.Descripcion = txtDescripcion.Text;
                EspecialidadLogic elog = new EspecialidadLogic();
                PlanActual.IDEspecialidad = elog.GetOne(cbxEspecialidades.Text).ID;
            }

            if (Modo == ModoForm.Eliminar)
            {
                PlanActual.State = Especialidad.States.Deleted;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            PlanLogic planLog = new PlanLogic();
            planLog.Save(PlanActual);
        }

        public override bool Validar()
        {
            string msj = "";

            if (txtDescripcion.Text.Trim().Equals(""))
            {
                msj += "La descripcion no puede estar vacía \n";
                txtDescripcion.BackColor = Color.Red;
            }
            else { txtDescripcion.BackColor = Color.White; }

            if (cbxEspecialidades.SelectedIndex == 0)
            {
                msj += "Debe seleccionar una especialidad \n";
                cbxEspecialidades.BackColor = Color.Red;
            }
            else { cbxEspecialidades.BackColor = Color.White; }

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
