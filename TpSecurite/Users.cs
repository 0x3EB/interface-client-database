using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpSecurite
{
    class Users
    {
        private static DB db;
        public int Id { get; private set; }
        public String lastname { get; private set; }
        public String name { get; private set; }
        public String email { get; private set; }
        public String username { get; private set; }
        public String password { get; private set; }
        public String role { get; private set; }
        private Users(int id, String lastname, String name, String email, String username, String password, String role)
        {
            this.Id = id;
            this.lastname = lastname;
            this.name = name;
            this.email = email;
            this.username = username;
            this.password = password;
            this.role = role;
        }
        /**
        * Get all the users into the database
        **/
        public static List<Users> GetUsers()
        {
            db = new DB();
            List<Users> users = new List<Users>();
            String query = "SELECT * FROM user";
            MySqlCommand cmd = new MySqlCommand(query, db.setConnection());
            db.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"]);
                String lastname = reader["lastname"].ToString();
                String name = reader["name"].ToString();
                String email = reader["email"].ToString();
                String username = reader["username"].ToString();
                String password = reader["password"].ToString();
                String role = reader["role"].ToString();
                Users u = new Users(id, lastname, name, email, username, password, role);
                users.Add(u);
            }
            reader.Close();
            db.Close();
            return users;
        }
        /**
        * Update a user informations
        **/
        public void Update(string strLastName, string strName, string strEmail, string strUsername, string strPassword)
        {
            db = new DB();
            String query = string.Format("UPDATE user SET lastname='{0}', name='{1}', email='{2}', username='{3}', password='{4}' WHERE ID={5}", strLastName, strName,strEmail, strUsername, strPassword, Id);
            MySqlCommand cmd = new MySqlCommand(query, db.setConnection());
            db.Open();
            cmd.ExecuteNonQuery();
            db.Close();
        }
    }
}
