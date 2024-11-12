namespace Student_Management_System_using_Windows_Forms_LLG.Presentation_Layer
{
    partial class StudentForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtstudentID = new System.Windows.Forms.TextBox();
            this.txtstudentname = new System.Windows.Forms.TextBox();
            this.txtstudentage = new System.Windows.Forms.TextBox();
            this.txtcourse = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnViewAllstudents = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.dgvdisplay = new System.Windows.Forms.DataGridView();
            this.lstview = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(69, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(69, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(69, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Student Course:";
            // 
            // txtstudentID
            // 
            this.txtstudentID.Location = new System.Drawing.Point(260, 140);
            this.txtstudentID.Name = "txtstudentID";
            this.txtstudentID.Size = new System.Drawing.Size(154, 22);
            this.txtstudentID.TabIndex = 5;
            this.txtstudentID.TextChanged += new System.EventHandler(this.txtstudentID_TextChanged);
            // 
            // txtstudentname
            // 
            this.txtstudentname.Location = new System.Drawing.Point(260, 191);
            this.txtstudentname.Name = "txtstudentname";
            this.txtstudentname.Size = new System.Drawing.Size(154, 22);
            this.txtstudentname.TabIndex = 6;
            // 
            // txtstudentage
            // 
            this.txtstudentage.Location = new System.Drawing.Point(260, 250);
            this.txtstudentage.Name = "txtstudentage";
            this.txtstudentage.Size = new System.Drawing.Size(154, 22);
            this.txtstudentage.TabIndex = 7;
            // 
            // txtcourse
            // 
            this.txtcourse.Location = new System.Drawing.Point(260, 302);
            this.txtcourse.Name = "txtcourse";
            this.txtcourse.Size = new System.Drawing.Size(154, 22);
            this.txtcourse.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(74, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add Student";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateStudent.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnUpdateStudent.Location = new System.Drawing.Point(481, 409);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(127, 41);
            this.btnUpdateStudent.TabIndex = 11;
            this.btnUpdateStudent.Text = "Update";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnViewAllstudents
            // 
            this.btnViewAllstudents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewAllstudents.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnViewAllstudents.Location = new System.Drawing.Point(312, 409);
            this.btnViewAllstudents.Name = "btnViewAllstudents";
            this.btnViewAllstudents.Size = new System.Drawing.Size(102, 41);
            this.btnViewAllstudents.TabIndex = 12;
            this.btnViewAllstudents.Text = "View students";
            this.btnViewAllstudents.UseVisualStyleBackColor = true;
            this.btnViewAllstudents.Click += new System.EventHandler(this.btnViewAllstudents_Click);
            // 
            // btndelete
            // 
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btndelete.Location = new System.Drawing.Point(666, 409);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(108, 41);
            this.btndelete.TabIndex = 13;
            this.btndelete.Text = "Delete Student";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerateReport.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnGenerateReport.Location = new System.Drawing.Point(846, 408);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(234, 42);
            this.btnGenerateReport.TabIndex = 14;
            this.btnGenerateReport.Text = "GenerateSummarry";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // dgvdisplay
            // 
            this.dgvdisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdisplay.Location = new System.Drawing.Point(459, 140);
            this.dgvdisplay.Name = "dgvdisplay";
            this.dgvdisplay.RowHeadersWidth = 51;
            this.dgvdisplay.RowTemplate.Height = 24;
            this.dgvdisplay.Size = new System.Drawing.Size(347, 184);
            this.dgvdisplay.TabIndex = 15;
            // 
            // lstview
            // 
            this.lstview.HideSelection = false;
            this.lstview.Location = new System.Drawing.Point(835, 140);
            this.lstview.Name = "lstview";
            this.lstview.Size = new System.Drawing.Size(267, 184);
            this.lstview.TabIndex = 16;
            this.lstview.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(394, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(426, 49);
            this.label5.TabIndex = 17;
            this.label5.Text = "STUDENT INFO FORM";
            // 
            // StudentForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1130, 529);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstview);
            this.Controls.Add(this.dgvdisplay);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnViewAllstudents);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtcourse);
            this.Controls.Add(this.txtstudentage);
            this.Controls.Add(this.txtstudentname);
            this.Controls.Add(this.txtstudentID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentForm2";
            this.Text = "StudentForm2";
            this.Load += new System.EventHandler(this.StudentForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtstudentID;
        private System.Windows.Forms.TextBox txtstudentname;
        private System.Windows.Forms.TextBox txtstudentage;
        private System.Windows.Forms.TextBox txtcourse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnViewAllstudents;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.DataGridView dgvdisplay;
        private System.Windows.Forms.ListView lstview;
        private System.Windows.Forms.Label label5;
    }
}