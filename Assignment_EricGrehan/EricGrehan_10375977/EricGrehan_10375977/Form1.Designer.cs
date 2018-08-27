namespace EricGrehan_10375977
{
    partial class Form1
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
            this.Exit = new System.Windows.Forms.Button();
            this.AddNewStudent = new System.Windows.Forms.Button();
            this.EditStudent = new System.Windows.Forms.Button();
            this.DeleteStudent = new System.Windows.Forms.Button();
            this.ViewDatabaseHistory = new System.Windows.Forms.Button();
            this.Progress = new System.Windows.Forms.Label();
            this.butXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(151, 298);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(110, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Log Out";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // AddNewStudent
            // 
            this.AddNewStudent.Location = new System.Drawing.Point(151, 76);
            this.AddNewStudent.Name = "AddNewStudent";
            this.AddNewStudent.Size = new System.Drawing.Size(110, 23);
            this.AddNewStudent.TabIndex = 2;
            this.AddNewStudent.Text = "Add New Student";
            this.AddNewStudent.UseVisualStyleBackColor = true;
            this.AddNewStudent.Click += new System.EventHandler(this.AddNewStudent_Click);
            // 
            // EditStudent
            // 
            this.EditStudent.Location = new System.Drawing.Point(151, 120);
            this.EditStudent.Name = "EditStudent";
            this.EditStudent.Size = new System.Drawing.Size(110, 23);
            this.EditStudent.TabIndex = 3;
            this.EditStudent.Text = "Edit Student";
            this.EditStudent.UseVisualStyleBackColor = true;
            this.EditStudent.Click += new System.EventHandler(this.EditStudent_Click);
            // 
            // DeleteStudent
            // 
            this.DeleteStudent.Location = new System.Drawing.Point(151, 162);
            this.DeleteStudent.Name = "DeleteStudent";
            this.DeleteStudent.Size = new System.Drawing.Size(110, 23);
            this.DeleteStudent.TabIndex = 4;
            this.DeleteStudent.Text = "Delete Student";
            this.DeleteStudent.UseVisualStyleBackColor = true;
            this.DeleteStudent.Click += new System.EventHandler(this.DeleteStudent_Click);
            // 
            // ViewDatabaseHistory
            // 
            this.ViewDatabaseHistory.Location = new System.Drawing.Point(151, 211);
            this.ViewDatabaseHistory.Name = "ViewDatabaseHistory";
            this.ViewDatabaseHistory.Size = new System.Drawing.Size(110, 23);
            this.ViewDatabaseHistory.TabIndex = 5;
            this.ViewDatabaseHistory.Text = "View Database History";
            this.ViewDatabaseHistory.UseVisualStyleBackColor = true;
            this.ViewDatabaseHistory.Click += new System.EventHandler(this.ViewDatabaseHistory_Click);
            // 
            // Progress
            // 
            this.Progress.AutoSize = true;
            this.Progress.Location = new System.Drawing.Point(148, 339);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(48, 13);
            this.Progress.TabIndex = 6;
            this.Progress.Text = "Progress";
            // 
            // butXML
            // 
            this.butXML.Location = new System.Drawing.Point(151, 252);
            this.butXML.Name = "butXML";
            this.butXML.Size = new System.Drawing.Size(110, 23);
            this.butXML.TabIndex = 7;
            this.butXML.Text = "Export to XML";
            this.butXML.UseVisualStyleBackColor = true;
            this.butXML.Click += new System.EventHandler(this.butXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 469);
            this.Controls.Add(this.butXML);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.ViewDatabaseHistory);
            this.Controls.Add(this.DeleteStudent);
            this.Controls.Add(this.EditStudent);
            this.Controls.Add(this.AddNewStudent);
            this.Controls.Add(this.Exit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button AddNewStudent;
        private System.Windows.Forms.Button EditStudent;
        private System.Windows.Forms.Button DeleteStudent;
        private System.Windows.Forms.Button ViewDatabaseHistory;
        private System.Windows.Forms.Label Progress;
        private System.Windows.Forms.Button butXML;
    }
}

