namespace UI.Desktop
{
    partial class PlanDesktop
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
            this.tlPlanDesktop = new System.Windows.Forms.TableLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblID_Especialidad = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbxEspecialidades = new System.Windows.Forms.ComboBox();
            this.tlPlanDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlPlanDesktop
            // 
            this.tlPlanDesktop.ColumnCount = 2;
            this.tlPlanDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPlanDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPlanDesktop.Controls.Add(this.lblID, 0, 0);
            this.tlPlanDesktop.Controls.Add(this.txtID, 1, 0);
            this.tlPlanDesktop.Controls.Add(this.lblDescripcion, 0, 1);
            this.tlPlanDesktop.Controls.Add(this.lblID_Especialidad, 0, 2);
            this.tlPlanDesktop.Controls.Add(this.txtDescripcion, 1, 1);
            this.tlPlanDesktop.Controls.Add(this.btnAceptar, 0, 3);
            this.tlPlanDesktop.Controls.Add(this.btnCancelar, 1, 3);
            this.tlPlanDesktop.Controls.Add(this.cbxEspecialidades, 1, 2);
            this.tlPlanDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPlanDesktop.Location = new System.Drawing.Point(0, 0);
            this.tlPlanDesktop.Name = "tlPlanDesktop";
            this.tlPlanDesktop.RowCount = 4;
            this.tlPlanDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlanDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlanDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlanDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPlanDesktop.Size = new System.Drawing.Size(246, 128);
            this.tlPlanDesktop.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 6);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtID.Location = new System.Drawing.Point(84, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 0;
            this.txtID.TabStop = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(3, 32);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblID_Especialidad
            // 
            this.lblID_Especialidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblID_Especialidad.AutoSize = true;
            this.lblID_Especialidad.Location = new System.Drawing.Point(3, 59);
            this.lblID_Especialidad.Name = "lblID_Especialidad";
            this.lblID_Especialidad.Size = new System.Drawing.Size(67, 13);
            this.lblID_Especialidad.TabIndex = 3;
            this.lblID_Especialidad.Text = "Especialidad";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDescripcion.Location = new System.Drawing.Point(84, 29);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(3, 82);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(84, 82);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbxEspecialidades
            // 
            this.cbxEspecialidades.FormattingEnabled = true;
            this.cbxEspecialidades.Location = new System.Drawing.Point(84, 55);
            this.cbxEspecialidades.Name = "cbxEspecialidades";
            this.cbxEspecialidades.Size = new System.Drawing.Size(121, 21);
            this.cbxEspecialidades.TabIndex = 2;
            // 
            // PlanDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 128);
            this.Controls.Add(this.tlPlanDesktop);
            this.Name = "PlanDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PlanDesktop";
            this.tlPlanDesktop.ResumeLayout(false);
            this.tlPlanDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlPlanDesktop;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblID_Especialidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbxEspecialidades;
    }
}