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
        DataHandler hl = new DataHandler();
        FileHandler FL = new FileHandler();
        public StudentForm()
        {
            InitializeComponent();
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
           string StudentId = txtstudentname.Text;
           string StudentName = txtstudentname.Text;
         //  string studentAge = txtstudentage.Text;
         if (!int.TryParse(txtstudentage.Text, out int age))
         {
               MessageBox.Show("Enter valid age");
                return;
         }
            try
            {
                string course = txtcourse.Text;

                Student newstudent = new Student(StudentId, Name, age, course);

                hl.Add(newstudent);

                MessageBox.Show("new student has been added to the file");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went Wrong");
            }



            
        }

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            try
            {
                
                List<Student> students = FL.ReadStudents();

             
                dgvdisplay.DataSource = students;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\Limpho\Videos\5200-183786525.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            // Configure settings to hide controls and fit to window size
            axWindowsMediaPlayer1.uiMode = "None";
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.stretchToFit = true;
            axWindowsMediaPlayer1.BackColor = this.BackColor;
            axWindowsMediaPlayer1.settings.autoStart = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
