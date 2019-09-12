using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr24WindowsForms
{
    class University : BaseClass<Department>
    {

        DateTime dateOfFoundation; //дата основания
        string nameOfDirector;     //имя ректора
        int numOfStudents = 0;         //количество студентов
        int numOfDepartments = 0;      //количество факультетов

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
        public string NameOfDirector
        {
            set
            {
                nameOfDirector = value;
            }
            get
            {
                return nameOfDirector;
            }
        }
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

        public int NumOfDepartments
        {
            set
            {
                numOfDepartments = value;
            }
            get
            {
                return numOfDepartments;

            }
        }

        List<Department> listOfDepartments; //список факультетов университета

        //конструктор университета
        public University(string name, DateTime date, string name1)
        {
            listOfDepartments = new List<Department>();
            this.name = name;
            this.dateOfFoundation = date;
            this.nameOfDirector = name1;
        }
        public University(string name, DateTime date, string name1, int a, int b)
        {
            listOfDepartments = new List<Department>();
            this.name = name;
            this.dateOfFoundation = date;
            this.nameOfDirector = name1;
            this.numOfDepartments = a;
            this.NumOfStudents = b;
        }
        //конструктор по умолчанию
        public University()
        {
            listOfDepartments = new List<Department>();
            this.name = "undefined";
        }

        //добавление факультета в университет
        public override void Add(Department department) { }


        public void Add(ref Department department)
        {
                listOfDepartments.Add(department);
                ++numOfDepartments;
                numOfStudents += department.NumOfStudents;
            department.UniversityName = this.Name;
            
        }

        //удаление факультета из университета
        public override void Delete(Department department)
        {
            foreach (var i in listOfDepartments.Reverse<Department>())
            {
                if (department.Name == i.Name)
                {
                    listOfDepartments.Remove(i);
                    --this.numOfDepartments;
                }
            }
        }

        public override string ToString()
        {
            return
                "University: " + this.name +
                ", founded on " + this.dateOfFoundation.ToShortDateString() +
                ", director - " + this.nameOfDirector;
        }

        //информация об университете
        public override void Show()
        {
            Console.WriteLine("University: {0}, founded on {1}, director - {2}, {3} students, {4} departments:",
                this.name, this.dateOfFoundation.ToShortDateString(), this.nameOfDirector, this.numOfStudents, this.numOfStudents);
            foreach (var i in listOfDepartments)
            {
                i.ToString();
            }
            Console.WriteLine();
        }

    }
}
