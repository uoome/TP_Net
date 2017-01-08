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
    public partial class GrillaInscripciones : Form
    {

        private static List<Business.Entities.Personas> _alumnos = new List<Business.Entities.Personas>();

        public List<Business.Entities.Personas> Alumnos
        {
            get { return _alumnos; }
            set { _alumnos = value; }
        }

        public GrillaInscripciones()
        {
            InitializeComponent();
            dgvInscripciones.AutoGenerateColumns = false;
            PersonaLogic perLog = new PersonaLogic();
            Alumnos = perLog.GetAll(Business.Entities.Personas.TiposPersonas.Alumno);

        }

        public void Listar()
        {
            dgvAlumnos.DataSource = Alumnos;
        }
        

        public void CargarInscripciones(int idAlu)
        {
            CursoLogic cur = new CursoLogic();
            List<Object> ListaCursos = new List<Object>();
            ListaCursos = cur.GetAllEstadosCursos(idAlu);
            dgvInscripciones.DataSource = ListaCursos;
        }



        #region Eventos

        private void btnInscripciones_Click(object sender, EventArgs e)
        {
            dgvInscripciones.Visible = true;
            CargarInscripciones(Alumnos[dgvAlumnos.SelectedColumns[0].Index].ID); //verificar

        }

        private void GrillaInscripciones_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
