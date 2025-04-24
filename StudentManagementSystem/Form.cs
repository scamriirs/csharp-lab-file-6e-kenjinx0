using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Students VALUES (@RollNo, @Name, @Course, @Age)";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@RollNo", txtRollNo.Text);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Course", txtCourse.Text);
                cmd.Parameters.AddWithValue("@Age", txtAge.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Saved!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Students SET Name=@Name, Course=@Course, Age=@Age WHERE RollNo=@RollNo";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@RollNo", txtRollNo.Text);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Course", txtCourse.Text);
                cmd.Parameters.AddWithValue("@Age", txtAge.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Updated!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Students WHERE RollNo=@RollNo";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@RollNo", txtRollNo.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Deleted!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Students WHERE RollNo=@RollNo";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@RollNo", txtRollNo.Text);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtName.Text = reader["Name"].ToString();
                    txtCourse.Text = reader["Course"].ToString();
                    txtAge.Text = reader["Age"].ToString();
                }
                else
                {
                    MessageBox.Show("No record found!");
                }
                con.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRollNo.Clear();
            txtName.Clear();
            txtCourse.Clear();
            txtAge.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
