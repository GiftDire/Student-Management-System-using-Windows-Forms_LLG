using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Student_Management_System_using_Windows_Forms_LLG.Business_Logic_Layer
{
    class DataHandler
    {
        List<Student> studentlist = new List<Student>();
        public void Add(Student student)
        {
            studentlist.Add(student);

            string filepath = @"C:\Users\direo\OneDrive\Desktop\Students.txt";

            using (StreamWriter writer = new StreamWriter(filepath, append: true))
            {
                writer.WriteLine($"StudentID : {student.StudentID},\t {student.Name},\t{student.Age},\t{student.Course}");

            }

        }
    }
}
