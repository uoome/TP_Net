namespace UI.Desktop
{
    partial class GrillaPersonas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tablePanelPersonas = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.Id_persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_nac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cambiaClave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habilitado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tablePanelPersonas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tablePanelPersonas);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1046, 236);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1046, 261);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tablePanelPersonas
            // 
            this.tablePanelPersonas.ColumnCount = 2;
            this.tablePanelPersonas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanelPersonas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanelPersonas.Controls.Add(this.dgvPersonas, 0, 0);
            this.tablePanelPersonas.Controls.Add(this.btnSalir, 1, 1);
            this.tablePanelPersonas.Controls.Add(this.btnActualizar, 0, 1);
            this.tablePanelPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelPersonas.Location = new System.Drawing.Point(0, 0);
            this.tablePanelPersonas.Name = "tablePanelPersonas";
            this.tablePanelPersonas.RowCount = 2;
            this.tablePanelPersonas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanelPersonas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelPersonas.Size = new System.Drawing.Size(1046, 236);
            this.tablePanelPersonas.TabIndex = 0;
            // 
            // dgvPersonas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dgvPersonas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_persona,
            this.Legajo,
            this.Apellido,
            this.Nombre,
            this.Fecha_nac,
            this.Direccion,
            this.Telefono,
            this.Email,
            this.Id_Plan,
            this.Tipo_persona,
            this.Usuario,
            this.Contraseña,
            this.cambiaClave,
            this.Habilitado});
            this.tablePanelPersonas.SetColumnSpan(this.dgvPersonas, 2);
            this.dgvPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersonas.Location = new System.Drawing.Point(3, 3);
            this.dgvPersonas.MultiSelect = false;
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonas.Size = new System.Drawing.Size(1040, 201);
            this.dgvPersonas.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(968, 210);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(887, 210);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbModificar,
            this.tsbEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(81, 25);
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
            // tsbModificar
            // 
            this.tsbModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModificar.Image = global::UI.Desktop.Properties.Resources.Icono_de_editar;
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(23, 22);
            this.tsbModificar.Text = "Modificar";
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
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
            // Id_persona
            // 
            this.Id_persona.DataPropertyName = "ID";
            this.Id_persona.HeaderText = "Id Persona";
            this.Id_persona.Name = "Id_persona";
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
            // Fecha_nac
            // 
            this.Fecha_nac.DataPropertyName = "FechaDeNacimiento";
            this.Fecha_nac.HeaderText = "Fecha de Nacimiento";
            this.Fecha_nac.Name = "Fecha_nac";
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Id_Plan
            // 
            this.Id_Plan.DataPropertyName = "IDPlan";
            this.Id_Plan.HeaderText = "Id Plan";
            this.Id_Plan.Name = "Id_Plan";
            this.Id_Plan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id_Plan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Tipo_persona
            // 
            this.Tipo_persona.DataPropertyName = "TipoPersona";
            this.Tipo_persona.HeaderText = "Tipo Persona";
            this.Tipo_persona.Name = "Tipo_persona";
            this.Tipo_persona.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tipo_persona.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "NombreUsuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            // 
            // Contraseña
            // 
            this.Contraseña.DataPropertyName = "Clave";
            this.Contraseña.HeaderText = "Contraseña";
            this.Contraseña.Name = "Contraseña";
            // 
            // cambiaClave
            // 
            this.cambiaClave.DataPropertyName = "CambiaClave";
            this.cambiaClave.HeaderText = "Cambia Clave";
            this.cambiaClave.Name = "cambiaClave";
            this.cambiaClave.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cambiaClave.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Habilitado
            // 
            this.Habilitado.DataPropertyName = "Habilitado";
            this.Habilitado.HeaderText = "Habilitado";
            this.Habilitado.Name = "Habilitado";
            // 
            // GrillaPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 261);
            this.Controls.Add(this.toolStripContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GrillaPersonas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrillaPersonas";
            this.Load += new System.EventHandler(this.GrillaPersonas_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tablePanelPersonas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.TableLayoutPanel tablePanelPersonas;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_nac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn cambiaClave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Habilitado;
    }
}