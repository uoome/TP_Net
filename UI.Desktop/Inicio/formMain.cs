using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void formMain_Shown(object sender, EventArgs e)
        {
            formLogin appLoguin = new formLogin();
            if (appLoguin.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            Usuarios grillaUs = new Usuarios();
            grillaUs.ShowDialog();
            grillaUs.Listar();
            
        }

        private void personasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GrillaPersonas grillaPers = new GrillaPersonas();
            grillaPers.Show();
            grillaPers.Listar();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrillaMaterias grillaMate = new GrillaMaterias();
            grillaMate.Show();
            grillaMate.Listar();
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrillaEspecialidades grillaEspe = new GrillaEspecialidades();
            grillaEspe.Show();
            grillaEspe.Listar();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrillaCursos grillaCurs = new GrillaCursos();
            grillaCurs.Show();
            grillaCurs.Listar();
        }

        private void planToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrillaPlanes grillaPlan = new GrillaPlanes();
            grillaPlan.Show();
            grillaPlan.Listar();
          
        }
    }
}
