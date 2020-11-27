using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CourtageCoin.Model.Funcionario;


namespace CourtageCoin.View.Cadastros
{
    public partial class frmFunc : Form
    {
        public String operacao;

        public void alteraBotoes(int op)
        {
            btnInserir.Enabled = false;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = false;
            pnlDados.Enabled = false;

            if (op == 1)
            {
                btnInserir.Enabled = true;

            }
            if (op == 2)
            {
                pnlDados.Enabled = true;
                btnSalvar.Enabled = true;
            }
            if (op == 3)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        public frmFunc()
        {
            InitializeComponent();
        }

        private void frmFunc_Load(object sender, EventArgs e)
        {
             this.alteraBotoes(1);
        }
      
        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            modelFunc modelo = new modelFunc();

            modelo.funcNome = txtNome.Text;
            modelo.funcCPF = mtxtCPF.Text;
            modelo.funcRG = mtxtRG.Text;
            modelo.funcTelefone = mtxtTelefone.Text;
            modelo.funcEmail = txtEmail.Text;
            modelo.funcEndereco = txtEndereco.Text;
            modelo.funcCEP = mtxtCEP.Text;
            modelo.funcCidade = txtCidade.Text;
            modelo.funcEstado = cmbEstado.Text;

            if (txtNome.Text.ToString().Trim() == "")
            {
                txtNome.Text = "";
                MessageBox.Show("Preencha o Nome", "Campo Vazio");
                txtNome.Focus();
                return;
            }

            if (txtEndereco.Text.ToString().Trim() == "")
            {
                txtEndereco.Text = "";
                MessageBox.Show("Preencha o Endereco", "Campo Vazio");
                txtEndereco.Focus();
                return;
            }
            if (txtCidade.Text.ToString().Trim() == "")
            {
                txtCidade.Text = "";
                MessageBox.Show("Preencha a Cidadeo", "Campo Vazio");
                txtCidade.Focus();
                return;
            }
            if (mtxtCPF.Text.ToString().Trim() == "")
            {
                mtxtCPF.Text = "";
                MessageBox.Show("Preencha o CPF", "Campo Vazio");
                mtxtCPF.Focus();
                return;
            }
         
            if (mtxtRG.Text.ToString().Trim() == "")
            {
                mtxtRG.Text = "";
                MessageBox.Show("Preencha o RG", "Campo Vazio");
                mtxtRG.Focus();
                return;
            }
            if (txtEmail.Text.ToString().Trim() == "")
            {
                txtEmail.Text = "";
                MessageBox.Show("Preencha o Emailo", "Campo Vazio");
                txtEmail.Focus();
                return;
            }
            if (cmbEstado.Text.ToString().Trim() == "")
            {
                cmbEstado.Text = "";
                MessageBox.Show("Escolha o Estado", "Campo Vazio");
                cmbEstado.Focus();
                return;
            }
            if (mtxtCEP.Text.ToString().Trim() == "")
            {
                mtxtCEP.Text = "";
                MessageBox.Show("Preencha o CEPo", "Campo Vazio");
                mtxtCEP.Focus();
                return;
            }
            if (mtxtTelefone.Text.ToString().Trim() == "")
            {
                mtxtTelefone.Text = "";
                MessageBox.Show("Preencha o Telefone", "Campo Vazio");
                txtEndereco.Focus();
                return;
            }
        }

        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCPF.Checked == true)
            {
                txtBuscarNome.Visible = false;
            }
            else
            {
                txtBuscarNome.Visible = true;
            }
        }

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNome.Checked == true)
            {
                mtxtBuscarCPF.Visible = false;
            }
            else
            {
                mtxtBuscarCPF.Visible = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
