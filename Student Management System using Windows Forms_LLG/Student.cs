using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System_using_Windows_Forms_LLG
{
    public class Student
    {
        public string StudentID { get;set; }

        public string Name { get;set; }
        public int Age { get;set; }
        public string Course { get;set; }
        
        public Student(string studentID, string name , int age ,string course)
        {
            this.StudentID = studentID;
            this.Name = name;
            this.Age = age;
            this.Course = course;
        
        
        
        }

        public string ToFileFormat()
        {
            return $"{StudentID},{Name},{Age},{Course}";
        }

        public static Student FromFileFormat(string line)
        {
            var parts = line.Split(',');

            return new Student(parts[0], parts[1], int.Parse(parts[2]), parts[3]);
        }
    }
}
