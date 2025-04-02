using System;
using System.Drawing;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.Resize += new EventHandler(FormMain_Resize);
            CenterComponents();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double weight, height, bmi = 0;
            bool isMetric = radioMetric.Checked;

            if (double.TryParse(txtWeight.Text, out weight) && double.TryParse(txtHeight.Text, out height))
            {
                if (isMetric)
                {
                    height /= 100; // Convert cm to meters
                }
                else
                {
                    weight *= 0.453592;  // Pounds to kg
                    height *= 0.0254;    // Inches to meters
                }
                bmi = weight / (height * height);

                FormResult resultForm = new FormResult(bmi);
                resultForm.Show();
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            CenterComponents();
        }

        private void CenterComponents()
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            int centerX = formWidth / 2;
            int centerY = formHeight / 2;

            lblWeight.Location = new Point(centerX - lblWeight.Width - 10, centerY - 70);
            txtWeight.Location = new Point(centerX, centerY - 70);
            lblHeight.Location = new Point(centerX - lblHeight.Width - 10, centerY - 40);
            txtHeight.Location = new Point(centerX, centerY - 40);
            radioMetric.Location = new Point(centerX - 80, centerY);
            radioImperial.Location = new Point(centerX + 20, centerY);
            btnCalculate.Location = new Point(centerX - btnCalculate.Width / 2, centerY + 40);
        }
    }
}
