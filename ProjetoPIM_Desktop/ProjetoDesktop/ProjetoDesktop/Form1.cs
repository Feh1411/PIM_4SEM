namespace ProjetoDesktop
{
    public partial class frmProjetoDesktop : Form
    {
        public frmProjetoDesktop()
        {
            InitializeComponent();

            MenuLateral.Width = 200;
            MenuLateral.Dock = DockStyle.Left;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Bloqueia o Enter
            }
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void frmProjetoDesktop_Load(object sender, EventArgs e)
        {
            MenuLateral.Height = this.ClientSize.Height;
        }

        private void frmProjetoDesktop_Click(object sender, EventArgs e)
        {

        }
    }
}
