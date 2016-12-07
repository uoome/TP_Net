namespace UI.Desktop
{
    partial class DictadoDesktop
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
            this.lblIDdictado = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblDocente = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtIDdictado = new System.Windows.Forms.TextBox();
            this.cbxCursos = new System.Windows.Forms.ComboBox();
            this.cbxCargos = new System.Windows.Forms.ComboBox();
            this.cbxDocentes = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblIDdocente = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Controls.Add(this.lblIDdictado, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCurso, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDocente, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCargo, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtIDdictado, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbxCursos, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxCargos, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbxDocentes, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblIDdocente, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(253, 149);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblIDdictado
            // 
            this.lblIDdictado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIDdictado.AutoSize = true;
            this.lblIDdictado.Location = new System.Drawing.Point(3, 6);
            this.lblIDdictado.Name = "lblIDdictado";
            this.lblIDdictado.Size = new System.Drawing.Size(58, 13);
            this.lblIDdictado.TabIndex = 0;
            this.lblIDdictado.Text = "ID Dictado";
            // 
            // lblCurso
            // 
            this.lblCurso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(3, 33);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(34, 13);
            this.lblCurso.TabIndex = 1;
            this.lblCurso.Text = "Curso";
            // 
            // lblDocente
            // 
            this.lblDocente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDocente.AutoSize = true;
            this.lblDocente.Location = new System.Drawing.Point(3, 60);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(48, 13);
            this.lblDocente.TabIndex = 2;
            this.lblDocente.Text = "Docente";
            // 
            // lblCargo
            // 
            this.lblCargo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(3, 87);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 3;
            this.lblCargo.Text = "Cargo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAceptar.Location = new System.Drawing.Point(3, 116);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtIDdictado
            // 
            this.txtIDdictado.Location = new System.Drawing.Point(84, 3);
            this.txtIDdictado.Name = "txtIDdictado";
            this.txtIDdictado.ReadOnly = true;
            this.txtIDdictado.Size = new System.Drawing.Size(100, 20);
            this.txtIDdictado.TabIndex = 99;
            this.txtIDdictado.TabStop = false;
            // 
            // cbxCursos
            // 
            this.cbxCursos.FormattingEnabled = true;
            this.cbxCursos.Location = new System.Drawing.Point(84, 29);
            this.cbxCursos.Name = "cbxCursos";
            this.cbxCursos.Size = new System.Drawing.Size(121, 21);
            this.cbxCursos.TabIndex = 1;
            // 
            // cbxCargos
            // 
            this.cbxCargos.FormattingEnabled = true;
            this.cbxCargos.Location = new System.Drawing.Point(84, 83);
            this.cbxCargos.Name = "cbxCargos";
            this.cbxCargos.Size = new System.Drawing.Size(121, 21);
            this.cbxCargos.TabIndex = 3;
            // 
            // cbxDocentes
            // 
            this.cbxDocentes.FormattingEnabled = true;
            this.cbxDocentes.Location = new System.Drawing.Point(84, 56);
            this.cbxDocentes.Name = "cbxDocentes";
            this.cbxDocentes.Size = new System.Drawing.Size(121, 21);
            this.cbxDocentes.TabIndex = 2;
            this.cbxDocentes.SelectedIndexChanged += new System.EventHandler(this.cbxDocentes_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.Location = new System.Drawing.Point(84, 116);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblIDdocente
            // 
            this.lblIDdocente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIDdocente.AutoSize = true;
            this.lblIDdocente.Location = new System.Drawing.Point(211, 60);
            this.lblIDdocente.Name = "lblIDdocente";
            this.lblIDdocente.Size = new System.Drawing.Size(15, 13);
            this.lblIDdocente.TabIndex = 10;
            this.lblIDdocente.Text = "id";
            // 
            // DictadoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 149);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DictadoDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dictado";
            this.Load += new System.EventHandler(this.DictadoDesktop_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblIDdictado;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtIDdictado;
        private System.Windows.Forms.ComboBox cbxCursos;
        private System.Windows.Forms.ComboBox cbxDocentes;
        private System.Windows.Forms.ComboBox cbxCargos;
        private System.Windows.Forms.Label lblIDdocente;
    }
}