﻿namespace UI.Desktop.ABM
{
    partial class GrillaCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrillaCursos));
            this.tscGrillaCursos = new System.Windows.Forms.ToolStripContainer();
            this.tsCursos = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tlpGrillaCursos = new System.Windows.Forms.TableLayoutPanel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.Id_Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anio_Calendario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tscGrillaCursos.ContentPanel.SuspendLayout();
            this.tscGrillaCursos.TopToolStripPanel.SuspendLayout();
            this.tscGrillaCursos.SuspendLayout();
            this.tsCursos.SuspendLayout();
            this.tlpGrillaCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // tscGrillaCursos
            // 
            // 
            // tscGrillaCursos.cpGrillaCursos
            // 
            this.tscGrillaCursos.ContentPanel.Controls.Add(this.tlpGrillaCursos);
            this.tscGrillaCursos.ContentPanel.Size = new System.Drawing.Size(650, 236);
            this.tscGrillaCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscGrillaCursos.Location = new System.Drawing.Point(0, 0);
            this.tscGrillaCursos.Name = "tscGrillaCursos";
            this.tscGrillaCursos.Size = new System.Drawing.Size(650, 261);
            this.tscGrillaCursos.TabIndex = 0;
            this.tscGrillaCursos.Text = "toolStripContainer1";
            // 
            // tscGrillaCursos.TopToolStripPanel
            // 
            this.tscGrillaCursos.TopToolStripPanel.Controls.Add(this.tsCursos);
            // 
            // tsCursos
            // 
            this.tsCursos.Dock = System.Windows.Forms.DockStyle.None;
            this.tsCursos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsCursos.Location = new System.Drawing.Point(3, 0);
            this.tsCursos.Name = "tsCursos";
            this.tsCursos.Size = new System.Drawing.Size(81, 25);
            this.tsCursos.TabIndex = 0;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "Nuevo";
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "Editar";
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "Eliminar";
            // 
            // tlpGrillaCursos
            // 
            this.tlpGrillaCursos.ColumnCount = 2;
            this.tlpGrillaCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGrillaCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpGrillaCursos.Controls.Add(this.btnActualizar, 0, 1);
            this.tlpGrillaCursos.Controls.Add(this.btnSalir, 1, 1);
            this.tlpGrillaCursos.Controls.Add(this.dgvCursos, 0, 0);
            this.tlpGrillaCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGrillaCursos.Location = new System.Drawing.Point(0, 0);
            this.tlpGrillaCursos.Name = "tlpGrillaCursos";
            this.tlpGrillaCursos.RowCount = 2;
            this.tlpGrillaCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGrillaCursos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGrillaCursos.Size = new System.Drawing.Size(650, 236);
            this.tlpGrillaCursos.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(491, 210);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(572, 210);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // dgvCursos
            // 
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Curso,
            this.Descripcion_Curso,
            this.ID_Comision,
            this.Id_Materia,
            this.Cupo,
            this.Anio_Calendario});
            this.tlpGrillaCursos.SetColumnSpan(this.dgvCursos, 2);
            this.dgvCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCursos.Location = new System.Drawing.Point(3, 3);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.Size = new System.Drawing.Size(644, 201);
            this.dgvCursos.TabIndex = 2;
            // 
            // Id_Curso
            // 
            this.Id_Curso.DataPropertyName = "ID";
            this.Id_Curso.HeaderText = "ID Curso";
            this.Id_Curso.Name = "Id_Curso";
            // 
            // Descripcion_Curso
            // 
            this.Descripcion_Curso.DataPropertyName = "Descripcion";
            this.Descripcion_Curso.HeaderText = "Descripcion";
            this.Descripcion_Curso.Name = "Descripcion_Curso";
            // 
            // ID_Comision
            // 
            this.ID_Comision.DataPropertyName = "IDComision";
            this.ID_Comision.HeaderText = "ID Comision";
            this.ID_Comision.Name = "ID_Comision";
            // 
            // Id_Materia
            // 
            this.Id_Materia.DataPropertyName = "IDMateria";
            this.Id_Materia.HeaderText = "ID Materia";
            this.Id_Materia.Name = "Id_Materia";
            // 
            // Cupo
            // 
            this.Cupo.DataPropertyName = "Cupo";
            this.Cupo.HeaderText = "Cupo";
            this.Cupo.Name = "Cupo";
            // 
            // Anio_Calendario
            // 
            this.Anio_Calendario.DataPropertyName = "AnioCalendario";
            this.Anio_Calendario.HeaderText = "Año Calendario";
            this.Anio_Calendario.Name = "Anio_Calendario";
            // 
            // GrillaCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 261);
            this.Controls.Add(this.tscGrillaCursos);
            this.Name = "GrillaCursos";
            this.Text = "GrillaCursos";
            this.tscGrillaCursos.ContentPanel.ResumeLayout(false);
            this.tscGrillaCursos.TopToolStripPanel.ResumeLayout(false);
            this.tscGrillaCursos.TopToolStripPanel.PerformLayout();
            this.tscGrillaCursos.ResumeLayout(false);
            this.tscGrillaCursos.PerformLayout();
            this.tsCursos.ResumeLayout(false);
            this.tsCursos.PerformLayout();
            this.tlpGrillaCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscGrillaCursos;
        private System.Windows.Forms.TableLayoutPanel tlpGrillaCursos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.ToolStrip tsCursos;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anio_Calendario;
    }
}