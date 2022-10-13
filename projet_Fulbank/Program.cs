﻿using projet_Fulbank.Class;
using projet_Fulbank.Class.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_Fulbank
{
    static class Program
    {
        public static string lastName = UserManager.getUser().getLastName();
        public static long accountNumber = UserManager.getUser().getLogin();
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Connexion());

            
        }
    }
}
