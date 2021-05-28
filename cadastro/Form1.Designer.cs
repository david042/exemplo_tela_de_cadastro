
namespace cadastro
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
            this.lbl_cadastro_cliente = new System.Windows.Forms.Label();
            this.btn_indicar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.grp_dados_extras = new System.Windows.Forms.GroupBox();
            this.chk_twitter = new System.Windows.Forms.CheckBox();
            this.chk_facebook = new System.Windows.Forms.CheckBox();
            this.chk_email = new System.Windows.Forms.CheckBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_facebook = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_facebook = new System.Windows.Forms.TextBox();
            this.txt_twitter = new System.Windows.Forms.TextBox();
            this.lbl_twitter = new System.Windows.Forms.Label();
            this.grp_endereco = new System.Windows.Forms.GroupBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.txt_logradouro = new System.Windows.Forms.TextBox();
            this.lbl_logradouro = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.txt_cep = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.grp_dados_pessoais = new System.Windows.Forms.GroupBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.lbl_tel_pessoal = new System.Windows.Forms.Label();
            this.txt_tel_pessoal = new System.Windows.Forms.TextBox();
            this.lbl_tel_residencial = new System.Windows.Forms.Label();
            this.lbl_rg = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.grp_genero = new System.Windows.Forms.GroupBox();
            this.rdo_feminino = new System.Windows.Forms.RadioButton();
            this.rdo_masculino = new System.Windows.Forms.RadioButton();
            this.txt_tel_residencial = new System.Windows.Forms.TextBox();
            this.btn_limpar_img = new System.Windows.Forms.Button();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_rg = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.Imagem = new System.Windows.Forms.PictureBox();
            this.btn_carregar_img = new System.Windows.Forms.Button();
            this.grp_dados_extras.SuspendLayout();
            this.grp_endereco.SuspendLayout();
            this.grp_dados_pessoais.SuspendLayout();
            this.grp_genero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_cadastro_cliente
            // 
            this.lbl_cadastro_cliente.AutoSize = true;
            this.lbl_cadastro_cliente.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cadastro_cliente.ForeColor = System.Drawing.Color.Blue;
            this.lbl_cadastro_cliente.Location = new System.Drawing.Point(214, -2);
            this.lbl_cadastro_cliente.Name = "lbl_cadastro_cliente";
            this.lbl_cadastro_cliente.Size = new System.Drawing.Size(441, 65);
            this.lbl_cadastro_cliente.TabIndex = 0;
            this.lbl_cadastro_cliente.Text = "Cadastro de Cliente";
            // 
            // btn_indicar
            // 
            this.btn_indicar.Location = new System.Drawing.Point(12, 464);
            this.btn_indicar.Name = "btn_indicar";
            this.btn_indicar.Size = new System.Drawing.Size(136, 56);
            this.btn_indicar.TabIndex = 1;
            this.btn_indicar.Text = "Indicar";
            this.btn_indicar.UseVisualStyleBackColor = true;
            this.btn_indicar.Click += new System.EventHandler(this.btn_indicar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(154, 464);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(136, 56);
            this.btn_alterar.TabIndex = 2;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(296, 464);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(136, 56);
            this.btn_consultar.TabIndex = 3;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(438, 464);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(136, 56);
            this.btn_excluir.TabIndex = 4;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(580, 464);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(136, 56);
            this.btn_limpar.TabIndex = 5;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(722, 464);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(136, 56);
            this.btn_sair.TabIndex = 6;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // grp_dados_extras
            // 
            this.grp_dados_extras.Controls.Add(this.chk_twitter);
            this.grp_dados_extras.Controls.Add(this.chk_facebook);
            this.grp_dados_extras.Controls.Add(this.chk_email);
            this.grp_dados_extras.Controls.Add(this.lbl_email);
            this.grp_dados_extras.Controls.Add(this.lbl_facebook);
            this.grp_dados_extras.Controls.Add(this.txt_email);
            this.grp_dados_extras.Controls.Add(this.txt_facebook);
            this.grp_dados_extras.Controls.Add(this.txt_twitter);
            this.grp_dados_extras.Controls.Add(this.lbl_twitter);
            this.grp_dados_extras.Location = new System.Drawing.Point(12, 349);
            this.grp_dados_extras.Name = "grp_dados_extras";
            this.grp_dados_extras.Size = new System.Drawing.Size(846, 109);
            this.grp_dados_extras.TabIndex = 7;
            this.grp_dados_extras.TabStop = false;
            this.grp_dados_extras.Text = "Dados Extras";
            // 
            // chk_twitter
            // 
            this.chk_twitter.AutoSize = true;
            this.chk_twitter.Location = new System.Drawing.Point(757, 82);
            this.chk_twitter.Name = "chk_twitter";
            this.chk_twitter.Size = new System.Drawing.Size(61, 19);
            this.chk_twitter.TabIndex = 11;
            this.chk_twitter.Text = "Twitter";
            this.chk_twitter.UseVisualStyleBackColor = true;
            this.chk_twitter.CheckedChanged += new System.EventHandler(this.chk_twitter_CheckedChanged);
            // 
            // chk_facebook
            // 
            this.chk_facebook.AutoSize = true;
            this.chk_facebook.Location = new System.Drawing.Point(757, 53);
            this.chk_facebook.Name = "chk_facebook";
            this.chk_facebook.Size = new System.Drawing.Size(77, 19);
            this.chk_facebook.TabIndex = 10;
            this.chk_facebook.Text = "Facebook";
            this.chk_facebook.UseVisualStyleBackColor = true;
            this.chk_facebook.CheckedChanged += new System.EventHandler(this.chk_facebook_CheckedChanged);
            // 
            // chk_email
            // 
            this.chk_email.AutoSize = true;
            this.chk_email.Location = new System.Drawing.Point(757, 24);
            this.chk_email.Name = "chk_email";
            this.chk_email.Size = new System.Drawing.Size(60, 19);
            this.chk_email.TabIndex = 9;
            this.chk_email.Text = "E-mail";
            this.chk_email.UseVisualStyleBackColor = true;
            this.chk_email.CheckedChanged += new System.EventHandler(this.chk_email_CheckedChanged);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(6, 25);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(47, 15);
            this.lbl_email.TabIndex = 8;
            this.lbl_email.Text = "E-mail: ";
            // 
            // lbl_facebook
            // 
            this.lbl_facebook.AutoSize = true;
            this.lbl_facebook.Location = new System.Drawing.Point(6, 54);
            this.lbl_facebook.Name = "lbl_facebook";
            this.lbl_facebook.Size = new System.Drawing.Size(64, 15);
            this.lbl_facebook.TabIndex = 7;
            this.lbl_facebook.Text = "Facebook: ";
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Location = new System.Drawing.Point(76, 22);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(675, 23);
            this.txt_email.TabIndex = 6;
            // 
            // txt_facebook
            // 
            this.txt_facebook.Enabled = false;
            this.txt_facebook.Location = new System.Drawing.Point(76, 51);
            this.txt_facebook.Name = "txt_facebook";
            this.txt_facebook.Size = new System.Drawing.Size(675, 23);
            this.txt_facebook.TabIndex = 5;
            // 
            // txt_twitter
            // 
            this.txt_twitter.Enabled = false;
            this.txt_twitter.Location = new System.Drawing.Point(76, 80);
            this.txt_twitter.Name = "txt_twitter";
            this.txt_twitter.Size = new System.Drawing.Size(675, 23);
            this.txt_twitter.TabIndex = 4;
            // 
            // lbl_twitter
            // 
            this.lbl_twitter.AutoSize = true;
            this.lbl_twitter.Location = new System.Drawing.Point(6, 83);
            this.lbl_twitter.Name = "lbl_twitter";
            this.lbl_twitter.Size = new System.Drawing.Size(42, 15);
            this.lbl_twitter.TabIndex = 3;
            this.lbl_twitter.Text = "Twitter";
            // 
            // grp_endereco
            // 
            this.grp_endereco.Controls.Add(this.txt_cidade);
            this.grp_endereco.Controls.Add(this.lbl_cidade);
            this.grp_endereco.Controls.Add(this.txt_bairro);
            this.grp_endereco.Controls.Add(this.lbl_bairro);
            this.grp_endereco.Controls.Add(this.txt_logradouro);
            this.grp_endereco.Controls.Add(this.lbl_logradouro);
            this.grp_endereco.Controls.Add(this.lbl_numero);
            this.grp_endereco.Controls.Add(this.lbl_cep);
            this.grp_endereco.Controls.Add(this.txt_cep);
            this.grp_endereco.Controls.Add(this.txt_numero);
            this.grp_endereco.Location = new System.Drawing.Point(12, 263);
            this.grp_endereco.Name = "grp_endereco";
            this.grp_endereco.Size = new System.Drawing.Size(846, 80);
            this.grp_endereco.TabIndex = 0;
            this.grp_endereco.TabStop = false;
            this.grp_endereco.Text = "Endereço";
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(568, 51);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(272, 23);
            this.txt_cidade.TabIndex = 9;
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Location = new System.Drawing.Point(512, 54);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(50, 15);
            this.lbl_cidade.TabIndex = 8;
            this.lbl_cidade.Text = "Cidade: ";
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(237, 51);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(272, 23);
            this.txt_bairro.TabIndex = 7;
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Location = new System.Drawing.Point(187, 54);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(44, 15);
            this.lbl_bairro.TabIndex = 6;
            this.lbl_bairro.Text = "Bairro: ";
            // 
            // txt_logradouro
            // 
            this.txt_logradouro.Location = new System.Drawing.Point(268, 22);
            this.txt_logradouro.Name = "txt_logradouro";
            this.txt_logradouro.Size = new System.Drawing.Size(572, 23);
            this.txt_logradouro.TabIndex = 5;
            // 
            // lbl_logradouro
            // 
            this.lbl_logradouro.AutoSize = true;
            this.lbl_logradouro.Location = new System.Drawing.Point(187, 25);
            this.lbl_logradouro.Name = "lbl_logradouro";
            this.lbl_logradouro.Size = new System.Drawing.Size(75, 15);
            this.lbl_logradouro.TabIndex = 4;
            this.lbl_logradouro.Text = "Logradouro: ";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(6, 54);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(57, 15);
            this.lbl_numero.TabIndex = 3;
            this.lbl_numero.Text = "Número: ";
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Location = new System.Drawing.Point(6, 25);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(34, 15);
            this.lbl_cep.TabIndex = 2;
            this.lbl_cep.Text = "CEP: ";
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(46, 22);
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(135, 23);
            this.txt_cep.TabIndex = 1;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(69, 51);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(112, 23);
            this.txt_numero.TabIndex = 0;
            // 
            // grp_dados_pessoais
            // 
            this.grp_dados_pessoais.Controls.Add(this.lbl_cpf);
            this.grp_dados_pessoais.Controls.Add(this.txt_cpf);
            this.grp_dados_pessoais.Controls.Add(this.lbl_tel_pessoal);
            this.grp_dados_pessoais.Controls.Add(this.txt_tel_pessoal);
            this.grp_dados_pessoais.Controls.Add(this.lbl_tel_residencial);
            this.grp_dados_pessoais.Controls.Add(this.lbl_rg);
            this.grp_dados_pessoais.Controls.Add(this.lbl_nome);
            this.grp_dados_pessoais.Controls.Add(this.lbl_codigo);
            this.grp_dados_pessoais.Controls.Add(this.grp_genero);
            this.grp_dados_pessoais.Controls.Add(this.txt_tel_residencial);
            this.grp_dados_pessoais.Controls.Add(this.btn_limpar_img);
            this.grp_dados_pessoais.Controls.Add(this.txt_codigo);
            this.grp_dados_pessoais.Controls.Add(this.txt_rg);
            this.grp_dados_pessoais.Controls.Add(this.txt_nome);
            this.grp_dados_pessoais.Controls.Add(this.Imagem);
            this.grp_dados_pessoais.Controls.Add(this.btn_carregar_img);
            this.grp_dados_pessoais.Location = new System.Drawing.Point(12, 66);
            this.grp_dados_pessoais.Name = "grp_dados_pessoais";
            this.grp_dados_pessoais.Size = new System.Drawing.Size(846, 191);
            this.grp_dados_pessoais.TabIndex = 0;
            this.grp_dados_pessoais.TabStop = false;
            this.grp_dados_pessoais.Text = "Dados Pessoais";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(278, 83);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(34, 15);
            this.lbl_cpf.TabIndex = 24;
            this.lbl_cpf.Text = "CPF: ";
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(318, 80);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(217, 23);
            this.txt_cpf.TabIndex = 23;
            // 
            // lbl_tel_pessoal
            // 
            this.lbl_tel_pessoal.AutoSize = true;
            this.lbl_tel_pessoal.Location = new System.Drawing.Point(286, 112);
            this.lbl_tel_pessoal.Name = "lbl_tel_pessoal";
            this.lbl_tel_pessoal.Size = new System.Drawing.Size(72, 15);
            this.lbl_tel_pessoal.TabIndex = 22;
            this.lbl_tel_pessoal.Text = "Tel. Pessoal: ";
            // 
            // txt_tel_pessoal
            // 
            this.txt_tel_pessoal.Location = new System.Drawing.Point(364, 109);
            this.txt_tel_pessoal.Name = "txt_tel_pessoal";
            this.txt_tel_pessoal.Size = new System.Drawing.Size(171, 23);
            this.txt_tel_pessoal.TabIndex = 21;
            // 
            // lbl_tel_residencial
            // 
            this.lbl_tel_residencial.AutoSize = true;
            this.lbl_tel_residencial.Location = new System.Drawing.Point(6, 112);
            this.lbl_tel_residencial.Name = "lbl_tel_residencial";
            this.lbl_tel_residencial.Size = new System.Drawing.Size(92, 15);
            this.lbl_tel_residencial.TabIndex = 20;
            this.lbl_tel_residencial.Text = "Tel. Residencial: ";
            // 
            // lbl_rg
            // 
            this.lbl_rg.AutoSize = true;
            this.lbl_rg.Location = new System.Drawing.Point(6, 83);
            this.lbl_rg.Name = "lbl_rg";
            this.lbl_rg.Size = new System.Drawing.Size(28, 15);
            this.lbl_rg.TabIndex = 19;
            this.lbl_rg.Text = "RG: ";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(6, 54);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(46, 15);
            this.lbl_nome.TabIndex = 18;
            this.lbl_nome.Text = "Nome: ";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(6, 25);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(52, 15);
            this.lbl_codigo.TabIndex = 17;
            this.lbl_codigo.Text = "Código: ";
            // 
            // grp_genero
            // 
            this.grp_genero.Controls.Add(this.rdo_feminino);
            this.grp_genero.Controls.Add(this.rdo_masculino);
            this.grp_genero.Location = new System.Drawing.Point(6, 138);
            this.grp_genero.Name = "grp_genero";
            this.grp_genero.Size = new System.Drawing.Size(175, 47);
            this.grp_genero.TabIndex = 16;
            this.grp_genero.TabStop = false;
            this.grp_genero.Text = "Sexo";
            // 
            // rdo_feminino
            // 
            this.rdo_feminino.AutoSize = true;
            this.rdo_feminino.Location = new System.Drawing.Point(92, 22);
            this.rdo_feminino.Name = "rdo_feminino";
            this.rdo_feminino.Size = new System.Drawing.Size(75, 19);
            this.rdo_feminino.TabIndex = 1;
            this.rdo_feminino.Text = "Feminino";
            this.rdo_feminino.UseVisualStyleBackColor = true;
            // 
            // rdo_masculino
            // 
            this.rdo_masculino.AutoSize = true;
            this.rdo_masculino.Checked = true;
            this.rdo_masculino.Location = new System.Drawing.Point(6, 22);
            this.rdo_masculino.Name = "rdo_masculino";
            this.rdo_masculino.Size = new System.Drawing.Size(80, 19);
            this.rdo_masculino.TabIndex = 0;
            this.rdo_masculino.TabStop = true;
            this.rdo_masculino.Text = "Masculino";
            this.rdo_masculino.UseVisualStyleBackColor = true;
            // 
            // txt_tel_residencial
            // 
            this.txt_tel_residencial.Location = new System.Drawing.Point(104, 109);
            this.txt_tel_residencial.Name = "txt_tel_residencial";
            this.txt_tel_residencial.Size = new System.Drawing.Size(171, 23);
            this.txt_tel_residencial.TabIndex = 14;
            // 
            // btn_limpar_img
            // 
            this.btn_limpar_img.Location = new System.Drawing.Point(710, 107);
            this.btn_limpar_img.Name = "btn_limpar_img";
            this.btn_limpar_img.Size = new System.Drawing.Size(130, 78);
            this.btn_limpar_img.TabIndex = 1;
            this.btn_limpar_img.Text = "Limpar Imagem";
            this.btn_limpar_img.UseVisualStyleBackColor = true;
            this.btn_limpar_img.Click += new System.EventHandler(this.btn_limpar_img_Click);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(58, 22);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(159, 23);
            this.txt_codigo.TabIndex = 12;
            this.txt_codigo.UseWaitCursor = true;
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(58, 80);
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(217, 23);
            this.txt_rg.TabIndex = 13;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(58, 51);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(477, 23);
            this.txt_nome.TabIndex = 15;
            // 
            // Imagem
            // 
            this.Imagem.Image = global::cadastro.Properties.Resources._4d99cb52ecdc6;
            this.Imagem.Location = new System.Drawing.Point(541, 22);
            this.Imagem.Name = "Imagem";
            this.Imagem.Size = new System.Drawing.Size(163, 163);
            this.Imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagem.TabIndex = 2;
            this.Imagem.TabStop = false;
            this.Imagem.Visible = false;
            // 
            // btn_carregar_img
            // 
            this.btn_carregar_img.Location = new System.Drawing.Point(710, 22);
            this.btn_carregar_img.Name = "btn_carregar_img";
            this.btn_carregar_img.Size = new System.Drawing.Size(130, 78);
            this.btn_carregar_img.TabIndex = 0;
            this.btn_carregar_img.Text = "Carregar Imagem";
            this.btn_carregar_img.UseVisualStyleBackColor = true;
            this.btn_carregar_img.Click += new System.EventHandler(this.btn_carregar_img_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 532);
            this.Controls.Add(this.grp_dados_pessoais);
            this.Controls.Add(this.grp_endereco);
            this.Controls.Add(this.grp_dados_extras);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_indicar);
            this.Controls.Add(this.lbl_cadastro_cliente);
            this.Name = "Form1";
            this.Text = "Cadastro";
            this.grp_dados_extras.ResumeLayout(false);
            this.grp_dados_extras.PerformLayout();
            this.grp_endereco.ResumeLayout(false);
            this.grp_endereco.PerformLayout();
            this.grp_dados_pessoais.ResumeLayout(false);
            this.grp_dados_pessoais.PerformLayout();
            this.grp_genero.ResumeLayout(false);
            this.grp_genero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cadastro_cliente;
        private System.Windows.Forms.Button btn_indicar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.GroupBox grp_dados_extras;
        private System.Windows.Forms.GroupBox grp_endereco;
        private System.Windows.Forms.GroupBox grp_dados_pessoais;
        private System.Windows.Forms.Button btn_limpar_img;
        private System.Windows.Forms.Button btn_carregar_img;
        private System.Windows.Forms.Label lbl_twitter;
        private System.Windows.Forms.PictureBox Imagem;
        private System.Windows.Forms.CheckBox chk_twitter;
        private System.Windows.Forms.CheckBox chk_facebook;
        private System.Windows.Forms.CheckBox chk_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_facebook;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_facebook;
        private System.Windows.Forms.TextBox txt_twitter;
        private System.Windows.Forms.TextBox txt_cep;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_tel_residencial;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_rg;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.GroupBox grp_genero;
        private System.Windows.Forms.RadioButton rdo_masculino;
        private System.Windows.Forms.RadioButton rdo_feminino;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.Label lbl_tel_residencial;
        private System.Windows.Forms.Label lbl_rg;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Label lbl_tel_pessoal;
        private System.Windows.Forms.TextBox txt_tel_pessoal;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label lbl_bairro;
        private System.Windows.Forms.TextBox txt_logradouro;
        private System.Windows.Forms.Label lbl_logradouro;
    }
}

