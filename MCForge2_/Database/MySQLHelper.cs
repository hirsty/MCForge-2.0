using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;


namespace MCForge2_.Database
{
    class MySQLHelper
    {
        private MySqlConnection connection = null;
        private MySqlTransaction transaction = null;
        private string MySQLconnString = null;
        /// <summary>
        /// Executes the query in MySQL.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>true if executed without errors, false otherwise</returns>
        public static bool Execute(string query)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                }
            }
            return true;
        }
    }
}
