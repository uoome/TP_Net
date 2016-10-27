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

        public PlanDesktop()
        {
            InitializeComponent();
        }
        public PlanDesktop(ModoForm modo) : this()
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

        public override void MapearDeDatos()
        {
            txtID.Text = PlanActual.ID.ToString();
            txtDescripcion.Text = PlanActual.Descripcion;
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
                this.PlanActual.Descripcion = txtDescripcion.Text;

            }
            if (Modo == ModoForm.Modificacion)
            {
                this.PlanActual.ID = Convert.ToInt32(this.txtID.Text.Trim());
                PlanActual.State = Especialidad.States.Modified;
            }
            if (Modo == ModoForm.Eliminar)
            {PlanActual.State = Especialidad.States.Deleted;
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
            }

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
    }
}
