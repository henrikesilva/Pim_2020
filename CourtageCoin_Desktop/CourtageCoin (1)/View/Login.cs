using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CourtageCoin
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            pnlLogin.Visible = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width / 2 - 166, this.Height / 2 - 170);
            pnlLogin.Visible = true;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 47, 131);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            chamarLogin();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                chamarLogin();
            }
        }

        private void chamarLogin() 
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Preencha o usuário.");
                txtUsuario.Focus();
                return;
            }

            if (txtSenha.Text == "")
            {
                MessageBox.Show("Preencha a senha.");
                txtUsuario.Focus();
                return;
            }

            //Aqui vai o código para o login

            frmMenuPrincipal form = new frmMenuPrincipal();
           // this.Hide();
            Limpar();
            form.Show();
        }

        private void Limpar()
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtUsuario.Focus();
        }

        private void frmLogin_Resize(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width / 2 - 166, this.Height / 2 - 170);
        }
    }
}
