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
    public partial class Search_By_LastName : Form
    {
        public Search_By_LastName()
        {
            InitializeComponent();
        }

        private void search_by_lastName_button_Click(object sender, EventArgs e)
        {
            List<Student> stList = new List<Student>();
            List<Student> neededStudents = new List<Student>();

            using (StreamReader in1 = new StreamReader(@".../students.txt"))
            {

                string student;
                string text = needed_student_lastName.Text;

                while ((student = in1.ReadLine()) != null)
                {
                    string[] studentSplit = student.Split(' ');
                    Student st = new Student(studentSplit[0], studentSplit[1],
                        studentSplit[2], DateTime.Parse(studentSplit[3]));

                    if (text == st.Last_name)
                        neededStudents.Add(st);

                    stList.Add(st);

                }

                string ans = null;

                if (neededStudents.Count == 0)
                    MessageBox.Show(text + " doesn't exist");
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
                    out1.WriteLine("{0} {1} {2} {3}", i.Name, i.Last_name,
                    i.Patronymic, i.DateOfBirth.ToShortDateString());
                }

            }
        }
    }
}
