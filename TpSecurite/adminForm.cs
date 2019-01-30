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
    public partial class adminForm : Form
    {
        Users currUser;
        public adminForm()
        {
            InitializeComponent();
        }

        public void load()
        {
            List<Users> users = Users.GetUsers();

            listViewUser.Items.Clear();

            foreach (Users u in users)
            {

                ListViewItem item = new ListViewItem(new String[] { u.Id.ToString(), u.lastname, u.name, u.email, u.username, u.password, u.role });
                item.Tag = u;

                listViewUser.Items.Add(item);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            load();
        }

        private void listViewUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewUser.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewUser.SelectedItems[0];
                currUser = (Users)item.Tag;

                int id = currUser.Id;
                String lastname = currUser.lastname;
                String name = currUser.name;
                String email = currUser.email;
                String username = currUser.username;
                String password = currUser.password;
                String role = currUser.role;

                txtbox_id.Text = id.ToString();
                txtbox_lastname.Text = lastname;
                txtbox_name.Text = name;
                txtbox_email.Text = email;
                txtbox_username.Text = username;
                txtbox_pasword.Text = password;
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String lastname = txtbox_lastname.Text;
            String name = txtbox_name.Text;
            String email = txtbox_email.Text;
            String username = txtbox_username.Text;
            String password = txtbox_pasword.Text;

            if (String.IsNullOrEmpty(lastname) || String.IsNullOrEmpty(name) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("EMPTY FIELD(S)");
                return;
            }
            currUser.Update(lastname, name, email, username, password);
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            Hide();
            login.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtbox_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
