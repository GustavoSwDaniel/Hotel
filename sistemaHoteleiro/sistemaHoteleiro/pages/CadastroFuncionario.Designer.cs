namespace sistemaHoteleiro
{
    partial class CadastroFuncionario
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
            this.lbl_cpfInvalido = new System.Windows.Forms.Label();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.lbl_vazio = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.dataN = new System.Windows.Forms.DateTimePicker();
            this.mtxt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_celular = new System.Windows.Forms.MaskedTextBox();
            this.txt_cep = new System.Windows.Forms.TextBox();
            this.txt_sobrenome = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_dataN = new System.Windows.Forms.Label();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.lbl_celular = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_sobrenome = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.title_cadastro = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.lbl_senhac = new System.Windows.Forms.Label();
            this.txt_csenha = new System.Windows.Forms.TextBox();
            this.lbl_senhaI = new System.Windows.Forms.Label();
            this.lbl_salario = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_rua = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_cpfInvalido
            // 
            this.lbl_cpfInvalido.AutoSize = true;
            this.lbl_cpfInvalido.ForeColor = System.Drawing.Color.Red;
            this.lbl_cpfInvalido.Location = new System.Drawing.Point(790, 196);
            this.lbl_cpfInvalido.Name = "lbl_cpfInvalido";
            this.lbl_cpfInvalido.Size = new System.Drawing.Size(69, 13);
            this.lbl_cpfInvalido.TabIndex = 55;
            this.lbl_cpfInvalido.Text = "CPF invalido!";
            this.lbl_cpfInvalido.Visible = false;
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(222, 409);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(100, 20);
            this.txt_estado.TabIndex = 54;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(222, 372);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(100, 20);
            this.txt_cidade.TabIndex = 53;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(39, 413);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(63, 16);
            this.lbl_estado.TabIndex = 52;
            this.lbl_estado.Text = "Estado*";
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cidade.Location = new System.Drawing.Point(39, 376);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(64, 16);
            this.lbl_cidade.TabIndex = 51;
            this.lbl_cidade.Text = "Cidade*";
            // 
            // lbl_vazio
            // 
            this.lbl_vazio.AutoSize = true;
            this.lbl_vazio.ForeColor = System.Drawing.Color.Red;
            this.lbl_vazio.Location = new System.Drawing.Point(252, 356);
            this.lbl_vazio.Name = "lbl_vazio";
            this.lbl_vazio.Size = new System.Drawing.Size(70, 13);
            this.lbl_vazio.TabIndex = 50;
            this.lbl_vazio.Text = "CEP invalido!";
            this.lbl_vazio.Visible = false;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(222, 146);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(275, 20);
            this.txt_email.TabIndex = 47;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(39, 147);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(58, 16);
            this.lbl_email.TabIndex = 46;
            this.lbl_email.Text = "E-mail*";
            // 
            // dataN
            // 
            this.dataN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataN.Location = new System.Drawing.Point(759, 218);
            this.dataN.Name = "dataN";
            this.dataN.Size = new System.Drawing.Size(80, 20);
            this.dataN.TabIndex = 45;
            // 
            // mtxt_cpf
            // 
            this.mtxt_cpf.Location = new System.Drawing.Point(759, 173);
            this.mtxt_cpf.Mask = "000,000,000-00";
            this.mtxt_cpf.Name = "mtxt_cpf";
            this.mtxt_cpf.Size = new System.Drawing.Size(100, 20);
            this.mtxt_cpf.TabIndex = 44;
            // 
            // mtxt_telefone
            // 
            this.mtxt_telefone.Location = new System.Drawing.Point(222, 260);
            this.mtxt_telefone.Mask = "(00) 0000-0000";
            this.mtxt_telefone.Name = "mtxt_telefone";
            this.mtxt_telefone.Size = new System.Drawing.Size(100, 20);
            this.mtxt_telefone.TabIndex = 43;
            // 
            // mtxt_celular
            // 
            this.mtxt_celular.Location = new System.Drawing.Point(222, 299);
            this.mtxt_celular.Mask = "(00) 0 0000-0000";
            this.mtxt_celular.Name = "mtxt_celular";
            this.mtxt_celular.Size = new System.Drawing.Size(100, 20);
            this.mtxt_celular.TabIndex = 42;
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(222, 335);
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(100, 20);
            this.txt_cep.TabIndex = 41;
            this.txt_cep.Leave += new System.EventHandler(this.txt_cep_Leave);
            // 
            // txt_sobrenome
            // 
            this.txt_sobrenome.Location = new System.Drawing.Point(222, 113);
            this.txt_sobrenome.Name = "txt_sobrenome";
            this.txt_sobrenome.Size = new System.Drawing.Size(275, 20);
            this.txt_sobrenome.TabIndex = 40;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(222, 77);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(275, 20);
            this.txt_nome.TabIndex = 39;
            // 
            // lbl_dataN
            // 
            this.lbl_dataN.AutoSize = true;
            this.lbl_dataN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dataN.Location = new System.Drawing.Point(602, 218);
            this.lbl_dataN.Name = "lbl_dataN";
            this.lbl_dataN.Size = new System.Drawing.Size(155, 16);
            this.lbl_dataN.TabIndex = 38;
            this.lbl_dataN.Text = "Data de Nascimento*";
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cep.Location = new System.Drawing.Point(39, 339);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(44, 16);
            this.lbl_cep.TabIndex = 37;
            this.lbl_cep.Text = "CEP*";
            // 
            // lbl_celular
            // 
            this.lbl_celular.AutoSize = true;
            this.lbl_celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_celular.Location = new System.Drawing.Point(39, 300);
            this.lbl_celular.Name = "lbl_celular";
            this.lbl_celular.Size = new System.Drawing.Size(57, 16);
            this.lbl_celular.TabIndex = 35;
            this.lbl_celular.Text = "Celular";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.Location = new System.Drawing.Point(39, 264);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(70, 16);
            this.lbl_telefone.TabIndex = 34;
            this.lbl_telefone.Text = "Telefone";
            // 
            // lbl_sobrenome
            // 
            this.lbl_sobrenome.AutoSize = true;
            this.lbl_sobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sobrenome.Location = new System.Drawing.Point(39, 117);
            this.lbl_sobrenome.Name = "lbl_sobrenome";
            this.lbl_sobrenome.Size = new System.Drawing.Size(94, 16);
            this.lbl_sobrenome.TabIndex = 33;
            this.lbl_sobrenome.Text = "Sobrenome*";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(39, 81);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(55, 16);
            this.lbl_nome.TabIndex = 32;
            this.lbl_nome.Text = "Nome*";
            // 
            // title_cadastro
            // 
            this.title_cadastro.AutoSize = true;
            this.title_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_cadastro.Location = new System.Drawing.Point(69, 16);
            this.title_cadastro.Name = "title_cadastro";
            this.title_cadastro.Size = new System.Drawing.Size(260, 25);
            this.title_cadastro.TabIndex = 56;
            this.title_cadastro.Text = "Cadastro de Funcionarios";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.Location = new System.Drawing.Point(39, 190);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(58, 16);
            this.lbl_senha.TabIndex = 57;
            this.lbl_senha.Text = "Senha*";
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(222, 185);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(140, 20);
            this.txt_senha.TabIndex = 58;
            // 
            // lbl_senhac
            // 
            this.lbl_senhac.AutoSize = true;
            this.lbl_senhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senhac.Location = new System.Drawing.Point(39, 219);
            this.lbl_senhac.Name = "lbl_senhac";
            this.lbl_senhac.Size = new System.Drawing.Size(123, 16);
            this.lbl_senhac.TabIndex = 59;
            this.lbl_senhac.Text = "Confirma Senha*";
            // 
            // txt_csenha
            // 
            this.txt_csenha.Location = new System.Drawing.Point(222, 214);
            this.txt_csenha.Name = "txt_csenha";
            this.txt_csenha.Size = new System.Drawing.Size(140, 20);
            this.txt_csenha.TabIndex = 60;
            this.txt_csenha.Leave += new System.EventHandler(this.txt_csenha_Leave);
            // 
            // lbl_senhaI
            // 
            this.lbl_senhaI.AutoSize = true;
            this.lbl_senhaI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senhaI.ForeColor = System.Drawing.Color.Red;
            this.lbl_senhaI.Location = new System.Drawing.Point(243, 237);
            this.lbl_senhaI.Name = "lbl_senhaI";
            this.lbl_senhaI.Size = new System.Drawing.Size(119, 13);
            this.lbl_senhaI.TabIndex = 61;
            this.lbl_senhaI.Text = "As senha não conferem";
            this.lbl_senhaI.Visible = false;
            // 
            // lbl_salario
            // 
            this.lbl_salario.AutoSize = true;
            this.lbl_salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salario.Location = new System.Drawing.Point(602, 113);
            this.lbl_salario.Name = "lbl_salario";
            this.lbl_salario.Size = new System.Drawing.Size(64, 16);
            this.lbl_salario.TabIndex = 62;
            this.lbl_salario.Text = "Salario*";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(759, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 63;
            this.textBox1.Text = "R$ ";
            // 
            // lbl_rua
            // 
            this.lbl_rua.AutoSize = true;
            this.lbl_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rua.Location = new System.Drawing.Point(602, 74);
            this.lbl_rua.Name = "lbl_rua";
            this.lbl_rua.Size = new System.Drawing.Size(42, 16);
            this.lbl_rua.TabIndex = 64;
            this.lbl_rua.Text = "Rua*";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(759, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 20);
            this.textBox2.TabIndex = 65;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.Location = new System.Drawing.Point(602, 178);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(43, 16);
            this.lbl_cpf.TabIndex = 36;
            this.lbl_cpf.Text = "CPF*";
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargo.Location = new System.Drawing.Point(602, 147);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(56, 16);
            this.lbl_cargo.TabIndex = 66;
            this.lbl_cargo.Text = "Cargo*";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Gerente",
            "Recepcionista",
            "Camareira",
            "Segurança"});
            this.comboBox1.Location = new System.Drawing.Point(759, 141);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 67;
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_limpar.Location = new System.Drawing.Point(933, 548);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 69;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_cadastrar.Location = new System.Drawing.Point(843, 548);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar.TabIndex = 68;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            // 
            // btn_voltar
            // 
            this.btn_voltar.FlatAppearance.BorderSize = 0;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Image = global::sistemaHoteleiro.Properties.Resources.icons8_back_25;
            this.btn_voltar.Location = new System.Drawing.Point(8, 8);
            this.btn_voltar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(32, 41);
            this.btn_voltar.TabIndex = 70;
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // CadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 602);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_cargo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_rua);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_salario);
            this.Controls.Add(this.lbl_senhaI);
            this.Controls.Add(this.txt_csenha);
            this.Controls.Add(this.lbl_senhac);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.title_cadastro);
            this.Controls.Add(this.lbl_cpfInvalido);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.lbl_cidade);
            this.Controls.Add(this.lbl_vazio);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.dataN);
            this.Controls.Add(this.mtxt_cpf);
            this.Controls.Add(this.mtxt_telefone);
            this.Controls.Add(this.mtxt_celular);
            this.Controls.Add(this.txt_cep);
            this.Controls.Add(this.txt_sobrenome);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_dataN);
            this.Controls.Add(this.lbl_cep);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.lbl_celular);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_sobrenome);
            this.Controls.Add(this.lbl_nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroFuncionario";
            this.Text = "CadastroFuncionario";
            this.Load += new System.EventHandler(this.CadastroFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cpfInvalido;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.Label lbl_vazio;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.DateTimePicker dataN;
        private System.Windows.Forms.MaskedTextBox mtxt_cpf;
        private System.Windows.Forms.MaskedTextBox mtxt_telefone;
        private System.Windows.Forms.MaskedTextBox mtxt_celular;
        private System.Windows.Forms.TextBox txt_cep;
        private System.Windows.Forms.TextBox txt_sobrenome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_dataN;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.Label lbl_celular;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_sobrenome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label title_cadastro;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label lbl_senhac;
        private System.Windows.Forms.TextBox txt_csenha;
        private System.Windows.Forms.Label lbl_senhaI;
        private System.Windows.Forms.Label lbl_salario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_rua;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_cargo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_voltar;
    }
}