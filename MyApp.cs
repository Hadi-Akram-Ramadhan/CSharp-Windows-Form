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
    public partial class MyApp : Form
    {
        public MyApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblHello.Text = "Hello World.";
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Apa woy";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Cancel";
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginForm LF = new LoginForm();
            LF.Show();
        }
    }
}
