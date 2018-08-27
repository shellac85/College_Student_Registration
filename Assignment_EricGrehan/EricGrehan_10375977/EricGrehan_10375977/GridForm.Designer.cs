namespace EricGrehan_10375977
{
    partial class GridForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butBack = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.butViewHistory = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 397);
            this.dataGridView1.TabIndex = 0;
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(575, 415);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(75, 23);
            this.butBack.TabIndex = 2;
            this.butBack.Text = "Log Out";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(12, 415);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 3;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // butViewHistory
            // 
            this.butViewHistory.Location = new System.Drawing.Point(312, 415);
            this.butViewHistory.Name = "butViewHistory";
            this.butViewHistory.Size = new System.Drawing.Size(133, 23);
            this.butViewHistory.TabIndex = 5;
            this.butViewHistory.Text = "View Inserted History";
            this.butViewHistory.UseVisualStyleBackColor = true;
            this.butViewHistory.Click += new System.EventHandler(this.butViewHistory_Click);
            // 
            // butEdit
            // 
            this.butEdit.Location = new System.Drawing.Point(93, 415);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(75, 23);
            this.butEdit.TabIndex = 7;
            this.butEdit.Text = "Edit Student";
            this.butEdit.UseVisualStyleBackColor = true;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(174, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete Student";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "View Deleted History";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.butEdit);
            this.Controls.Add(this.butViewHistory);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GridForm";
            this.Text = "GridForm";
            this.Load += new System.EventHandler(this.GridForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button butViewHistory;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
    }
}