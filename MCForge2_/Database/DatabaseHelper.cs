﻿/*
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

namespace MCForge2_
{
    namespace Database
    {
        public abstract class DatabaseHelper : IDisposable
        {
            /// <summary>
            /// The database helpers
            /// </summary>
            /// <returns></returns>
            /// <remarks></remarks>
            public static DatabaseHelper Create()
            {
                if (Database.Databasing.UseMySQL)
                {
                    return MySQLHelper.Create();
                }
                else
                {
                    return null;
                }
            }
            /// <summary>
            /// Executes the specified query.
            /// </summary>
            /// <param name="query">The query.</param>
            /// <remarks></remarks>
            public abstract void Execute(string query);
            /// <summary>
            /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
            /// </summary>
            /// <remarks></remarks>
            public abstract void Dispose();
        }
    }
}
