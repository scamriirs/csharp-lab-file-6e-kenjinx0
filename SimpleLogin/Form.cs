using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleLoginApp
{
    public partial class LoginForm : Form
    {
        // Define the username and password
        private string predefinedUsername = "user123";
        private string predefinedPassword = "pass123";

        public LoginForm()
        {
            InitializeComponent();0
        }

        // Handle the Submit button click event
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;

            if (enteredUsername == predefinedUsername && enteredPassword == predefinedPassword)
            {
                // If the login is successful, show the WelcomeForm
                WelcomeForm welcomeForm = new WelcomeForm();
                welcomeForm.Show();
                this.Hide();  // Hide the login form
            }
            else
            {
                // If the login fails, show a warning message
                lblMessage.Text = "Incorrect username or password!";
                lblMessage.ForeColor = Color.Red;
            }
        }

        // Form Load Event to set some initial properties
        private void LoginForm_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            lblMessage.ForeColor = Color.Black;
        }
    }
}
