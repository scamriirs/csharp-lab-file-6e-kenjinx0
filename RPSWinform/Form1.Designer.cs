namespace RPSWinform
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelPlayer;
        private Label labelComputer;
        private RadioButton radioRock;
        private RadioButton radioPaper;
        private RadioButton radioScissors;
        private PictureBox pictureBoxPlayer;
        private PictureBox pictureBoxComputer;
        private Button buttonSubmit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelPlayer = new Label();
            this.labelComputer = new Label();
            this.radioRock = new RadioButton();
            this.radioPaper = new RadioButton();
            this.radioScissors = new RadioButton();
            this.pictureBoxPlayer = new PictureBox();
            this.pictureBoxComputer = new PictureBox();
            this.buttonSubmit = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComputer)).BeginInit();
            this.SuspendLayout();

            // labelPlayer
            this.labelPlayer.Text = "Player 1";
            this.labelPlayer.Location = new System.Drawing.Point(40, 20);
            this.labelPlayer.Size = new System.Drawing.Size(100, 20);

            // labelComputer
            this.labelComputer.Text = "Computer";
            this.labelComputer.Location = new System.Drawing.Point(250, 20);
            this.labelComputer.Size = new System.Drawing.Size(100, 20);

            // radioRock
            this.radioRock.Text = "Rock";
            this.radioRock.Location = new System.Drawing.Point(40, 50);

            // radioPaper
            this.radioPaper.Text = "Paper";
            this.radioPaper.Location = new System.Drawing.Point(40, 75);

            // radioScissors
            this.radioScissors.Text = "Scissors";
            this.radioScissors.Location = new System.Drawing.Point(40, 100);

            // pictureBoxPlayer
            this.pictureBoxPlayer.Location = new System.Drawing.Point(40, 140);
            this.pictureBoxPlayer.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxPlayer.SizeMode = PictureBoxSizeMode.StretchImage;

            // pictureBoxComputer
            this.pictureBoxComputer.Location = new System.Drawing.Point(250, 140);
            this.pictureBoxComputer.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxComputer.SizeMode = PictureBoxSizeMode.StretchImage;

            // buttonSubmit
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.Location = new System.Drawing.Point(150, 260);
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.labelComputer);
            this.Controls.Add(this.radioRock);
            this.Controls.Add(this.radioPaper);
            this.Controls.Add(this.radioScissors);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Controls.Add(this.pictureBoxComputer);
            this.Controls.Add(this.buttonSubmit);
            this.Text = "Rock Paper Scissors";

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComputer)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
