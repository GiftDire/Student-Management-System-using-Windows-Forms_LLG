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
        private readonly string studentFilePath = @"C:\Users\direo\OneDrive\Desktop\Students.txt";
        private readonly string summaryFilePath = @"C:\Users\direo\OneDrive\Desktop\Summary.txt";

        // Method to read all student data from the file
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
                    MessageBox.Show("Error: students.txt not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return students;
        }

        // Method to write all student data back to the file
        public void WriteStudents(List<Student> students)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(studentFilePath, false))
                {
                    foreach (var student in students)
                    {
                        writer.WriteLine(student.ToFileFormat());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Method to generate a summary report and save it to a file
        public void GenerateSummary(List<Student> students)
        {
            try
            {
                int totalStudents = students.Count;
                double averageAge = students.Count > 0 ? students.Average(s => s.Age) : 0;

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
