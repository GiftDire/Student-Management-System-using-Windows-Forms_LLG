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

        // Adds a new student and writes to file
        public void AddStudent(Student student)
        {
            studentList.Add(student);
            fileHandler.WriteStudents(studentList);
        }

        // Updates student information and writes to file
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

        // Deletes a student from the list and updates the file
        public bool DeleteStudent(string studentID)
        {
            var student = studentList.Find(s => s.StudentID == studentID);
            if (student != null)
            {
                studentList.Remove(student);
                fileHandler.WriteStudents(studentList);
                return true;
            }
            return false;
        }

        // Gets the list of all students
        public List<Student> GetAllStudents()
        {
            return studentList;
        }

        // Generates a summary report
        public void GenerateSummary()
        {
            fileHandler.GenerateSummary(studentList);
        }
    }
}
