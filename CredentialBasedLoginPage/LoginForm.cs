using System;
using System.Windows.Forms;

namespace CredentialBasedLoginPage
{
    public partial class LoginForm : Form
    {
        private DatabaseManager dbManager = new DatabaseManager();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dbManager.ValidateUser(username, password))
            {
                MessageBox.Show("Successful login!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Here you would typically open your main application form
                // MainForm mainForm = new MainForm();
                // mainForm.Show();
                // this.Hide();
            }
            else if (dbManager.DoesUserExist(username))
            {
                MessageBox.Show("Invalid password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"No account with username '{username}'", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
            this.Hide();
        }
    }
}
