﻿using System;
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
        public void Listar()
        {   ComisionLogic ComLog = new ComisionLogic();
            this.grvComisiones.DataSource = ComLog.GetAll();
        }

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
            this.Listar();
        }
    }
}
