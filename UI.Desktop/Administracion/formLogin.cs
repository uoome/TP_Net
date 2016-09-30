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
            UsuarioLogic usLogic = new UsuarioLogic();
            Usuario usr;

            //La propiedad Text de los TextBox contiene el texto escrito en ellos
            if (usLogic.ExisteUs(this.txtUsuario.Text))
            {
                usr= usLogic.GetOne(this.txtUsuario.Text);
                if (usr.Clave == this.txtPass.Text)
                {
                    this.DialogResult = DialogResult.OK;
                    Usuarios users = new Usuarios();
                    users.ShowDialog();
                    users.Listar();
                }

            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Login"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lnkOlvidaPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Es Ud. un usuario muy descuidado, haga memoria", "Olvidé mi contraseña",
        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
        
    }
}
