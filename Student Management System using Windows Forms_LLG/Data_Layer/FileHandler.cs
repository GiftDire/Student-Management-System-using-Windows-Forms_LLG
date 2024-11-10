using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_Management_System_using_Windows_Forms_LLG.Presentation_Layer;
using Student_Management_System_using_Windows_Forms_LLG.Business_Logic_Layer;
using System.IO;
using System.Windows.Forms;

namespace Student_Management_System_using_Windows_Forms_LLG.Data_Layer
{

    class FileHandler
    {
       public string studentFilePath = @"C:\Users\direo\OneDrive\Desktop\Students.txt";
       public  string summaryFilePath = @"C:\Users\direo\OneDrive\Desktop\Summary.txt";

  
        public List<Student> ReadStudents()
        {
            List<Student> students = new List<Student>();

            try
            {
                if (File.Exists(studentFilePath))
                {
                    using (StreamReader reader = new StreamReader(studentFilePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (string.IsNullOrWhiteSpace(line))
                                continue;

                            var student = Student.FromFileFormat(line);
                            if (student != null)
                                students.Add(student);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(".txt file not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return students;
        }


        public void WriteStudents(List<Student> students)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(studentFilePath, false))
                {
                    foreach (var student in students)
                    {
                        writer.WriteLine($"StudentID : {student.StudentID},\t Name: {student.Name},\t Age: {student.Age},\t Course: {student.Course}");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      
        public void GenerateSummary(List<Student> students)
        {
            try
            {
                int totalStudents = students.Count;
                double averageAge = 0;

                if (totalStudents > 0)
                {
                    double totalAge = 0;
                    foreach (var student in students)
                    {
                        totalAge += student.Age;
                    }
                    averageAge = totalAge / totalStudents;
                }

                using (StreamWriter writer = new StreamWriter(summaryFilePath, false))
                {
                    writer.WriteLine($"Total Students: {totalStudents}");
                    writer.WriteLine($"Average Age: {averageAge:F2}");
                }

                MessageBox.Show("Summary report generated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
