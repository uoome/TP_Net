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
    public partial class MateriaDesktop : ApplicationForm
    {
        private Materia _materiaActual;

        public Materia MateriaActual
        {
            get { return _materiaActual; }
            set { _materiaActual = value; }
        }

        #region Constructores
        public MateriaDesktop()
        {
            InitializeComponent();
        }

        public MateriaDesktop(ModoForm modo):this()
        {
            Modo = modo;

            if (Modo == ModoForm.Alta || Modo==ModoForm.Modificacion)
            {
                this.btnAceptar.Text = "Guardar";
            }
            if(Modo== ModoForm.Eliminar)
            {
                this.btnAceptar.Text = "Eliminar";
            }
        }

        public MateriaDesktop(int ID, ModoForm modo):this()
        {
            Modo = modo;

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                btnAceptar.Text = "Guardar";
            }
            if (Modo == ModoForm.Eliminar)
            {
                this.btnAceptar.Text = "Eliminar";
            }

            MateriaLogic matLog = new MateriaLogic();
            MateriaActual = matLog.GetOne(ID);
            MapearDeDatos();
        }
        #endregion

        #region Metodos
        public override void MapearDeDatos()
        {
            txbId_Materia.Text = MateriaActual.ID.ToString();
            txbDescripcion.Text = MateriaActual.Descripcion;
            txbHSSemanales.Text = MateriaActual.HSSemanales.ToString();
            txbHSTotales.Text = MateriaActual.HSTotales.ToString();
            txbId_Plan.Text = MateriaActual.IDplan.ToString();

        }
        public override void MapearADatos()
        {
            if(Modo== ModoForm.Alta)
            {
                MateriaActual = new Materia();
                MateriaActual.State = BusinessEntity.States.New;

            }
            if(Modo==ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                MateriaActual.Descripcion = txbDescripcion.Text;
                MateriaActual.HSSemanales = Convert.ToInt32(txbHSSemanales.Text.Trim());
                MateriaActual.HSTotales = Convert.ToInt32(txbHSTotales.Text.Trim());
                MateriaActual.IDplan = Convert.ToInt32(txbId_Plan.Text.Trim());
            }

            //Siendo Alta no tiene ID inicial, por eso 
            if (Modo == ModoForm.Modificacion)
            {
                txbId_Materia.Text = MateriaActual.ID.ToString();
                MateriaActual.State = Usuario.States.Modified;
            }

            if (Modo == ModoForm.Eliminar)
            {
                MateriaActual.State = BusinessEntity.States.Deleted;
            }

        }
        public override void GuardarCambios()
        {
            this.MapearADatos();
            MateriaLogic matLog = new MateriaLogic();
            matLog.Save(MateriaActual);
        }
        public override bool Validar()
        {
            string msj = "";

            if (txbDescripcion.Text.Trim().Equals(""))
                msj += "La descripcion no puede estar vacía \n";
            if (txbHSSemanales.Text.Trim().Equals(""))
                msj += "Las horas semanales no pueden estar vacías \n";
            if (txbHSTotales.Text.Trim().Equals(""))
                msj += "Las horas totales no pueden estar vacías \n";
            //Validar combo-box

            if (string.IsNullOrEmpty(msj))
            {
                return true;
            }
            else
            {
                this.Notificar(msj, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public new void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        public new void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }

        #endregion

        #region Eventos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                this.GuardarCambios();
                this.Close();
            }
        }

        #endregion
    }
}
