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
    public partial class formMain : ApplicationForm
    {
        private Personas _personaSesion;

        public Personas PersonaSesion
        {
            get { return _personaSesion; }
            set { _personaSesion = value; }
        }

        public formMain()
        {
            InitializeComponent();
        }

        //Evento que carga el formulario cuando se abre por primera vez, luego no se ejecuta mas.
        //Cargo valores por defecto del formulario.
        private void formMain_Shown(object sender, EventArgs e)
        {
            Program.UsuarioSesion = null;
            btnSesion.Text = "Iniciar sesion";
            lblMensajeSesion.Visible = false;
            menuAdministrador.Visible = false;
            menuAlumnos.Visible = false;
            menuDocentes.Visible = false;
            
        }

        //Evento que se ejecuta cada vez que se carga la pagina
        //Hay que validar siempre si hay un usuario con su sesión iniciada
        private void formMain_Load(object sender, EventArgs e)
        {
            if (Program.UsuarioSesion != null)
            {
                this.AbrirSesion();
            }
            else
            {
                this.CerrarSesion();
            }
        }

        
        #region Manejo de Sesion

        private void AbrirSesion()
        {
            btnSesion.Text = "Cerrar Sesion";
            PersonaLogic pl = new PersonaLogic();
            PersonaSesion = pl.GetOne(Program.UsuarioSesion.ID);
            lblMensajeSesion.Visible = true;
            lblMensajeSesion.Text = PersonaSesion.TipoPersona + ": " + PersonaSesion.Apellido + ", " + PersonaSesion.Nombre;

            if (PersonaSesion.TipoPersona == Personas.TiposPersonas.Administrador)
            {
                menuAdministrador.Visible = true;
                menuAlumnos.Visible = false;
                menuDocentes.Visible = false;
            }
            if (PersonaSesion.TipoPersona == Personas.TiposPersonas.Alumno)
            {
                menuAdministrador.Visible = false;
                menuAlumnos.Visible = true;
                menuDocentes.Visible = false;
            }
            if (PersonaSesion.TipoPersona == Personas.TiposPersonas.Docente)
            {
                menuAdministrador.Visible = false;
                menuAlumnos.Visible = false;
                menuDocentes.Visible = true;
            }

        }

        private void CerrarSesion()
        {
            Program.UsuarioSesion = null;
            btnSesion.Text = "Iniciar sesion";
            lblMensajeSesion.Visible = false;
            menuAdministrador.Visible = false;
            menuAlumnos.Visible = false;
            menuDocentes.Visible = false;

        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            if (Program.UsuarioSesion != null)
            {
                this.CerrarSesion();
            }
            else
            {
                formLogin appLoguin = new formLogin();
                if (appLoguin.ShowDialog() == DialogResult.OK && Program.UsuarioSesion != null)
                {
                    this.AbrirSesion();
                    appLoguin.Close();
                }
            }
        }

        #endregion

        #region Controles Administrador

        private void tsc_Admin_Usuarios_Click(object sender, EventArgs e)
        {
            Usuarios grillaUs = new Usuarios();
            grillaUs.ShowDialog();
            grillaUs.Listar();
        }

        private void tsc_Admin_Personas_Click(object sender, EventArgs e)
        {
            GrillaPersonas grillaPers = new GrillaPersonas();
            grillaPers.Show();
            grillaPers.Listar();
        }

        private void tsc_Admin_Epecialidades_Click(object sender, EventArgs e)
        {
            GrillaEspecialidades grillaEspe = new GrillaEspecialidades();
            grillaEspe.Show();
            grillaEspe.Listar();
        }

        private void tsc_Admin_Docentes_Click(object sender, EventArgs e)
        {

        }

        private void tsc_Admin_Materias_Click(object sender, EventArgs e)
        {
            GrillaMaterias grillaMat = new GrillaMaterias();
            grillaMat.Show();
            grillaMat.Listar();
        }

        private void tsc_Admin_Cursos_Click(object sender, EventArgs e)
        {
            GrillaCursos grillaCurs = new GrillaCursos();
            grillaCurs.Show();
            grillaCurs.Listar();
        }

        private void tsc_Admin_Planes_Click(object sender, EventArgs e)
        {
            GrillaPlanes grillaPlan = new GrillaPlanes();
            grillaPlan.Show();
            grillaPlan.Listar();
        }
        
        private void tsc_Admin_Comisiones_Click(object sender, EventArgs e)
        {
            GrillaComisiones grillaComi = new GrillaComisiones();
            grillaComi.Show();
            grillaComi.Listar();
        }

        private void tsc_Admin_AluInscp_Click(object sender, EventArgs e)
        {
            GrillaInscripciones grillaInscp = new GrillaInscripciones();
            grillaInscp.Show();
            grillaInscp.Listar();

        }
        private void mnuSalir_Admin_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #endregion

        #region Controles Alumno

        private void tsc_Alumno_EstadoAcad_Click(object sender, EventArgs e)
        {
            frmGrillaEstadoAcademico estAcad = new frmGrillaEstadoAcademico();
            estAcad.Show();
            estAcad.Listar();
        }

        private void tsc_Alumno_InscCursado_Click(object sender, EventArgs e)
        {
            frmInscripcion_Curso formInscripcion = new frmInscripcion_Curso();
            formInscripcion.Show();
            formInscripcion.Listar();
        }

        private void tsc_Alumno_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #endregion

        #region Controles Docente

        private void tsc_Docente_Dictado_Click(object sender, EventArgs e)
        {
            GrillaDictados grillaDict = new GrillaDictados();
            grillaDict.Show();
            grillaDict.Listar();
        }
        private void tsc_Docente_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }





        #endregion

        private void reporteCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteCursos Rep = new ReporteCursos();
            Rep.ShowDialog();
        }

        private void reportePlanesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportePlanes rep = new ReportePlanes();
            rep.ShowDialog();
        }

        private void tsc_Alumno_MateriasPlan_Click(object sender, EventArgs e)
        {

        }
    }
}
