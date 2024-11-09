using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Student_Management_System_using_Windows_Forms_LLG.Data_Layer;


namespace Student_Management_System_using_Windows_Forms_LLG.Business_Logic_Layer
{
    class DataHandler
    {
        private FileHandler fileHandler = new FileHandler();
        private List<Student> studentList;

        public DataHandler()
        {
            studentList = fileHandler.ReadStudents();
        }
        public void AddStudent(Student student)
        {
            studentList.Add(student);
            fileHandler.WriteStudents(studentList);
        }

        public bool UpdateStudent(Student updatedStudent)
        {
            var student = studentList.Find(s => s.StudentID == updatedStudent.StudentID);
            if (student != null)
            {
                student.Name = updatedStudent.Name;
                student.Age = updatedStudent.Age;
                student.Course = updatedStudent.Course;
                fileHandler.WriteStudents(studentList);
                return true;
            }
            return false;
        }

       
        public bool DeleteStudent(string studentID)
        {
            MessageBox.Show($"Searching for StudentID: {studentID}"); 
            var student = studentList.Find(s => s.StudentID == studentID);
            if (student != null)
            {
                studentList.Remove(student);
                fileHandler.WriteStudents(studentList);
                return true;
            }
            MessageBox.Show("Student not found in the list."); 
            return false;
        }

    
        public List<Student> GetAllStudents()
        {
            return studentList;
        }

        public void GenerateSummary()
        {
            fileHandler.GenerateSummary(studentList);
        }
    }
}
