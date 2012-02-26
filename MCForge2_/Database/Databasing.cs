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

namespace MCForge2_.Database
{
    class Databasing
    {
        internal static bool UseMySQL          { get; set; }
        internal static string DatabaseName    { get; set; }
        internal static string MySQLHost       { get; set; }
        internal static ushort MySQLPort       { get; set; }
        internal static string MySQLUser       { get; set; }
        internal static string MySQLPassword   { get; set; }
        private static DatabaseHelper Database { get; set; }
        /// <summary>
        /// Creates the default databases.
        /// </summary>
        /// <remarks></remarks>
        public static void CreateDatabases()
        {
            Database.Execute(string.Format("CREATE TABLE if not exists Players (ID INTEGER {0} NOT NULL, Name VARCHAR(20) NOT NULL, IP CHAR(15) NOT NULL, PRIMARY KEY (ID))", (UseMySQL) ? "AUTO_INCREMENT" : "AUTOINCREMENT"));
        }
        /// <summary>
        /// Initializes this instance with defaults.
        /// </summary>
        /// <remarks></remarks>
        public void Initialize()
        {
            UseMySQL = true;
            DatabaseName = "MCForge2";
            MySQLHost = "127.0.0.1";
            MySQLPort = 3306;
            MySQLUser = "root";
            MySQLPassword = "password";
            Database = DatabaseHelper.Create();
        }
    }
}
