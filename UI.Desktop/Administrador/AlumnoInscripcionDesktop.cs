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

namespace UI.Desktop.Administrador
{
    public partial class AlumnoInscripcionDesktop : ApplicationForm
    {
        public AlumnoInscripcionDesktop()
        {
            InitializeComponent();
        }
        private AlumnoInscripcion _alumnoInscripcion;
        public AlumnoInscripcion AlumnoInscripcion
        {
            get { return _alumnoInscripcion; }
            set { _alumnoInscripcion = value; }
        }
        public AlumnoInscripcionDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            if ((Modo = ModoForm.Alta) || (Modo = ModoForm.Modificacion))
            { this.btnAceptar.Text = "Guardar"; } else if ( Modo = ModoForm.Modificacion)
            { this.btnAceptar.Text = "Eliminar"; } 
        }
        public AlumnoInscripcionDesktop(int ID,ModoForm modo): this()
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
            AlumnoInscripcionLogic AlLogic = new AlumnoInscripcionLogic();
            AlumnoInscripcion = AlLogic.GetOne(ID);
            MapearDeDatos();

        }
        public void MapearDeDatos()
        {
            txtID.Text = AlumnoInscripcion.ID.ToString();
            txtID_Alumno.Text = AlumnoInscripcion.IdAlumno.ToString();
            txtNota.Text = AlumnoInscripcion.Nota.ToString();
            txtID_Curso.Text = AlumnoInscripcion.IdCurso.ToString();
            txtCondicion.Text = AlumnoInscripcion.Condicion;

                    
        }
        public void MapearADatos()
        { if (Modo = ModoForm.Alta)
            {
                AlumnoInscripcion = new AlumnoInscripcion();
                AlumnoInscripcion.State = Business.Entities.AlumnoInscripcion.States.New;
            }
        if ((Modo = ModoForm.Alta) || (Modo = ModoForm.Modificacion))
            {
                AlumnoInscripcion.ID = txtID.Text;
                AlumnoInscripcion.IdAlumno = txtID_Alumno.Text;
                AlumnoInscripcion.IdCurso = txtID_Curso.Text;
                AlumnoInscripcion.Condicion = txtCondicion.Text;
                AlumnoInscripcion.Nota = txtNota.Text;
            
            
            }
        if (Modo =  ModoForm.Modificacion)
            {
                txtID.Text = AlumnoInscripcion.ID.ToString();
                AlumnoInscripcion.State = Business.Entities.AlumnoInscripcion.States.Modified;
            }
        if (Modo = ModoForm.Eliminar)
            {
                AlumnoInscripcion.State = Business.Entities.AlumnoInscripcion.States.Deleted;
            }


        }
        public void GuardarCambios()
        {
            MapearADatos();
            AlumnoInscripcionLogic AlLogic = new AlumnoInscripcionLogic();
            AlLogic.Save(AlumnoInscripcion);

        }

        private void AlumnoInscripcionDesktop_Load(object sender, EventArgs e)
        {

        }
    }
}
