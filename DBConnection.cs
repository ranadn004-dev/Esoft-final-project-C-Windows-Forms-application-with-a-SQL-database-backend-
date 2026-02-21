using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esoft_Final_project
{
    internal class DBConnection
    {
        private string conn;

        public string myConnection()
        {
            conn = @"Data Source=DHEERAKA\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True;TrustServerCertificate=True";
            return conn;
        }
        

        
    }
}
