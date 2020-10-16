using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace Fridgerator
{
    static class Program
    {
        public static MySqlConnection Connection;

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
        public static List<string> Select(string Text)
        {
            //Результат
            List<string> results = new List<string>();
            //Создать команду
            MySqlCommand command = new MySqlCommand(Text, Connection);
            //Выполнить команду
            DbDataReader reader = command.ExecuteReader();

            while (reader.Read())
                for (int i = 0; i < reader.FieldCount; i++)
                    results.Add(reader.GetValue(i).ToString());

            reader.Close();

            return results;
        }
    }
}
