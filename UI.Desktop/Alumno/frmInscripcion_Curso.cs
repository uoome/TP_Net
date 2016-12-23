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
    public partial class frmInscripcion_Curso : Form
    {
        public frmInscripcion_Curso()
        {
            InitializeComponent();
            dgvMaterias.AutoGenerateColumns = false;
            dgvComisiones_Incrip.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            MateriaLogic matlog = new MateriaLogic();
            this.dgvMaterias.DataSource = matlog.GetAll();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            dgvComisiones_Incrip.Visible = true;
            btnAceptar.Visible = true;
            btnCancelar.Visible = true;
            MessageBox.Show("Al realizar la inscripcion no podra eliminarla","Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            int ID = ((Materia)dgvMaterias.SelectedRows[0].DataBoundItem).ID;
            this.CargarComisiones(ID);
        }

        private void CargarComisiones(int ID)
        {
            ComisionLogic com = new ComisionLogic();
            dgvComisiones_Incrip.DataSource = com.GetAllComisionesMaterias(ID);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnAceptar.Visible = false;
            btnCancelar.Visible = false;
            dgvComisiones_Incrip.Visible = false;
            MessageBox.Show("Se ha cancelado la inscripcion","", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int idCur = (int)dgvComisiones_Incrip.SelectedRows[0].Cells[0].Value;

            Curso Cur = new Curso();
            CursoLogic curlog = new CursoLogic();
            Cur = curlog.GetOne(idCur);

            if (curlog.validarCupo(Cur))
            {
                AlumnoInscripcion Alu = new AlumnoInscripcion();
                Alu.IdAlumno = (int)Program.UsuarioSesion.ID;
                Alu.IdCurso = idCur;
                Alu.Condicion = AlumnoInscripcion.TiposCondiciones.Inscripto;
                Alu.Nota = "Sin nota";
                AlumnoInscripcionLogic Allog = new AlumnoInscripcionLogic();
                Alu.State = BusinessEntity.States.New;
                Allog.Save(Alu);
                Cur.CupoDis = Cur.CupoDis - 1;
                Cur.State = BusinessEntity.States.Modified;
                curlog.Save(Cur);

                MessageBox.Show("Se ha inscripto al curso");
                dgvComisiones_Incrip.Visible = false;
                btnAceptar.Visible = false;
                btnCancelar.Visible = false;
                /* 
                lblCurso.Text = Cur.CupoDis.ToString();
                lblCurso.Visible = true;
                PARA SABER CUANTOS CUPOS DISPONIBLES QUEDAN
                */
            }
            else
            {
                MessageBox.Show("No hay cupos disponibles", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
