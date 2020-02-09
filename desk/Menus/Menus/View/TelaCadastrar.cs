﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Menus.Model;
using System.Data.SqlClient;
using MaterialSkin.Controls;

namespace Menus
{
    public partial class TelaCadastrar : MaterialForm
    {
        Thread nf;



        public string retorna()
        {
            string emailLogin = txtlogin2.Text;

            return emailLogin;
        }

        public string emailMain;

        public TelaCadastrar()
        {
            InitializeComponent();

        }

        private void GravarUser(string Nome, string Idade, string Sexo, string Email, string Senha, string Facebook, string Google)
        {

            try
            {
                Dados objDados = new Dados();

                objDados.GravarUser(Nome, Idade, Sexo, Email, Senha, Facebook, Google);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Deu ruim" + ex.Message);
            }
        }

        private void SelectUser(string EmailVar)
        {

            try
            {
                Dados objDados = new Dados();

                objDados.SelectUser(EmailVar);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Deu ruim" + ex.Message);
            }
        }

        private void btnconcluir_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pichau\Documents\bancoMain.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM TB_USER WHERE USER_STR_EMAIL='" + txtlogin2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("ERRO\n\n Usuário já existente");
            }
            else
            {
                if (!String.IsNullOrEmpty(txtnome.Text) && !String.IsNullOrEmpty(txtidade.Text) && !String.IsNullOrEmpty(txtsexo.Text) && !String.IsNullOrEmpty(txtlogin2.Text) && !String.IsNullOrEmpty(txtsenha2.Text))
                {
                    Login.Usuario = txtlogin2.Text;

                    GravarUser(txtnome.Text, txtidade.Text, txtsexo.Text, txtlogin2.Text, txtsenha2.Text, "0", "0");

                    emailMain = retorna();

                    SelectUser(retorna());

                    var telaAtual = new TelaCadastrar();

                    var telaMFC = new Telamfc(txtlogin2.Text);

                    telaMFC.Show();


                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Um ou mais campos estão em branco");
                }
            }

        }

        private void TelaCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltarLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TelaLogin().Show();
        }
    }
}
