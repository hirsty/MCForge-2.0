/*
	Copyright 2012 MCForge
		
	Dual-licensed under the	Educational Community License, Version 2.0 and
	the GNU General Public License, Version 3 (the "Licenses"); you may
	not use this file except in compliance with the Licenses. You may
	obtain a copy of the Licenses at
	
	http://www.opensource.org/licenses/ecl2.php
	http://www.gnu.org/licenses/gpl-3.0.html
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the Licenses are distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the Licenses for the specific language governing
	permissions and limitations under the Licenses.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;


namespace MCForge2_.Database
{
    /// <summary>
    /// Database stuff for MySQL
    /// </summary>
    /// <remarks></remarks>
    class MySQLHelper : DatabaseHelper
    {
        private MySqlConnection connection = null;
        private MySqlTransaction transaction = null;
        internal static string ConnString = 
            "Server=" + Databasing.MySQLHost +
            ";Port=" + Databasing.MySQLPort +
            ";Database=" + Databasing.DatabaseName + 
            ";Uid=" + Databasing.MySQLUser +
            ";Pwd=" + Databasing.MySQLPassword + ";";


        /// <summary>
        /// Initializes a new instance of the <see cref="MySQLHelper"/> class.
        /// </summary>
        /// <remarks></remarks>
        public MySQLHelper()
        {
            Initialize(ConnString);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MySQLHelper"/> class.
        /// </summary>
        /// <param name="ConnString">The MySQL connection string.</param>
        /// <remarks></remarks>
        public MySQLHelper(string ConnString)
        {
            Initialize(ConnString);
        }

        /// <summary>
        /// Executes the query in MySQL.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>true if executed without errors, false otherwise</returns>
        public override void Execute(string query)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection, transaction))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch //(Exception ex)
            {
                System.IO.File.AppendAllText("Database_error.log", DateTime.Now + " " + query + "\r\n");
            }
        }

        internal void Initialize(string ConnString)
        {
            connection = new MySqlConnection(ConnString);
            connection.Open();
            connection.ChangeDatabase(Databasing.DatabaseName);
            transaction = connection.BeginTransaction();
        }

        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public static new DatabaseHelper Create()
        {
            return Create(MySQLHelper.ConnString);
        }

        /// <summary>
        /// Creates instance using the specified MySQL connection string.
        /// </summary>
        /// <param name="connString">The MySQL connection string.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static DatabaseHelper Create(string connString)
        {
            try
            {
                return new MySQLHelper(connString);
            }
            catch //(Exception ex)
            {
                //Server.ErrorLog(ex);
                return null;
            }
        }
        /// <summary>
        /// Disposes this instance.
        /// </summary>
        /// <remarks></remarks>
        public override void Dispose()
        {
            transaction.Dispose();
            connection.Dispose();
            transaction = null;
            connection = null;
        }
    }
}
