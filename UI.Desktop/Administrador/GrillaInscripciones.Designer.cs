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
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInscp = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInscripciones = new System.Windows.Forms.Button();
            this.dgvInscripciones = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tlpInscripciones);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(786, 405);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(786, 430);
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
            this.tlpInscripciones.Controls.Add(this.lblInscp, 2, 1);
            this.tlpInscripciones.Controls.Add(this.btnSalir, 1, 1);
            this.tlpInscripciones.Controls.Add(this.btnInscripciones, 0, 1);
            this.tlpInscripciones.Controls.Add(this.dgvInscripciones, 2, 2);
            this.tlpInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInscripciones.Location = new System.Drawing.Point(0, 0);
            this.tlpInscripciones.Name = "tlpInscripciones";
            this.tlpInscripciones.RowCount = 4;
            this.tlpInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInscripciones.Size = new System.Drawing.Size(786, 405);
            this.tlpInscripciones.TabIndex = 0;
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Legajo,
            this.Apellido,
            this.Nombre});
            this.tlpInscripciones.SetColumnSpan(this.dgvAlumnos, 3);
            this.dgvAlumnos.Location = new System.Drawing.Point(171, 3);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(443, 150);
            this.dgvAlumnos.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
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
            this.dgvInscripciones.Location = new System.Drawing.Point(21, 188);
            this.dgvInscripciones.MultiSelect = false;
            this.dgvInscripciones.Name = "dgvInscripciones";
            this.dgvInscripciones.ReadOnly = true;
            this.dgvInscripciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInscripciones.Size = new System.Drawing.Size(743, 201);
            this.dgvInscripciones.TabIndex = 0;
            this.dgvInscripciones.Visible = false;
            // 
            // Cur
            // 
            this.Cur.DataPropertyName = "curs";
            this.Cur.HeaderText = "Curso";
            this.Cur.Name = "Cur";
            this.Cur.ReadOnly = true;
            // 
            // Mate
            // 
            this.Mate.DataPropertyName = "desc_materia";
            this.Mate.HeaderText = "Materia";
            this.Mate.Name = "Mate";
            this.Mate.ReadOnly = true;
            // 
            // Plan
            // 
            this.Plan.DataPropertyName = "desc_plan";
            this.Plan.HeaderText = "Plan";
            this.Plan.Name = "Plan";
            this.Plan.ReadOnly = true;
            // 
            // AñoMate
            // 
            this.AñoMate.DataPropertyName = "año";
            this.AñoMate.HeaderText = "Año Materia";
            this.AñoMate.Name = "AñoMate";
            this.AñoMate.ReadOnly = true;
            // 
            // Comi
            // 
            this.Comi.DataPropertyName = "com";
            this.Comi.HeaderText = "Comision";
            this.Comi.Name = "Comi";
            this.Comi.ReadOnly = true;
            // 
            // Condicion
            // 
            this.Condicion.DataPropertyName = "estado";
            this.Condicion.HeaderText = "Condicion";
            this.Condicion.Name = "Condicion";
            this.Condicion.ReadOnly = true;
            // 
            // Nota
            // 
            this.Nota.DataPropertyName = "nota";
            this.Nota.HeaderText = "Nota";
            this.Nota.Name = "Nota";
            this.Nota.ReadOnly = true;
            // 
            // GrillaInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 430);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "GrillaInscripciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscripciones";
            this.Load += new System.EventHandler(this.GrillaInscripciones_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tlpInscripciones.ResumeLayout(false);
            this.tlpInscripciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TableLayoutPanel tlpInscripciones;
        private System.Windows.Forms.DataGridView dgvInscripciones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Label lblInscp;
        private System.Windows.Forms.Button btnInscripciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
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