using MySql.Data.MySqlClient;  // Add MySQL client
using System;
using System.Data;
using System.Windows.Forms;

namespace labExamjoelle
{
    public partial class Studentpage : Form
    {
        // MySQL connection string (adjust as needed)
        private string connectionString = "Server=127.0.0.1;Database=studentinfodb;User Id=root;";

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public Studentpage()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            // Use MySqlConnection for MySQL databases
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT studentId, CONCAT(firstName, ' ', lastName) AS FullName FROM StudentRecordTB";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        int studentId = Convert.ToInt32(row["studentId"]);
                        string fullName = row["FullName"].ToString();
                        AddStudentRow(studentId, fullName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void AddStudentRow(int studentId, string fullName)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel { Width = 300, Height = 40 };
            Label nameLabel = new Label { Text = fullName, Width = 200 };
            Button viewButton = new Button { Text = "VIEW", Tag = studentId, Width = 80 };
            viewButton.Click += ViewButton_Click;

            panel.Controls.Add(nameLabel);
            panel.Controls.Add(viewButton);
            studentsPanel.Controls.Add(panel); // Ensure studentsPanel exists in your Form's Designer
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int studentId = (int)clickedButton.Tag;

            studentpageIndividual studentPage = new studentpageIndividual(studentId);
            studentPage.Show();
        }
    }
}
