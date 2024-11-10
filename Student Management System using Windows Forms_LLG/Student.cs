using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System_using_Windows_Forms_LLG
{
    public class Student
    {
        public string StudentID { get;set; }

        public string Name { get;set; }
        public int Age { get;set; }
        public string Course { get;set; }

        public Student(string studentID, string name, int age, string course)
        {
            this.StudentID = studentID;
            this.Name = name;
            this.Age = age;
            this.Course = course;



        }
        public static Student FromFileFormat(string line)
        {
            try
            {
                var parts = line.Split(',');

                if (parts.Length == 4) // Assuming there are 4 fields: ID, Name, Age, Course
                {
                    string studentID = parts[0];
                    string name = parts[1];
                    if (int.TryParse(parts[2], out int age)) // Parse the age
                    {
                        string course = parts[3];
                        return new Student(studentID, name, age, course);
                    }
                    else
                    {
                        MessageBox.Show($"Invalid age format in line: {line}");
                    }
                }
                else
                {
                    MessageBox.Show($"Incorrect format in line: {line}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error parsing line: {line}\n{ex.Message}");
            }

            return null; // Return null if parsing failed
        }

    }
}
