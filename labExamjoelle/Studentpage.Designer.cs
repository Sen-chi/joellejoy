namespace labExamjoelle
{
    partial class Studentpage
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel studentsPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.studentsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // studentsPanel
            // 
            this.studentsPanel.AutoScroll = true;
            this.studentsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.studentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentsPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsPanel.Location = new System.Drawing.Point(0, 0);
            this.studentsPanel.Name = "studentsPanel";
            this.studentsPanel.Size = new System.Drawing.Size(800, 450);
            this.studentsPanel.TabIndex = 0;
            // 
            // StudentPage
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.studentsPanel);
            this.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StudentPage";
            this.Text = "Student Page";
            this.ResumeLayout(false);

        }
    }
}
