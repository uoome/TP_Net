namespace UI.Desktop
{
    partial class MateriaDesktop
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
            this.tbpMateriaDesktop = new System.Windows.Forms.TableLayoutPanel();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblId_Materia = new System.Windows.Forms.Label();
            this.txtID_Materia = new System.Windows.Forms.TextBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblHSTotales = new System.Windows.Forms.Label();
            this.lblHSSemanales = new System.Windows.Forms.Label();
            this.txbHSSemanales = new System.Windows.Forms.TextBox();
            this.txbHSTotales = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cbxPlanes = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.cbxEspecialidades = new System.Windows.Forms.ComboBox();
            this.tbpMateriaDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpMateriaDesktop
            // 
            this.tbpMateriaDesktop.ColumnCount = 4;
            this.tbpMateriaDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbpMateriaDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbpMateriaDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbpMateriaDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbpMateriaDesktop.Controls.Add(this.txbDescripcion, 1, 2);
            this.tbpMateriaDesktop.Controls.Add(this.lblDescripcion, 0, 2);
            this.tbpMateriaDesktop.Controls.Add(this.lblId_Materia, 0, 0);
            this.tbpMateriaDesktop.Controls.Add(this.txtID_Materia, 1, 0);
            this.tbpMateriaDesktop.Controls.Add(this.lblAnio, 2, 0);
            this.tbpMateriaDesktop.Controls.Add(this.lblHSTotales, 2, 1);
            this.tbpMateriaDesktop.Controls.Add(this.lblHSSemanales, 0, 1);
            this.tbpMateriaDesktop.Controls.Add(this.txbHSSemanales, 1, 1);
            this.tbpMateriaDesktop.Controls.Add(this.txbHSTotales, 3, 1);
            this.tbpMateriaDesktop.Controls.Add(this.txtAnio, 3, 0);
            this.tbpMateriaDesktop.Controls.Add(this.btnAceptar, 2, 4);
            this.tbpMateriaDesktop.Controls.Add(this.cbxPlanes, 3, 3);
            this.tbpMateriaDesktop.Controls.Add(this.btnCancelar, 3, 4);
            this.tbpMateriaDesktop.Controls.Add(this.lblPlan, 2, 3);
            this.tbpMateriaDesktop.Controls.Add(this.lblEspecialidad, 0, 3);
            this.tbpMateriaDesktop.Controls.Add(this.cbxEspecialidades, 1, 3);
            this.tbpMateriaDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpMateriaDesktop.Location = new System.Drawing.Point(0, 0);
            this.tbpMateriaDesktop.Name = "tbpMateriaDesktop";
            this.tbpMateriaDesktop.RowCount = 5;
            this.tbpMateriaDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbpMateriaDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbpMateriaDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbpMateriaDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbpMateriaDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbpMateriaDesktop.Size = new System.Drawing.Size(544, 136);
            this.tbpMateriaDesktop.TabIndex = 0;
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbDescripcion.Location = new System.Drawing.Point(97, 55);
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(142, 20);
            this.txbDescripcion.TabIndex = 4;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(3, 58);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblId_Materia
            // 
            this.lblId_Materia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblId_Materia.AutoSize = true;
            this.lblId_Materia.Location = new System.Drawing.Point(3, 6);
            this.lblId_Materia.Name = "lblId_Materia";
            this.lblId_Materia.Size = new System.Drawing.Size(54, 13);
            this.lblId_Materia.TabIndex = 7;
            this.lblId_Materia.Text = "Id Materia";
            // 
            // txtID_Materia
            // 
            this.txtID_Materia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtID_Materia.Location = new System.Drawing.Point(97, 3);
            this.txtID_Materia.Name = "txtID_Materia";
            this.txtID_Materia.ReadOnly = true;
            this.txtID_Materia.Size = new System.Drawing.Size(100, 20);
            this.txtID_Materia.TabIndex = 0;
            this.txtID_Materia.TabStop = false;
            // 
            // lblAnio
            // 
            this.lblAnio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(245, 6);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(26, 13);
            this.lblAnio.TabIndex = 8;
            this.lblAnio.Text = "Año";
            // 
            // lblHSTotales
            // 
            this.lblHSTotales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHSTotales.AutoSize = true;
            this.lblHSTotales.Location = new System.Drawing.Point(245, 32);
            this.lblHSTotales.Name = "lblHSTotales";
            this.lblHSTotales.Size = new System.Drawing.Size(69, 13);
            this.lblHSTotales.TabIndex = 2;
            this.lblHSTotales.Text = "Horas totales";
            // 
            // lblHSSemanales
            // 
            this.lblHSSemanales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHSSemanales.AutoSize = true;
            this.lblHSSemanales.Location = new System.Drawing.Point(3, 32);
            this.lblHSSemanales.Name = "lblHSSemanales";
            this.lblHSSemanales.Size = new System.Drawing.Size(88, 13);
            this.lblHSSemanales.TabIndex = 1;
            this.lblHSSemanales.Text = "Horas semanales";
            // 
            // txbHSSemanales
            // 
            this.txbHSSemanales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbHSSemanales.Location = new System.Drawing.Point(97, 29);
            this.txbHSSemanales.Name = "txbHSSemanales";
            this.txbHSSemanales.Size = new System.Drawing.Size(142, 20);
            this.txbHSSemanales.TabIndex = 2;
            // 
            // txbHSTotales
            // 
            this.txbHSTotales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbHSTotales.Location = new System.Drawing.Point(326, 29);
            this.txbHSTotales.Name = "txbHSTotales";
            this.txbHSTotales.Size = new System.Drawing.Size(121, 20);
            this.txbHSTotales.TabIndex = 3;
            // 
            // txtAnio
            // 
            this.txtAnio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAnio.Location = new System.Drawing.Point(326, 3);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(120, 20);
            this.txtAnio.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(245, 108);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cbxPlanes
            // 
            this.cbxPlanes.FormattingEnabled = true;
            this.cbxPlanes.Location = new System.Drawing.Point(326, 81);
            this.cbxPlanes.Name = "cbxPlanes";
            this.cbxPlanes.Size = new System.Drawing.Size(121, 21);
            this.cbxPlanes.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(326, 108);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblPlan
            // 
            this.lblPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(245, 85);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(28, 13);
            this.lblPlan.TabIndex = 3;
            this.lblPlan.Text = "Plan";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(3, 85);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.lblEspecialidad.TabIndex = 9;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // cbxEspecialidades
            // 
            this.cbxEspecialidades.FormattingEnabled = true;
            this.cbxEspecialidades.Location = new System.Drawing.Point(97, 81);
            this.cbxEspecialidades.Name = "cbxEspecialidades";
            this.cbxEspecialidades.Size = new System.Drawing.Size(142, 21);
            this.cbxEspecialidades.TabIndex = 5;
            this.cbxEspecialidades.SelectedIndexChanged += new System.EventHandler(this.cbxEspecialidades_SelectedIndexChanged);
            // 
            // MateriaDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 136);
            this.Controls.Add(this.tbpMateriaDesktop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MateriaDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MateriaDesktop";
            this.Load += new System.EventHandler(this.MateriaDesktop_Load);
            this.tbpMateriaDesktop.ResumeLayout(false);
            this.tbpMateriaDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbpMateriaDesktop;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblHSSemanales;
        private System.Windows.Forms.Label lblHSTotales;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.TextBox txbHSSemanales;
        private System.Windows.Forms.TextBox txbHSTotales;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblId_Materia;
        private System.Windows.Forms.TextBox txtID_Materia;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.ComboBox cbxPlanes;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.ComboBox cbxEspecialidades;
    }
}