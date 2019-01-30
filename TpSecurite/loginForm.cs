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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void buttonHomeRegisterPage_Click(object sender, EventArgs e)
        {
            Form1 homepage = new Form1();
            this.Hide();
            homepage.ShowDialog(); // show the homepage dialog
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Md5 md5 = new Md5();
            String strUsername = txtboxusername.Text;
            String strPassword = txtboxpassword.Text;
            strPassword = md5.SetMd5(strPassword); // tranform password into md5 to check with the database
            DB db = new DB();
            
            db.setConnection(); // set the connection
            if (db.getActivation(strUsername, strPassword).ToLower().Equals("0"))
            {
                codeInformation codeInfo = new codeInformation();
                codeInfo.setUsername(strUsername);
                codeInfo.setPassword(strPassword);
                codeInfo.ShowDialog(); // verify email code dialog
                
            }
            else
            {
                if (db.login(strUsername, strPassword).ToLower().Equals("admin"))
                {
                    adminForm admin = new adminForm();
                    Hide();
                    admin.ShowDialog(); // shwo the admin dialog if the suer is an admin
                }
                else
                {
                    clientForm client = new clientForm();
                    Hide();
                    client.ShowDialog(); // show the client dialog if the user is a client
                }
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changePasswordForm passwordchange = new changePasswordForm();
            passwordchange.ShowDialog(); // show the changing password dialog
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
             
        }

        private void buttonRegisterLoginPage_Click(object sender, EventArgs e)
        {
            registerForm register = new registerForm();
            this.Hide();
            register.ShowDialog(); // show the register dialog
        }
    }
}
