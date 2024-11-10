using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Student_Management_System_using_Windows_Forms_LLG.Data_Layer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;




namespace Student_Management_System_using_Windows_Forms_LLG.Business_Logic_Layer
{
    
    class DataHandler
    {
        FileHandler fileHandler = new FileHandler();
        List<Student> studentList;
        // Constructor for DataHandler class
        // This constructor initializes the studentList by reading the student data from the file via FileHandler.
        public DataHandler()
        {
            studentList = fileHandler.ReadStudents();
        }
        // Adds a new student to the studentList and then writes the updated list back to the file using FileHandler.
        public void AddStudent(Student student)
        {
            studentList.Add(student);
            fileHandler.WriteStudents(studentList);
        }

        // Updates the details of an existing student in the studentList based on their StudentID.
        // Returns true if the student is found and updated, otherwise returns false.
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


        // Deletes a student from the studentList by their StudentID.
        // Returns true if the student is found and removed, otherwise returns false.
        public bool DeleteStudent(string studentID)
        {
          
            bool studentFound = false;
           

            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].StudentID == studentID)
                {
                    studentList.RemoveAt(i);
                    studentFound = true;
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


        // Returns the entire studentList.
        public List<Student> GetAllStudents()
        {
            return studentList;
        }

        // Generates a summary of the students (e.g., total students, average age) 
        // and displays it in the provided ListView control. The summary is also written to a file.
        public void GenerateSummary(List<Student> students, System.Windows.Forms.ListView lstview)
        {
           
            FileHandler fileHandler = new FileHandler();
            fileHandler.GenerateSummary(students, lstview);
        }

    }
}

