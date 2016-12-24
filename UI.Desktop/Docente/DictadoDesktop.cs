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
    public partial class DictadoDesktop : ApplicationForm
    {

        private DocenteCurso _dictadoActual;

        public DocenteCurso DictadoActual { get { return _dictadoActual; } set { _dictadoActual = value; } }

        #region Constructores
        public DictadoDesktop()
        {
            InitializeComponent();
            
        }

        public DictadoDesktop(ApplicationForm.ModoForm modo): this()
        {
            Modo = modo;
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                this.btnAceptar.Text = "Guardar";
            }
            if (Modo == ModoForm.Eliminar)
            {
                this.btnAceptar.Text = "Eliminar";
            }
        }

        public DictadoDesktop(ApplicationForm.ModoForm modo, int ID): this()
        {
            Modo = modo;
            if (Modo == ModoForm.Modificacion)
            {
                this.btnAceptar.Text = "Guardar";
            }
            if (Modo == ModoForm.Eliminar)
            {
                this.btnAceptar.Text = "Eliminar";
            }

            DocenteCursologic dlog = new DocenteCursologic();
            DictadoActual = dlog.GetOne(ID);

            MapearDeDatos();
        }

        #endregion

        #region Metodos

        public override void MapearADatos()
        {
            if(Modo == ModoForm.Alta)
            {
                DictadoActual = new DocenteCurso();
                DictadoActual.State = BusinessEntity.States.New;
            }

            if(Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo == ModoForm.Modificacion)
                {
                    txtIDdictado.Text = DictadoActual.ID.ToString();
                    DictadoActual.State = BusinessEntity.States.Modified;
                }

                DictadoActual.IdCurso = int.Parse(cbxCursos.Text);
                DictadoActual.Cargo = (DocenteCurso.TiposCargos)cbxCargos.SelectedIndex;
                DictadoActual.IdDocente = int.Parse(lblIDdocente.Text);
            }

            if (Modo == ModoForm.Eliminar)
                DictadoActual.State = BusinessEntity.States.Deleted;

        }

        public override void MapearDeDatos()
        {
            if (Modo != ModoForm.Alta)
                txtIDdictado.Text = DictadoActual.ID.ToString();
            else { txtIDdictado.Text = "-"; }

            cbxCursos.Text = DictadoActual.IdCurso.ToString();
            cbxCargos.Text = DictadoActual.Cargo.ToString();
            PersonaLogic plog = new PersonaLogic();
            Personas p = plog.GetOne(DictadoActual.IdDocente);
            cbxDocentes.Text = p.Apellido + " " + p.Nombre;
            lblIDdocente.Visible = true;
            lblIDdocente.Text = DictadoActual.IdDocente.ToString();
            
        }

        public override void GuardarCambios()
        {
            this.MapearADatos();
            DocenteCursologic dlog = new DocenteCursologic();
            dlog.Save(DictadoActual);
            
        }

        public override bool Validar()
        {
            string msj = "";

            if (cbxDocentes.SelectedIndex == 0)
            {
                msj += "Debe seleccionar un docente \n";
                cbxDocentes.BackColor = Color.Red;
            }
            else { cbxDocentes.BackColor = Color.White; }

            if (cbxCursos.SelectedIndex == 0)
            {
                msj += "Debe seleccionar un curso \n";
                cbxCursos.BackColor = Color.Red;
            }
            else { cbxCursos.BackColor = Color.White; }

            if (cbxCargos.SelectedIndex == 0)
            {
                msj += "Debe seleccionar un cargo \n";
                cbxCargos.BackColor = Color.Red;
            }
            else { cbxCargos.BackColor = Color.White; }

            if (string.IsNullOrEmpty(msj))
                return true;
            else
            {
                Notificar(msj, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        
        public new void Notificar(string titulo, string mensaje, MessageBoxButtons
        botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }

        public new void Notificar(string mensaje, MessageBoxButtons botones,
        MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }

        #endregion

        #region Eventos

        private void DictadoDesktop_Load(object sender, EventArgs e)
        {
            lblIDdocente.Visible = false;

            CursoLogic curLog = new CursoLogic();
            List<Curso> listaCursos = curLog.GetAll();
            cbxCursos.Items.Add("");
            foreach (Curso c in listaCursos)
            {
                cbxCursos.Items.Add(c.ID.ToString());
            }

            PersonaLogic plog = new PersonaLogic();
            List<Personas> listadoPersonas = plog.GetAll();
            cbxDocentes.Items.Add("");
            foreach (Personas p in listadoPersonas)
            {
                if (p.TipoPersona == Personas.TiposPersonas.Docente)
                {
                    cbxDocentes.Items.Add(p.Apellido + " " + p.Nombre);
                }
            }

            cbxCargos.Items.Add("");
            cbxCargos.Items.Add(DocenteCurso.TiposCargos.Titular);
            cbxCargos.Items.Add(DocenteCurso.TiposCargos.Auxiliar);

        }

        private void cbxDocentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonaLogic perlog = new PersonaLogic();
            lblIDdocente.Visible = true;
            lblIDdocente.Text = perlog.TraerDocente(cbxDocentes.Text).ToString();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                this.GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

    }
}
