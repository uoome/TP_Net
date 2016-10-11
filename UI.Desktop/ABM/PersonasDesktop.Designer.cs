namespace UI.Desktop
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
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblId_Plan = new System.Windows.Forms.Label();
            this.lblTipo_Pers = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.cbTipoPers = new System.Windows.Forms.ComboBox();
            this.cbxId_Plan = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 13);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 39);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(12, 65);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Direccion";
            this.lblDireccion.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblFecha_nac
            // 
            this.lblFecha_nac.AutoSize = true;
            this.lblFecha_nac.Location = new System.Drawing.Point(12, 117);
            this.lblFecha_nac.Name = "lblFecha_nac";
            this.lblFecha_nac.Size = new System.Drawing.Size(108, 13);
            this.lblFecha_nac.TabIndex = 4;
            this.lblFecha_nac.Text = "Fecha de Nacimiento";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 91);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblID_Persona
            // 
            this.lblID_Persona.AutoSize = true;
            this.lblID_Persona.Location = new System.Drawing.Point(318, 17);
            this.lblID_Persona.Name = "lblID_Persona";
            this.lblID_Persona.Size = new System.Drawing.Size(63, 13);
            this.lblID_Persona.TabIndex = 6;
            this.lblID_Persona.Text = "ID_Persona";
            this.lblID_Persona.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(126, 10);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(166, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(126, 36);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(166, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(126, 62);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(166, 20);
            this.txtDireccion.TabIndex = 3;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtFecha_nac
            // 
            this.txtFecha_nac.Location = new System.Drawing.Point(126, 114);
            this.txtFecha_nac.Name = "txtFecha_nac";
            this.txtFecha_nac.Size = new System.Drawing.Size(100, 20);
            this.txtFecha_nac.TabIndex = 5;
            this.txtFecha_nac.TextChanged += new System.EventHandler(this.txtFecha_nac_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(126, 88);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(166, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtID_Persona
            // 
            this.txtID_Persona.HideSelection = false;
            this.txtID_Persona.Location = new System.Drawing.Point(394, 10);
            this.txtID_Persona.Name = "txtID_Persona";
            this.txtID_Persona.ReadOnly = true;
            this.txtID_Persona.Size = new System.Drawing.Size(100, 20);
            this.txtID_Persona.TabIndex = 7;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(318, 43);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(39, 13);
            this.lblLegajo.TabIndex = 7;
            this.lblLegajo.Text = "Legajo";
            // 
            // lblId_Plan
            // 
            this.lblId_Plan.AutoSize = true;
            this.lblId_Plan.Location = new System.Drawing.Point(318, 70);
            this.lblId_Plan.Name = "lblId_Plan";
            this.lblId_Plan.Size = new System.Drawing.Size(43, 13);
            this.lblId_Plan.TabIndex = 8;
            this.lblId_Plan.Text = "Id_Plan";
            // 
            // lblTipo_Pers
            // 
            this.lblTipo_Pers.AutoSize = true;
            this.lblTipo_Pers.Location = new System.Drawing.Point(318, 95);
            this.lblTipo_Pers.Name = "lblTipo_Pers";
            this.lblTipo_Pers.Size = new System.Drawing.Size(70, 13);
            this.lblTipo_Pers.TabIndex = 9;
            this.lblTipo_Pers.Text = "Tipo Persona";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(394, 36);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(100, 20);
            this.txtLegajo.TabIndex = 8;
            // 
            // cbTipoPers
            // 
            this.cbTipoPers.FormattingEnabled = true;
            this.cbTipoPers.Location = new System.Drawing.Point(394, 89);
            this.cbTipoPers.Name = "cbTipoPers";
            this.cbTipoPers.Size = new System.Drawing.Size(100, 21);
            this.cbTipoPers.TabIndex = 10;
            // 
            // cbxId_Plan
            // 
            this.cbxId_Plan.FormattingEnabled = true;
            this.cbxId_Plan.Location = new System.Drawing.Point(394, 62);
            this.cbxId_Plan.Name = "cbxId_Plan";
            this.cbxId_Plan.Size = new System.Drawing.Size(100, 21);
            this.cbxId_Plan.TabIndex = 9;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(338, 141);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(419, 141);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(12, 141);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 17;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(126, 141);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 6;
            // 
            // PersonasDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 180);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbxId_Plan);
            this.Controls.Add(this.cbTipoPers);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.lblTipo_Pers);
            this.Controls.Add(this.lblId_Plan);
            this.Controls.Add(this.lblLegajo);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonasDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PersonasDesktop";
            this.Load += new System.EventHandler(this.PersonasDesktop_Load);
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
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblId_Plan;
        private System.Windows.Forms.Label lblTipo_Pers;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.ComboBox cbTipoPers;
        private System.Windows.Forms.ComboBox cbxId_Plan;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
    }
}