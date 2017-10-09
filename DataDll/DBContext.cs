using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDll
{
    public class DBContext
    {
        private SqlConnection db;


        public DBContext(string connectionString)
        {
            var ss = ConfigurationManager.ConnectionStrings["name=SqlLiteConnection"].ConnectionString;
            db = new SqlConnection();
            db.Open();


        }


        ~DBContext()
        {
            db?.Close();
        }
    }
}
