﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class Retrait : Form
    {
        Menu menu;
        MySqlConnection pdo = DBConnexion.getConnexion();
        MySqlDataReader reader;
        MySqlCommand command;
        public string lastName;
        public string accountNumber;
        public Retrait()
        {
            InitializeComponent();
        }

        private void titre_Click(object sender, EventArgs e)
        {

        }

        private void retour_Click(object sender, EventArgs e)
        {
            this.Hide();
           menu= new Menu();
            menu.Show();
           
           
           
        }

        private void SoldText_TextChanged(object sender, EventArgs e)
        {
        }

        private void Retrait_Load(object sender, EventArgs e)
        {
            lastNameLabel.Text = Connexion.lastName;
            accountNumberLabel.Text = Connexion.accountNumber.ToString();
            /* pdo.Open();
             command = pdo.CreateCommand();
             command.CommandText = "SELECT Sold FROM Account A INNER JOIN Person P ON A.idPerson = P.id WHERE P.Login = @login ";

             MySqlParameter param = new MySqlParameter();
             param.ParameterName = "@login";
             param.DbType =DbType.Int64;
             param.Value = Connexion.accountNumber;
             command.Parameters.Add(param);

             reader = command.ExecuteReader();
             reader.Read();
             string solde = reader["Sold"].ToString() + " €";*/
            SoldText.Text = AccountManager.getSoldeBDD(UserManager.getUser()).ToString();
            SoldAfterText.Text = AccountManager.getSoldeBDD(UserManager.getUser()).ToString();
            


        }

        private void SoldAfterText_TextChanged(object sender, EventArgs e)
        {     
        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {
        }

        private void DebiteSumText_TextChanged(object sender, EventArgs e)
        {
            
            if (DebiteSumText.Text == "")
            {
                SoldAfterText.Text = AccountManager.getSoldeBDD(UserManager.getUser()).ToString(); 
                MessageBox.Show("Entrez une valeur");
            }
            else
            {
                int retrait = int.Parse(DebiteSumText.Text);
                int sold = int.Parse(AccountManager.getSoldeBDD(UserManager.getUser()).ToString());
                SoldAfterText.Text = (sold - retrait).ToString();
            }

            pdo.Close();

        }

        private void retirer_Click(object sender, EventArgs e)
        {
            SoldAfterText.Text = OperationManager.withdrawal(Convert.ToDouble(DebiteSumText.Text));
           
            
            MessageBox.Show("Votre retrait a bien été effectué");
           
            









        }
        
    }
}
