using System;
using System.Windows.Forms;

namespace SimpleLoginApp
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            // Set the welcome message
            lblWelcomeMessage.Text = "WELCOME";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the form
        }
    }
}
