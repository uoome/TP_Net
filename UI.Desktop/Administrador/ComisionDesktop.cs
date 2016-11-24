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
    public partial class ComisionDesktop : ApplicationForm
    {
        public ComisionDesktop()
        {
            InitializeComponent();
        }
        private Comision _comActual;
        public Comision ComActual
        {
            set { _comActual = value; }
            get { return _comActual; }
        }
        public ComisionDesktop(ModoForm modo):this()
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

        public ComisionDesktop(int ID, ModoForm modo):this()
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

           ComisionLogic ComLog = new ComisionLogic();
            ComActual = ComLog.GetOne(ID);
            MapearDeDatos();
        }

        #region Metodos

        public override void MapearDeDatos()
        {
            PlanLogic pl = new PlanLogic();
            Plan PlanEntity = new Plan();
            PlanEntity = pl.GetOne(int.Parse(comboIDPLAN.Text)); 
            txtIDComi.Text = ComActual.ID.ToString();
          
            txtDescripcion.Text = ComActual.Descripcion;
           txtAnioEsp.Text = ComActual.AnioEspecialidad.ToString();
            txtDescPlan.Text = PlanEntity.Descripcion;
      

        }
        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
               ComActual = new Comision();
               ComActual.State = BusinessEntity.States.New;

            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo == ModoForm.Modificacion)
                {
                    txtIDComi.Text = ComActual.ID.ToString();
                    ComActual.State = BusinessEntity.States.Modified;
                }
         

                ComActual.Descripcion = txtDescripcion.Text;
                ComActual.AnioEspecialidad = int.Parse(txtAnioEsp.Text);
                ComActual.IdPlan = int.Parse(comboIDPLAN.Text);
               
                
              
            }

            //Siendo Alta no tiene ID inicial, por eso 
        

            if (Modo == ModoForm.Eliminar)
            {
                ComActual.State = BusinessEntity.States.Deleted;
            }

        }
        public override void GuardarCambios()
        {
            this.MapearADatos();
           ComisionLogic comLog = new ComisionLogic();
           comLog.Save(ComActual);
        }



        #endregion
        #region eventos

        private void ComisionDesktop_Load(object sender, EventArgs e)
        {
            PlanLogic plog = new PlanLogic();
            List<Plan> listaPlanes = new List<Plan>();
            listaPlanes = plog.GetAll();
            //Carglo lista de especialidades


            comboIDPLAN.Items.Add("");

            foreach (Plan pl in listaPlanes)
            {
                comboIDPLAN.Items.Add(pl.ID);
            }

        }



        #endregion region

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
            this.Close();
        }

        private void comboIDPLAN_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* PlanLogic pl = new PlanLogic();
            Plan PlanEntity = new Plan();
            PlanEntity = pl.GetOne(int.Parse(comboIDPLAN.Text));
            txtDescPlan.Text = PlanEntity.ID.ToString(); */
        }
    }
}
