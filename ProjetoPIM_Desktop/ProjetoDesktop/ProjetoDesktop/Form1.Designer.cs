namespace ProjetoDesktop
{
    partial class frmProjetoDesktop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjetoDesktop));
            panel_Login = new Panel();
            pictureBox3 = new PictureBox();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            pictureBox2 = new PictureBox();
            TelaLogin = new Panel();
            pictureBox1 = new PictureBox();
            TelaDashboard_Adm = new Panel();
            Dashboard = new Panel();
            lblChmSemanais = new Label();
            lblDashboard = new Label();
            MenuLateral = new Panel();
            pnlBotoes = new Panel();
            btnUsuarios = new Button();
            btnCdsUsuario = new Button();
            btnChmResolvido = new Button();
            btnChmPendente = new Button();
            btnDashboard = new Button();
            pnlSair = new Panel();
            btnSair = new Button();
            Cabecalho02 = new Panel();
            CabecalhoCentralTec = new Panel();
            lblCentralTec = new Label();
            panel_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            TelaLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            TelaDashboard_Adm.SuspendLayout();
            Dashboard.SuspendLayout();
            MenuLateral.SuspendLayout();
            pnlBotoes.SuspendLayout();
            pnlSair.SuspendLayout();
            CabecalhoCentralTec.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Login
            // 
            panel_Login.BackColor = Color.White;
            panel_Login.Controls.Add(pictureBox3);
            panel_Login.Controls.Add(txtSenha);
            panel_Login.Controls.Add(txtUsuario);
            panel_Login.Controls.Add(pictureBox2);
            panel_Login.Location = new Point(1222, 278);
            panel_Login.Name = "panel_Login";
            panel_Login.Size = new Size(437, 524);
            panel_Login.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(148, 456);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(185, 45);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Left;
            txtSenha.BackColor = Color.FromArgb(199, 211, 228);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.Black;
            txtSenha.ImeMode = ImeMode.NoControl;
            txtSenha.Location = new Point(20, 324);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(397, 25);
            txtSenha.TabIndex = 6;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Left;
            txtUsuario.BackColor = Color.FromArgb(199, 211, 228);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.ImeMode = ImeMode.NoControl;
            txtUsuario.Location = new Point(20, 230);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(397, 25);
            txtUsuario.TabIndex = 4;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            txtUsuario.KeyPress += txtUsuario_KeyPress;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(437, 524);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // TelaLogin
            // 
            TelaLogin.BackColor = Color.FromArgb(11, 35, 65);
            TelaLogin.Controls.Add(panel_Login);
            TelaLogin.Controls.Add(pictureBox1);
            TelaLogin.Location = new Point(1, 0);
            TelaLogin.Name = "TelaLogin";
            TelaLogin.Size = new Size(1904, 1045);
            TelaLogin.TabIndex = 1;
            TelaLogin.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(949, 1045);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // TelaDashboard_Adm
            // 
            TelaDashboard_Adm.Controls.Add(Dashboard);
            TelaDashboard_Adm.Controls.Add(MenuLateral);
            TelaDashboard_Adm.Controls.Add(Cabecalho02);
            TelaDashboard_Adm.Controls.Add(CabecalhoCentralTec);
            TelaDashboard_Adm.Location = new Point(0, 0);
            TelaDashboard_Adm.Name = "TelaDashboard_Adm";
            TelaDashboard_Adm.Size = new Size(1905, 1042);
            TelaDashboard_Adm.TabIndex = 2;
            // 
            // Dashboard
            // 
            Dashboard.Controls.Add(lblChmSemanais);
            Dashboard.Controls.Add(lblDashboard);
            Dashboard.Dock = DockStyle.Fill;
            Dashboard.Location = new Point(200, 60);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(1705, 982);
            Dashboard.TabIndex = 3;
            // 
            // lblChmSemanais
            // 
            lblChmSemanais.Font = new Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChmSemanais.Location = new Point(709, 140);
            lblChmSemanais.Name = "lblChmSemanais";
            lblChmSemanais.Size = new Size(283, 38);
            lblChmSemanais.TabIndex = 1;
            lblChmSemanais.Text = "Chamados Semanais";
            // 
            // lblDashboard
            // 
            lblDashboard.Font = new Font("Poppins SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(29, 15);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(175, 40);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Dashboard";
            // 
            // MenuLateral
            // 
            MenuLateral.BackColor = Color.FromArgb(45, 45, 45);
            MenuLateral.Controls.Add(pnlBotoes);
            MenuLateral.Controls.Add(pnlSair);
            MenuLateral.Dock = DockStyle.Left;
            MenuLateral.Location = new Point(0, 60);
            MenuLateral.Name = "MenuLateral";
            MenuLateral.Padding = new Padding(0, 10, 0, 0);
            MenuLateral.Size = new Size(200, 982);
            MenuLateral.TabIndex = 2;
            // 
            // pnlBotoes
            // 
            pnlBotoes.Controls.Add(btnUsuarios);
            pnlBotoes.Controls.Add(btnCdsUsuario);
            pnlBotoes.Controls.Add(btnChmResolvido);
            pnlBotoes.Controls.Add(btnChmPendente);
            pnlBotoes.Controls.Add(btnDashboard);
            pnlBotoes.Dock = DockStyle.Left;
            pnlBotoes.Location = new Point(0, 10);
            pnlBotoes.Name = "pnlBotoes";
            pnlBotoes.Size = new Size(200, 932);
            pnlBotoes.TabIndex = 7;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.Transparent;
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderColor = Color.DimGray;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnUsuarios.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Poppins SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Location = new Point(0, 160);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(200, 40);
            btnUsuarios.TabIndex = 4;
            btnUsuarios.Text = "Usuários";
            btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnCdsUsuario
            // 
            btnCdsUsuario.BackColor = Color.Transparent;
            btnCdsUsuario.Dock = DockStyle.Top;
            btnCdsUsuario.FlatAppearance.BorderColor = Color.DimGray;
            btnCdsUsuario.FlatAppearance.BorderSize = 0;
            btnCdsUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnCdsUsuario.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            btnCdsUsuario.FlatStyle = FlatStyle.Flat;
            btnCdsUsuario.Font = new Font("Poppins SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCdsUsuario.ForeColor = Color.White;
            btnCdsUsuario.Location = new Point(0, 120);
            btnCdsUsuario.Name = "btnCdsUsuario";
            btnCdsUsuario.Size = new Size(200, 40);
            btnCdsUsuario.TabIndex = 3;
            btnCdsUsuario.Text = "Cadastro de Usuário";
            btnCdsUsuario.UseVisualStyleBackColor = false;
            // 
            // btnChmResolvido
            // 
            btnChmResolvido.BackColor = Color.Transparent;
            btnChmResolvido.Dock = DockStyle.Top;
            btnChmResolvido.FlatAppearance.BorderColor = Color.DimGray;
            btnChmResolvido.FlatAppearance.BorderSize = 0;
            btnChmResolvido.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnChmResolvido.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            btnChmResolvido.FlatStyle = FlatStyle.Flat;
            btnChmResolvido.Font = new Font("Poppins SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChmResolvido.ForeColor = Color.White;
            btnChmResolvido.Location = new Point(0, 80);
            btnChmResolvido.Name = "btnChmResolvido";
            btnChmResolvido.Size = new Size(200, 40);
            btnChmResolvido.TabIndex = 2;
            btnChmResolvido.Text = "Chamados Resolvidos";
            btnChmResolvido.UseVisualStyleBackColor = false;
            // 
            // btnChmPendente
            // 
            btnChmPendente.BackColor = Color.Transparent;
            btnChmPendente.Dock = DockStyle.Top;
            btnChmPendente.FlatAppearance.BorderColor = Color.DimGray;
            btnChmPendente.FlatAppearance.BorderSize = 0;
            btnChmPendente.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnChmPendente.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            btnChmPendente.FlatStyle = FlatStyle.Flat;
            btnChmPendente.Font = new Font("Poppins SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChmPendente.ForeColor = Color.White;
            btnChmPendente.Location = new Point(0, 40);
            btnChmPendente.Name = "btnChmPendente";
            btnChmPendente.Size = new Size(200, 40);
            btnChmPendente.TabIndex = 1;
            btnChmPendente.Text = "Chamados Pendentes";
            btnChmPendente.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderColor = Color.DimGray;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnDashboard.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Poppins SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(200, 40);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // pnlSair
            // 
            pnlSair.Controls.Add(btnSair);
            pnlSair.Dock = DockStyle.Bottom;
            pnlSair.Location = new Point(0, 942);
            pnlSair.Name = "pnlSair";
            pnlSair.Size = new Size(200, 40);
            pnlSair.TabIndex = 6;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Transparent;
            btnSair.Dock = DockStyle.Fill;
            btnSair.FlatAppearance.BorderColor = Color.DimGray;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnSair.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Poppins SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(0, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(200, 40);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            // 
            // Cabecalho02
            // 
            Cabecalho02.BackColor = Color.FromArgb(0, 20, 31);
            Cabecalho02.Dock = DockStyle.Top;
            Cabecalho02.Location = new Point(0, 40);
            Cabecalho02.Name = "Cabecalho02";
            Cabecalho02.Size = new Size(1905, 20);
            Cabecalho02.TabIndex = 1;
            // 
            // CabecalhoCentralTec
            // 
            CabecalhoCentralTec.BackColor = Color.FromArgb(0, 51, 102);
            CabecalhoCentralTec.Controls.Add(lblCentralTec);
            CabecalhoCentralTec.Dock = DockStyle.Top;
            CabecalhoCentralTec.Location = new Point(0, 0);
            CabecalhoCentralTec.Name = "CabecalhoCentralTec";
            CabecalhoCentralTec.Size = new Size(1905, 40);
            CabecalhoCentralTec.TabIndex = 0;
            // 
            // lblCentralTec
            // 
            lblCentralTec.AutoSize = true;
            lblCentralTec.Font = new Font("Poppins SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCentralTec.ForeColor = Color.White;
            lblCentralTec.Location = new Point(12, 6);
            lblCentralTec.Name = "lblCentralTec";
            lblCentralTec.Size = new Size(122, 34);
            lblCentralTec.TabIndex = 0;
            lblCentralTec.Text = "CentralTec";
            // 
            // frmProjetoDesktop
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1370, 749);
            Controls.Add(TelaDashboard_Adm);
            Controls.Add(TelaLogin);
            Location = new Point(0, 253);
            Name = "frmProjetoDesktop";
            Text = "Central Tec";
            WindowState = FormWindowState.Maximized;
            Load += frmProjetoDesktop_Load;
            Click += frmProjetoDesktop_Click;
            panel_Login.ResumeLayout(false);
            panel_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            TelaLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            TelaDashboard_Adm.ResumeLayout(false);
            Dashboard.ResumeLayout(false);
            MenuLateral.ResumeLayout(false);
            pnlBotoes.ResumeLayout(false);
            pnlSair.ResumeLayout(false);
            CabecalhoCentralTec.ResumeLayout(false);
            CabecalhoCentralTec.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Login;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Panel TelaLogin;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel TelaDashboard_Adm;
        private Panel CabecalhoCentralTec;
        private Label lblCentralTec;
        private Panel MenuLateral;
        private Panel Cabecalho02;
        private Button btnDashboard;
        private Button btnChmPendente;
        private Button btnCdsUsuario;
        private Button btnChmResolvido;
        private Button btnUsuarios;
        private Button btnSair;
        private Panel Dashboard;
        private Label lblChmSemanais;
        private Label lblDashboard;
        private Panel pnlBotoes;
        private Panel pnlSair;
    }
}
