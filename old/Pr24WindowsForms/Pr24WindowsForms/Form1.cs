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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void студентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Student f2 = new Add_Student();
            f2.ShowDialog();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Student f2 = new Add_Student();
            f2.ShowDialog();
        }

        private void обУниверситетеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<University> universitiesList = new List<University>();

            using (StreamReader in1 = new StreamReader(@".../universities.txt"))
            {
                string universityBuf;

                string departmentInfo = "Университет: ";
                departmentInfo += Environment.NewLine;

                while ((universityBuf = in1.ReadLine()) != null)
                {
                    string[] universitySplit = universityBuf.Split(' ');
                    University un = new University(universitySplit[0], DateTime.Parse(universitySplit[1]),
                        universitySplit[2], int.Parse(universitySplit[3]), int.Parse(universitySplit[4]));

                    universitiesList.Add(un);

                    departmentInfo += un.ToString();
                    departmentInfo += Environment.NewLine;

                }
                MessageBox.Show(departmentInfo);

            }

            using (StreamWriter out1 = new StreamWriter(@".../universities.txt"))
            {
                foreach (var i in universitiesList)
                {
                    out1.WriteLine("{0} {1} {2} {3} {4}", i.Name, i.DateOfFoundation.ToShortDateString(),
                        i.NameOfDirector, i.NumOfStudents, i.NumOfDepartments);
                }
            }
        }

        private void оФакультетеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Department> departmentsList = new List<Department>();

            using (StreamReader in1 = new StreamReader(@".../departments.txt"))
            {
                string departmentBuf;

                string departmentInfo = "Факультеты: ";
                departmentInfo += Environment.NewLine;

                while ((departmentBuf = in1.ReadLine()) != null)
                {
                    string[] studentSplit = departmentBuf.Split(' ');
                    Department dp = new Department(studentSplit[0], DateTime.Parse(studentSplit[1]),
                        studentSplit[2], studentSplit[3]);

                    departmentsList.Add(dp);

                    departmentInfo += dp.ToString();
                    departmentInfo += Environment.NewLine;

                }
                MessageBox.Show(departmentInfo);

            }



            using (StreamWriter out1 = new StreamWriter(@".../departments.txt"))
            {
                foreach (var i in departmentsList)
                {
                    out1.WriteLine("{0} {1} {2} {3}", i.Name, i.DateOfFoundation.ToShortDateString(),
                    i.HeadOfDepartment, i.UniversityName);
                }
            }
        }

        private void оСтудентеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Student> studentsList = new List<Student>();

            using (StreamReader in1 = new StreamReader(@".../students.txt"))
            {
                string studentBuf;

                string studentInfo = "Студенты: ";
                studentInfo += Environment.NewLine;

                while ((studentBuf = in1.ReadLine()) != null)
                {
                    string[] studentSplit = studentBuf.Split(' ');

                    Student st = new Student(studentSplit[0], studentSplit[1],
                        studentSplit[2], DateTime.Parse(studentSplit[3]), 0, "null", "null", "null");

                    studentsList.Add(st);

                    studentInfo += st.ToString();
                    studentInfo += Environment.NewLine;

                }
                MessageBox.Show(studentInfo);

            }

            using (StreamWriter out1 = new StreamWriter(@".../students.txt"))
            {
                foreach (var i in studentsList)
                {
                    out1.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", i.Name, i.Last_name,
                    i.Patronymic, i.DateOfBirth.ToShortDateString(), i.Group, i.Department, i.University, i.Specialty);
                }

            }
        }

        private void факультетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Department f3 = new Add_Department();
            f3.ShowDialog();
        }

        private void университетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_University f4 = new Add_University();
            f4.ShowDialog();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_Student f5 = new Delete_Student();
            f5.ShowDialog();
        }

        private void поФамилииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_By_LastName f6 = new Search_By_LastName();
            f6.ShowDialog();
        }

        private void поДатеРожденияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_By_DateOfBirth f7 = new Search_By_DateOfBirth();
            f7.ShowDialog();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Department f3 = new Add_Department();
            f3.ShowDialog();
        }

        private void создатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Add_University f4 = new Add_University();
            f4.ShowDialog();
        }

        private void добавитьСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_toDepartment f8 = new Add_toDepartment();
            f8.ShowDialog();
        }

        private void добавитьФакультетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_toUniversity f9 = new Add_toUniversity();
            f9.ShowDialog();
        }
    }
}
