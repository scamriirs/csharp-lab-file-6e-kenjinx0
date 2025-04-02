namespace BMICalculator
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.RadioButton radioMetric;
        private System.Windows.Forms.RadioButton radioImperial;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            radioMetric = new RadioButton();
            radioImperial = new RadioButton();
            btnCalculate = new Button();
            lblWeight = new Label();
            lblHeight = new Label();
            SuspendLayout();
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(150, 20);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(100, 27);
            txtWeight.TabIndex = 1;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(150, 50);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(100, 27);
            txtHeight.TabIndex = 3;
            // 
            // radioMetric
            // 
            radioMetric.AutoSize = true;
            radioMetric.Checked = true;
            radioMetric.Location = new Point(20, 80);
            radioMetric.Name = "radioMetric";
            radioMetric.Size = new Size(129, 24);
            radioMetric.TabIndex = 4;
            radioMetric.TabStop = true;
            radioMetric.Text = "Metric (kg, cm)";
            // 
            // radioImperial
            // 
            radioImperial.AutoSize = true;
            radioImperial.Location = new Point(155, 80);
            radioImperial.Name = "radioImperial";
            radioImperial.Size = new Size(131, 24);
            radioImperial.TabIndex = 5;
            radioImperial.Text = "Imperial (lb, in)";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(80, 120);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate BMI";
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(20, 20);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(124, 20);
            lblWeight.TabIndex = 0;
            lblWeight.Text = "Weight (kg or lb):";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(20, 50);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(125, 20);
            lblHeight.TabIndex = 2;
            lblHeight.Text = "Height (cm or in):";
            // 
            // FormMain
            // 
            ClientSize = new Size(295, 197);
            Controls.Add(lblWeight);
            Controls.Add(txtWeight);
            Controls.Add(lblHeight);
            Controls.Add(txtHeight);
            Controls.Add(radioMetric);
            Controls.Add(radioImperial);
            Controls.Add(btnCalculate);
            Name = "FormMain";
            Text = "BMI Calculator";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
