namespace aulaCSharp04
{
    public partial class telaLogin : Form
    {
        public telaLogin()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            string loginUsuario = txtLogin.Text;
            string senhaUsuario = txtSenha.Text;

            string loginTeste = "lhrp";
            string senhaTeste = "3595";

            if (loginUsuario == loginTeste && senhaUsuario == senhaTeste)
            {
                telaPrincipal telaMenu = new telaPrincipal();
                this.Hide();
                telaMenu.WindowState = FormWindowState.Maximized;
                telaMenu.Show();
            }
            else
            {
                MessageBox.Show("Login ou senha incorretos");
            }
        }

        private void telaLogin_Load(object sender, EventArgs e)
        {
            txtLogin.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            telaLoding telaEmProcessamento = new telaLoding();
            telaEmProcessamento.Visible = true;

            


            telaEmProcessamento.Visible = false;
        }
    }
}
