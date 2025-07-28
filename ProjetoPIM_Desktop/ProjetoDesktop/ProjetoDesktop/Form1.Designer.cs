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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel_Login = new Panel();
            pictureBox3 = new PictureBox();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Left;
            txtSenha.BackColor = Color.FromArgb(199, 211, 228);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = SystemColors.Menu;
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
            txtUsuario.ForeColor = SystemColors.Menu;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 35, 65);
            panel1.Location = new Point(945, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 1045);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(949, 1045);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1904, 1041);
            Controls.Add(pictureBox1);
            Controls.Add(panel_Login);
            Controls.Add(panel1);
            Location = new Point(0, 253);
            Name = "Form1";
            Text = "Form1";
            panel_Login.ResumeLayout(false);
            panel_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Login;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
