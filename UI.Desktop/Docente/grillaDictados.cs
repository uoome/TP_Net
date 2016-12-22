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
    public partial class GrillaDictados : Form
    {

        private List<DocenteCurso> _listaDictados;

        public List<DocenteCurso> listaDictados
        {
            get { return _listaDictados; }
            set { _listaDictados = value; }
        }



        public GrillaDictados()
        {
            InitializeComponent();
            dgvDictados.AutoGenerateColumns = false;
            
            DocenteCursologic dcl = new DocenteCursologic();
            listaDictados = dcl.GetAll();
        }

        public void Listar()
        {
            string doc = "";
            List<Object> listaGrilla = new List<Object>();

            foreach (DocenteCurso dc in listaDictados) //Busco los cursos del docente logueado
            {
                if (dc.IdDocente == Program.UsuarioSesion.ID)
                {
                    PersonaLogic plog = new PersonaLogic();
                    Personas p = plog.GetOne(dc.IdDocente);
                    doc = p.Apellido + " " + p.Nombre;

                    // Armo el tipo anonimo
                    listaGrilla.Add(new
                    {
                        ID = dc.ID,
                        cur = dc.IdCurso,
                        docente = doc,
                        cargo = dc.Cargo.ToString()
                    });

                }
            }
            dgvDictados.DataSource = listaGrilla;

        }

        #region Metodos

        #endregion

        #region Eventos
        private void GrillaDictados_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            DictadoDesktop dicDesk = new DictadoDesktop(ApplicationForm.ModoForm.Alta);
            dicDesk.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int ID = (int)dgvDictados.SelectedRows[0].Cells[0].Value;
            //Se reemplaza la linea de codigo inferior por la superior por el tipo anonimo
            //int ID = ((DocenteCurso)dgvDictados.SelectedRows[0].DataBoundItem).ID;
            DictadoDesktop dicDesk = new DictadoDesktop(ApplicationForm.ModoForm.Modificacion, ID);
            dicDesk.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = (int)dgvDictados.SelectedRows[0].Cells[0].Value;
            DictadoDesktop dicDesk = new DictadoDesktop(ApplicationForm.ModoForm.Eliminar, ID);
            dicDesk.ShowDialog();
            this.Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
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
