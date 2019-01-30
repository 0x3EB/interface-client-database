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
    public partial class changePasswordForm : Form
    {
        public changePasswordForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String strEmail = txtbox_email.Text;
            String strPassword = txtbox_password.Text;
            String strConfirmPassword = txtbox_confirmpassword.Text;
            String strAnswer = questionAnswser.Text;

            if (!strPassword.Equals(strConfirmPassword))
            {
                MessageBox.Show("Err password are not the same");
                return;
            }

            try
            {
                DB db = new DB();
                String query = string.Format("UPDATE user SET password='{0}' WHERE EMAIL='{1}' AND QUESTION='{2}'", strPassword, strEmail, strAnswer); // update the password 
                MySqlCommand cmd = new MySqlCommand(query, db.setConnection()); //setup the databse
                db.Open(); // open the database
                cmd.ExecuteNonQuery();// execute the query
                db.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("PASSWORD CHANGED");
            Close();
            
        }

        private void changePasswordForm_Load(object sender, EventArgs e)
        {

        }
    }
}
