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
    public partial class GrillaInscripciones : Form
    {
        public GrillaInscripciones()
        {
            InitializeComponent();
            dgvInscripciones.AutoGenerateColumns = false;
        }
        public void Listar()
        {
            AlumnoInscripcionLogic AlLogic = new AlumnoInscripcionLogic();
            dgvInscripciones.DataSource = AlLogic.GetAll();

        }

        private void GrillaInscripciones_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            AlumnoInscripcionDesktop Desk = new AlumnoInscripcionDesktop(ApplicationForm.ModoForm.Alta);
            Desk.ShowDialog();
            this.Listar();

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.AlumnoInscripcion)dgvInscripciones.SelectedRows[0].DataBoundItem).ID;
            AlumnoInscripcionDesktop Desk = new AlumnoInscripcionDesktop(ApplicationForm.ModoForm.Modificacion);
            Desk.ShowDialog();
            this.Listar();

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.AlumnoInscripcion)dgvInscripciones.SelectedRows[0].DataBoundItem).ID;
            AlumnoInscripcionDesktop Desk = new AlumnoInscripcionDesktop(ApplicationForm.ModoForm.Eliminar);
            Desk.ShowDialog();
            this.Listar();


        }
    }
}
