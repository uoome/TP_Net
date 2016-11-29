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
    public partial class GrillaPlanes : Form
    {
        public GrillaPlanes()
        {
            InitializeComponent();
            dgvPlanes.AutoGenerateColumns = false;
        }
        

        #region Metodos
        public void Listar()
        {
            PlanLogic PlanLog = new PlanLogic();
            this.dgvPlanes.DataSource = PlanLog.GetAll();
        }

        #endregion

        #region Eventos
        private void GrillaPlanes_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnActualizar_MouseClick(object sender, MouseEventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            PlanDesktop planDesk = new PlanDesktop(ApplicationForm.ModoForm.Alta);
            planDesk.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID;
            PlanDesktop planDesk = new PlanDesktop(ID,ApplicationForm.ModoForm.Modificacion);
            planDesk.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID;
            PlanDesktop planDesk = new PlanDesktop(ID, ApplicationForm.ModoForm.Eliminar);
            planDesk.ShowDialog();
            this.Listar();
        }

        #endregion
    }
}
