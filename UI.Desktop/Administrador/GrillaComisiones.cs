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
    public partial class GrillaComisiones : Form
    {
        public GrillaComisiones()
        {
            InitializeComponent();
            grvComisiones.AutoGenerateColumns = false;
        }

        #region Metodos
        public void Listar()
        {
            ComisionLogic ComLog = new ComisionLogic();
            this.grvComisiones.DataSource = ComLog.GetAll();
        }

        #endregion

        #region Eventos
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GrillaComisiones_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            ComisionDesktop ComDs = new ComisionDesktop(ApplicationForm.ModoForm.Alta);
            ComDs.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Comision)this.grvComisiones.SelectedRows[0].DataBoundItem).ID;
            ComisionDesktop ComDesk = new ComisionDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            ComDesk.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Comision)this.grvComisiones.SelectedRows[0].DataBoundItem).ID;
            ComisionDesktop ComDesk = new ComisionDesktop(ID, ApplicationForm.ModoForm.Eliminar);
            ComDesk.ShowDialog();
            this.Listar();
        }
        #endregion


    }
    
}
