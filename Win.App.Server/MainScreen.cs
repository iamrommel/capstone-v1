using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.App.Server
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void btnJPIA_Click(object sender, EventArgs e)
        {
            MainScreen2 frm1 = new MainScreen2();
            frm1.Show();
            this.Hide();
        }

        private void btnLPU_Click(object sender, EventArgs e)
        {
            GMainScreen frm2 = new GMainScreen();
            frm2.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm frmLogin = new LoginForm();
            frmLogin.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
