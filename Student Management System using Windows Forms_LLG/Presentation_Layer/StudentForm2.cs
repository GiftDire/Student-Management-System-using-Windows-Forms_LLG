using Student_Management_System_using_Windows_Forms_LLG.Business_Logic_Layer;
using Student_Management_System_using_Windows_Forms_LLG.Data_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Management_System_using_Windows_Forms_LLG.Presentation_Layer
{
    public partial class StudentForm2 : Form
    {
        DataHandler dataHandler = new DataHandler();
        FileHandler FL = new FileHandler();
     

        public StudentForm2()
        {
            InitializeComponent();
        }

        private void StudentForm2_Load(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtstudentID.Text))
            {
                MessageBox.Show("Please enter a Student ID.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtstudentname.Text))
            {
                MessageBox.Show("Please enter a Student Name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtcourse.Text))
            {
                MessageBox.Show("Please enter the Course.");
                return;
            }

            if (!int.TryParse(txtstudentage.Text, out int age) || age <= 0)
            {
                MessageBox.Show("Enter a valid age (greater than 0).");
                return;
            }


            var newStudent = new Student(txtstudentID.Text, txtstudentname.Text, age, txtcourse.Text);
            dataHandler.AddStudent(newStudent);
            RefreshStudentList();
            MessageBox.Show("New student has been added.");

            txtstudentID.Clear();
            txtstudentname.Clear();
            txtstudentage.Clear();
            txtcourse.Clear();

        }
        private void RefreshStudentList()
        {
            dgvdisplay.DataSource = null;
            dgvdisplay.DataSource = dataHandler.GetAllStudents();
        }

        private void btnViewAllstudents_Click(object sender, EventArgs e)
        {
            try
            {

                List<Student> students = FL.ReadStudents();
                dgvdisplay.DataSource = students;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying students: {ex.Message}");
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtstudentID.Text))
                {
                    MessageBox.Show("Please enter the Student ID.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtstudentname.Text))
                {
                    MessageBox.Show("Please enter the Student Name.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtstudentage.Text) || !int.TryParse(txtstudentage.Text, out int age))
                {
                    MessageBox.Show("Please enter a valid Age.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtcourse.Text))
                {
                    MessageBox.Show("Please enter the Course.");
                    return;
                }
                var updatedStudent = new Student(txtstudentID.Text, txtstudentname.Text, age, txtcourse.Text);


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
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            txtstudentID.Clear();
            txtstudentname.Clear();
            txtstudentage.Clear();
            txtcourse.Clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
        

                if (string.IsNullOrWhiteSpace(txtstudentID.Text))
                {
                    MessageBox.Show("Please enter the Student ID to delete.");
                    return;
                }

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
                txtstudentID.Clear();
                txtstudentname.Clear();
                txtstudentage.Clear();
                txtcourse.Clear();
            
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                List<Student> students = dataHandler.GetAllStudents();
                dataHandler.GenerateSummary(students, lstview);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message);
            }
        }
    }
    
}
