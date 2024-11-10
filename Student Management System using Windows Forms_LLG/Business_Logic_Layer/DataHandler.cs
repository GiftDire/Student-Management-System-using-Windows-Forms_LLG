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
            bool studentFound = false;

            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].StudentID == updatedStudent.StudentID)
                {             
                    studentList[i].Name = updatedStudent.Name;
                    studentList[i].Age = updatedStudent.Age;
                    studentList[i].Course = updatedStudent.Course;

                    studentFound = true;
                    break;
                }
            }

            if (studentFound)
            {
                fileHandler.WriteStudents(studentList);
            }

            return studentFound;
        }



        public bool DeleteStudent(string studentID)
        {
            MessageBox.Show($"Searching for StudentID: {studentID}");
            bool studentFound = false;

            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].StudentID == studentID)
                {
                    studentList.RemoveAt(i);
                    studentFound = true;
                    break;
                }
            }

            if (studentFound)
            {
                fileHandler.WriteStudents(studentList);
                return true;
            }
            else
            {
                MessageBox.Show("Student not found in the list.");
                return false;
            }
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
