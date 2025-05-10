namespace aulaCSharp04
{
    partial class telaCadastroUsuario
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
            comboTipoUsuario = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtCodigo = new TextBox();
            groupNome = new GroupBox();
            txtNome = new TextBox();
            groupBox4 = new GroupBox();
            txtDocumento = new TextBox();
            groupBox5 = new GroupBox();
            txtEmail = new TextBox();
            groupBox6 = new GroupBox();
            txtCelular = new TextBox();
            btnSair = new Button();
            btnIncluir = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            groupSenha = new GroupBox();
            txtSenha = new TextBox();
            groupConfirmarSenha = new GroupBox();
            txtConfirmarSenha = new TextBox();
            dataGridView1 = new DataGridView();
            btnLimpar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupNome.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupSenha.SuspendLayout();
            groupConfirmarSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboTipoUsuario
            // 
            comboTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipoUsuario.FormattingEnabled = true;
            comboTipoUsuario.Items.AddRange(new object[] { "1-Usuário do Sistema", "2-Cliente" });
            comboTipoUsuario.Location = new Point(6, 22);
            comboTipoUsuario.Name = "comboTipoUsuario";
            comboTipoUsuario.Size = new Size(160, 23);
            comboTipoUsuario.TabIndex = 0;
            comboTipoUsuario.SelectedIndexChanged += comboTipoUsuario_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboTipoUsuario);
            groupBox1.Location = new Point(12, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(172, 51);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de Usuário";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCodigo);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(172, 51);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(6, 22);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(160, 23);
            txtCodigo.TabIndex = 0;
            txtCodigo.TextChanged += textBox1_TextChanged;
            // 
            // groupNome
            // 
            groupNome.Controls.Add(txtNome);
            groupNome.Location = new Point(12, 126);
            groupNome.Name = "groupNome";
            groupNome.Size = new Size(776, 51);
            groupNome.TabIndex = 3;
            groupNome.TabStop = false;
            groupNome.Text = "Nome do";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(6, 22);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(762, 23);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtDocumento);
            groupBox4.Location = new Point(12, 240);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(325, 51);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "CPF/CNPJ";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(6, 22);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(313, 23);
            txtDocumento.TabIndex = 1;
            txtDocumento.TextChanged += txtDocumento_TextChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtEmail);
            groupBox5.Location = new Point(12, 183);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(776, 51);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(6, 22);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(762, 23);
            txtEmail.TabIndex = 2;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtCelular);
            groupBox6.Location = new Point(463, 240);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(325, 51);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "Celular";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(6, 22);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(313, 23);
            txtCelular.TabIndex = 1;
            txtCelular.TextChanged += txtCelular_TextChanged;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(420, 361);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 40);
            btnSair.TabIndex = 6;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(12, 361);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(75, 40);
            btnIncluir.TabIndex = 7;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(109, 361);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 40);
            btnAlterar.TabIndex = 8;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(210, 361);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 40);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // groupSenha
            // 
            groupSenha.Controls.Add(txtSenha);
            groupSenha.Location = new Point(12, 297);
            groupSenha.Name = "groupSenha";
            groupSenha.Size = new Size(325, 51);
            groupSenha.TabIndex = 4;
            groupSenha.TabStop = false;
            groupSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(6, 22);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(313, 23);
            txtSenha.TabIndex = 1;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // groupConfirmarSenha
            // 
            groupConfirmarSenha.Controls.Add(txtConfirmarSenha);
            groupConfirmarSenha.Location = new Point(463, 297);
            groupConfirmarSenha.Name = "groupConfirmarSenha";
            groupConfirmarSenha.Size = new Size(325, 51);
            groupConfirmarSenha.TabIndex = 12;
            groupConfirmarSenha.TabStop = false;
            groupConfirmarSenha.Text = "Confirmar Senha";
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(6, 22);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(313, 23);
            txtConfirmarSenha.TabIndex = 1;
            txtConfirmarSenha.TextChanged += txtConfirmarSenha_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 414);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 189);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(313, 361);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 40);
            btnLimpar.TabIndex = 11;
            btnLimpar.Text = "Limpar Campos";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // telaCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 620);
            Controls.Add(dataGridView1);
            Controls.Add(groupConfirmarSenha);
            Controls.Add(groupSenha);
            Controls.Add(btnLimpar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnIncluir);
            Controls.Add(btnSair);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupNome);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "telaCadastroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "telaCadastroUsuario";
            Load += telaCadastroUsuario_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupNome.ResumeLayout(false);
            groupNome.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupSenha.ResumeLayout(false);
            groupSenha.PerformLayout();
            groupConfirmarSenha.ResumeLayout(false);
            groupConfirmarSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboTipoUsuario;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupNome;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private Button btnSair;
        private Button btnIncluir;
        private Button btnAlterar;
        private Button btnExcluir;
        private TextBox txtCodigo;
        private TextBox txtNome;
        private TextBox txtDocumento;
        private TextBox txtEmail;
        private TextBox txtCelular;
        private GroupBox groupSenha;
        private TextBox txtSenha;
        private GroupBox groupConfirmarSenha;
        private TextBox txtConfirmarSenha;
        private DataGridView dataGridView1;
        private Button btnLimpar;
    }
}