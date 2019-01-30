using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace TpSecurite
{
    public partial class registerForm : Form
    {
        String[] strAlphabetAndNumber = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        Random r = new Random();
        String strCaptcha = null;
        String strCode = null;

        Form1 home = new Form1();
        public registerForm()
        {
            InitializeComponent();
        }

        private void buttonHomeRegisterPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            home.ShowDialog();
        }

        private void registerForm_Load(object sender, EventArgs e)
        {
            // create a captcha form the register form
            for (int i = 0; i < 6; i++)
            {
                int index = r.Next(0, strAlphabetAndNumber.Length);
                string letter_index = strAlphabetAndNumber[index].ToString();
                strCaptcha += letter_index;
            }
            label_captcha.Text = strCaptcha;
            label_captcha.Font = new Font(label_captcha.Font, FontStyle.Bold);
            label_captcha.Font = new Font(label_captcha.Font, FontStyle.Italic);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strUsername = txtboxusername.Text;
            string strLastName = txtboxlastname.Text;
            string strFirstName = txtboxfirstname.Text;
            string strPassword = txtboxpassword.Text;
            string strComfirmPwd = txtboxcomfirmpassword.Text;
            string strEmail = txtboxemail.Text;
            string strCaptcha = txtboxcaptcha.Text;
            string strQuestion = questiontxtbox.Text;

            // create a code for the email
            for (int i = 0; i < 6; i++)
            {
                int index = r.Next(0, strAlphabetAndNumber.Length);
                string letter_index = strAlphabetAndNumber[index].ToString();
                strCode += letter_index;
            }

            // list that contains all the textboxes
            List<string> textBoxes = new List<string>(new string[] { strUsername , strLastName , strFirstName , strPassword , strComfirmPwd , strEmail, strCaptcha });

            // VERIFY THE FORMAT OF ALL FIELDS

            if (String.IsNullOrEmpty(strUsername) || String.IsNullOrEmpty(strLastName) || String.IsNullOrEmpty(strFirstName) || String.IsNullOrEmpty(strPassword) || String.IsNullOrEmpty(strComfirmPwd) ||String.IsNullOrEmpty(strEmail) || String.IsNullOrEmpty(strQuestion))
            {
                MessageBox.Show("Un/des champs sont vides");
                return;
            }
            
            if (isValidEmail(strEmail)==(false))
            {
                MessageBox.Show("Wrong Email format");
                return;
            }
            
            if (!strPassword.Equals(strComfirmPwd))
            {
                MessageBox.Show("Not the same password");
                return;
            }

            if (!strCaptcha.Equals(this.strCaptcha))
            {
                MessageBox.Show("ERREUR CAPTCHA");
                return;
            }
            String err;
            if(ValidatePassword(strPassword,out err)==false) {
                MessageBox.Show(err);
                return;
            }
            DB db = new DB();
            db.setConnection();
            Md5 md5 = new Md5();
            //Insert into the database if all field are correct 
            if (db.Insert(strLastName, strFirstName, strEmail, strUsername, md5.SetMd5(strPassword), strQuestion, strCode)==true)
            {
                MessageBox.Show("REGISTER DONE !");
                EmailService email = new EmailService(new System.Net.Mail.MailAddress(txtboxemail.Text), strCode); // send the code by mail
                this.Hide();
                home.ShowDialog();
            }
            else
                MessageBox.Show("Err");
            
        }

        private void buttonLoginRegisterPage_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            this.Hide();
            login.ShowDialog();
            
        }
        /**
         * verify the email format
         **/ 
        bool isValidEmail(String email)
        {
            try
            {
                var EmailValid = new System.Net.Mail.MailAddress(email);
                return EmailValid.Address == email;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void txtboxpassword_TextChanged(object sender, EventArgs e)
        {

        }

        /**
         * Check if the password has the correct policy format
         **/ 
        private bool ValidatePassword(string password, out string ErrorMessage)
        {
            var input = password;
            ErrorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Password should not be empty");
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");

            if (!hasLowerChar.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one lower case letter";
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one upper case letter";
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                ErrorMessage = "Password should not be less than or greater than 12 characters";
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one numeric value";
                return false;
            }
            else
                return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

           
        }
    }

}
