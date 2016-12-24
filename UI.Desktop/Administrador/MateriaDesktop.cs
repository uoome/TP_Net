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
        private List<Plan> listaPlanes;
        private List<Especialidad> listaEspecialidades;

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

            if (Modo == ModoForm.Alta)
            {
                this.btnAceptar.Text = "Guardar";
                MateriaLogic mlog = new MateriaLogic();
                txtID_Materia.Text = mlog.TraerSiguienteID().ToString();
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
            if(Modo!=ModoForm.Alta)
                txtID_Materia.Text = MateriaActual.ID.ToString();

            txbDescripcion.Text = MateriaActual.Descripcion;
            txbHSSemanales.Text = MateriaActual.HSSemanales.ToString();
            txbHSTotales.Text = MateriaActual.HSTotales.ToString();
            txtAnio.Text = MateriaActual.Anio.ToString();

            PlanLogic plog = new PlanLogic();
            Plan p = plog.GetOne(MateriaActual.IDplan);
            cbxPlanes.Text = p.Descripcion;
            cbxEspecialidades.Text = new EspecialidadLogic().GetOne(p.IDEspecialidad).Descripcion;

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
                if (Modo == ModoForm.Modificacion)
                    MateriaActual.State = BusinessEntity.States.Modified;

                MateriaActual.Descripcion = txbDescripcion.Text;
                MateriaActual.HSSemanales = Convert.ToInt32(txbHSSemanales.Text.Trim());
                MateriaActual.HSTotales = Convert.ToInt32(txbHSTotales.Text.Trim());
                MateriaActual.Anio = Convert.ToInt32(txtAnio.Text.Trim());
                MateriaActual.IDplan= new PlanLogic().GetOne(cbxEspecialidades.Text, cbxPlanes.Text).ID;
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
            {
                msj += "La descripcion no puede estar vacía \n";
                txbDescripcion.BackColor = Color.Red;
            }
            else { txbDescripcion.BackColor = Color.White; }

            if (txbHSSemanales.Text.Trim().Equals(""))
            {
                msj += "Las horas semanales no pueden estar vacías \n";
                txbHSSemanales.BackColor = Color.Red;
            }
            else { txbHSSemanales.BackColor = Color.White; }

            if (txbHSTotales.Text.Trim().Equals(""))
            {
                msj += "Las horas totales no pueden estar vacías \n";
                txbHSTotales.BackColor = Color.Red;
            }
            else{ txbHSTotales.BackColor = Color.White; }

            if (txtAnio.Text.Trim().Equals(""))
            {
                msj += "El año no puede estar vacías \n";
                txtAnio.BackColor = Color.Red;
            }
            else { txtAnio.BackColor = Color.White; }

            if (cbxPlanes.SelectedIndex == 0)
            {
                msj += "Debe seleccionar un plan de la lista \n";
                cbxPlanes.BackColor = Color.Red;
            }
            else { cbxPlanes.BackColor = Color.White; }

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

        private void MateriaDesktop_Load(object sender, EventArgs e)
        {
            PlanLogic plog = new PlanLogic();
            listaPlanes = plog.GetAll();

            EspecialidadLogic elog = new EspecialidadLogic();
            listaEspecialidades = elog.GetAll();

            cbxEspecialidades.Items.Add("");
            foreach (Especialidad esp in listaEspecialidades)
            {
                cbxEspecialidades.Items.Add(esp.Descripcion);
            }
        }

        private void cbxEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxPlanes.Items.Clear();
            cbxPlanes.Items.Add("");
            if (cbxEspecialidades.SelectedIndex > 0) //Si hay una especialidad del combo elegida
            {
                foreach (Plan p in listaPlanes)
                {
                    if (p.IDEspecialidad == cbxEspecialidades.SelectedIndex)
                        cbxPlanes.Items.Add(p.Descripcion);
                }
                cbxPlanes.SelectedIndex = 0;
            }
        }

        #endregion


    }
}
