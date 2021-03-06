﻿namespace UI.Desktop
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnsPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuAdministrador = new System.Windows.Forms.ToolStripMenuItem();
            this.tsc_Admin_Personas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsc_Admin_Epecialidades = new System.Windows.Forms.ToolStripMenuItem();
            this.tsc_Admin_Materias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsc_Admin_Cursos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsc_Admin_Planes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsc_Admin_Comisiones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsc_Admin_AluInscp = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportePlanesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsc_Admin_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsc_Alumno_EstadoAcad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsc_Alumno_MateriasPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsc_Alumno_InscCursado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsc_Alumno_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDocentes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsc_Docente_Dictado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsc_Docente_ActNotas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsc_Docente_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMensajeSesion = new System.Windows.Forms.Label();
            this.btnSesion = new System.Windows.Forms.Button();
            this.mnsPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsPrincipal
            // 
            this.mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdministrador,
            this.menuAlumnos,
            this.menuDocentes});
            this.mnsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsPrincipal.Name = "mnsPrincipal";
            this.mnsPrincipal.Size = new System.Drawing.Size(284, 24);
            this.mnsPrincipal.TabIndex = 1;
            this.mnsPrincipal.Text = "menuStrip1";
            // 
            // menuAdministrador
            // 
            this.menuAdministrador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsc_Admin_Personas,
            this.tsc_Admin_Epecialidades,
            this.tsc_Admin_Materias,
            this.tsc_Admin_Cursos,
            this.tsc_Admin_Planes,
            this.tsc_Admin_Comisiones,
            this.tsc_Admin_AluInscp,
            this.reportesToolStripMenuItem,
            this.tsc_Admin_Salir});
            this.menuAdministrador.Name = "menuAdministrador";
            this.menuAdministrador.Size = new System.Drawing.Size(50, 20);
            this.menuAdministrador.Text = "Menu";
            // 
            // tsc_Admin_Personas
            // 
            this.tsc_Admin_Personas.Name = "tsc_Admin_Personas";
            this.tsc_Admin_Personas.Size = new System.Drawing.Size(191, 22);
            this.tsc_Admin_Personas.Text = "Personas";
            this.tsc_Admin_Personas.Click += new System.EventHandler(this.tsc_Admin_Personas_Click);
            // 
            // tsc_Admin_Epecialidades
            // 
            this.tsc_Admin_Epecialidades.Name = "tsc_Admin_Epecialidades";
            this.tsc_Admin_Epecialidades.Size = new System.Drawing.Size(191, 22);
            this.tsc_Admin_Epecialidades.Text = "Especialidades";
            this.tsc_Admin_Epecialidades.Click += new System.EventHandler(this.tsc_Admin_Epecialidades_Click);
            // 
            // tsc_Admin_Materias
            // 
            this.tsc_Admin_Materias.Name = "tsc_Admin_Materias";
            this.tsc_Admin_Materias.Size = new System.Drawing.Size(191, 22);
            this.tsc_Admin_Materias.Text = "Materias";
            this.tsc_Admin_Materias.Click += new System.EventHandler(this.tsc_Admin_Materias_Click);
            // 
            // tsc_Admin_Cursos
            // 
            this.tsc_Admin_Cursos.Name = "tsc_Admin_Cursos";
            this.tsc_Admin_Cursos.Size = new System.Drawing.Size(191, 22);
            this.tsc_Admin_Cursos.Text = "Cursos";
            this.tsc_Admin_Cursos.Click += new System.EventHandler(this.tsc_Admin_Cursos_Click);
            // 
            // tsc_Admin_Planes
            // 
            this.tsc_Admin_Planes.Name = "tsc_Admin_Planes";
            this.tsc_Admin_Planes.Size = new System.Drawing.Size(191, 22);
            this.tsc_Admin_Planes.Text = "Planes";
            this.tsc_Admin_Planes.Click += new System.EventHandler(this.tsc_Admin_Planes_Click);
            // 
            // tsc_Admin_Comisiones
            // 
            this.tsc_Admin_Comisiones.Name = "tsc_Admin_Comisiones";
            this.tsc_Admin_Comisiones.Size = new System.Drawing.Size(191, 22);
            this.tsc_Admin_Comisiones.Text = "Comisiones";
            this.tsc_Admin_Comisiones.Click += new System.EventHandler(this.tsc_Admin_Comisiones_Click);
            // 
            // tsc_Admin_AluInscp
            // 
            this.tsc_Admin_AluInscp.Name = "tsc_Admin_AluInscp";
            this.tsc_Admin_AluInscp.Size = new System.Drawing.Size(191, 22);
            this.tsc_Admin_AluInscp.Text = "Alumno_Inscripciones";
            this.tsc_Admin_AluInscp.Click += new System.EventHandler(this.tsc_Admin_AluInscp_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteCursosToolStripMenuItem,
            this.reportePlanesToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteCursosToolStripMenuItem
            // 
            this.reporteCursosToolStripMenuItem.Name = "reporteCursosToolStripMenuItem";
            this.reporteCursosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reporteCursosToolStripMenuItem.Text = "Reporte cursos";
            this.reporteCursosToolStripMenuItem.Click += new System.EventHandler(this.reporteCursosToolStripMenuItem_Click);
            // 
            // reportePlanesToolStripMenuItem
            // 
            this.reportePlanesToolStripMenuItem.Name = "reportePlanesToolStripMenuItem";
            this.reportePlanesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reportePlanesToolStripMenuItem.Text = "Reporte planes";
            this.reportePlanesToolStripMenuItem.Click += new System.EventHandler(this.reportePlanesToolStripMenuItem_Click);
            // 
            // tsc_Admin_Salir
            // 
            this.tsc_Admin_Salir.Name = "tsc_Admin_Salir";
            this.tsc_Admin_Salir.Size = new System.Drawing.Size(191, 22);
            this.tsc_Admin_Salir.Text = "Salir";
            this.tsc_Admin_Salir.Click += new System.EventHandler(this.mnuSalir_Admin_Click);
            // 
            // menuAlumnos
            // 
            this.menuAlumnos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsc_Alumno_EstadoAcad,
            this.tsc_Alumno_MateriasPlan,
            this.tsc_Alumno_InscCursado,
            this.tsc_Alumno_Salir});
            this.menuAlumnos.Name = "menuAlumnos";
            this.menuAlumnos.Size = new System.Drawing.Size(50, 20);
            this.menuAlumnos.Text = "Menu";
            // 
            // tsc_Alumno_EstadoAcad
            // 
            this.tsc_Alumno_EstadoAcad.Name = "tsc_Alumno_EstadoAcad";
            this.tsc_Alumno_EstadoAcad.Size = new System.Drawing.Size(183, 22);
            this.tsc_Alumno_EstadoAcad.Text = "Estado Académico";
            this.tsc_Alumno_EstadoAcad.Click += new System.EventHandler(this.tsc_Alumno_EstadoAcad_Click);
            // 
            // tsc_Alumno_MateriasPlan
            // 
            this.tsc_Alumno_MateriasPlan.Name = "tsc_Alumno_MateriasPlan";
            this.tsc_Alumno_MateriasPlan.Size = new System.Drawing.Size(183, 22);
            this.tsc_Alumno_MateriasPlan.Text = "Materias del Plan";
            this.tsc_Alumno_MateriasPlan.Click += new System.EventHandler(this.tsc_Alumno_MateriasPlan_Click);
            // 
            // tsc_Alumno_InscCursado
            // 
            this.tsc_Alumno_InscCursado.Name = "tsc_Alumno_InscCursado";
            this.tsc_Alumno_InscCursado.Size = new System.Drawing.Size(183, 22);
            this.tsc_Alumno_InscCursado.Text = "Inscribirse a Cursado";
            this.tsc_Alumno_InscCursado.Click += new System.EventHandler(this.tsc_Alumno_InscCursado_Click);
            // 
            // tsc_Alumno_Salir
            // 
            this.tsc_Alumno_Salir.Name = "tsc_Alumno_Salir";
            this.tsc_Alumno_Salir.Size = new System.Drawing.Size(183, 22);
            this.tsc_Alumno_Salir.Text = "Salir";
            this.tsc_Alumno_Salir.Click += new System.EventHandler(this.tsc_Alumno_Salir_Click);
            // 
            // menuDocentes
            // 
            this.menuDocentes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsc_Docente_Dictado,
            this.tsc_Docente_ActNotas,
            this.tsc_Docente_Salir});
            this.menuDocentes.Name = "menuDocentes";
            this.menuDocentes.Size = new System.Drawing.Size(50, 20);
            this.menuDocentes.Text = "Menu";
            // 
            // tsc_Docente_Dictado
            // 
            this.tsc_Docente_Dictado.Name = "tsc_Docente_Dictado";
            this.tsc_Docente_Dictado.Size = new System.Drawing.Size(160, 22);
            this.tsc_Docente_Dictado.Text = "Dictados";
            this.tsc_Docente_Dictado.Click += new System.EventHandler(this.tsc_Docente_Dictado_Click);
            // 
            // tsc_Docente_ActNotas
            // 
            this.tsc_Docente_ActNotas.Name = "tsc_Docente_ActNotas";
            this.tsc_Docente_ActNotas.Size = new System.Drawing.Size(160, 22);
            this.tsc_Docente_ActNotas.Text = "Actualizar Notas";
            // 
            // tsc_Docente_Salir
            // 
            this.tsc_Docente_Salir.Name = "tsc_Docente_Salir";
            this.tsc_Docente_Salir.Size = new System.Drawing.Size(160, 22);
            this.tsc_Docente_Salir.Text = "Salir";
            this.tsc_Docente_Salir.Click += new System.EventHandler(this.tsc_Docente_Salir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMensajeSesion);
            this.panel1.Controls.Add(this.btnSesion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 237);
            this.panel1.TabIndex = 3;
            // 
            // lblMensajeSesion
            // 
            this.lblMensajeSesion.AutoSize = true;
            this.lblMensajeSesion.Location = new System.Drawing.Point(13, 3);
            this.lblMensajeSesion.Name = "lblMensajeSesion";
            this.lblMensajeSesion.Size = new System.Drawing.Size(65, 13);
            this.lblMensajeSesion.TabIndex = 1;
            this.lblMensajeSesion.Text = "Inicie sesión";
            // 
            // btnSesion
            // 
            this.btnSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSesion.Location = new System.Drawing.Point(150, 3);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(131, 23);
            this.btnSesion.TabIndex = 0;
            this.btnSesion.Text = "Sesion";
            this.btnSesion.UseVisualStyleBackColor = true;
            this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnsPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsPrincipal;
            this.Name = "formMain";
            this.Text = "Academia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formMain_Load);
            this.Shown += new System.EventHandler(this.formMain_Shown);
            this.mnsPrincipal.ResumeLayout(false);
            this.mnsPrincipal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuAdministrador;
        private System.Windows.Forms.ToolStripMenuItem tsc_Admin_Salir;
        private System.Windows.Forms.ToolStripMenuItem tsc_Admin_Cursos;
        private System.Windows.Forms.ToolStripMenuItem tsc_Admin_Materias;
        private System.Windows.Forms.ToolStripMenuItem tsc_Admin_Planes;
        private System.Windows.Forms.ToolStripMenuItem tsc_Admin_Comisiones;
        private System.Windows.Forms.ToolStripMenuItem tsc_Admin_Epecialidades;
        private System.Windows.Forms.ToolStripMenuItem tsc_Admin_Personas;
        private System.Windows.Forms.ToolStripMenuItem menuAlumnos;
        private System.Windows.Forms.ToolStripMenuItem menuDocentes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMensajeSesion;
        private System.Windows.Forms.Button btnSesion;
        private System.Windows.Forms.ToolStripMenuItem tsc_Alumno_Salir;
        private System.Windows.Forms.ToolStripMenuItem tsc_Docente_Salir;
        private System.Windows.Forms.ToolStripMenuItem tsc_Alumno_EstadoAcad;
        private System.Windows.Forms.ToolStripMenuItem tsc_Alumno_MateriasPlan;
        private System.Windows.Forms.ToolStripMenuItem tsc_Alumno_InscCursado;
        private System.Windows.Forms.ToolStripMenuItem tsc_Docente_Dictado;
        private System.Windows.Forms.ToolStripMenuItem tsc_Docente_ActNotas;
        private System.Windows.Forms.ToolStripMenuItem tsc_Admin_AluInscp;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportePlanesToolStripMenuItem;
    }
}