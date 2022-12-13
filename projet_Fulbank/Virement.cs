﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using projet_Fulbank.Class;
using projet_Fulbank.Class.Model;

namespace projet_Fulbank
{
    public partial class Virement : Form
    {
        Menu menu;
        MySqlConnection pdo = DBConnexion.getConnexion();
        MySqlDataReader reader;
        MySqlCommand command;
        public string lastName;
        public string accountNumber;
        public int SoldAfterSum;
        public Virement()
        {
            InitializeComponent();

        }

        private void return_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new Menu();
            menu.Show();
        }

        private void TransfertSum_TextChanged(object sender, EventArgs e)
        {
            if (TransfertSum.Text == "")
            {
                MessageBox.Show("Veuillez saisir une valeur");
            }
            else if ((deb_current.Checked == true && cred_booklet.Checked == true))
            {
                int retrait = int.Parse(TransfertSum.Text);
                int sold = int.Parse(AccountManager.getSoldeBDD(UserManager.getUser()).ToString());
                test.Text = (sold - retrait).ToString();
            }
            else if (deb_booklet.Checked == true && cred_current.Checked == true)
            {
                int retrait = int.Parse(TransfertSum.Text);
                int sold = int.Parse(AccountManager.getSoldSavings(UserManager.getUser()).ToString());
                test.Text = (sold - retrait).ToString();
            }
        }

        private void Virement_Load(object sender, EventArgs e)
        {
            VirementLastName.Text = Connexion.lastName;
            VirementAccountNumber.Text = Connexion.accountNumber.ToString();
            
            
        }

        private void beneficiary_Click(object sender, EventArgs e)
        {
            this.Hide();
            var beneficiaire = new Beneficiare();
            beneficiaire.Show();
        }
        private void transfert_Click(object sender, EventArgs e)
        {
            if (deb_current.Checked == true && cred_current.Checked == true)
            {
                MessageBox.Show("Cette action est impossible");
            }
            else if (deb_booklet.Checked == true && cred_booklet.Checked == true)
            {
                MessageBox.Show("Cette action est impossible");
            }
            else if (deb_current.Checked == true && cred_booklet.Checked == true)
            {
                OperationManager.TransferCurrentIntoSavings(Convert.ToDouble(TransfertSum.Text));
                OperationManager.setOperationTransfer(Convert.ToDouble(TransfertSum.Text));
                MessageBox.Show("Votre virement a bien été effectuer");
            }
            else if (deb_booklet.Checked == true && cred_current.Checked == true)
            {
                OperationManager.TransfertSavingsIntoCurrent(Convert.ToDouble(TransfertSum.Text));
                OperationManager.setOperationTransferIntoCurrent(Convert.ToDouble(TransfertSum.Text));
                MessageBox.Show("Votre virement a bien été effectuer");
            }

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void titre_Click(object sender, EventArgs e)
        {

        }

        private void deb_current_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void deb_booklet_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void cred_current_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void test_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
