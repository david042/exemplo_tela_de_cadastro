using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_carregar_img_Click(object sender, EventArgs e)
        {
            Imagem.Visible = true;
        }

        private void btn_limpar_img_Click(object sender, EventArgs e)
        {
            Imagem.Visible = false;
        }

        private void chk_email_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_email.Checked)
            {
                txt_email.Enabled = true;
            }
            if (chk_email.Checked == false)
            {
                txt_email.Text = "";
                txt_email.Enabled = false;
            }
        }

        private void chk_facebook_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_facebook.Checked)
            {
                txt_facebook.Enabled = true;
            }
            if (chk_facebook.Checked == false)
            {
                txt_facebook.Text = "";
                txt_facebook.Enabled = false;
            }
        }

        private void chk_twitter_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_twitter.Checked)
            {
                txt_twitter.Enabled = true;
            }
            if (chk_twitter.Checked == false)
            {
                txt_twitter.Text = "";
                txt_twitter.Enabled = false;
            }

        }

        private void btn_indicar_Click(object sender, EventArgs e)
        {
            txt_codigo.Text = "123456789";
            txt_nome.Text = "Pedro de Alcântara João Carlos Leopoldo Salvador de Habsburgo-Lorena e Bragança";
            txt_rg.Text = "12.345.678-9";
            txt_cpf.Text = "123.456.789-10";
            txt_tel_residencial.Text = "(12) 34567-8910";
            txt_tel_pessoal.Text = "(10) 98765-4321";
            rdo_masculino.Checked = true;
            txt_cep.Text = "12345-678";
            txt_logradouro.Text = "Avenida Carolina Josefa Leopoldina de Habsburgo-Lorena";
            txt_numero.Text = "123";
            txt_bairro.Text = "Bairro José Bonifácio de Andrada e Silva";
            txt_cidade.Text = "São José do Vale do Rio Preto";
            chk_email.Checked = true;
            txt_email.Text = "pedrinho.imperador@gmail.com";
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dados Pessoais\n------------\n" +
                            "Código: " + (txt_codigo.Text != "" ? txt_codigo.Text : "Nenhum Código cadastrado") + "\n" +
                            "Nome: " + (txt_nome.Text != "" ? txt_nome.Text : "Nenhum Nome cadastrado") + "\n" +
                            "RG: " + (txt_rg.Text != "" ? txt_rg.Text : "Nenhum RG cadastrado") + "\n" +
                            "CPF: " + (txt_cpf.Text != "" ? txt_cpf.Text : "Nenhum CPF cadastrado") + "\n" +
                            "Telefone Residencial: " + (txt_tel_residencial.Text != "" ? txt_tel_residencial.Text : "Nenhum Telefone Residencial cadastrado") + "\n" +
                            "Telefone Pessoal: " + (txt_tel_pessoal.Text != "" ? txt_tel_pessoal.Text : "Nenhum Telefone Pessoal cadastrado") + "\n" +
                            (rdo_masculino.Checked == true ? "Sexo: " + rdo_masculino.Text : "") +
                            (rdo_feminino.Checked == true ? "Sexo: " + rdo_feminino.Text : "") + "\n\n" +
                            "Endereço\n------------\n" +
                            "CEP: " + (txt_cep.Text != "" ? txt_cep.Text : "Nenhum CEP cadastrado") + "\n" +
                            "Logradouro: " + (txt_logradouro.Text != "" ? txt_logradouro.Text : "Nenhum Logradouro cadastrado") + "\n" +
                            "Número: " + (txt_numero.Text != "" ? txt_numero.Text : "Nenhum Número cadastrado") + "\n" +
                            "Bairro: " + (txt_bairro.Text != "" ? txt_bairro.Text : "Nenhum Bairro cadastrado") + "\n" +
                            "Cidade: " + (txt_cidade.Text != "" ? txt_cidade.Text : "Nenhuma Cidade cadastrado") + "\n\n" +
                            "Dados Pessoais\n------------\n" +
                            "E-mail: " + (chk_email.Checked == true ? txt_email.Text : "Nenhum E-mail cadastrado") + "\n" +
                            "Facebook: " + (chk_facebook.Checked == true ? txt_facebook.Text : "Nenhum Facebook cadastrado") + "\n" +
                            "Twitter: " + (chk_twitter.Checked == true ? txt_twitter.Text : "Nenhum Twitter cadastrado"), "Dados cadastrados");
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_codigo.Text = "";
            txt_nome.Text = "";
            txt_rg.Text = "";
            txt_cpf.Text = "";
            txt_tel_residencial.Text = "";
            txt_tel_pessoal.Text = "";
            txt_cep.Text = "";
            txt_logradouro.Text = "";
            txt_numero.Text = "";
            txt_bairro.Text = "";
            txt_cidade.Text = "";
            chk_email.Checked = false;
            chk_facebook.Checked = false;
            chk_twitter.Checked = false;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
