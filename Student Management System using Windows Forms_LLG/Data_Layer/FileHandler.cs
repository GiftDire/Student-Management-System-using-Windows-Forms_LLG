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
        private readonly string studentFilePath = "students.txt";
        private readonly string summaryFilePath = "summary.txt";

        // Method to read all student data from the file using StreamReader
        public List<Student> ReadStudents()
        {
            string studentFilePath = @"C:\Users\direo\OneDrive\Desktop\Students.txt";
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

                         
                            var parts = line.Split(',');

                         
                            if (parts.Length >= 4)
                            {
                                try
                                {
                                
                                    string studentID = parts[0].Split(':')[1].Trim();
                                    string name = parts[1].Split(':')[1].Trim();
                                    int age = int.Parse(parts[2].Split(':')[1].Trim());
                                    string course = parts[3].Split(':')[1].Trim();

                                    
                                    students.Add(new Student(studentID, name, age, course));
                                }
                                catch (Exception ex)
                                {
                                    
                                    MessageBox.Show($"Error parsing line: {line}\n{ex.Message}");
                                }
                            }
                            else
                            {
                                // Log or handle lines that don't have the expected number of parts
                                MessageBox.Show($"Invalid line format: {line}");
                            }
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


    }
}
