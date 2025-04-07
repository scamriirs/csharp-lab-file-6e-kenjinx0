using System.Windows.Forms;

namespace RPSWinform
{
    public partial class ResultForm : Form
    {
        public ResultForm(string result)
        {
            InitializeComponent();
            labelResult.Text = result;
        }
    }
}
