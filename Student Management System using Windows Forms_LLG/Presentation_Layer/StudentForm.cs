using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Student_Management_System_using_Windows_Forms_LLG.Business_Logic_Layer;
using Student_Management_System_using_Windows_Forms_LLG.Data_Layer;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Drawing.Drawing2D;

namespace Student_Management_System_using_Windows_Forms_LLG.Presentation_Layer
{
    public partial class StudentForm : Form
    {
        DataHandler dataHandler = new DataHandler();
        FileHandler FL = new FileHandler();
        public StudentForm()
        {
            InitializeComponent();
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtstudentage.Text, out int age))
            {
                MessageBox.Show("Enter a valid age");
                return;
            }

            var newStudent = new Student(txtstudentID.Text, txtstudentname.Text, age, txtcourse.Text);
            dataHandler.AddStudent(newStudent);
            RefreshStudentList();
            MessageBox.Show("New student has been added.");



        }

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the list of students from the file
                List<Student> students = FL.ReadStudents();

                // Bind the retrieved list to the DataGridView to display all students
                dgvdisplay.DataSource = students;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying students: {ex.Message}");
            }
        }

      

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void StudentForm_Activated(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\direo\Downloads\5200-183786525.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            // Configure settings to hide controls and fit to window size
            axWindowsMediaPlayer1.uiMode = "None";
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.stretchToFit = true;
            axWindowsMediaPlayer1.BackColor = this.BackColor;
            axWindowsMediaPlayer1.settings.autoStart = true;
        }
        private void RefreshStudentList()
        {
            dgvdisplay.DataSource = null;
            dgvdisplay.DataSource = dataHandler.GetAllStudents();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
           

            var updatedStudent = new Student(txtstudentID.Text, txtstudentname.Text,int.Parse(txtstudentage.Text), txtcourse.Text);
            if (dataHandler.UpdateStudent(updatedStudent))
            {
                RefreshStudentList();
                MessageBox.Show("Student information updated.");
            }
            else
            {
                MessageBox.Show("Student not found.");
            }

        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            string studentID = txtstudentID.Text;
            if (dataHandler.DeleteStudent(studentID))
            {
                RefreshStudentList();
                MessageBox.Show("Student deleted.");
            }
            else
            {
                MessageBox.Show("Student not found.");
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            dataHandler.GenerateSummary();
        }
    }
}
