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
    public partial class Delete_Student : Form
    {
        public Delete_Student()
        {
            InitializeComponent();
        }

        private void delete_student_button_Click(object sender, EventArgs e)
        {

            string text = deleted_student_last_name.Text;
            List<Student> stList = new List<Student>();

            using (StreamReader in1 = new StreamReader(@".../students.txt"))
            {

                string student;
                bool isDeleted = false;

                while ((student = in1.ReadLine()) != null)
                {
                    string[] studentSplit = student.Split(' ');

                    Student st = new Student(studentSplit[0], studentSplit[1],
                        studentSplit[2], DateTime.Parse(studentSplit[3]), 0, "null", "null", "null");

                    if (text != studentSplit[0])
                        stList.Add(st);
                    else
                    {
                        isDeleted = true;
                        MessageBox.Show("Deleted " + st.ToString());
                    }

                }

                if (!isDeleted)
                    MessageBox.Show("Student doesn't exist");
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
