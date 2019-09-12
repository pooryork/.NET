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
    public partial class Add_toDepartment : Form
    {
        public Add_toDepartment()
        {
            InitializeComponent();
        }

        private void add_student_to_department_button_Click(object sender, EventArgs e)
        {
            string name_of_department = department_name.Text;
            string student_fio_line = student_name.Text;
            string[] student_fio = student_fio_line.Split(' ');
            int group_num = int.Parse(group_number.Text);
            string spec = specialty.Text;


            List<Student> studentsList = new List<Student>();
            List<Department>departmentsList = new List<Department>();

            using (StreamReader in1 = new StreamReader(@".../students.txt"))
            {
                using (StreamReader in2 = new StreamReader(@".../departments.txt"))
                {
                    string studentBuf;
                    while ((studentBuf = in1.ReadLine()) != null)
                    {
                        string[] studentSplit = studentBuf.Split(' ');

                        Student st1 = new Student(studentSplit[0], studentSplit[1],
                            studentSplit[2], DateTime.Parse(studentSplit[3]), 0, "null", "null", "null");

                        studentsList.Add(st1);

                    }

                    string departmentBuf;
                    while ((departmentBuf = in2.ReadLine()) != null)
                    {
                        string[] departmentSplit = departmentBuf.Split(' ');
                        Department dp1 = new Department(departmentSplit[0], DateTime.Parse(departmentSplit[1]),
                            departmentSplit[2], departmentSplit[3]);

                        departmentsList.Add(dp1);

                    }

                }
            }

            if (departmentsList.Count != 0 && studentsList.Count != 0)
            {

                Student st = new Student();

                foreach (var student in studentsList.Reverse<Student>())
                {
                    if (student.Last_name == student_fio[0] && student.Name == student_fio[1]
                        && student.Patronymic == student_fio[2])
                    {
                        st = student;
                        studentsList.Remove(st);
                    }
                }

                Department dp = new Department();

                foreach (var department in departmentsList.Reverse<Department>())
                {
                    if (department.Name == name_of_department)
                    {
                        dp = department;
                        departmentsList.Remove(dp);
                    }
                }

                if (st.Name == "undefined")
                    MessageBox.Show(student_fio_line + " не существует");
                else if (dp.Name == "undefined")
                    MessageBox.Show(name_of_department + " не существует");
                else
                {
                    dp.Add(ref st, spec, group_num);
                    MessageBox.Show(student_fio_line + " зачислен на " + name_of_department +
                   ", группа " + group_num + ", " + spec);
                }

                departmentsList.Add(dp);
                studentsList.Add(st);                

            }

            using (StreamWriter out1 = new StreamWriter(@".../students.txt"))
            {
                using (StreamWriter out2 = new StreamWriter(@".../departments.txt"))
                {
                    foreach (var i in studentsList)
                    {
                        out1.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", i.Name, i.Last_name,
                        i.Patronymic, i.DateOfBirth.ToShortDateString(), i.Group, i.Department, i.University, i.Specialty);
                    }

                    foreach (var i in departmentsList)
                    {
                        out2.WriteLine("{0} {1} {2} {3}", i.Name, i.DateOfFoundation.ToShortDateString(),
                        i.HeadOfDepartment, i.UniversityName);
                    }
                }
            }
        }
    }
}
