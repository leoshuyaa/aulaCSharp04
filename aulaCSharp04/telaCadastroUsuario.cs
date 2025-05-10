using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aulaCSharp04
{
    public partial class telaCadastroUsuario : Form
    {
        public telaCadastroUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void validaTipoUsuario()
        {
            int tipoUsuario = comboTipoUsuario.SelectedIndex;
            //0 = Usuário do Sistema
            //1 - Cliente

            if (tipoUsuario == 1)
            {
                this.groupSenha.Hide();
                this.groupConfirmarSenha.Hide();
                this.groupNome.Text = "Nome do Cliente";
            }
            else
            {
                this.groupSenha.Show();
                this.groupConfirmarSenha.Show();
                this.groupNome.Text = "Nome do Usuário";
            }
        }

        private void comboTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            validaTipoUsuario();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void telaCadastroUsuario_Load(object sender, EventArgs e)
        {
            comboTipoUsuario.SelectedIndex = 0;
            validaTipoUsuario();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtDocumento.Clear();
            txtCelular.Clear();
            txtSenha.Clear();
            txtConfirmarSenha.Clear();
            comboTipoUsuario.SelectedIndex = 0;
        }        

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            string campoNome = txtNome.Text;
            string campoEmail = txtEmail.Text;
            string campoDocumento = txtDocumento.Text;
            string campoCelular = txtCelular.Text;
            string campoSenha = txtSenha.Text;
            string campoConfirmarSenha = txtConfirmarSenha.Text;
            int campoTipoUsuario = comboTipoUsuario.SelectedIndex;
            int campoCodigo;
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                campoCodigo = 0;
            }
            else
            {
                campoCodigo = int.Parse(txtCodigo.Text);
            }

            bool cadastroValidado = ValidaCadastro(campoNome: campoNome
                                                  , campoEmail: campoEmail
                                                  , campoDocumento: campoDocumento
                                                  , campoCelular: campoCelular
                                                  , campoSenha: campoSenha
                                                  , campoConfirmarSenha: campoConfirmarSenha
                                                  , campoTipoUsuario: campoTipoUsuario
                                                  , campoCodigo: campoCodigo
                                                  );
            if (cadastroValidado)
            {
                telaLoding telaEmProcessamento = new telaLoding();
                telaEmProcessamento.Visible = true;


                efetuarCadastro(tipoAcao: 1);


                telaEmProcessamento.Visible = false;
            }
            else
            {
            }

        }

        private bool ValidaCadastro( string campoNome
                                   , string campoEmail
                                   , string campoDocumento
                                   , string campoCelular
                                   , string campoSenha
                                   , string campoConfirmarSenha
                                   , int campoTipoUsuario
                                   , int campoCodigo
                                   )
        {
            ToolTip toolTip = new ToolTip();            

            if (string.IsNullOrWhiteSpace(campoNome) ||
                string.IsNullOrWhiteSpace(campoEmail) ||
                string.IsNullOrWhiteSpace(campoDocumento) ||
                string.IsNullOrWhiteSpace(campoCelular)
                 )
            {
                MessageBox.Show("Existem campos sem preenchimento, por favor os revise");
            }

            if (string.IsNullOrWhiteSpace(campoNome))
            {
                txtNome.BackColor = Color.Red;
                txtNome.ForeColor = Color.White;
                toolTip.SetToolTip(txtNome, "O campo Nome não pode estar vazio!");
                toolTip.Show("O campo Nome não pode estar vazio!", txtNome, 0, txtNome.Height, 2000);
                txtNome.Focus();
            }
            // Validação do campo Email
            if (string.IsNullOrWhiteSpace(campoEmail))
            {
                txtEmail.BackColor = Color.Red;
                txtEmail.ForeColor = Color.White;
                toolTip.SetToolTip(txtEmail, "O campo Email não pode estar vazio!");
                toolTip.Show("O campo Email não pode estar vazio!", txtEmail, 0, txtEmail.Height, 2000);
                txtEmail.Focus();
            }

            // Validação do campo Documento
            if (string.IsNullOrWhiteSpace(campoDocumento))
            {
                txtDocumento.BackColor = Color.Red;
                txtDocumento.ForeColor = Color.White;
                toolTip.SetToolTip(txtDocumento, "O campo Documento não pode estar vazio!");
                toolTip.Show("O campo Documento não pode estar vazio!", txtDocumento, 0, txtDocumento.Height, 2000);
                txtDocumento.Focus();
            }

            // Validação do campo Celular
            if (string.IsNullOrWhiteSpace(campoCelular))
            {
                txtCelular.BackColor = Color.Red;
                txtCelular.ForeColor = Color.White;
                toolTip.SetToolTip(txtCelular, "O campo Celular não pode estar vazio!");
                toolTip.Show("O campo Celular não pode estar vazio!", txtCelular, 0, txtCelular.Height, 2000);
                txtCelular.Focus();
            }

            // Validação do campo Senha (apenas para usuários do tipo 1)
            if (campoTipoUsuario == 0 && string.IsNullOrWhiteSpace(campoSenha))
            {
                txtSenha.BackColor = Color.Red;
                txtSenha.ForeColor = Color.White;
                toolTip.SetToolTip(txtSenha, "O campo Senha não pode estar vazio!");
                toolTip.Show("O campo Senha não pode estar vazio!", txtSenha, 0, txtSenha.Height, 2000);
                txtSenha.Focus();
            }

            // Validação do campo Senha (apenas para usuários do tipo 1)
            if (campoTipoUsuario == 0 && string.IsNullOrWhiteSpace(campoConfirmarSenha))
            {
                txtConfirmarSenha.BackColor = Color.Red;
                txtConfirmarSenha.ForeColor = Color.White;
                toolTip.SetToolTip(txtSenha, "O campo Confirmar Senha não pode estar vazio!");
                toolTip.Show("O campo Confirmar Senha não pode estar vazio!", txtConfirmarSenha, 0, txtConfirmarSenha.Height, 2000);
                txtConfirmarSenha.Focus();
            }

            if (string.IsNullOrWhiteSpace(campoNome) ||
                string.IsNullOrWhiteSpace(campoEmail) ||
                string.IsNullOrWhiteSpace(campoDocumento) ||
                string.IsNullOrWhiteSpace(campoCelular)
                 )
            {
                return false;
            }
            if (campoTipoUsuario == 0 && (string.IsNullOrWhiteSpace(campoConfirmarSenha)
                                           || string.IsNullOrWhiteSpace(campoSenha)
                                         )
                )
            {
                MessageBox.Show("Existem campos sem preenchimento, por favor os revise");
            }
            if (campoTipoUsuario == 0 && (string.IsNullOrWhiteSpace(campoConfirmarSenha)
                                           || string.IsNullOrWhiteSpace(campoSenha)
                                         )
                )
            {
                return false;
            }


            if (campoTipoUsuario == 0 && (campoConfirmarSenha != campoSenha))
            {
                MessageBox.Show("Senhas não conferem!");
                txtSenha.Focus();
                return false;
            }

            return true;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text.Length > 0)
            {
                txtNome.BackColor = Color.White;
                txtNome.ForeColor = Color.Black;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length > 0)
            {
                txtEmail.BackColor = Color.White;
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            if (txtDocumento.Text.Length > 0)
            {
                txtDocumento.BackColor = Color.White;
                txtDocumento.ForeColor = Color.Black;
            }
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {
            if (txtCelular.Text.Length > 0)
            {
                txtCelular.BackColor = Color.White;
                txtCelular.ForeColor = Color.Black;
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text.Length > 0)
            {
                txtSenha.BackColor = Color.White;
                txtSenha.ForeColor = Color.Black;
            }
        }

        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmarSenha.Text.Length > 0)
            {
                txtConfirmarSenha.BackColor = Color.White;
                txtConfirmarSenha.ForeColor = Color.Black;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string campoNome = txtNome.Text;
            string campoEmail = txtEmail.Text;
            string campoDocumento = txtDocumento.Text;
            string campoCelular = txtCelular.Text;
            string campoSenha = txtSenha.Text;
            string campoConfirmarSenha = txtConfirmarSenha.Text;
            int campoTipoUsuario = comboTipoUsuario.SelectedIndex;
            int campoCodigo;
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                campoCodigo = 0;
            }
            else
            {
                campoCodigo = int.Parse(txtCodigo.Text);
            }

            bool cadastroValidado = ValidaCadastro(campoNome: campoNome
                                                  , campoEmail: campoEmail
                                                  , campoDocumento: campoDocumento
                                                  , campoCelular: campoCelular
                                                  , campoSenha: campoSenha
                                                  , campoConfirmarSenha: campoConfirmarSenha
                                                  , campoTipoUsuario: campoTipoUsuario
                                                  , campoCodigo: campoCodigo
                                                  );
            if (cadastroValidado)
            {
                efetuarCadastro(tipoAcao: 2);
            }
            else
            {
            }
        }

        private void efetuarCadastro(int tipoAcao)
        {

            MessageBox.Show("OK");
            

        }
    }
}
