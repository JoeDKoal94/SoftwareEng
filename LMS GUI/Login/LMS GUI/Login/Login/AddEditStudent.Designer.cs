namespace Login
{
    partial class addEditInfoForm
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
            this.newStudentButton = new System.Windows.Forms.Button();
            this.editStudentButton = new System.Windows.Forms.Button();
            this.backButtonEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newStudentButton
            // 
            this.newStudentButton.Location = new System.Drawing.Point(51, 43);
            this.newStudentButton.Name = "newStudentButton";
            this.newStudentButton.Size = new System.Drawing.Size(130, 47);
            this.newStudentButton.TabIndex = 0;
            this.newStudentButton.Text = "Add New Student Info";
            this.newStudentButton.UseVisualStyleBackColor = true;
            // 
            // editStudentButton
            // 
            this.editStudentButton.Location = new System.Drawing.Point(242, 43);
            this.editStudentButton.Name = "editStudentButton";
            this.editStudentButton.Size = new System.Drawing.Size(140, 47);
            this.editStudentButton.TabIndex = 1;
            this.editStudentButton.Text = "Edit Existing Student Info";
            this.editStudentButton.UseVisualStyleBackColor = true;
            // 
            // backButtonEdit
            // 
            this.backButtonEdit.Location = new System.Drawing.Point(119, 108);
            this.backButtonEdit.Name = "backButtonEdit";
            this.backButtonEdit.Size = new System.Drawing.Size(199, 40);
            this.backButtonEdit.TabIndex = 2;
            this.backButtonEdit.Text = "Back";
            this.backButtonEdit.UseVisualStyleBackColor = true;
            this.backButtonEdit.Click += new System.EventHandler(this.backButtonEdit_Click);
            // 
            // addEditInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 173);
            this.Controls.Add(this.backButtonEdit);
            this.Controls.Add(this.editStudentButton);
            this.Controls.Add(this.newStudentButton);
            this.Name = "addEditInfoForm";
            this.Text = "Add/Edit Student Info";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newStudentButton;
        private System.Windows.Forms.Button editStudentButton;
        private System.Windows.Forms.Button backButtonEdit;
    }
}