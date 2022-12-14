using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TraininCourse.View.Pages.LoginPages;

namespace TraininCourse.Core.lib.DB
{
    public class AuthDB
    {
        private string _name = "userAuth.db"; // имя файла БД

        public AuthDB()
        {
            using (var conn = new SqliteConnection("Data Source=" + _name))
            {
                // открываем соединение с локальной БД
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
                            if(!MainUtil.auth(reader.GetValue(1).ToString(), reader.GetValue(2).ToString()))
                            {
                                reader.Close();
                                clear();
                            }
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

                command.CommandText = "DELETE FROM auth WHERE 1";
                command.ExecuteNonQuery();

                command.CommandText = "INSERT INTO auth (email, password) VALUES (@email, @password)";
                command.Parameters.AddWithValue("email", email);
                command.Parameters.AddWithValue("password", pass);
                id = command.ExecuteNonQuery();

                conn.Close();


                return id;
            }
        }

        public void clear()
        {
            using (var conn = new SqliteConnection("Data Source=" + _name))
            {
                conn.Open();
                SqliteCommand command = new SqliteCommand();
                command.Connection = conn;

                command.CommandText = "DELETE FROM auth WHERE 1";
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void logout()
        {
            clear();
            ((MainWindow)Application.Current.MainWindow).logout();
            MainUtil.FrameObject.Navigate(new LoginPage());
        }
    }
}
