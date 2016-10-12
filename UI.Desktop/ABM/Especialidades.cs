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
    public partial class Especialidades : Form
    {
        public Especialidades()
        {
            InitializeComponent();
            this.dgvEspecialidades.AutoGenerateColumns = false;
        }
        public void Listar()
        {
            EspecialidadLogic EsLog = new EspecialidadLogic();
            this.dgvEspecialidades.DataSource = EsLog.GetAll();

        }

        private void Especialidades_Load(object sender, EventArgs e)
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
            EspecialidadDesktop EspDesk = new EspecialidadDesktop(ApplicationForm.ModoForm.Alta);
           EspDesk.ShowDialog();
            this.Listar();

        }

        private void Editar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
            EspecialidadDesktop EspDesk = new EspecialidadDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            EspDesk.ShowDialog();
            this.Listar();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
            EspecialidadDesktop espDesk = new EspecialidadDesktop(ID, ApplicationForm.ModoForm.Eliminar);
            espDesk.ShowDialog();
            this.Listar();
        }
    }
}
