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
    public partial class CursoDesktop : ApplicationForm
    {
        private Curso _cursoActual;
        
        public Curso CursoActual
        {
            get { return _cursoActual; }
            set { _cursoActual = value; }
        }

        #region Constructores
        public CursoDesktop()
        {
            InitializeComponent();
        }

        public CursoDesktop(ModoForm modo) : this()
        {
            Modo = modo;

            if (Modo == ApplicationForm.ModoForm.Alta || Modo==ModoForm.Modificacion)
            {
                btnAceptar.Text = "Guardar";
            }
            if (Modo == ModoForm.Eliminar)
            {
                btnAceptar.Text = "Eliminar";
            }

        }

        public CursoDesktop(int ID,ModoForm modo) : this()
        {
            Modo = modo;

            if(Modo==ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                btnAceptar.Text = "Guardar";
            }
            if (Modo == ModoForm.Eliminar)
            {
                btnAceptar.Text = "Eliminar";
            }

            CursoLogic cursoLog = new CursoLogic();
            CursoActual = cursoLog.GetOne(ID);
            this.MapearDeDatos();
        }

        #endregion

        #region Metodos
        public override void MapearDeDatos()
        {
            txbID_Curso.Text = CursoActual.ID.ToString();
            txbAnioCalendario.Text = CursoActual.AnioCalendario.ToString();
            txbCupo.Text = CursoActual.Cupo.ToString();
            txtCuposDis.Text = CursoActual.CupoDis.ToString();

            MateriaLogic ml = new MateriaLogic();
            Materia m = ml.GetOne(CursoActual.IDMateria);
            cbxMaterias.Text = m.Descripcion;
            
            ComisionLogic cl = new ComisionLogic();
            Comision c = cl.GetOne(CursoActual.IDComision);
            cbxComisiones.Text = c.Descripcion;
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                CursoActual = new Curso();
                CursoActual.State = BusinessEntity.States.New;
            }
            //Si es alta no tiene ID incial, por eso validamos
            if (Modo != ModoForm.Alta)
            {
                CursoActual.ID = int.Parse(txbID_Curso.Text.Trim());
                CursoActual.State = BusinessEntity.States.Modified;
            }
            if (Modo==ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                CursoActual.Cupo = int.Parse(txbCupo.Text.Trim());
                CursoActual.CupoDis = int.Parse(txtCuposDis.Text);
                CursoActual.AnioCalendario = int.Parse(txbAnioCalendario.Text.Trim());
                CursoActual.IDMateria = new MateriaLogic().GetOne(cbxMaterias.Text).ID;
                CursoActual.IDComision = new ComisionLogic().GetOne(cbxComisiones.Text).ID;
            }
            if (Modo == ModoForm.Eliminar)
            {
                CursoActual.State = BusinessEntity.States.Deleted;
            }
        }

        public override void GuardarCambios()
        {
            this.MapearADatos();
            CursoLogic cursLog = new CursoLogic();
            cursLog.Save(CursoActual);
        }

        public override bool Validar()
        {
            string msj = "";

            if (txbCupo.Text.Trim().Equals(""))
            {
                msj += "El cupo no puede estar vacío \n";
                txbCupo.BackColor = Color.Red;
            }
            else { txbCupo.BackColor = Color.White; }
                
            if (txbAnioCalendario.Text.Trim().Equals(""))
            {
                msj += "El año no puede estar vacío \n";
                txbAnioCalendario.BackColor = Color.Red;
            }
            else { txbAnioCalendario.BackColor = Color.White; }
                
            if (cbxComisiones.SelectedIndex == 0)
            {
                msj += "Debe seleccionar una comisión \n";
                cbxComisiones.BackColor = Color.Red;
            }
            else { cbxComisiones.BackColor = Color.White; }
                
            if (cbxMaterias.SelectedIndex==0)
            {
                msj += "Debe seleccionar una materia \n";
                cbxMaterias.BackColor = Color.Red;
            }
            else { cbxMaterias.BackColor = Color.White; }

            if (msj.Trim().Equals(""))
                return true;
            else
            {
                this.Notificar("Datos incorrectos", msj, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private List<Materia> listaMaterias;
        private List<Comision> listaComisiones;

        private void CursoDesktop_Load(object sender, EventArgs e)
        {
            //Cargo combo de materias
            MateriaLogic ml = new MateriaLogic();
            listaMaterias= ml.GetAll();

            cbxMaterias.Items.Add("");
            foreach(Materia m in listaMaterias)
            {
                cbxMaterias.Items.Add(m.Descripcion);
            }

            //Cargo combo de comisiones
            ComisionLogic cl = new ComisionLogic();
            listaComisiones = cl.GetAll();

            cbxComisiones.Items.Add("");
            foreach(Comision c in listaComisiones)
            {
                cbxComisiones.Items.Add(c.Descripcion);
            }
              
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
