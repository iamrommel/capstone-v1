using System;
using System.Threading;
using System.Windows.Forms;

namespace Win.App.Server
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        public void SplashScreen()
        {
            Application.Run(new SplashScreen());
        }


        private AdminAccountManager _adminAccountManager;
        public AdminAccountManager AdminAccountManager
        {
            get
            {
                if (_adminAccountManager == null)
                {
                    _adminAccountManager = new AdminAccountManager();
                }

                return _adminAccountManager;
            }
            set { _adminAccountManager = value; }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {

            var isLoggedin = AdminAccountManager.Login(txtUsername.Text, txtPassword.Text);

            if (isLoggedin)
            {
                MessageBox.Show("Welcome to the system Admin", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error : Make sure you input a valid Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to QUIT?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (Application.MessageLoop)
            {
                Application.Exit();
            }

            else
            {

                Environment.Exit(1);
            }
        }


    }
}
