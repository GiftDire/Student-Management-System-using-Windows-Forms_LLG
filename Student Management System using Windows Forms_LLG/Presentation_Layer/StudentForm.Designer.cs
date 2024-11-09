namespace Student_Management_System_using_Windows_Forms_LLG.Presentation_Layer
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.BtnAddStudent = new System.Windows.Forms.Button();
            this.btnViewStudents = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtstudentID = new System.Windows.Forms.TextBox();
            this.txtstudentname = new System.Windows.Forms.TextBox();
            this.txtstudentage = new System.Windows.Forms.TextBox();
            this.txtcourse = new System.Windows.Forms.TextBox();
            this.dgvdisplay = new System.Windows.Forms.DataGridView();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAddStudent
            // 
            this.BtnAddStudent.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnAddStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAddStudent.BackgroundImage")));
            this.BtnAddStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAddStudent.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.BtnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddStudent.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddStudent.ForeColor = System.Drawing.Color.White;
            this.BtnAddStudent.Location = new System.Drawing.Point(79, 444);
            this.BtnAddStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddStudent.Name = "BtnAddStudent";
            this.BtnAddStudent.Size = new System.Drawing.Size(144, 62);
            this.BtnAddStudent.TabIndex = 0;
            this.BtnAddStudent.Text = "Add New Student";
            this.BtnAddStudent.UseVisualStyleBackColor = false;
            this.BtnAddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // btnViewStudents
            // 
            this.btnViewStudents.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnViewStudents.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewStudents.BackgroundImage")));
            this.btnViewStudents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnViewStudents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewStudents.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnViewStudents.ForeColor = System.Drawing.Color.White;
            this.btnViewStudents.Location = new System.Drawing.Point(307, 444);
            this.btnViewStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewStudents.Name = "btnViewStudents";
            this.btnViewStudents.Size = new System.Drawing.Size(147, 62);
            this.btnViewStudents.TabIndex = 1;
            this.btnViewStudents.Text = "View All Student";
            this.btnViewStudents.UseVisualStyleBackColor = false;
            this.btnViewStudents.Click += new System.EventHandler(this.btnViewStudents_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateStudent.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnUpdateStudent.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateStudent.Location = new System.Drawing.Point(531, 444);
            this.btnUpdateStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(181, 62);
            this.btnUpdateStudent.TabIndex = 2;
            this.btnUpdateStudent.Text = "Update Student Info";
            this.btnUpdateStudent.UseVisualStyleBackColor = false;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnDeleteStudent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteStudent.Image")));
            this.btnDeleteStudent.Location = new System.Drawing.Point(785, 444);
            this.btnDeleteStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(115, 62);
            this.btnDeleteStudent.TabIndex = 3;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerateReport.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateReport.Image")));
            this.btnGenerateReport.Location = new System.Drawing.Point(949, 444);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(179, 62);
            this.btnGenerateReport.TabIndex = 4;
            this.btnGenerateReport.Text = "Generate Student Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(148, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(147, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Student Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(147, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Student Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(147, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Course:";
            // 
            // txtstudentID
            // 
            this.txtstudentID.Location = new System.Drawing.Point(307, 172);
            this.txtstudentID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtstudentID.Name = "txtstudentID";
            this.txtstudentID.Size = new System.Drawing.Size(285, 22);
            this.txtstudentID.TabIndex = 9;
            // 
            // txtstudentname
            // 
            this.txtstudentname.Location = new System.Drawing.Point(307, 236);
            this.txtstudentname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtstudentname.Name = "txtstudentname";
            this.txtstudentname.Size = new System.Drawing.Size(285, 22);
            this.txtstudentname.TabIndex = 10;
            // 
            // txtstudentage
            // 
            this.txtstudentage.Location = new System.Drawing.Point(307, 292);
            this.txtstudentage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtstudentage.Name = "txtstudentage";
            this.txtstudentage.Size = new System.Drawing.Size(285, 22);
            this.txtstudentage.TabIndex = 11;
            // 
            // txtcourse
            // 
            this.txtcourse.Location = new System.Drawing.Point(307, 345);
            this.txtcourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcourse.Name = "txtcourse";
            this.txtcourse.Size = new System.Drawing.Size(285, 22);
            this.txtcourse.TabIndex = 12;
            // 
            // dgvdisplay
            // 
            this.dgvdisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdisplay.Location = new System.Drawing.Point(669, 172);
            this.dgvdisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvdisplay.Name = "dgvdisplay";
            this.dgvdisplay.RowHeadersWidth = 51;
            this.dgvdisplay.RowTemplate.Height = 24;
            this.dgvdisplay.Size = new System.Drawing.Size(459, 197);
            this.dgvdisplay.TabIndex = 13;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(-11, -1);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(910, 508);
            this.axWindowsMediaPlayer1.TabIndex = 14;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Menu;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(431, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(390, 47);
            this.label5.TabIndex = 15;
            this.label5.Text = "STUDENT INFO FORM";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 539);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvdisplay);
            this.Controls.Add(this.txtcourse);
            this.Controls.Add(this.txtstudentage);
            this.Controls.Add(this.txtstudentname);
            this.Controls.Add(this.txtstudentID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.btnViewStudents);
            this.Controls.Add(this.BtnAddStudent);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Activated += new System.EventHandler(this.StudentForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddStudent;
        private System.Windows.Forms.Button btnViewStudents;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtstudentID;
        private System.Windows.Forms.TextBox txtstudentname;
        private System.Windows.Forms.TextBox txtstudentage;
        private System.Windows.Forms.TextBox txtcourse;
        private System.Windows.Forms.DataGridView dgvdisplay;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label5;
    }
}