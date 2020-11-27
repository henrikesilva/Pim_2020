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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            pnlTopo.BackColor = Color.FromArgb(240, 240, 240);
            pnlRight.BackColor = Color.FromArgb(140, 140, 140);

            labData.Text = DateTime.Today.ToString("dd/MM/yyyy");
            labHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void menuFunc_Click(object sender, EventArgs e)
        {
            View.Cadastros.frmFunc frm = new View.Cadastros.frmFunc();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void menuCliente_Click(object sender, EventArgs e)
        {
            View.Cadastros.frmCliente frm = new View.Cadastros.frmCliente();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void menuReport_Click(object sender, EventArgs e)
        {
            View.Cadastros.frmRelatorio frm = new View.Cadastros.frmRelatorio();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            View.Cadastros.frmCliente frm = new View.Cadastros.frmCliente();
            frm.ShowDialog();
            frm.Dispose();
        }
        

        private void btnDelCliente_Click(object sender, EventArgs e)
        {
            View.Cadastros.frmCliente frm = new View.Cadastros.frmCliente();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnAddFunc_Click(object sender, EventArgs e)
        {
            View.Cadastros.frmFunc frm = new View.Cadastros.frmFunc();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnDelFunc_Click(object sender, EventArgs e)
        {
            View.Cadastros.frmFunc frm = new View.Cadastros.frmFunc();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            View.Cadastros.frmRelatorio frm = new View.Cadastros.frmRelatorio();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void menuExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
