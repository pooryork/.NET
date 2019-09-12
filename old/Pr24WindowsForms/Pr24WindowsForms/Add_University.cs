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
    public partial class Add_University : Form
    {
        public Add_University()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void department_add_Click(object sender, EventArgs e)
        {
            string text = department_name.Text;
            string head = name_of_head.Text;
            DateTime dateOfFoundation = date_of_foundation.Value;

            //Student student = new Student(splitedText[0], splitedText[1], splitedText[2], dateOfBirth);
            //string name, DateTime date, string nameOfHead, string university

            University university = new University(text, dateOfFoundation, head);

            List<University> universitiesList = new List<University>();

            using (StreamReader in1 = new StreamReader(@".../universities.txt"))
            {
                string universityBuf;
                while ((universityBuf = in1.ReadLine()) != null)
                {
                    string[] universitySplit = universityBuf.Split(' ');
                    University un = new University(universitySplit[0], DateTime.Parse(universitySplit[1]),
                        universitySplit[2], int.Parse(universitySplit[3]), int.Parse(universitySplit[4]));

                    universitiesList.Add(un);

                }
            }

            universitiesList.Add(university);

            MessageBox.Show(university.ToString());

            using (StreamWriter out1 = new StreamWriter(@".../universities.txt"))
            {
                foreach (var i in universitiesList)
                {
                    out1.WriteLine("{0} {1} {2} {3} {4}", i.Name, i.DateOfFoundation.ToShortDateString(), i.NameOfDirector, i.NumOfStudents, i.NumOfDepartments);
                }
            }
        }
    }
}
