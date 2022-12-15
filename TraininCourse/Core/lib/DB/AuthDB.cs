using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TraininCourse.Core.lib.DB
{
    public class AuthDB
    {
        private string _name = "userAuth.db";


        public AuthDB()
        {
            using (var conn = new SqliteConnection("Data Source=" + _name))
            {
                conn.Open();
                SqliteCommand command = new SqliteCommand();
                command.Connection = conn;
                command.CommandText = "SELECT name FROM sqlite_master WHERE name='auth'";

                var name = command.ExecuteScalar();
                if (name != null && name.ToString() == "auth")
                {
                    command.CommandText = "SELECT * FROM auth";
                    using(SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            MessageBox.Show(reader.GetValue(1).ToString() + " | " + reader.GetValue(2).ToString());
                            MainUtil.auth(reader.GetValue(1).ToString(), reader.GetValue(2).ToString());
                        }
                    }
                } 
                else
                {
                    
                    command.CommandText = "CREATE TABLE auth (_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, email VARCHAR(355), password VARCHAR(256))";
                    command.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

        public int create(string email, string pass)
        {
            using (var conn = new SqliteConnection("Data Source=" + _name))
            {
                int id = 0;

                conn.Open();
                SqliteCommand command = new SqliteCommand();
                command.Connection = conn;

                command.CommandText = "INSERT INTO auth (email, password) VALUES (@email, @pass)";
                command.Parameters.AddWithValue("email", email);
                command.Parameters.AddWithValue("pass", pass);
                id = command.ExecuteNonQuery();

                conn.Close();


                return id;
            }
        }
    }
}
