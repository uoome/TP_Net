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
    public partial class frmGrillaEstadoAcademico : Form
    {
        public frmGrillaEstadoAcademico()
        {
            InitializeComponent();
            dgvEstaAcademico.AutoGenerateColumns = false;
        }
        
        public void Listar()
        {
            List<Object> lista = new List<Object>();
            PersonaLogic perlog = new PersonaLogic();
            lista = perlog.GetAllEstados(Program.UsuarioSesion.ID);
            dgvEstaAcademico.DataSource = lista;
            dgvEstaAcademico.Show();

        }
        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
