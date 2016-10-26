namespace UI.Desktop
{
    partial class GrillaMaterias
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
            this.tscMateria = new System.Windows.Forms.ToolStripContainer();
            this.tlpMateria = new System.Windows.Forms.TableLayoutPanel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvMateria = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HsSemanales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HsTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tscMateria.ContentPanel.SuspendLayout();
            this.tscMateria.TopToolStripPanel.SuspendLayout();
            this.tscMateria.SuspendLayout();
            this.tlpMateria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscMateria
            // 
            // 
            // tscMateria.ContentPanel
            // 
            this.tscMateria.ContentPanel.Controls.Add(this.tlpMateria);
            this.tscMateria.ContentPanel.Size = new System.Drawing.Size(449, 236);
            this.tscMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscMateria.Location = new System.Drawing.Point(0, 0);
            this.tscMateria.Name = "tscMateria";
            this.tscMateria.Size = new System.Drawing.Size(449, 261);
            this.tscMateria.TabIndex = 0;
            this.tscMateria.Text = "toolStripContainer1";
            // 
            // tscMateria.TopToolStripPanel
            // 
            this.tscMateria.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tlpMateria
            // 
            this.tlpMateria.ColumnCount = 2;
            this.tlpMateria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMateria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMateria.Controls.Add(this.btnActualizar, 0, 1);
            this.tlpMateria.Controls.Add(this.btnCancelar, 1, 1);
            this.tlpMateria.Controls.Add(this.dgvMateria, 0, 0);
            this.tlpMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMateria.Location = new System.Drawing.Point(0, 0);
            this.tlpMateria.Name = "tlpMateria";
            this.tlpMateria.RowCount = 2;
            this.tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMateria.Size = new System.Drawing.Size(449, 236);
            this.tlpMateria.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(290, 210);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(371, 210);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvMateria
            // 
            this.dgvMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.HsSemanales,
            this.HsTotales,
            this.Id_Plan});
            this.tlpMateria.SetColumnSpan(this.dgvMateria, 2);
            this.dgvMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMateria.Location = new System.Drawing.Point(3, 3);
            this.dgvMateria.MultiSelect = false;
            this.dgvMateria.Name = "dgvMateria";
            this.dgvMateria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMateria.Size = new System.Drawing.Size(443, 201);
            this.dgvMateria.TabIndex = 0;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // HsSemanales
            // 
            this.HsSemanales.DataPropertyName = "HSSemanales";
            this.HsSemanales.HeaderText = "Horas Semanales";
            this.HsSemanales.Name = "HsSemanales";
            // 
            // HsTotales
            // 
            this.HsTotales.DataPropertyName = "HSTotales";
            this.HsTotales.HeaderText = "Horas Totales";
            this.HsTotales.Name = "HsTotales";
            // 
            // Id_Plan
            // 
            this.Id_Plan.DataPropertyName = "IDplan";
            this.Id_Plan.HeaderText = "Id Plan";
            this.Id_Plan.Name = "Id_Plan";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(112, 25);
            this.toolStrip1.TabIndex = 0;
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
            // GrillaMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 261);
            this.Controls.Add(this.tscMateria);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GrillaMaterias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrillaMaterias";
            this.Load += new System.EventHandler(this.GrillaMaterias_Load);
            this.tscMateria.ContentPanel.ResumeLayout(false);
            this.tscMateria.TopToolStripPanel.ResumeLayout(false);
            this.tscMateria.TopToolStripPanel.PerformLayout();
            this.tscMateria.ResumeLayout(false);
            this.tscMateria.PerformLayout();
            this.tlpMateria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscMateria;
        private System.Windows.Forms.TableLayoutPanel tlpMateria;
        private System.Windows.Forms.DataGridView dgvMateria;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn HsSemanales;
        private System.Windows.Forms.DataGridViewTextBoxColumn HsTotales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Plan;
    }
}