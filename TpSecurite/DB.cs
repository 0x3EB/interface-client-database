using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpSecurite
{
    class DB
    {
        private MySqlConnection connection;
        public DB()
        {

        }
        /**
         * setup the data base
         **/ 
        public MySqlConnection setConnection()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "sml_databse";
            builder.SslMode = MySqlSslMode.None;
            connection = new MySqlConnection(builder.ToString());
            return connection;
        }
        /**
         * Get the status of the data base
         **/
        public String getStatus()
        {
            return connection.State.ToString();
        }
        /**
        * Open the database system
        **/
        public void Open()
        {
            connection.Open();    
        }

        /**
        * Close the data base system
        **/
        public void Close()
        {
            connection.Close();
        }

        /**
        * Insert a user into the table of the database
        **/
        public bool Insert(String strLastName, String strName, String strEmail, String strUsername, String strpassword, String strQuestion, String strCode)
        {
            try
            {
                String query = string.Format("INSERT INTO user(lastname, name, email, username, password, question, last_verif_code) VALUES ('{0}', '{1}','{2}', '{3}','{4}','{5}','{6}')", strLastName, strName, strEmail, strUsername, strpassword, strQuestion, strCode);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                Open();
                cmd.ExecuteNonQuery();
                int id = (int)cmd.LastInsertedId;
                Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /**
        * return the "role" of the user and login
        **/
        public String login(String strUserName, String strPassword)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM user WHERE username='"+ strUserName + "' and password='"+ strPassword + "'",connection);
            //Open();
            da.Fill(dt);
            int i = dt.Rows.Count;
            if (i > 0)
            {
                Close();
                return dt.Rows[0][7].ToString();
                
            }
            else
            {
                Close();
                return null;
            }
                
            
        }

        /**
        * return the code of the user
        **/
        public String getCode(String strUserName)
        {
            
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM user WHERE username='" + strUserName + "'", connection);
            //Open();
            da.Fill(dt);
            int i = dt.Rows.Count;
            if (i > 0)
            {
                Close();
                return dt.Rows[0][9].ToString();
            }
            else
            {
                Close();
                return null;
            }
                

        }

        /**
        * return the activated status of the user
        **/
        public String getActivation(String strUserName, String strPassword)
        {
            //Open();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM user WHERE username='" + strUserName + "' and password='" + strPassword + "'", connection);
            da.Fill(dt);
            int i = dt.Rows.Count;
            if (i > 0)
            {
                return dt.Rows[0][10].ToString();
            }
            else
                return null;

        }
    }
}
