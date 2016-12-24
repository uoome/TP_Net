﻿namespace UI.Desktop
{
    partial class ComisionDesktop
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
            this.tlpComisionDesktop = new System.Windows.Forms.TableLayoutPanel();
            this.lblIdComision = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblIdPlan = new System.Windows.Forms.Label();
            this.txtIDComi = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.comboIDPLAN = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtAnioEsp = new System.Windows.Forms.TextBox();
            this.lblAnioEspe = new System.Windows.Forms.Label();
            this.lblDescPlan = new System.Windows.Forms.Label();
            this.txtDescPlan = new System.Windows.Forms.TextBox();
            this.tlpComisionDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpComisionDesktop
            // 
            this.tlpComisionDesktop.ColumnCount = 2;
            this.tlpComisionDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpComisionDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpComisionDesktop.Controls.Add(this.lblIdComision, 0, 0);
            this.tlpComisionDesktop.Controls.Add(this.lblDescripcion, 0, 1);
            this.tlpComisionDesktop.Controls.Add(this.lblIdPlan, 0, 2);
            this.tlpComisionDesktop.Controls.Add(this.txtIDComi, 1, 0);
            this.tlpComisionDesktop.Controls.Add(this.txtDescripcion, 1, 1);
            this.tlpComisionDesktop.Controls.Add(this.comboIDPLAN, 1, 2);
            this.tlpComisionDesktop.Controls.Add(this.btnAceptar, 0, 5);
            this.tlpComisionDesktop.Controls.Add(this.btnCancelar, 1, 5);
            this.tlpComisionDesktop.Controls.Add(this.txtAnioEsp, 1, 4);
            this.tlpComisionDesktop.Controls.Add(this.lblAnioEspe, 0, 4);
            this.tlpComisionDesktop.Controls.Add(this.lblDescPlan, 0, 3);
            this.tlpComisionDesktop.Controls.Add(this.txtDescPlan, 1, 3);
            this.tlpComisionDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpComisionDesktop.Location = new System.Drawing.Point(0, 0);
            this.tlpComisionDesktop.Name = "tlpComisionDesktop";
            this.tlpComisionDesktop.RowCount = 6;
            this.tlpComisionDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpComisionDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpComisionDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpComisionDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpComisionDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpComisionDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpComisionDesktop.Size = new System.Drawing.Size(337, 171);
            this.tlpComisionDesktop.TabIndex = 0;
            // 
            // lblIdComision
            // 
            this.lblIdComision.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIdComision.AutoSize = true;
            this.lblIdComision.Location = new System.Drawing.Point(3, 6);
            this.lblIdComision.Name = "lblIdComision";
            this.lblIdComision.Size = new System.Drawing.Size(63, 13);
            this.lblIdComision.TabIndex = 0;
            this.lblIdComision.Text = "ID Comision";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(3, 32);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblIdPlan
            // 
            this.lblIdPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIdPlan.AutoSize = true;
            this.lblIdPlan.Location = new System.Drawing.Point(3, 59);
            this.lblIdPlan.Name = "lblIdPlan";
            this.lblIdPlan.Size = new System.Drawing.Size(42, 13);
            this.lblIdPlan.TabIndex = 2;
            this.lblIdPlan.Text = "ID Plan";
            // 
            // txtIDComi
            // 
            this.txtIDComi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIDComi.Location = new System.Drawing.Point(100, 3);
            this.txtIDComi.Name = "txtIDComi";
            this.txtIDComi.ReadOnly = true;
            this.txtIDComi.Size = new System.Drawing.Size(100, 20);
            this.txtIDComi.TabIndex = 0;
            this.txtIDComi.TabStop = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDescripcion.Location = new System.Drawing.Point(100, 29);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // comboIDPLAN
            // 
            this.comboIDPLAN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboIDPLAN.FormattingEnabled = true;
            this.comboIDPLAN.Location = new System.Drawing.Point(100, 55);
            this.comboIDPLAN.Name = "comboIDPLAN";
            this.comboIDPLAN.Size = new System.Drawing.Size(121, 21);
            this.comboIDPLAN.TabIndex = 2;
            this.comboIDPLAN.SelectedIndexChanged += new System.EventHandler(this.comboIDPLAN_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAceptar.Location = new System.Drawing.Point(19, 139);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.Location = new System.Drawing.Point(100, 139);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtAnioEsp
            // 
            this.txtAnioEsp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAnioEsp.Location = new System.Drawing.Point(100, 108);
            this.txtAnioEsp.Name = "txtAnioEsp";
            this.txtAnioEsp.Size = new System.Drawing.Size(100, 20);
            this.txtAnioEsp.TabIndex = 4;
            // 
            // lblAnioEspe
            // 
            this.lblAnioEspe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAnioEspe.AutoSize = true;
            this.lblAnioEspe.Location = new System.Drawing.Point(3, 111);
            this.lblAnioEspe.Name = "lblAnioEspe";
            this.lblAnioEspe.Size = new System.Drawing.Size(91, 13);
            this.lblAnioEspe.TabIndex = 3;
            this.lblAnioEspe.Text = "Anio Especialidad";
            // 
            // lblDescPlan
            // 
            this.lblDescPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescPlan.AutoSize = true;
            this.lblDescPlan.Location = new System.Drawing.Point(3, 85);
            this.lblDescPlan.Name = "lblDescPlan";
            this.lblDescPlan.Size = new System.Drawing.Size(82, 13);
            this.lblDescPlan.TabIndex = 10;
            this.lblDescPlan.Text = "Decripcion Plan";
            // 
            // txtDescPlan
            // 
            this.txtDescPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDescPlan.Location = new System.Drawing.Point(100, 82);
            this.txtDescPlan.Name = "txtDescPlan";
            this.txtDescPlan.Size = new System.Drawing.Size(100, 20);
            this.txtDescPlan.TabIndex = 3;
            // 
            // ComisionDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 171);
            this.Controls.Add(this.tlpComisionDesktop);
            this.Name = "ComisionDesktop";
            this.Text = "ComisionDesktop";
            this.Load += new System.EventHandler(this.ComisionDesktop_Load);
            this.tlpComisionDesktop.ResumeLayout(false);
            this.tlpComisionDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpComisionDesktop;
        private System.Windows.Forms.Label lblIdComision;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblIdPlan;
        private System.Windows.Forms.TextBox txtIDComi;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox comboIDPLAN;
        private System.Windows.Forms.Label lblAnioEspe;
        private System.Windows.Forms.TextBox txtAnioEsp;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblDescPlan;
        private System.Windows.Forms.TextBox txtDescPlan;
    }
}