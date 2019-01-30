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
    public partial class clientForm : Form
    {
        public clientForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            this.Hide();
            login.ShowDialog(); // go back to the login menu
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); // close the actual form
        }
    }
}
