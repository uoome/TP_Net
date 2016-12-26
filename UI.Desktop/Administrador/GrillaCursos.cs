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
    public partial class GrillaCursos : Form
    {
        public GrillaCursos()
        {
            InitializeComponent();
            this.dgvCursos.AutoGenerateColumns = false;
        }
        
        public void Listar()
        {
            CursoLogic curLog = new CursoLogic();
            this.dgvCursos.DataSource= curLog.GetAllNuevo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            CursoDesktop curDesk = new CursoDesktop(ApplicationForm.ModoForm.Alta);
            curDesk.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int ID = (int)dgvCursos.SelectedRows[0].Cells[0].Value;
            CursoDesktop curDek = new CursoDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            curDek.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = (int)dgvCursos.SelectedRows[0].Cells[0].Value;
            CursoDesktop curDesk = new CursoDesktop(ID, ApplicationForm.ModoForm.Eliminar);
            curDesk.ShowDialog();
            this.Listar();
        }

        private void GrillaCursos_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}
