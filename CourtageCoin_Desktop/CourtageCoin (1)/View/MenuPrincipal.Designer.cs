namespace CourtageCoin
{
    partial class frmMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.menuClientes = new System.Windows.Forms.MenuStrip();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFunc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnDelFunc = new System.Windows.Forms.Button();
            this.btnAddFunc = new System.Windows.Forms.Button();
            this.btnDelCliente = new System.Windows.Forms.Button();
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.labHora = new System.Windows.Forms.Label();
            this.labNomeData = new System.Windows.Forms.Label();
            this.labData = new System.Windows.Forms.Label();
            this.pbxRelogio = new System.Windows.Forms.PictureBox();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.labNome = new System.Windows.Forms.Label();
            this.labSeparacao2 = new System.Windows.Forms.Label();
            this.pbxFunc = new System.Windows.Forms.PictureBox();
            this.labCargo = new System.Windows.Forms.Label();
            this.labNomeCargo = new System.Windows.Forms.Label();
            this.labSepearacao1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuClientes.SuspendLayout();
            this.pnlTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRelogio)).BeginInit();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // menuClientes
            // 
            this.menuClientes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCliente,
            this.menuFunc,
            this.menuReport,
            this.menuExit});
            this.menuClientes.Location = new System.Drawing.Point(0, 0);
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(770, 24);
            this.menuClientes.TabIndex = 0;
            this.menuClientes.Text = "menuStrip1";
            // 
            // menuCliente
            // 
            this.menuCliente.Image = ((System.Drawing.Image)(resources.GetObject("menuCliente.Image")));
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(73, 20);
            this.menuCliente.Text = "Clientes";
            this.menuCliente.Click += new System.EventHandler(this.menuCliente_Click);
            // 
            // menuFunc
            // 
            this.menuFunc.Image = ((System.Drawing.Image)(resources.GetObject("menuFunc.Image")));
            this.menuFunc.Name = "menuFunc";
            this.menuFunc.Size = new System.Drawing.Size(95, 20);
            this.menuFunc.Text = "Funcionários";
            this.menuFunc.Click += new System.EventHandler(this.menuFunc_Click);
            // 
            // menuReport
            // 
            this.menuReport.Image = ((System.Drawing.Image)(resources.GetObject("menuReport.Image")));
            this.menuReport.Name = "menuReport";
            this.menuReport.Size = new System.Drawing.Size(83, 20);
            this.menuReport.Text = "Relatõrios";
            this.menuReport.Click += new System.EventHandler(this.menuReport_Click);
            // 
            // menuExit
            // 
            this.menuExit.Image = ((System.Drawing.Image)(resources.GetObject("menuExit.Image")));
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(53, 20);
            this.menuExit.Text = "Sair";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click_1);
            // 
            // pnlTopo
            // 
            this.pnlTopo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTopo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlTopo.Controls.Add(this.btnReport);
            this.pnlTopo.Controls.Add(this.btnDelFunc);
            this.pnlTopo.Controls.Add(this.btnAddFunc);
            this.pnlTopo.Controls.Add(this.btnDelCliente);
            this.pnlTopo.Controls.Add(this.btnAddCliente);
            this.pnlTopo.Location = new System.Drawing.Point(1, 27);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(599, 79);
            this.pnlTopo.TabIndex = 1;
            // 
            // btnReport
            // 
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.Location = new System.Drawing.Point(438, 6);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(80, 73);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "v";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnDelFunc
            // 
            this.btnDelFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelFunc.FlatAppearance.BorderSize = 0;
            this.btnDelFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelFunc.Image = ((System.Drawing.Image)(resources.GetObject("btnDelFunc.Image")));
            this.btnDelFunc.Location = new System.Drawing.Point(328, 6);
            this.btnDelFunc.Name = "btnDelFunc";
            this.btnDelFunc.Size = new System.Drawing.Size(80, 73);
            this.btnDelFunc.TabIndex = 3;
            this.btnDelFunc.Text = "v";
            this.btnDelFunc.UseVisualStyleBackColor = true;
            this.btnDelFunc.Click += new System.EventHandler(this.btnDelFunc_Click);
            // 
            // btnAddFunc
            // 
            this.btnAddFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFunc.FlatAppearance.BorderSize = 0;
            this.btnAddFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFunc.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFunc.Image")));
            this.btnAddFunc.Location = new System.Drawing.Point(218, 6);
            this.btnAddFunc.Name = "btnAddFunc";
            this.btnAddFunc.Size = new System.Drawing.Size(80, 73);
            this.btnAddFunc.TabIndex = 2;
            this.btnAddFunc.UseVisualStyleBackColor = true;
            this.btnAddFunc.Click += new System.EventHandler(this.btnAddFunc_Click);
            // 
            // btnDelCliente
            // 
            this.btnDelCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelCliente.FlatAppearance.BorderSize = 0;
            this.btnDelCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnDelCliente.Image")));
            this.btnDelCliente.Location = new System.Drawing.Point(113, 6);
            this.btnDelCliente.Name = "btnDelCliente";
            this.btnDelCliente.Size = new System.Drawing.Size(80, 73);
            this.btnDelCliente.TabIndex = 1;
            this.btnDelCliente.UseVisualStyleBackColor = true;
            this.btnDelCliente.Click += new System.EventHandler(this.btnDelCliente_Click);
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCliente.FlatAppearance.BorderSize = 0;
            this.btnAddCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCliente.Image")));
            this.btnAddCliente.Location = new System.Drawing.Point(18, 6);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(80, 73);
            this.btnAddCliente.TabIndex = 0;
            this.btnAddCliente.UseVisualStyleBackColor = true;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // labHora
            // 
            this.labHora.AutoSize = true;
            this.labHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labHora.Location = new System.Drawing.Point(79, 34);
            this.labHora.Name = "labHora";
            this.labHora.Size = new System.Drawing.Size(103, 29);
            this.labHora.TabIndex = 0;
            this.labHora.Text = "13:15:00";
            // 
            // labNomeData
            // 
            this.labNomeData.AutoSize = true;
            this.labNomeData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNomeData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labNomeData.Location = new System.Drawing.Point(10, 91);
            this.labNomeData.Name = "labNomeData";
            this.labNomeData.Size = new System.Drawing.Size(53, 22);
            this.labNomeData.TabIndex = 0;
            this.labNomeData.Text = "Data:";
            this.labNomeData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labData
            // 
            this.labData.AutoSize = true;
            this.labData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labData.Location = new System.Drawing.Point(65, 92);
            this.labData.Name = "labData";
            this.labData.Size = new System.Drawing.Size(100, 22);
            this.labData.TabIndex = 1;
            this.labData.Text = "13/04/2009";
            // 
            // pbxRelogio
            // 
            this.pbxRelogio.BackColor = System.Drawing.Color.Transparent;
            this.pbxRelogio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxRelogio.Image = ((System.Drawing.Image)(resources.GetObject("pbxRelogio.Image")));
            this.pbxRelogio.Location = new System.Drawing.Point(10, 14);
            this.pbxRelogio.Name = "pbxRelogio";
            this.pbxRelogio.Size = new System.Drawing.Size(64, 65);
            this.pbxRelogio.TabIndex = 2;
            this.pbxRelogio.TabStop = false;
            // 
            // pnlRight
            // 
            this.pnlRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRight.BackColor = System.Drawing.Color.DimGray;
            this.pnlRight.Controls.Add(this.labNome);
            this.pnlRight.Controls.Add(this.labSeparacao2);
            this.pnlRight.Controls.Add(this.pbxFunc);
            this.pnlRight.Controls.Add(this.labCargo);
            this.pnlRight.Controls.Add(this.labNomeCargo);
            this.pnlRight.Controls.Add(this.labSepearacao1);
            this.pnlRight.Controls.Add(this.pbxRelogio);
            this.pnlRight.Controls.Add(this.labData);
            this.pnlRight.Controls.Add(this.labNomeData);
            this.pnlRight.Controls.Add(this.labHora);
            this.pnlRight.Location = new System.Drawing.Point(545, 27);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(225, 359);
            this.pnlRight.TabIndex = 2;
            // 
            // labNome
            // 
            this.labNome.AutoSize = true;
            this.labNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labNome.Location = new System.Drawing.Point(70, 165);
            this.labNome.Name = "labNome";
            this.labNome.Size = new System.Drawing.Size(134, 18);
            this.labNome.TabIndex = 8;
            this.labNome.Text = "Guilherme Griscioli";
            // 
            // labSeparacao2
            // 
            this.labSeparacao2.AutoSize = true;
            this.labSeparacao2.BackColor = System.Drawing.Color.Transparent;
            this.labSeparacao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSeparacao2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labSeparacao2.Location = new System.Drawing.Point(6, 243);
            this.labSeparacao2.Name = "labSeparacao2";
            this.labSeparacao2.Size = new System.Drawing.Size(240, 22);
            this.labSeparacao2.TabIndex = 7;
            this.labSeparacao2.Text = "_______________________";
            this.labSeparacao2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbxFunc
            // 
            this.pbxFunc.BackColor = System.Drawing.Color.Transparent;
            this.pbxFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxFunc.Image = ((System.Drawing.Image)(resources.GetObject("pbxFunc.Image")));
            this.pbxFunc.Location = new System.Drawing.Point(10, 138);
            this.pbxFunc.Name = "pbxFunc";
            this.pbxFunc.Size = new System.Drawing.Size(64, 65);
            this.pbxFunc.TabIndex = 6;
            this.pbxFunc.TabStop = false;
            // 
            // labCargo
            // 
            this.labCargo.AutoSize = true;
            this.labCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labCargo.Location = new System.Drawing.Point(70, 221);
            this.labCargo.Name = "labCargo";
            this.labCargo.Size = new System.Drawing.Size(99, 18);
            this.labCargo.TabIndex = 5;
            this.labCargo.Text = "Administrador";
            // 
            // labNomeCargo
            // 
            this.labNomeCargo.AutoSize = true;
            this.labNomeCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNomeCargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labNomeCargo.Location = new System.Drawing.Point(14, 221);
            this.labNomeCargo.Name = "labNomeCargo";
            this.labNomeCargo.Size = new System.Drawing.Size(53, 18);
            this.labNomeCargo.TabIndex = 4;
            this.labNomeCargo.Text = "Cargo:";
            this.labNomeCargo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labSepearacao1
            // 
            this.labSepearacao1.AutoSize = true;
            this.labSepearacao1.BackColor = System.Drawing.Color.Transparent;
            this.labSepearacao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSepearacao1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labSepearacao1.Location = new System.Drawing.Point(-15, 113);
            this.labSepearacao1.Name = "labSepearacao1";
            this.labSepearacao1.Size = new System.Drawing.Size(240, 22);
            this.labSepearacao1.TabIndex = 3;
            this.labSepearacao1.Text = "_______________________";
            this.labSepearacao1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(770, 385);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlTopo);
            this.Controls.Add(this.menuClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuClientes;
            this.MaximizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.Text = "|Courtage Coin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.Resize += new System.EventHandler(this.frmMenuPrincipal_Resize);
            this.menuClientes.ResumeLayout(false);
            this.menuClientes.PerformLayout();
            this.pnlTopo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxRelogio)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuClientes;
        private System.Windows.Forms.ToolStripMenuItem menuFunc;
        private System.Windows.Forms.ToolStripMenuItem menuReport;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Button btnAddCliente;
        private System.Windows.Forms.Button btnDelCliente;
        private System.Windows.Forms.Button btnDelFunc;
        private System.Windows.Forms.Button btnAddFunc;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label labHora;
        private System.Windows.Forms.Label labNomeData;
        private System.Windows.Forms.Label labData;
        private System.Windows.Forms.PictureBox pbxRelogio;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label labSepearacao1;
        private System.Windows.Forms.Label labSeparacao2;
        private System.Windows.Forms.PictureBox pbxFunc;
        private System.Windows.Forms.Label labCargo;
        private System.Windows.Forms.Label labNomeCargo;
        private System.Windows.Forms.Label labNome;
        private System.Windows.Forms.ToolStripMenuItem menuCliente;
        private System.Windows.Forms.Timer timer1;
    }
}