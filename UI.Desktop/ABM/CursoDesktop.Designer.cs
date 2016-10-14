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
            this.lblAnioCalendario = new System.Windows.Forms.Label();
            this.lblId_Comi = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCupo = new System.Windows.Forms.Label();
            this.lblID_Materia = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txbID_Curso = new System.Windows.Forms.TextBox();
            this.txbAnioCalendario = new System.Windows.Forms.TextBox();
            this.txbId_Comi = new System.Windows.Forms.TextBox();
            this.txbCupo = new System.Windows.Forms.TextBox();
            this.txbID_Materia = new System.Windows.Forms.TextBox();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.Controls.Add(this.lblAnioCalendario, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblId_Comi, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDescripcion, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCupo, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblID_Materia, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txbID_Curso, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txbAnioCalendario, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txbId_Comi, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txbCupo, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txbID_Materia, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txbDescripcion, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(502, 115);
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
            // lblAnioCalendario
            // 
            this.lblAnioCalendario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAnioCalendario.AutoSize = true;
            this.lblAnioCalendario.Location = new System.Drawing.Point(3, 32);
            this.lblAnioCalendario.Name = "lblAnioCalendario";
            this.lblAnioCalendario.Size = new System.Drawing.Size(79, 13);
            this.lblAnioCalendario.TabIndex = 1;
            this.lblAnioCalendario.Text = "Año Calendario";
            // 
            // lblId_Comi
            // 
            this.lblId_Comi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblId_Comi.AutoSize = true;
            this.lblId_Comi.Location = new System.Drawing.Point(3, 58);
            this.lblId_Comi.Name = "lblId_Comi";
            this.lblId_Comi.Size = new System.Drawing.Size(63, 13);
            this.lblId_Comi.TabIndex = 2;
            this.lblId_Comi.Text = "ID Comision";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(219, 6);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblCupo
            // 
            this.lblCupo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCupo.AutoSize = true;
            this.lblCupo.Location = new System.Drawing.Point(219, 32);
            this.lblCupo.Name = "lblCupo";
            this.lblCupo.Size = new System.Drawing.Size(32, 13);
            this.lblCupo.TabIndex = 4;
            this.lblCupo.Text = "Cupo";
            // 
            // lblID_Materia
            // 
            this.lblID_Materia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblID_Materia.AutoSize = true;
            this.lblID_Materia.Location = new System.Drawing.Point(219, 58);
            this.lblID_Materia.Name = "lblID_Materia";
            this.lblID_Materia.Size = new System.Drawing.Size(56, 13);
            this.lblID_Materia.TabIndex = 5;
            this.lblID_Materia.Text = "ID Materia";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAceptar.Location = new System.Drawing.Point(219, 85);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.Location = new System.Drawing.Point(300, 85);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txbID_Curso
            // 
            this.txbID_Curso.Location = new System.Drawing.Point(88, 3);
            this.txbID_Curso.Name = "txbID_Curso";
            this.txbID_Curso.ReadOnly = true;
            this.txbID_Curso.Size = new System.Drawing.Size(125, 20);
            this.txbID_Curso.TabIndex = 8;
            this.txbID_Curso.TabStop = false;
            // 
            // txbAnioCalendario
            // 
            this.txbAnioCalendario.Location = new System.Drawing.Point(88, 29);
            this.txbAnioCalendario.Name = "txbAnioCalendario";
            this.txbAnioCalendario.Size = new System.Drawing.Size(125, 20);
            this.txbAnioCalendario.TabIndex = 2;
            // 
            // txbId_Comi
            // 
            this.txbId_Comi.Location = new System.Drawing.Point(88, 55);
            this.txbId_Comi.Name = "txbId_Comi";
            this.txbId_Comi.Size = new System.Drawing.Size(125, 20);
            this.txbId_Comi.TabIndex = 4;
            // 
            // txbCupo
            // 
            this.txbCupo.Location = new System.Drawing.Point(300, 29);
            this.txbCupo.Name = "txbCupo";
            this.txbCupo.Size = new System.Drawing.Size(128, 20);
            this.txbCupo.TabIndex = 3;
            // 
            // txbID_Materia
            // 
            this.txbID_Materia.Location = new System.Drawing.Point(300, 55);
            this.txbID_Materia.Name = "txbID_Materia";
            this.txbID_Materia.Size = new System.Drawing.Size(128, 20);
            this.txbID_Materia.TabIndex = 5;
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(300, 3);
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(199, 20);
            this.txbDescripcion.TabIndex = 1;
            // 
            // CursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 115);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CursoDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CursoDesktop";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblID_Curso;
        private System.Windows.Forms.Label lblAnioCalendario;
        private System.Windows.Forms.Label lblId_Comi;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCupo;
        private System.Windows.Forms.Label lblID_Materia;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txbID_Curso;
        private System.Windows.Forms.TextBox txbAnioCalendario;
        private System.Windows.Forms.TextBox txbId_Comi;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.TextBox txbCupo;
        private System.Windows.Forms.TextBox txbID_Materia;
    }
}