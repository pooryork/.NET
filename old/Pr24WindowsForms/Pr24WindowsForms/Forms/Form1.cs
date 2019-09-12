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
            MessageBox.Show("Университет");
        }

        private void оФакультетеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Факультет");
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
                        studentSplit[2], DateTime.Parse(studentSplit[3]));

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
                    out1.WriteLine("{0} {1} {2} {3}", i.Name, i.Last_name,
                    i.Patronymic, i.DateOfBirth.ToShortDateString());
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
    }
}
