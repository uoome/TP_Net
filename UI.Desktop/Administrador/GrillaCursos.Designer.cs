namespace UI.Desktop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tscGrillaCursos = new System.Windows.Forms.ToolStripContainer();
            this.tlpGrillaCursos = new System.Windows.Forms.TableLayoutPanel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.tsCursos = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.id_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio_calendario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupo_disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tscGrillaCursos.ContentPanel.SuspendLayout();
            this.tscGrillaCursos.TopToolStripPanel.SuspendLayout();
            this.tscGrillaCursos.SuspendLayout();
            this.tlpGrillaCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.tsCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscGrillaCursos
            // 
            // 
            // tscGrillaCursos.ContentPanel
            // 
            this.tscGrillaCursos.ContentPanel.Controls.Add(this.tlpGrillaCursos);
            this.tscGrillaCursos.ContentPanel.Size = new System.Drawing.Size(649, 236);
            this.tscGrillaCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscGrillaCursos.Location = new System.Drawing.Point(0, 0);
            this.tscGrillaCursos.Name = "tscGrillaCursos";
            this.tscGrillaCursos.Size = new System.Drawing.Size(649, 261);
            this.tscGrillaCursos.TabIndex = 0;
            this.tscGrillaCursos.Text = "toolStripContainer1";
            // 
            // tscGrillaCursos.TopToolStripPanel
            // 
            this.tscGrillaCursos.TopToolStripPanel.Controls.Add(this.tsCursos);
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
            this.tlpGrillaCursos.Size = new System.Drawing.Size(649, 236);
            this.tlpGrillaCursos.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(490, 210);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(571, 210);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvCursos
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvCursos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_curso,
            this.anio_calendario,
            this.Cupo,
            this.cupo_disponible,
            this.comision,
            this.materia});
            this.tlpGrillaCursos.SetColumnSpan(this.dgvCursos, 2);
            this.dgvCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCursos.Location = new System.Drawing.Point(3, 3);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.Size = new System.Drawing.Size(643, 201);
            this.dgvCursos.TabIndex = 2;
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
            this.tsbNuevo.Image = global::UI.Desktop.Properties.Resources.agregar_planes;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = global::UI.Desktop.Properties.Resources.Icono_de_editar;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = global::UI.Desktop.Properties.Resources.eliminar;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // id_curso
            // 
            this.id_curso.DataPropertyName = "id_curso";
            this.id_curso.HeaderText = "ID Curso";
            this.id_curso.Name = "id_curso";
            // 
            // anio_calendario
            // 
            this.anio_calendario.DataPropertyName = "anio_calend";
            this.anio_calendario.HeaderText = "Año ";
            this.anio_calendario.Name = "anio_calendario";
            // 
            // Cupo
            // 
            this.Cupo.DataPropertyName = "cupo";
            this.Cupo.HeaderText = "Cupo";
            this.Cupo.Name = "Cupo";
            // 
            // cupo_disponible
            // 
            this.cupo_disponible.DataPropertyName = "cupo_disp";
            this.cupo_disponible.HeaderText = "Cupo Disponible";
            this.cupo_disponible.Name = "cupo_disponible";
            // 
            // comision
            // 
            this.comision.DataPropertyName = "comision";
            this.comision.HeaderText = "Comision";
            this.comision.Name = "comision";
            // 
            // materia
            // 
            this.materia.DataPropertyName = "materia";
            this.materia.HeaderText = "Materia";
            this.materia.Name = "materia";
            // 
            // GrillaCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 261);
            this.Controls.Add(this.tscGrillaCursos);
            this.Name = "GrillaCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.GrillaCursos_Load);
            this.tscGrillaCursos.ContentPanel.ResumeLayout(false);
            this.tscGrillaCursos.TopToolStripPanel.ResumeLayout(false);
            this.tscGrillaCursos.TopToolStripPanel.PerformLayout();
            this.tscGrillaCursos.ResumeLayout(false);
            this.tscGrillaCursos.PerformLayout();
            this.tlpGrillaCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.tsCursos.ResumeLayout(false);
            this.tsCursos.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio_calendario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cupo_disponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn materia;
    }
}