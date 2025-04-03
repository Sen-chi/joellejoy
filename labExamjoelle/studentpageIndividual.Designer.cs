namespace labExamjoelle
{
    partial class studentpageIndividual
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label studentIdLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label guardianLabel;
        private System.Windows.Forms.Label hobbiesLabel;
        private System.Windows.Forms.Button closeBtn;

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
            this.studentIdLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.guardianLabel = new System.Windows.Forms.Label();
            this.hobbiesLabel = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentIdLabel
            // 
            this.studentIdLabel.AutoSize = true;
            this.studentIdLabel.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIdLabel.Location = new System.Drawing.Point(22, 25);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.Size = new System.Drawing.Size(132, 27);
            this.studentIdLabel.TabIndex = 0;
            this.studentIdLabel.Text = "Student ID:";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameLabel.Location = new System.Drawing.Point(24, 52);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(127, 27);
            this.fullNameLabel.TabIndex = 1;
            this.fullNameLabel.Text = "Full Name:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(24, 79);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(101, 27);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Address:";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.Location = new System.Drawing.Point(22, 106);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(188, 27);
            this.contactLabel.TabIndex = 3;
            this.contactLabel.Text = "Contact Number:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(22, 133);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(80, 27);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email:";
            // 
            // guardianLabel
            // 
            this.guardianLabel.AutoSize = true;
            this.guardianLabel.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardianLabel.Location = new System.Drawing.Point(22, 160);
            this.guardianLabel.Name = "guardianLabel";
            this.guardianLabel.Size = new System.Drawing.Size(182, 27);
            this.guardianLabel.TabIndex = 5;
            this.guardianLabel.Text = "Guardian Name:";
            // 
            // hobbiesLabel
            // 
            this.hobbiesLabel.AutoSize = true;
            this.hobbiesLabel.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hobbiesLabel.Location = new System.Drawing.Point(24, 187);
            this.hobbiesLabel.Name = "hobbiesLabel";
            this.hobbiesLabel.Size = new System.Drawing.Size(99, 27);
            this.hobbiesLabel.TabIndex = 6;
            this.hobbiesLabel.Text = "Hobbies:";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.closeBtn.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(27, 249);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(117, 49);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn);
            // 
            // StudentPage_Individual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 333);
            this.Controls.Add(this.studentIdLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.guardianLabel);
            this.Controls.Add(this.hobbiesLabel);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "StudentPage_Individual";
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.StudentPage_Individual_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
