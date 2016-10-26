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
    public partial class GrillaMaterias : ApplicationForm
    {
        public GrillaMaterias()
        {
            InitializeComponent();
            dgvMateria.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            MateriaLogic matLog = new MateriaLogic();
            dgvMateria.AutoGenerateColumns = false;
            dgvMateria.DataSource= matLog.GetAll();
        }
        
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GrillaMaterias_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            MateriaDesktop formMateria = new MateriaDesktop(ApplicationForm.ModoForm.Alta);
            formMateria.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Materia)this.dgvMateria.SelectedRows[0].DataBoundItem).ID;
            MateriaDesktop formMateria = new MateriaDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            formMateria.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Materia)this.dgvMateria.SelectedRows[0].DataBoundItem).ID;
            MateriaDesktop formMateria = new MateriaDesktop(ID, ApplicationForm.ModoForm.Eliminar);
            formMateria.ShowDialog();
            this.Listar();
        }
    }
}
