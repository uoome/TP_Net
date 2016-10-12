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

namespace UI.Desktop.ABM
{
    public partial class EspecialidadDesktop : ApplicationForm 
        {

        private Especialidad _especialidadActual;
        public EspecialidadDesktop()
        {
            InitializeComponent();
        }
        public Especialidad EspecialidadActual
        { set { _especialidadActual = value; }
            get
            {
                return _especialidadActual;
            }
        }

        #region constructores
        public EspecialidadDesktop(ModoForm modo) :this()
        {
            Modo = modo;
            if (ModoForm.Alta == modo)
            {

            }
        }
        public EspecialidadDesktop(int ID, ModoForm modo):this()
        {
            Modo = modo;
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            { this.btnAceptar.Text = "Guardar"; }
            else if (Modo == ModoForm.Eliminar)
            {
                this.btnAceptar.Text = "Eliminar";
            }
            EspecialidadLogic espLog = new EspecialidadLogic();
            EspecialidadActual = espLog.GetOne(ID);
            MapearDeDatos();
        }
        #endregion

        #region Metodos
        public override void MapearDeDatos()
        {
            txtID.Text = EspecialidadActual.ID.ToString();
            txtDescripcion.Text = EspecialidadActual.Descripcion;         
        }
        public override void MapearADatos()
        { 
            if (Modo == ModoForm.Alta)
            {
                EspecialidadActual = new Especialidad();
                EspecialidadActual.State = Especialidad.States.New;
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                this.EspecialidadActual.Descripcion = txtDescripcion.Text;

            }
            if (Modo == ModoForm.Modificacion)
            {
                this.EspecialidadActual.ID = Convert.ToInt32(this.txtID.Text.Trim());
                EspecialidadActual.State = Especialidad.States.Modified;
            }
            if (Modo == ModoForm.Eliminar)
            {
                EspecialidadActual.State = Especialidad.States.Deleted;
            }
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            EspecialidadLogic EspLog = new EspecialidadLogic();
            EspLog.Save(EspecialidadActual);
        }
        public override bool Validar() { return false; }
        public void Notificar(string titulo, string mensaje, MessageBoxButtons
        botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        public void Notificar(string mensaje, MessageBoxButtons botones,
        MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }


        #endregion





        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
