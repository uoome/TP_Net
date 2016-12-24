using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            PersonaLogic persLogic = new PersonaLogic();
            Personas per;

            if (persLogic.ExisteUs(this.txtUsuario.Text))
            {
                per = persLogic.GetOne(this.txtUsuario.Text);
                if (per.Clave == this.txtPass.Text)
                {
                    if (per.Habilitado)
                    {
                        Program.UsuarioSesion = per;
                        this.DialogResult = DialogResult.OK;
                    }
                    else { MessageBox.Show("Usuario no habilitado", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("Usuario y/o contraseña incorrectos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("Usuario y/o contraseña incorrectos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void lnkOlvidaPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Trate de recordar su clave, por el momento no contamos con el servicio de recuperación de clave", "Olvidé mi contraseña",
        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
        
    }
}
