namespace aulaCSharp04
{
    partial class telaLogin
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
            groupBox1 = new GroupBox();
            txtLogin = new TextBox();
            groupBox2 = new GroupBox();
            txtSenha = new TextBox();
            groupBox3 = new GroupBox();
            btnLimpar = new Button();
            btnRecuperar = new Button();
            btnCadastrar = new Button();
            btnAcessar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLogin);
            groupBox1.Location = new Point(12, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(376, 41);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(6, 17);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Informe seu Login ou E-mail";
            txtLogin.Size = new Size(364, 23);
            txtLogin.TabIndex = 0;
            txtLogin.Text = "lhrp";
            txtLogin.TextChanged += txtLogin_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSenha);
            groupBox2.Location = new Point(12, 110);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(376, 41);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(6, 17);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '¨';
            txtSenha.PlaceholderText = "Informe Sua Senha";
            txtSenha.Size = new Size(364, 23);
            txtSenha.TabIndex = 0;
            txtSenha.Text = "3595";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnLimpar);
            groupBox3.Controls.Add(btnRecuperar);
            groupBox3.Controls.Add(btnCadastrar);
            groupBox3.Controls.Add(btnAcessar);
            groupBox3.Location = new Point(12, 167);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(376, 58);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(295, 12);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 40);
            btnLimpar.TabIndex = 3;
            btnLimpar.Text = "Limpar Campos";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnRecuperar
            // 
            btnRecuperar.Location = new Point(199, 12);
            btnRecuperar.Name = "btnRecuperar";
            btnRecuperar.Size = new Size(75, 40);
            btnRecuperar.TabIndex = 2;
            btnRecuperar.Text = "Recuperar Senha";
            btnRecuperar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(103, 12);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 40);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnAcessar
            // 
            btnAcessar.Location = new Point(6, 12);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(75, 40);
            btnAcessar.TabIndex = 0;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = true;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // telaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 261);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "telaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += telaLogin_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtLogin;
        private GroupBox groupBox2;
        private TextBox txtSenha;
        private GroupBox groupBox3;
        private Button btnLimpar;
        private Button btnRecuperar;
        private Button btnCadastrar;
        private Button btnAcessar;
    }
}
