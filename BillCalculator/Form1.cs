using System;
using System.Drawing;
using System.Windows.Forms;

namespace BillCalculator
{
    public partial class FormBillCalculator : Form
    {
        // Prices for items
        private const double PRICE_PIZZA = 8.99;
        private const double PRICE_BURGER = 5.49;
        private const double PRICE_COFFEE = 2.99;
        private const double PRICE_COKE = 1.99;

        public FormBillCalculator()
        {
            InitializeComponent();
            this.Resize += new EventHandler(FormBillCalculator_Resize);
            CenterComponents();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double total = 0;

            if (chkPizza.Checked) total += PRICE_PIZZA;
            if (chkBurger.Checked) total += PRICE_BURGER;
            if (chkCoffee.Checked) total += PRICE_COFFEE;
            if (chkCoke.Checked) total += PRICE_COKE;

            if (total == 0)
            {
                MessageBox.Show("Please select at least one item!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Your total is ${total:F2}.\nYour food will be ready soon!", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormBillCalculator_Resize(object sender, EventArgs e)
        {
            CenterComponents();
        }

        private void CenterComponents()
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            int centerX = formWidth / 2;

            lblMenu.Location = new Point(centerX - lblMenu.Width / 2, 20);
            chkPizza.Location = new Point(centerX - chkPizza.Width / 2, 60);
            chkBurger.Location = new Point(centerX - chkBurger.Width / 2, 90);
            chkCoffee.Location = new Point(centerX - chkCoffee.Width / 2, 120);
            chkCoke.Location = new Point(centerX - chkCoke.Width / 2, 150);
            btnCalculate.Location = new Point(centerX - btnCalculate.Width / 2, 200);
        }
    }
}
