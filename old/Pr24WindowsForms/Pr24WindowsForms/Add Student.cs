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
    public partial class Add_Student : Form
    {
        public Add_Student()
        {
            InitializeComponent();
        }

              
        private void student_add_Click(object sender, EventArgs e)
        {
            string text = name.Text;
            string[] splitedText = text.Split(' ');
            DateTime dateOfBirth = date_of_birth.Value;

            Student student = new Student(splitedText[0], splitedText[1], splitedText[2], dateOfBirth);

            List<Student> studentsList = new List<Student>();

            using (StreamReader in1 = new StreamReader(@".../students.txt"))
            {
                string studentBuf;
                while ((studentBuf = in1.ReadLine()) != null)
                {
                    string[] studentSplit = studentBuf.Split(' ');
                    //string last_name, string name, string patronymic,
            //DateTime date, int group, string department, string university, string specialty
                    Student st = new Student(studentSplit[0], studentSplit[1],
                        studentSplit[2], DateTime.Parse(studentSplit[3]), 0, "null", "null", "null");

                    studentsList.Add(st);

                }
            }

            studentsList.Add(student);

            using (StreamWriter out1 = new StreamWriter(@".../students.txt"))
            {
                foreach (var i in studentsList)
                {
                    out1.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", i.Name, i.Last_name,
                    i.Patronymic, i.DateOfBirth.ToShortDateString(), i.Group, i.Department, i.University, i.Specialty);
                }

            }

            MessageBox.Show(student.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
