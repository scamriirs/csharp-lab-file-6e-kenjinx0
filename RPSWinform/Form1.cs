using System;
using System.Drawing;
using System.Windows.Forms;

namespace RPSWinform
{
    public partial class Form1 : Form
    {
        private string playerChoice;
        private string computerChoice;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (radioRock.Checked)
                playerChoice = "rock";
            else if (radioPaper.Checked)
                playerChoice = "paper";
            else if (radioScissors.Checked)
                playerChoice = "scissors";
            else
            {
                MessageBox.Show("Please make a selection!");
                return;
            }

            string playerImagePath = System.IO.Path.Combine(Application.StartupPath, "images", $"{playerChoice}.jpg");
            pictureBoxPlayer.Image = Image.FromFile(playerImagePath);

            string[] options = { "rock", "paper", "scissors" };
            Random rnd = new Random();
            computerChoice = options[rnd.Next(0, 3)];

            string computerImagePath = System.IO.Path.Combine(Application.StartupPath, "images", $"{computerChoice}.jpg");
            pictureBoxComputer.Image = Image.FromFile(computerImagePath);

            string result = GetResult(playerChoice, computerChoice);
            ResultForm resultForm = new ResultForm(result);
            resultForm.Show();
        }

        private string GetResult(string player, string computer)
        {
            if (player == computer)
                return "It's a Tie!";
            if ((player == "rock" && computer == "scissors") ||
                (player == "paper" && computer == "rock") ||
                (player == "scissors" && computer == "paper"))
                return "Player Wins!";
            else
                return "Computer Wins!";
        }
    }
}
