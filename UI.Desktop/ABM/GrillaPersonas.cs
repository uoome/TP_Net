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
    public partial class GrillaPersonas : Form
    {
        public GrillaPersonas()
        {
            InitializeComponent();
            this.dgvPersonas.AutoGenerateColumns=false;
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
