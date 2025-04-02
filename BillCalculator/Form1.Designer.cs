namespace BillCalculator
{
    partial class FormBillCalculator
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.CheckBox chkPizza;
        private System.Windows.Forms.CheckBox chkBurger;
        private System.Windows.Forms.CheckBox chkCoffee;
        private System.Windows.Forms.CheckBox chkCoke;
        private System.Windows.Forms.Button btnCalculate;

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
            this.lblMenu = new System.Windows.Forms.Label();
            this.chkPizza = new System.Windows.Forms.CheckBox();
            this.chkBurger = new System.Windows.Forms.CheckBox();
            this.chkCoffee = new System.Windows.Forms.CheckBox();
            this.chkCoke = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Menu Label
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblMenu.Location = new System.Drawing.Point(80, 20);
            this.lblMenu.Text = "Menu";

            // Pizza CheckBox
            this.chkPizza.AutoSize = true;
            this.chkPizza.Font = new System.Drawing.Font("Arial", 10F);
            this.chkPizza.Location = new System.Drawing.Point(50, 60);
            this.chkPizza.Text = "Pizza ($8.99)";

            // Burger CheckBox
            this.chkBurger.AutoSize = true;
            this.chkBurger.Font = new System.Drawing.Font("Arial", 10F);
            this.chkBurger.Location = new System.Drawing.Point(50, 90);
            this.chkBurger.Text = "Burger ($5.49)";

            // Coffee CheckBox
            this.chkCoffee.AutoSize = true;
            this.chkCoffee.Font = new System.Drawing.Font("Arial", 10F);
            this.chkCoffee.Location = new System.Drawing.Point(50, 120);
            this.chkCoffee.Text = "Coffee ($2.99)";

            // Coke CheckBox
            this.chkCoke.AutoSize = true;
            this.chkCoke.Font = new System.Drawing.Font("Arial", 10F);
            this.chkCoke.Location = new System.Drawing.Point(50, 150);
            this.chkCoke.Text = "Coke ($1.99)";

            // Calculate Bill Button
            this.btnCalculate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.Location = new System.Drawing.Point(50, 200);
            this.btnCalculate.Size = new System.Drawing.Size(150, 30);
            this.btnCalculate.Text = "Calculate Bill";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // Form Properties
            this.ClientSize = new System.Drawing.Size(250, 270);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.chkPizza);
            this.Controls.Add(this.chkBurger);
            this.Controls.Add(this.chkCoffee);
            this.Controls.Add(this.chkCoke);
            this.Controls.Add(this.btnCalculate);
            this.Text = "Bill Calculator";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
