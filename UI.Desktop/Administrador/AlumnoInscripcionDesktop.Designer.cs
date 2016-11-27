namespace UI.Desktop
{
    partial class AlumnoInscripcionDesktop
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
            this.tlpInscripcionesDesktop = new System.Windows.Forms.TableLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblIDAlu = new System.Windows.Forms.Label();
            this.lblIDCurso = new System.Windows.Forms.Label();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtID_Curso = new System.Windows.Forms.TextBox();
            this.txtID_Alumno = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbxCondiciones = new System.Windows.Forms.ComboBox();
            this.cbxNotas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tlpInscripcionesDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpInscripcionesDesktop
            // 
            this.tlpInscripcionesDesktop.ColumnCount = 2;
            this.tlpInscripcionesDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpInscripcionesDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInscripcionesDesktop.Controls.Add(this.lblID, 0, 0);
            this.tlpInscripcionesDesktop.Controls.Add(this.txtID, 1, 0);
            this.tlpInscripcionesDesktop.Controls.Add(this.lblIDAlu, 0, 1);
            this.tlpInscripcionesDesktop.Controls.Add(this.txtID_Alumno, 1, 1);
            this.tlpInscripcionesDesktop.Controls.Add(this.btnAceptar, 0, 7);
            this.tlpInscripcionesDesktop.Controls.Add(this.btnCancelar, 1, 7);
            this.tlpInscripcionesDesktop.Controls.Add(this.lblNota, 0, 6);
            this.tlpInscripcionesDesktop.Controls.Add(this.cbxNotas, 1, 6);
            this.tlpInscripcionesDesktop.Controls.Add(this.lblCondicion, 0, 5);
            this.tlpInscripcionesDesktop.Controls.Add(this.cbxCondiciones, 1, 5);
            this.tlpInscripcionesDesktop.Controls.Add(this.lblIDCurso, 0, 4);
            this.tlpInscripcionesDesktop.Controls.Add(this.txtID_Curso, 1, 4);
            this.tlpInscripcionesDesktop.Controls.Add(this.label1, 0, 2);
            this.tlpInscripcionesDesktop.Controls.Add(this.label2, 0, 3);
            this.tlpInscripcionesDesktop.Controls.Add(this.textBox1, 1, 2);
            this.tlpInscripcionesDesktop.Controls.Add(this.textBox2, 1, 3);
            this.tlpInscripcionesDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInscripcionesDesktop.Location = new System.Drawing.Point(0, 0);
            this.tlpInscripcionesDesktop.Name = "tlpInscripcionesDesktop";
            this.tlpInscripcionesDesktop.RowCount = 8;
            this.tlpInscripcionesDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInscripcionesDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInscripcionesDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpInscripcionesDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpInscripcionesDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpInscripcionesDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpInscripcionesDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpInscripcionesDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpInscripcionesDesktop.Size = new System.Drawing.Size(397, 261);
            this.tlpInscripcionesDesktop.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(84, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(121, 20);
            this.txtID.TabIndex = 1;
            // 
            // lblIDAlu
            // 
            this.lblIDAlu.AutoSize = true;
            this.lblIDAlu.Location = new System.Drawing.Point(3, 26);
            this.lblIDAlu.Name = "lblIDAlu";
            this.lblIDAlu.Size = new System.Drawing.Size(56, 13);
            this.lblIDAlu.TabIndex = 2;
            this.lblIDAlu.Text = "ID Alumno";
            // 
            // lblIDCurso
            // 
            this.lblIDCurso.AutoSize = true;
            this.lblIDCurso.Location = new System.Drawing.Point(3, 120);
            this.lblIDCurso.Name = "lblIDCurso";
            this.lblIDCurso.Size = new System.Drawing.Size(48, 13);
            this.lblIDCurso.TabIndex = 3;
            this.lblIDCurso.Text = "ID Curso";
            // 
            // lblCondicion
            // 
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Location = new System.Drawing.Point(3, 154);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(54, 13);
            this.lblCondicion.TabIndex = 4;
            this.lblCondicion.Text = "Condicion";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(3, 188);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(30, 13);
            this.lblNota.TabIndex = 5;
            this.lblNota.Text = "Nota";
            // 
            // txtID_Curso
            // 
            this.txtID_Curso.Location = new System.Drawing.Point(84, 123);
            this.txtID_Curso.Name = "txtID_Curso";
            this.txtID_Curso.Size = new System.Drawing.Size(121, 20);
            this.txtID_Curso.TabIndex = 8;
            // 
            // txtID_Alumno
            // 
            this.txtID_Alumno.Location = new System.Drawing.Point(84, 29);
            this.txtID_Alumno.Name = "txtID_Alumno";
            this.txtID_Alumno.Size = new System.Drawing.Size(121, 20);
            this.txtID_Alumno.TabIndex = 9;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(3, 225);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(84, 225);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbxCondiciones
            // 
            this.cbxCondiciones.FormattingEnabled = true;
            this.cbxCondiciones.Location = new System.Drawing.Point(84, 157);
            this.cbxCondiciones.Name = "cbxCondiciones";
            this.cbxCondiciones.Size = new System.Drawing.Size(121, 21);
            this.cbxCondiciones.TabIndex = 12;
            // 
            // cbxNotas
            // 
            this.cbxNotas.FormattingEnabled = true;
            this.cbxNotas.Location = new System.Drawing.Point(84, 191);
            this.cbxNotas.Name = "cbxNotas";
            this.cbxNotas.Size = new System.Drawing.Size(121, 21);
            this.cbxNotas.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 17;
            // 
            // AlumnoInscripcionDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 261);
            this.Controls.Add(this.tlpInscripcionesDesktop);
            this.Name = "AlumnoInscripcionDesktop";
            this.Text = "AlumnoInscripcionDesktop";
            this.Load += new System.EventHandler(this.AlumnoInscripcionDesktop_Load);
            this.tlpInscripcionesDesktop.ResumeLayout(false);
            this.tlpInscripcionesDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpInscripcionesDesktop;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblIDAlu;
        private System.Windows.Forms.Label lblIDCurso;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.TextBox txtID_Curso;
        private System.Windows.Forms.TextBox txtID_Alumno;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbxNotas;
        private System.Windows.Forms.ComboBox cbxCondiciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}