using MySql.Data.MySqlClient;  // Add MySQL client
using System;
using System.Windows.Forms;

namespace labExamjoelle
{
    public partial class studentpageIndividual : Form
    {
        private string connectionString = "Server=127.0.0.1;Database=studentinfodb;User Id=root;";
        private int studentId;

        public studentpageIndividual(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            LoadStudentDetails();
        }

        private void LoadStudentDetails()
        {
            // Create a connection to the MySQL database
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM StudentRecordTB WHERE studentId = @studentId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@studentId", studentId); // Add parameter to prevent SQL injection

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Populate the form with student data
                        studentIdLabel.Text = "Student ID: " + reader["studentId"].ToString();
                        fullNameLabel.Text = "Full Name: " + reader["firstName"].ToString() + " " + reader["lastName"].ToString();
                        addressLabel.Text = "Address: " + reader["houseNo"].ToString() + ", " + reader["brgyName"].ToString() + ", " + reader["municipality"].ToString() + ", " + reader["province"].ToString() + ", " + reader["region"].ToString() + ", " + reader["country"].ToString();
                        contactLabel.Text = "Contact: " + reader["studContactNo"].ToString();
                        emailLabel.Text = "Email: " + reader["emailAddress"].ToString();
                        guardianLabel.Text = "Guardian: " + reader["guardianFirstName"].ToString() + " " + reader["guardianLastName"].ToString();
                        hobbiesLabel.Text = "Hobbies: " + reader["hobbies"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void CloseBtn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentPage_Individual_Load(object sender, EventArgs e)
        {

        }
    }
}
