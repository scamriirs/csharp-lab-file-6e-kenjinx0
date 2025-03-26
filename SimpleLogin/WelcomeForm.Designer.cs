namespace SimpleLoginApp
{
    partial class WelcomeForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcomeMessage.ForeColor = System.Drawing.Color.Green;
            this.lblWelcomeMessage.Location = new System.Drawing.Point(50, 50);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(300, 80);
            this.lblWelcomeMessage.TabIndex = 0;
            this.lblWelcomeMessage.Text = "WELCOME";
            this.lblWelcomeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(150, 150);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // WelcomeForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblWelcomeMessage);
            this.Name = "WelcomeForm";
            this.Text = "Welcome";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.Button btnClose;
    }
}
