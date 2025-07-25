namespace ProjetoDesktop
{
    partial class Form1
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
            panel_Login = new Panel();
            lblCentralTec = new Label();
            lblLogin = new Label();
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            panel_Login.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Login
            // 
            panel_Login.BackColor = Color.FromArgb(16, 43, 78);
            panel_Login.Controls.Add(txtUsuario);
            panel_Login.Controls.Add(label2);
            panel_Login.Controls.Add(label1);
            panel_Login.Controls.Add(lblLogin);
            panel_Login.Controls.Add(lblCentralTec);
            panel_Login.Location = new Point(742, 217);
            panel_Login.Name = "panel_Login";
            panel_Login.Size = new Size(437, 646);
            panel_Login.TabIndex = 0;
            // 
            // lblCentralTec
            // 
            lblCentralTec.Anchor = AnchorStyles.Top;
            lblCentralTec.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCentralTec.ForeColor = Color.White;
            lblCentralTec.Location = new Point(0, 83);
            lblCentralTec.Name = "lblCentralTec";
            lblCentralTec.Size = new Size(437, 65);
            lblCentralTec.TabIndex = 0;
            lblCentralTec.Text = "Central Tec";
            lblCentralTec.TextAlign = ContentAlignment.MiddleCenter;
            lblCentralTec.Click += label1_Click;
            // 
            // lblLogin
            // 
            lblLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(194, 194, 194);
            lblLogin.Location = new Point(-3, 139);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(437, 35);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "LOGIN";
            lblLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(194, 194, 194);
            label1.Location = new Point(23, 247);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "lblUsuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 357);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "lblSenha";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(11, 41, 65);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.ForeColor = SystemColors.Menu;
            txtUsuario.Location = new Point(20, 279);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(397, 16);
            txtUsuario.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 35, 65);
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel_Login);
            Location = new Point(0, 253);
            Name = "Form1";
            Text = "Form1";
            panel_Login.ResumeLayout(false);
            panel_Login.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Login;
        private Label lblCentralTec;
        private Label lblLogin;
        private TextBox txtUsuario;
        private Label label2;
        private Label label1;
    }
}
