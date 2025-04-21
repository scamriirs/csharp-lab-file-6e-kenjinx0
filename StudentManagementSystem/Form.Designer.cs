namespace StudentManagementSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();

            this.lblRollNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Title Label
            this.lblTitle.Text = "Student Management System";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Height = 40;

            // Labels and TextBoxes
            this.lblRollNo.Text = "Roll No:";
            this.lblName.Text = "Name:";
            this.lblCourse.Text = "Course:";
            this.lblAge.Text = "Age:";

            this.lblRollNo.SetBounds(50, 60, 100, 25);
            this.lblName.SetBounds(50, 100, 100, 25);
            this.lblCourse.SetBounds(50, 140, 100, 25);
            this.lblAge.SetBounds(50, 180, 100, 25);

            this.txtRollNo.SetBounds(160, 60, 200, 25);
            this.txtName.SetBounds(160, 100, 200, 25);
            this.txtCourse.SetBounds(160, 140, 200, 25);
            this.txtAge.SetBounds(160, 180, 200, 25);

            // Buttons
            this.btnSave.Text = "Save";
            this.btnUpdate.Text = "Update";
            this.btnDelete.Text = "Delete";
            this.btnSearch.Text = "Search";
            this.btnClear.Text = "Clear";
            this.btnExit.Text = "Exit";

            this.btnSave.SetBounds(50, 230, 80, 30);
            this.btnUpdate.SetBounds(140, 230, 80, 30);
            this.btnDelete.SetBounds(230, 230, 80, 30);
            this.btnSearch.SetBounds(320, 230, 80, 30);
            this.btnClear.SetBounds(410, 230, 80, 30);
            this.btnExit.SetBounds(500, 230, 80, 30);

            // Event Handlers
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // Controls
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRollNo);
            this.Controls.Add(this.txtRollNo);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtAge);

            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);

            this.Text = "Student Management";
            this.ClientSize = new System.Drawing.Size(650, 300);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle, lblRollNo, lblName, lblCourse, lblAge;
        private System.Windows.Forms.TextBox txtRollNo, txtName, txtCourse, txtAge;
        private System.Windows.Forms.Button btnSave, btnUpdate, btnDelete, btnSearch, btnClear, btnExit;
    }
}
