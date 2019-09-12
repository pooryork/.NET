using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pr24WindowsForms
{
    public partial class Search_By_DateOfBirth : Form
    {
        public Search_By_DateOfBirth()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void search_by_dateOfBirth_button_Click(object sender, EventArgs e)
        {
            List<Student> stList = new List<Student>();
            List<Student> neededStudents = new List<Student>();

            string ans = null;

            using (StreamReader in1 = new StreamReader(@".../students.txt"))
            {
                DateTime student_date = student_dateOfBirth.Value;
                string student;

                while ((student = in1.ReadLine()) != null)
                {
                    string[] studentSplit = student.Split(' ');

                    Student st = new Student(studentSplit[0], studentSplit[1],
                        studentSplit[2], DateTime.Parse(studentSplit[3]), 0, "null", "null", "null");

                    if (student_date.ToShortDateString() == st.DateOfBirth.ToShortDateString())
                        neededStudents.Add(st);

                    stList.Add(st);

                }

                if (neededStudents.Count == 0)
                    MessageBox.Show("Student doesn't exist");
                else
                {
                    foreach (var i in neededStudents)
                    {
                        ans += i.ToString();
                        ans += Environment.NewLine;
                    }
                    MessageBox.Show(ans);
                }
            }

            using (StreamWriter out1 = new StreamWriter(@".../students.txt"))
            {
                foreach (var i in stList)
                {
                    out1.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", i.Name, i.Last_name,
                    i.Patronymic, i.DateOfBirth.ToShortDateString(), i.Group, i.Department, i.University, i.Specialty);
                }

            }
        }
    }
}
