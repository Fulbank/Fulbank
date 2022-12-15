﻿using projet_Fulbank.Class;
using projet_Fulbank.Class.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_Fulbank
{
    public partial class Conversion : Form
    {
        public Conversion()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label13.Text = Connexion.lastName;
            label14.Text = Connexion.accountNumber.ToString();
            var listeCryptocrurrencies = AppelsAPI.RequeteAPI();
            foreach (var currency in listeCryptocrurrencies.data) //une boucle pour ajouter 3 cryptomonnaies qu'on va gerer dans la liste 
            {
                lstCrypto.Items.Add(currency.name.ToString());
            }
            lstCrypto.SelectedIndex = 0; //nous y mettons une valeur par default 
        }

        private void retour_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new Menu();
            menu.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void convertir_Click(object sender, EventArgs e)
        {
            Regex check = new Regex("^[\\d,]+$");
            if (check.IsMatch(nbConvert.Text.ToString()))
            {
                int user = UserManager.getUser().getId();
                float amount = AppelsAPI.RequeteAPI().data[lstCrypto.SelectedIndex].priceUsd * float.Parse(nbConvert.Text);
                amountAfter.Text = amount.ToString();
                MessageBox.Show("Opération éffectuée");
            }
            else
            {
                MessageBox.Show("Valeur invalide");
                nbConvert.Text = "0";
            }


        }
    }
}
