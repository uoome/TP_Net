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
    }
}
