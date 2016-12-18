using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
using Business.Entities;

namespace UI.Web
{
    public partial class Especialidades : ABM
    {
        private EspecialidadLogic _espLog;
        public EspecialidadLogic EspLog
        {
            get { if (_espLog == null)
                { _espLog = new EspecialidadLogic(); }
                return _espLog;
            }

        }
        public Especialidad Entity
        {
            set;
            get;
        }

        #region Metodos
        private void LoadGrid()
        {
            this.grvEspecialidades.DataSource = EspLog.GetAll();
            this.grvEspecialidades.DataBind();
        }
        private void ClearForm()
        {
            this.txtDescripcion.Text = string.Empty;
        }
        private void LoadForm(int id)
        {
            this.Entity = EspLog.GetOne(id);
            this.txtDescripcion.Text = Entity.Descripcion;
        }
        private void EnabledForm(bool enable)
        {
            this.txtDescripcion.Enabled = enable;
        }
        
        private void DeleteEntity(int id)
        {
            EspLog.Delete(id);
        }
        private void LoadEntity(Especialidad esp)
        {
            esp.Descripcion = this.txtDescripcion.Text;
        }
        private void SaveEntity(Especialidad esp)
        {
            EspLog.Save(esp);
        }


        #endregion
        #region Eventos

        protected override void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string si = "menuEspecialidades";
                Session["Menu"] = si;
                this.LoadGrid();
            }
        }





        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Especialidades.aspx");
            panelControles.Visible = false;
            panelConformacion.Visible = false;
        }

        protected void grvEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.grvEspecialidades.SelectedValue;
            panelConformacion.Visible = false;
            panelControles.Visible = false;
        }

        protected void linkbtnEditar_Click(object sender, EventArgs e)
        {
            if (IsEntitySelected)
            {
                EnabledForm(true);
                panelConformacion.Visible = true;
                panelControles.Visible = true;
                LoadForm(SelectedID);
                FormMode = ABM.FormModes.Modificacion;
            }
        }

        protected void linkbtnEliminar_Click(object sender, EventArgs e)
        {
            if (IsEntitySelected)
            {
                panelConformacion.Visible = true;
                panelControles.Visible = true;
                EnabledForm(false);
                this.LoadForm(SelectedID);
                FormMode = ABM.FormModes.Baja;
            }
        }

        protected void linkbtnNuevo_Click(object sender, EventArgs e)
        {
            ClearForm();
            panelConformacion.Visible = true;
            panelControles.Visible = true;
            FormMode = FormModes.Alta;
            EnabledForm(true);

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {

                case FormModes.Alta:

                    Entity = new Especialidad();
                    this.Entity.State = BusinessEntity.States.New;
                    this.LoadEntity(Entity);
                    this.SaveEntity(Entity);
                    this.LoadGrid();

                    break;

                case FormModes.Modificacion:

                    Entity = new Especialidad();
                    Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(Entity);
                    this.SaveEntity(Entity);
                    this.LoadGrid();
                    break;

                case FormModes.Baja:

                    this.DeleteEntity(this.SelectedID);
                    this.LoadGrid();
                    break;

                default:
                    break;

            }
            panelControles.Visible = false;
            panelConformacion.Visible = false;



        }











        #endregion


    }
}