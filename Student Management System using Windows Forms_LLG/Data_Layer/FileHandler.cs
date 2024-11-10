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

        //The method down beloow read studenttextfile using the streamreader it then formats the values to fit into the Datagrid.
        //The ReadStudents method reads student data from a file and returns a list of Student objects
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

                        
                            var parts = line.Split(new[] { ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                            if (parts.Length >= 4)
                            {
                                
                                string studentID = parts[0].Replace("StudentID :", "").Trim();
                                string name = parts[1].Replace("Name:", "").Trim();
                                int age = int.Parse(parts[2].Replace("Age:", "").Trim());
                                string course = parts[3].Replace("Course:", "").Trim();

                               
                                var student = new Student(studentID, name, age, course);
                                students.Add(student);
                            }
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


        //The WriteStudents method saves a list of students to a file by writing each student's details in a formatted line.
        //It overwrites any existing file content to ensure the data is up-to-date. If an error occurs, it displays an error message.
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
        //The GenerateSummary method creates a summary of the student data, calculating the total number of students and the average age.
        //\It saves these details to a file and displays them in a ListView for easy viewing. If an error occurs, it displays an error message.
        public void GenerateSummary(List<Student> students, ListView lstview)
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

                string[] summaryData = new string[]
                {
            $"Total Students: {totalStudents}",
            $"Average Age: {averageAge:F2}"
                };

               
                using (StreamWriter writer = new StreamWriter(summaryFilePath, false))
                {
                    writer.WriteLine($"Total Students: {totalStudents}");
                    writer.WriteLine($"Average Age: {averageAge:F2}");
                }

                lstview.Items.Clear();
                foreach (string data in summaryData)
                {
                    lstview.Items.Add(new ListViewItem(new string[] { data }));
                }

                MessageBox.Show("Summary report generated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating summary: " + ex.Message);
            }
        }





    }
}
