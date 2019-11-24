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

namespace Menus
{
    public partial class Telamfc : Form
    {

        

        Thread ne;
        public Telamfc(string texto)
        {
            InitializeComponent();

            lbEmailLogin.Text = texto;
        }

        private void btnconcluir_Click(object sender, EventArgs e)
        {
            this.Close();
            ne = new Thread(novoform4);
            ne.SetApartmentState(ApartmentState.STA);
            ne.Start();
        }

        private void novoform4()
        {
            Application.Run(new TelaLogin());
        }

        private void GravarFacul(string EmailUser,string NomeFacul, string NomeCurso, string NomeMateria, string HoraMateria)
        {




            try
            {
                Dados objDados = new Dados();

                objDados.SelectFacul(EmailUser,NomeFacul);

                objDados.SelectCurso(EmailUser, NomeCurso);

                objDados.SelectMateria(EmailUser, NomeMateria, HoraMateria);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Deu ruim" + ex.Message);
            }
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtuniversidade.Text))
            {
                GravarFacul(lbEmailLogin.Text,txtuniversidade.Text,txtcurso.Text, txtmateria1.Text, txthora1.Text);

                this.Close();
                ne = new Thread(novoform5);
                ne.SetApartmentState(ApartmentState.STA);
                ne.Start();
            }

            else
            {
                MessageBox.Show("um ou mais campos estão vazioss");
            }
        }

        private void novoform5()
        {
            Application.Run(new Menuprinc());
        }

        private void Telamfc_Load(object sender, EventArgs e)
        {

        }
    }
}