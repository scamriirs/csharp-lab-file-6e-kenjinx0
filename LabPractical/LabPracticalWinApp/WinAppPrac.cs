namespace LabPracticalWinApp
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
        public partial class WinAppPrac : Form
    {
        public WinAppPrac()
        {
            TextBox textBox = new TextBox();

            Button buttonMessage = new Button();
            buttonMessage.Text = "Show Welcome";

            Button buttonFont = new Button();
            buttonFont.Text = "Change Font";

            Button buttonColor = new Button();
            buttonColor.Text = "Change Color";

            buttonMessage.Click += (s, e) => MessageBox.Show("Welcome to C# Windows App", "Welcome");

            buttonFont.Click += (s, e) =>
            {
                FontDialog fontDialog = new FontDialog();
                if (fontDialog.ShowDialog() == DialogResult.OK)
                    textBox.Font = fontDialog.Font;
            };

            buttonColor.Click += (s, e) =>
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                    textBox.ForeColor = colorDialog.Color;
            };


            Controls.Add(textBox);
            Controls.Add(buttonMessage);
            Controls.Add(buttonFont);
            Controls.Add(buttonColor);


            Text = "C# Windows App";
            ClientSize = new Size(240, 150);
        }
    
    }
}

