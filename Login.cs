using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace siapa
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string id = txbID.Text;
            string pass = txbPass.Text;

            if (id == "123" &&  pass == "123")
            {
                this.Hide();
                MyApp my = new MyApp();
                my.Show();
                
            }
            else
            {
                MessageBox.Show("Masukan data yang valid");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txbID.Text = string.Empty;
            txbPass.Text = string.Empty;
        }
    }
}
