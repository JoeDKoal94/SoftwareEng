namespace Login
{
    partial class Dashboard
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
            this.editStudentMarks = new System.Windows.Forms.Button();
            this.exitAdminButton = new System.Windows.Forms.Button();
            this.studentCourseButton = new System.Windows.Forms.Button();
            this.addEditStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editStudentMarks
            // 
            this.editStudentMarks.Location = new System.Drawing.Point(82, 224);
            this.editStudentMarks.Name = "editStudentMarks";
            this.editStudentMarks.Size = new System.Drawing.Size(178, 39);
            this.editStudentMarks.TabIndex = 7;
            this.editStudentMarks.Text = "Edit Student\'s Marks";
            this.editStudentMarks.UseVisualStyleBackColor = true;
            // 
            // exitAdminButton
            // 
            this.exitAdminButton.Location = new System.Drawing.Point(82, 311);
            this.exitAdminButton.Name = "exitAdminButton";
            this.exitAdminButton.Size = new System.Drawing.Size(178, 39);
            this.exitAdminButton.TabIndex = 6;
            this.exitAdminButton.Text = "Exit to Log In";
            this.exitAdminButton.UseVisualStyleBackColor = true;
            this.exitAdminButton.Click += new System.EventHandler(this.exitAdminButton_Click);
            // 
            // studentCourseButton
            // 
            this.studentCourseButton.Location = new System.Drawing.Point(82, 154);
            this.studentCourseButton.Name = "studentCourseButton";
            this.studentCourseButton.Size = new System.Drawing.Size(178, 39);
            this.studentCourseButton.TabIndex = 5;
            this.studentCourseButton.Text = "Edit Student Course";
            this.studentCourseButton.UseVisualStyleBackColor = true;
            this.studentCourseButton.Click += new System.EventHandler(this.studentCourseButton_Click);
            // 
            // addEditStudent
            // 
            this.addEditStudent.Location = new System.Drawing.Point(82, 85);
            this.addEditStudent.Name = "addEditStudent";
            this.addEditStudent.Size = new System.Drawing.Size(178, 39);
            this.addEditStudent.TabIndex = 4;
            this.addEditStudent.Text = "Add/Edit Student Info";
            this.addEditStudent.UseVisualStyleBackColor = true;
            this.addEditStudent.Click += new System.EventHandler(this.addEditStudent_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 450);
            this.Controls.Add(this.editStudentMarks);
            this.Controls.Add(this.exitAdminButton);
            this.Controls.Add(this.studentCourseButton);
            this.Controls.Add(this.addEditStudent);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editStudentMarks;
        private System.Windows.Forms.Button exitAdminButton;
        private System.Windows.Forms.Button studentCourseButton;
        private System.Windows.Forms.Button addEditStudent;
    }
}