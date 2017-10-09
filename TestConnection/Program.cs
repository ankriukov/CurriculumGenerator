using DataDll;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            string databaseName = @"C:\Users\Sony\Desktop\CurriculumGenerator\DataDll\DBCurriculum.db";
            SQLiteConnection connection =
            new SQLiteConnection(string.Format("Data Source={0};", databaseName));
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("SELECT name FROM sqlite_master WHERE type='table' ORDER BY name;", connection);
            SQLiteDataReader reader = command.ExecuteReader();
            foreach (DbDataRecord record in reader)
                Console.WriteLine("Таблица: " + record["name"]);
            connection.Close();
        }
    }
}
