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
    public partial class Add_Department : Form
    {
        public Add_Department()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void department_add_Click(object sender, EventArgs e)
        {
            string text = department_name.Text;
            string head = name_of_head.Text;
            DateTime dateOfFoundation = date_of_foundation.Value;

            //Student student = new Student(splitedText[0], splitedText[1], splitedText[2], dateOfBirth);
            //string name, DateTime date, string nameOfHead, string university

            Department department = new Department(text, dateOfFoundation, head, "null");

            List<Department> departmentsList = new List<Department>();

            using (StreamReader in1 = new StreamReader(@".../departments.txt"))
            {
                string studentBuf;
                while ((studentBuf = in1.ReadLine()) != null)
                {
                    string[] studentSplit = studentBuf.Split(' ');
                    Department dp = new Department(studentSplit[0], DateTime.Parse(studentSplit[1]),
                        studentSplit[2], studentSplit[3]);

                    departmentsList.Add(dp);

                }
            }

            departmentsList.Add(department);

            MessageBox.Show(department.ToString());

            using (StreamWriter out1 = new StreamWriter(@".../departments.txt"))
            {
                foreach (var i in departmentsList)
                {
                    out1.WriteLine("{0} {1} {2} {3}", i.Name, i.DateOfFoundation.ToShortDateString(),
                    i.HeadOfDepartment, i.UniversityName);
                }
            }
        }
    }
}
