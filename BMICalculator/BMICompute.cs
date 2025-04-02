using System;
using System.Drawing;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class FormResult : Form
    {
        private Label lblBMIResult;
        private Label lblCategory;

        public FormResult(double bmi)
        {
            InitializeComponent();
            lblBMIResult.Text = $"Your BMI: {bmi:F2}";
            lblCategory.Text = $"Category: {GetBMICategory(bmi)}";

            this.Resize += new EventHandler(FormResult_Resize);
            CenterLabels();
        }

        private string GetBMICategory(double bmi)
        {
            if (bmi < 18.5) return "Underweight";
            if (bmi >= 18.5 && bmi < 25) return "Normal Weight";
            if (bmi >= 25 && bmi < 30) return "Overweight";
            return "Obese";
        }

        private void FormResult_Resize(object sender, EventArgs e)
        {
            CenterLabels();
        }

        private void CenterLabels()
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            lblBMIResult.Location = new Point(formWidth / 2 - lblBMIResult.Width / 2, formHeight / 3 - lblBMIResult.Height / 2);
            lblCategory.Location = new Point(formWidth / 2 - lblCategory.Width / 2, formHeight / 2 - lblCategory.Height / 2);
        }

        private void InitializeComponent()
        {
            this.lblBMIResult = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // BMI Label
            this.lblBMIResult.AutoSize = true;
            this.lblBMIResult.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.lblBMIResult);

            // BMI Category Label
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.Controls.Add(this.lblCategory);

            // Form Properties
            this.Text = "BMI Result";
            this.BackColor = Color.MistyRose; // Pastel background
            this.ClientSize = new System.Drawing.Size(300, 200);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
