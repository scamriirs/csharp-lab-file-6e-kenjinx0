namespace RPSWinform
{
    partial class ResultForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // labelResult
            this.labelResult.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelResult.Location = new System.Drawing.Point(30, 40);
            this.labelResult.Size = new System.Drawing.Size(220, 40);
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ResultForm
            this.ClientSize = new System.Drawing.Size(280, 120);
            this.Controls.Add(this.labelResult);
            this.Text = "Result";
            this.ResumeLayout(false);
        }
    }
}
