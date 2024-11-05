using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_Management_System_using_Windows_Forms_LLG.Presentation_Layer;
using Student_Management_System_using_Windows_Forms_LLG.Business_Logic_Layer;
using System.IO;

namespace Student_Management_System_using_Windows_Forms_LLG.Data_Layer
{
    class FileHandler
    {
        private readonly string studentFilePath = "students.txt";
        private readonly string summaryFilePath = "summary.txt";

        // Method to read all student data from the file using StreamReader
        public List<string> ReadStudents()
        {
            List<string> students = new List<string>();
            try
            {
                if (File.Exists(studentFilePath))
                {
                    using (StreamReader reader = new StreamReader(studentFilePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            students.Add(line);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error: students.txt not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
            return students;
        }
    }
}
