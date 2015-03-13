using System;
using System.Windows.Forms;

namespace Win.App.Server
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AdminAccountManager.ChangePassword(UserNameTextBox.Text, OldPasswordTextbox.Text, NewPasswordTextbox.Text);

                //if it can go this line of code then tell the user that updating of setting was successful
                MessageBox.Show("Your username and password was changed successfully. Try to login again to see your changes.",
                "Updating successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (InvalidUserNameOrPasswordException)
            {
                //if it goes on this exception then the operation inside the try block has invalid username or password error
                //and so it should be handled and show to the user for the response
                MessageBox.Show("Invalid UserName or Password. \n Please input your correct UserName and password and then do update setting again.",
                    "Invalid UserName or Password", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
