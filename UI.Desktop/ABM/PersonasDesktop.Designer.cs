namespace UI.Desktop.ABM
{
    partial class PersonasDesktop
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblFecha_nac = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblID_Persona = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtFecha_nac = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtID_Persona = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 64);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(12, 98);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Direccion";
            this.lblDireccion.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblFecha_nac
            // 
            this.lblFecha_nac.AutoSize = true;
            this.lblFecha_nac.Location = new System.Drawing.Point(12, 128);
            this.lblFecha_nac.Name = "lblFecha_nac";
            this.lblFecha_nac.Size = new System.Drawing.Size(108, 13);
            this.lblFecha_nac.TabIndex = 4;
            this.lblFecha_nac.Text = "Fecha de Nacimiento";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 167);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblID_Persona
            // 
            this.lblID_Persona.AutoSize = true;
            this.lblID_Persona.Location = new System.Drawing.Point(15, 212);
            this.lblID_Persona.Name = "lblID_Persona";
            this.lblID_Persona.Size = new System.Drawing.Size(63, 13);
            this.lblID_Persona.TabIndex = 6;
            this.lblID_Persona.Text = "ID_Persona";
            this.lblID_Persona.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(147, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(147, 57);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(147, 95);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // txtFecha_nac
            // 
            this.txtFecha_nac.Location = new System.Drawing.Point(147, 125);
            this.txtFecha_nac.Name = "txtFecha_nac";
            this.txtFecha_nac.Size = new System.Drawing.Size(100, 20);
            this.txtFecha_nac.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(147, 160);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtID_Persona
            // 
            this.txtID_Persona.Enabled = false;
            this.txtID_Persona.Location = new System.Drawing.Point(147, 205);
            this.txtID_Persona.Name = "txtID_Persona";
            this.txtID_Persona.Size = new System.Drawing.Size(100, 20);
            this.txtID_Persona.TabIndex = 6;
            // 
            // PersonasDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtID_Persona);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFecha_nac);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblID_Persona);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFecha_nac);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "PersonasDesktop";
            this.Text = "PersonasDesktop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblFecha_nac;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblID_Persona;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtFecha_nac;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtID_Persona;
    }
}