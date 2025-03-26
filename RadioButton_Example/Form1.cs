namespace RadioButton_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("You are American.");
            }
            else if (radioButton2.Checked == true)
            {
                MessageBox.Show("You are Indian.");
            }
            else
            {
                MessageBox.Show("You are Canadian.");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if(radioButton4.Checked == true)
            {
                this.BackColor = Color.Red;
            }
            else if(radioButton5.Checked == true)
            {
                this.BackColor = Color.LimeGreen;
            }
            else
            {
                this.BackColor = Color.SkyBlue;
            }
        }
    }
}
