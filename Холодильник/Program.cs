﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace Fridgerator
{
    static class Program
    {
        public static MySqlConnection Connection;

        public static string CurrentUser;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string connString = "Server=VH287.spaceweb.ru;" +
                ";Database= beavisabra_holod" +
                ";port=3306;User Id=beavisabra_holod;password=Beavis1989";

            Connection = new MySqlConnection(connString);
            Connection.Open();
            Application.Run(new Main());
            Connection.Close();
        }

        /// <summary>
        /// Select-запрос
        /// </summary>
        public static List<string> Select(string Text, Dictionary<string, string> parameters = null)
        {
            List<string> results = new List<string>();

            MySqlCommand command = new MySqlCommand(Text, Connection);

            if (parameters != null)
                foreach (var pair in parameters)
                    command.Parameters.AddWithValue(pair.Key, pair.Value);
            try
            {
                DbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    for (int i = 0; i < reader.FieldCount; i++)
                        results.Add(reader.GetValue(i).ToString());

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");

                string address = System.IO.Path.GetTempPath() + "Холодильник.txt";
                if (!System.IO.File.Exists(address))
                    System.IO.File.Create(address);


                System.IO.File.AppendAllText(address, DateTime.Now.ToString() + Environment.NewLine + 
                    ex.Message + Environment.NewLine +
                    "Текст запроса: " + Text + Environment.NewLine + Environment.NewLine);

            }

            return results;
        }

        public static void Insert(string Text)
        {
            //Создать команду
            MySqlCommand command = new MySqlCommand(Text, Connection);

            //Выполнить команду
            command.ExecuteNonQuery();
        }
    }
}
