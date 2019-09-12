using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr24WindowsForms
{
    class Department : BaseClass<Student>
    {

        DateTime dateOfFoundation; //дата основания факультета
        public DateTime DateOfFoundation
        {
            set
            {
                dateOfFoundation = value;
            }
            get
            {
                return dateOfFoundation;
            }
        }

        string headOfDepartment;   //декан факультета
        public string HeadOfDepartment
        {
            set
            {
                headOfDepartment = value;
            }
            get
            {
                return headOfDepartment;
            }
        }

        int numOfStudents;         //число студентов
        public int NumOfStudents
        {
            set
            {
                numOfStudents = value;
            }
            get
            {
                return numOfStudents;

            }
        }

        string universityName;     //какого университета факультет
        public string UniversityName
        {
            set
            {
                universityName = value;
            }
            get
            {
                return universityName;

            }
        }

        internal List<Student> studentsOfThisDepartment;
        internal List<Student> dismembered;

        public Department() {
            this.name = "undefined";
        }

        //конструктор факультета
        public Department(string name, DateTime date, string nameOfHead, string university)
        {
            studentsOfThisDepartment = new List<Student>();
            dismembered = new List<Student>();
            this.name = name;
            this.dateOfFoundation = date;
            this.headOfDepartment = nameOfHead;
            this.numOfStudents = 0;
            this.universityName = university;
        }

        public Department(string name, DateTime date, string nameOfHead, List<Student> list)
        {
            studentsOfThisDepartment = new List<Student>();
            dismembered = new List<Student>();
            this.name = name;
            this.dateOfFoundation = date;
            this.headOfDepartment = nameOfHead;
            this.numOfStudents = 0;
            foreach (var i in list)
            {

                if (i.Group == 0)
                {
                    i.ShowName();
                    Console.Write("Group number:\n");
                    int groupNumber = int.Parse(Console.ReadLine());
                    i.Group = groupNumber;
                    Console.WriteLine("Specialty:\n");
                    string spec = Console.ReadLine();
                    i.Specialty = spec;
                    i.Department = name;
                    i.University = universityName;
                }

                //проверка корректности добавления
                if (i.Department == this.name && i.University == this.universityName)
                {
                    studentsOfThisDepartment.Add(i);
                    ++numOfStudents;
                }
            }
        }

        //добавление студентов на факультет
        public override void Add(Student student)
        {
            Console.WriteLine("Adding students to {0}, {1}:", this.name, this.universityName);
            //если у студента известно только имя и дата рождения и требуется заполнить остальные поля
            if (student.Group == 0)
            {
                student.ShowName();
                Console.WriteLine("Group number");
                int groupNumber = int.Parse(Console.ReadLine());
                student.Group = groupNumber;
                Console.WriteLine("Specialty:");
                string spec = Console.ReadLine();
                student.Specialty = spec;
                student.Department = name;
                student.University = universityName;
                Console.WriteLine();
            }

            //проверка корректности добавления
            if (student.Department == this.name && student.University == this.universityName)
            {
                studentsOfThisDepartment.Add(student);
                ++numOfStudents;
            }
            else
                MessageBox.Show("Error: Wrong university or department");

        }

        public void Add(ref Student student, string spec, int group_num)
        {            
            student.Specialty = spec;
            student.Department = name;
            student.University = universityName;
            student.Group = group_num;
            studentsOfThisDepartment.Add(student);

            ++this.NumOfStudents;

        }

        //удаление студентов из факультета
        public override void Delete(Student student)
        {
            if (studentsOfThisDepartment.Count != 0)
            {
                foreach (var i in studentsOfThisDepartment.Reverse<Student>())
                {
                    if (i == student)
                    {
                        i.Department = "";
                        i.Group = 0;
                        i.University = "";
                        i.Department = "";
                        studentsOfThisDepartment.Remove(i);
                        --this.numOfStudents;
                    }
                }
            }
        }

        //информация о факультете
        public override void Show()
        {
            Console.WriteLine("Department: {0}, {1} Founded on {2}, director - {3}, {4} students",
                this.name, this.universityName, this.dateOfFoundation.ToShortDateString(), this.headOfDepartment,
                this.numOfStudents);
            foreach (var i in studentsOfThisDepartment)
            {
                i.ToString();
            }
            Console.WriteLine();

        }

        public override string ToString()
        {
            return
                "Department: " + this.name + "Founded on " + this.dateOfFoundation.ToShortDateString() +
                ", director - " + this.headOfDepartment;
        }


    }
}
