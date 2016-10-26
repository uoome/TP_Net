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
    public partial class GrillaPersonas : Form
    {
        public GrillaPersonas()
        {
            InitializeComponent();
            this.dgvPersonas.AutoGenerateColumns=false;
        }

        public void Listar()
        {
            PersonaLogic pl = new PersonaLogic();
            this.dgvPersonas.DataSource = pl.GetAll();
        }

        #region Eventos 

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GrillaPersonas_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            PersonasDesktop persDesk = new PersonasDesktop(ApplicationForm.ModoForm.Alta);
            persDesk.ShowDialog();
            this.Listar();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            int ID = ((Personas)this.dgvPersonas.SelectedRows[0].DataBoundItem).ID;
            PersonasDesktop persDesk = new PersonasDesktop(ApplicationForm.ModoForm.Modificacion,ID);
            persDesk.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Personas)this.dgvPersonas.SelectedRows[0].DataBoundItem).ID;
            PersonasDesktop persDesk = new PersonasDesktop(ApplicationForm.ModoForm.Eliminar, ID);
            persDesk.ShowDialog();
            this.Listar();
        }

        #endregion
    }
}
