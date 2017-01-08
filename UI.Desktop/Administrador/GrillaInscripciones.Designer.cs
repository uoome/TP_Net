namespace UI.Desktop
{
    partial class GrillaInscripciones
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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tlpInscripciones = new System.Windows.Forms.TableLayoutPanel();
            this.dgvInscripciones = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.btnInscripciones = new System.Windows.Forms.Button();
            this.lblInscp = new System.Windows.Forms.Label();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AñoMate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tlpInscripciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tlpInscripciones);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(687, 490);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(687, 490);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // tlpInscripciones
            // 
            this.tlpInscripciones.ColumnCount = 3;
            this.tlpInscripciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpInscripciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpInscripciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpInscripciones.Controls.Add(this.dgvAlumnos, 0, 0);
            this.tlpInscripciones.Controls.Add(this.btnAgregar, 0, 3);
            this.tlpInscripciones.Controls.Add(this.btnEditar, 1, 3);
            this.tlpInscripciones.Controls.Add(this.btnEliminar, 2, 3);
            this.tlpInscripciones.Controls.Add(this.dgvCursos, 0, 4);
            this.tlpInscripciones.Controls.Add(this.lblInscp, 2, 1);
            this.tlpInscripciones.Controls.Add(this.btnSalir, 1, 1);
            this.tlpInscripciones.Controls.Add(this.btnInscripciones, 0, 1);
            this.tlpInscripciones.Controls.Add(this.dgvInscripciones, 2, 2);
            this.tlpInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInscripciones.Location = new System.Drawing.Point(0, 0);
            this.tlpInscripciones.Name = "tlpInscripciones";
            this.tlpInscripciones.RowCount = 5;
            this.tlpInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpInscripciones.Size = new System.Drawing.Size(687, 490);
            this.tlpInscripciones.TabIndex = 0;
            // 
            // dgvInscripciones
            // 
            this.dgvInscripciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscripciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cur,
            this.Mate,
            this.Plan,
            this.AñoMate,
            this.Comi,
            this.Condicion,
            this.Nota});
            this.tlpInscripciones.SetColumnSpan(this.dgvInscripciones, 3);
            this.dgvInscripciones.Location = new System.Drawing.Point(22, 188);
            this.dgvInscripciones.MultiSelect = false;
            this.dgvInscripciones.Name = "dgvInscripciones";
            this.dgvInscripciones.ReadOnly = true;
            this.dgvInscripciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInscripciones.Size = new System.Drawing.Size(643, 201);
            this.dgvInscripciones.TabIndex = 0;
            this.dgvInscripciones.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(84, 159);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Legajo,
            this.Apellido,
            this.Nombre});
            this.tlpInscripciones.SetColumnSpan(this.dgvAlumnos, 3);
            this.dgvAlumnos.Location = new System.Drawing.Point(171, 3);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(344, 150);
            this.dgvAlumnos.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAgregar.Location = new System.Drawing.Point(3, 419);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEditar.Location = new System.Drawing.Point(84, 419);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEliminar.Location = new System.Drawing.Point(165, 419);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            // 
            // dgvCursos
            // 
            this.dgvCursos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Curso,
            this.Comision,
            this.Cupo});
            this.tlpInscripciones.SetColumnSpan(this.dgvCursos, 3);
            this.dgvCursos.Location = new System.Drawing.Point(171, 473);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.Size = new System.Drawing.Size(344, 14);
            this.dgvCursos.TabIndex = 7;
            this.dgvCursos.Visible = false;
            // 
            // btnInscripciones
            // 
            this.btnInscripciones.Location = new System.Drawing.Point(3, 159);
            this.btnInscripciones.Name = "btnInscripciones";
            this.btnInscripciones.Size = new System.Drawing.Size(75, 23);
            this.btnInscripciones.TabIndex = 8;
            this.btnInscripciones.Text = "Ver Inscripciones";
            this.btnInscripciones.UseVisualStyleBackColor = true;
            this.btnInscripciones.Click += new System.EventHandler(this.btnInscripciones_Click);
            // 
            // lblInscp
            // 
            this.lblInscp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInscp.AutoSize = true;
            this.lblInscp.Location = new System.Drawing.Point(165, 164);
            this.lblInscp.Name = "lblInscp";
            this.lblInscp.Size = new System.Drawing.Size(237, 13);
            this.lblInscp.TabIndex = 9;
            this.lblInscp.Text = "Seleccione un alumno para ver sus inscripciones";
            // 
            // Curso
            // 
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            // 
            // Comision
            // 
            this.Comision.HeaderText = "Comision";
            this.Comision.Name = "Comision";
            // 
            // Cupo
            // 
            this.Cupo.HeaderText = "Cupo";
            this.Cupo.Name = "Cupo";
            // 
            // Legajo
            // 
            this.Legajo.DataPropertyName = "Legajo";
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Cur
            // 
            this.Cur.HeaderText = "Curso";
            this.Cur.Name = "Cur";
            this.Cur.ReadOnly = true;
            // 
            // Mate
            // 
            this.Mate.HeaderText = "Materia";
            this.Mate.Name = "Mate";
            this.Mate.ReadOnly = true;
            // 
            // Plan
            // 
            this.Plan.HeaderText = "Plan";
            this.Plan.Name = "Plan";
            this.Plan.ReadOnly = true;
            // 
            // AñoMate
            // 
            this.AñoMate.HeaderText = "Año Materia";
            this.AñoMate.Name = "AñoMate";
            this.AñoMate.ReadOnly = true;
            // 
            // Comi
            // 
            this.Comi.HeaderText = "Comision";
            this.Comi.Name = "Comi";
            this.Comi.ReadOnly = true;
            // 
            // Condicion
            // 
            this.Condicion.HeaderText = "Condicion";
            this.Condicion.Name = "Condicion";
            this.Condicion.ReadOnly = true;
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Nota";
            this.Nota.Name = "Nota";
            this.Nota.ReadOnly = true;
            // 
            // GrillaInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 490);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "GrillaInscripciones";
            this.Text = "Inscripciones";
            this.Load += new System.EventHandler(this.GrillaInscripciones_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tlpInscripciones.ResumeLayout(false);
            this.tlpInscripciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TableLayoutPanel tlpInscripciones;
        private System.Windows.Forms.DataGridView dgvInscripciones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Label lblInscp;
        private System.Windows.Forms.Button btnInscripciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn AñoMate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
    }
}