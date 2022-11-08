﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_Fulbank.Class.Model
{
    public class OperationManager
    {
        private static MySqlConnection pdo = DBConnexion.getConnexion();
        private static MySqlDataReader reader;
        private static MySqlCommand command;

       
        public static void withdrawal(double anAmout)
        {
            pdo.Open();
            command = pdo.CreateCommand();
            command.CommandText = "UPDATE Account set sold = @anAmount WHERE idPerson = (SELECT id FROM Person WHERE login = @login)";
            MySqlParameter param = new MySqlParameter();
            param.ParameterName = "@login";
            param.DbType = DbType.Int64;
            param.Value = UserManager.getUser().getLogin();
            MySqlParameter param2 = new MySqlParameter();
            param.ParameterName = "@anAmout";
            param.DbType = DbType.Double;
            param.Value = anAmout;
            command.Parameters.Add(param);
            command.Parameters.Add(param2);
            reader = command.ExecuteReader();
        }

    }
}
