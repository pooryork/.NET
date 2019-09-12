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
    public partial class Add_toUniversity : Form
    {
        public Add_toUniversity()
        {
            InitializeComponent();
        }

        private void add_student_to_university_button_Click(object sender, EventArgs e)
        {

            {
                string name_of_department = department_name.Text;
                string name_of_university = university_name.Text;


                List<University> universitiesList = new List<University>();
                List<Department> departmentsList = new List<Department>();

                using (StreamReader in1 = new StreamReader(@".../universities.txt"))
                {
                    using (StreamReader in2 = new StreamReader(@".../departments.txt"))
                    {
                        string universityBuf;
                        while ((universityBuf = in1.ReadLine()) != null)
                        {
                            string[] universitySplit = universityBuf.Split(' ');
                            University un = new University(universitySplit[0], DateTime.Parse(universitySplit[1]),
                                universitySplit[2], int.Parse(universitySplit[3]), int.Parse(universitySplit[4]));

                            universitiesList.Add(un);

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

                if (departmentsList.Count != 0 && universitiesList.Count != 0)
                {

                    University un = new University();

                    foreach (var i in universitiesList.Reverse<University>())
                    {
                        if (i.Name == name_of_university)
                        {
                            un = i;
                            universitiesList.Remove(un);
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

                    if (un.Name == "undefined")
                        MessageBox.Show(name_of_university + " не существует");
                    else if (dp.Name == "undefined")
                        MessageBox.Show(name_of_department + " не существует");
                    else
                    {
                        un.Add(ref dp);
                        MessageBox.Show(name_of_department + " добавлен в " + name_of_university);
                    }

                    departmentsList.Add(dp);
                    universitiesList.Add(un);

                }

                using (StreamWriter out1 = new StreamWriter(@".../universities.txt"))
                {
                    using (StreamWriter out2 = new StreamWriter(@".../departments.txt"))
                    {
                        foreach (var i in universitiesList)
                        {
                            out1.WriteLine("{0} {1} {2} {3} {4}", i.Name, i.DateOfFoundation.ToShortDateString(),
                                i.NameOfDirector, i.NumOfStudents, i.NumOfDepartments);
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
}
