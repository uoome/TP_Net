namespace UI.Desktop
{
    partial class CursoDesktop
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblID_Curso = new System.Windows.Forms.Label();
            this.txbID_Curso = new System.Windows.Forms.TextBox();
            this.cbxComisiones = new System.Windows.Forms.ComboBox();
            this.cbxMaterias = new System.Windows.Forms.ComboBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            this.txbCupo = new System.Windows.Forms.TextBox();
            this.lblCupo = new System.Windows.Forms.Label();
            this.lblAnioCalendario = new System.Windows.Forms.Label();
            this.txbAnioCalendario = new System.Windows.Forms.TextBox();
            this.lblCupoDis = new System.Windows.Forms.Label();
            this.txtCuposDis = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblID_Curso, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txbID_Curso, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbxComisiones, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbxMaterias, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblMateria, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblComision, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txbCupo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCupo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAnioCalendario, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txbAnioCalendario, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCupoDis, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCuposDis, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(441, 133);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblID_Curso
            // 
            this.lblID_Curso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblID_Curso.AutoSize = true;
            this.lblID_Curso.Location = new System.Drawing.Point(3, 6);
            this.lblID_Curso.Name = "lblID_Curso";
            this.lblID_Curso.Size = new System.Drawing.Size(48, 13);
            this.lblID_Curso.TabIndex = 0;
            this.lblID_Curso.Text = "ID Curso";
            // 
            // txbID_Curso
            // 
            this.txbID_Curso.Location = new System.Drawing.Point(58, 3);
            this.txbID_Curso.Name = "txbID_Curso";
            this.txbID_Curso.ReadOnly = true;
            this.txbID_Curso.Size = new System.Drawing.Size(75, 20);
            this.txbID_Curso.TabIndex = 0;
            this.txbID_Curso.TabStop = false;
            // 
            // cbxComisiones
            // 
            this.cbxComisiones.FormattingEnabled = true;
            this.cbxComisiones.Location = new System.Drawing.Point(58, 55);
            this.cbxComisiones.Name = "cbxComisiones";
            this.cbxComisiones.Size = new System.Drawing.Size(75, 21);
            this.cbxComisiones.TabIndex = 4;
            // 
            // cbxMaterias
            // 
            this.cbxMaterias.FormattingEnabled = true;
            this.cbxMaterias.Location = new System.Drawing.Point(237, 55);
            this.cbxMaterias.Name = "cbxMaterias";
            this.cbxMaterias.Size = new System.Drawing.Size(199, 21);
            this.cbxMaterias.TabIndex = 5;
            // 
            // lblMateria
            // 
            this.lblMateria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(139, 59);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(42, 13);
            this.lblMateria.TabIndex = 5;
            this.lblMateria.Text = "Materia";
            // 
            // lblComision
            // 
            this.lblComision.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(3, 59);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(49, 13);
            this.lblComision.TabIndex = 2;
            this.lblComision.Text = "Comision";
            // 
            // txbCupo
            // 
            this.txbCupo.Location = new System.Drawing.Point(58, 29);
            this.txbCupo.Name = "txbCupo";
            this.txbCupo.Size = new System.Drawing.Size(75, 20);
            this.txbCupo.TabIndex = 2;
            // 
            // lblCupo
            // 
            this.lblCupo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCupo.AutoSize = true;
            this.lblCupo.Location = new System.Drawing.Point(3, 32);
            this.lblCupo.Name = "lblCupo";
            this.lblCupo.Size = new System.Drawing.Size(32, 13);
            this.lblCupo.TabIndex = 4;
            this.lblCupo.Text = "Cupo";
            // 
            // lblAnioCalendario
            // 
            this.lblAnioCalendario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAnioCalendario.AutoSize = true;
            this.lblAnioCalendario.Location = new System.Drawing.Point(139, 6);
            this.lblAnioCalendario.Name = "lblAnioCalendario";
            this.lblAnioCalendario.Size = new System.Drawing.Size(79, 13);
            this.lblAnioCalendario.TabIndex = 1;
            this.lblAnioCalendario.Text = "Año Calendario";
            // 
            // txbAnioCalendario
            // 
            this.txbAnioCalendario.Location = new System.Drawing.Point(237, 3);
            this.txbAnioCalendario.Name = "txbAnioCalendario";
            this.txbAnioCalendario.Size = new System.Drawing.Size(125, 20);
            this.txbAnioCalendario.TabIndex = 1;
            // 
            // lblCupoDis
            // 
            this.lblCupoDis.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCupoDis.AutoSize = true;
            this.lblCupoDis.Location = new System.Drawing.Point(139, 32);
            this.lblCupoDis.Name = "lblCupoDis";
            this.lblCupoDis.Size = new System.Drawing.Size(92, 13);
            this.lblCupoDis.TabIndex = 9;
            this.lblCupoDis.Text = "Cupos disponibles";
            // 
            // txtCuposDis
            // 
            this.txtCuposDis.Location = new System.Drawing.Point(237, 29);
            this.txtCuposDis.Name = "txtCuposDis";
            this.txtCuposDis.Size = new System.Drawing.Size(125, 20);
            this.txtCuposDis.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAceptar.Location = new System.Drawing.Point(156, 94);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.Location = new System.Drawing.Point(237, 94);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 133);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CursoDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CursoDesktop";
            this.Load += new System.EventHandler(this.CursoDesktop_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblID_Curso;
        private System.Windows.Forms.Label lblAnioCalendario;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Label lblCupo;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.TextBox txbID_Curso;
        private System.Windows.Forms.TextBox txbAnioCalendario;
        private System.Windows.Forms.TextBox txbCupo;
        private System.Windows.Forms.ComboBox cbxComisiones;
        private System.Windows.Forms.ComboBox cbxMaterias;
        private System.Windows.Forms.Label lblCupoDis;
        private System.Windows.Forms.TextBox txtCuposDis;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}