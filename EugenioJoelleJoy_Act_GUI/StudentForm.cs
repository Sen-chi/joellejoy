using EugenioJoelleJoy_Act_GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EugenioJoelleJoy_Act_GUI
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            // Mock Student Data
            StudentNameLabel.Text = "Joelle Joy M. Eugenio";
            StudentAgeLabel.Text = "20";
            StudentAddressLabel.Text = "456 Cat Street";
            StudentContactLabel.Text = "090987654321";
            StudentEmailLabel.Text = "email@sample.com";
            StudentCourseYearLabel.Text = "BSIT Third";
            ParentNameLabel.Text = "Richelle Eugenio";
            ParentContactLabel.Text = "09123456789";
            HobbiesLabel.Text = "Watching anime, reading manga/hwa/hua, playing games";
            NicknameLabel.Text = "Senri";
        }

        private void AddImageBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Image functionality is not implemented.", "Feature Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChangeImageBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change Image functionality is not implemented.", "Feature Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditUpdateBtn_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(this);
            this.Hide();
            editForm.Show();
        }

    }
}