using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpSecurite
{
    public partial class codeInformation : Form
    {
        private string strUsername = null;
        private string strPassword = null;
        DB db;
 
        public codeInformation()
        {
            InitializeComponent();
        }

        private void codeInformation_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.setConnection(); // set the connection
            string strTxtCode = txtboxcode.Text;
            if (strTxtCode.Equals(db.getCode(this.strUsername)))
            {
                try
                {
                    Update("1"); // set the activation status to 1 
                    if (db.login(strUsername, strPassword).ToLower().Equals("admin"))
                    {
                        adminForm admin = new adminForm();
                        Hide();
                        admin.ShowDialog(); // show the admin dialog if the user is an admin
                    }
                    else
                    {
                        clientForm client = new clientForm();
                        Hide();
                        client.ShowDialog(); // show the client dialog if the user is a client
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
            }
            else
            {
                MessageBox.Show("VERIFY THE CODE !!");
            }
        }

        public void setUsername(string strUsername)
        {
            this.strUsername = strUsername; // set the username 
        }

        public void setPassword(string strPassword)
        {
            this.strPassword=  strPassword; // set the password
        }

        /**
         * Update the status of the activation
         **/ 
        public void Update(string strValue)
        {
            db = new DB();
            String query = string.Format("UPDATE user SET activated = '{0}' WHERE username ='{1}'", strValue, this.strUsername);
            MySqlCommand cmd = new MySqlCommand(query, db.setConnection());
            db.Open();
            cmd.ExecuteNonQuery();
            db.Close();
        }
    }
}
