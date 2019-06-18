namespace Login
{
    partial class studentInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.viewStudentMarks = new System.Windows.Forms.Button();
            this.exitAdminButton = new System.Windows.Forms.Button();
            this.viewstudentCourseButton = new System.Windows.Forms.Button();
            this.viewStudentInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewStudentMarks
            // 
            this.viewStudentMarks.Location = new System.Drawing.Point(118, 232);
            this.viewStudentMarks.Name = "viewStudentMarks";
            this.viewStudentMarks.Size = new System.Drawing.Size(178, 39);
            this.viewStudentMarks.TabIndex = 11;
            this.viewStudentMarks.Text = "View Student\'s Marks";
            this.viewStudentMarks.UseVisualStyleBackColor = true;
            // 
            // exitAdminButton
            // 
            this.exitAdminButton.Location = new System.Drawing.Point(118, 319);
            this.exitAdminButton.Name = "exitAdminButton";
            this.exitAdminButton.Size = new System.Drawing.Size(178, 39);
            this.exitAdminButton.TabIndex = 10;
            this.exitAdminButton.Text = "Exit to Log In";
            this.exitAdminButton.UseVisualStyleBackColor = true;
            this.exitAdminButton.Click += new System.EventHandler(this.exitAdminButton_Click);
            // 
            // viewstudentCourseButton
            // 
            this.viewstudentCourseButton.Location = new System.Drawing.Point(118, 162);
            this.viewstudentCourseButton.Name = "viewstudentCourseButton";
            this.viewstudentCourseButton.Size = new System.Drawing.Size(178, 39);
            this.viewstudentCourseButton.TabIndex = 9;
            this.viewstudentCourseButton.Text = "View Student Course";
            this.viewstudentCourseButton.UseVisualStyleBackColor = true;
            // 
            // viewStudentInfo
            // 
            this.viewStudentInfo.Location = new System.Drawing.Point(118, 93);
            this.viewStudentInfo.Name = "viewStudentInfo";
            this.viewStudentInfo.Size = new System.Drawing.Size(178, 39);
            this.viewStudentInfo.TabIndex = 8;
            this.viewStudentInfo.Text = "View Student Info";
            this.viewStudentInfo.UseVisualStyleBackColor = true;
            this.viewStudentInfo.Click += new System.EventHandler(this.addEditStudent_Click);
            // 
            // studentInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 450);
            this.Controls.Add(this.viewStudentMarks);
            this.Controls.Add(this.exitAdminButton);
            this.Controls.Add(this.viewstudentCourseButton);
            this.Controls.Add(this.viewStudentInfo);
            this.Name = "studentInterface";
            this.Text = "Student Interface";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewStudentMarks;
        private System.Windows.Forms.Button exitAdminButton;
        private System.Windows.Forms.Button viewstudentCourseButton;
        private System.Windows.Forms.Button viewStudentInfo;
    }
}