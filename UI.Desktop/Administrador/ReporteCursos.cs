﻿using System;
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
    public partial class ReporteCursos : ApplicationForm
    {
        public ReporteCursos()
        {
            InitializeComponent();
        }

        private void ReporteCursos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatasetCursos.cursos' Puede moverla o quitarla según sea necesario.
            this.cursosTableAdapter.Fill(this.DatasetCursos.cursos);

            this.reportViewer1.RefreshReport();
        }
    }
}
