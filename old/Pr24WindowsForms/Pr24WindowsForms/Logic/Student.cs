using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr24WindowsForms
{
    class Student
    {
        string name;          //имя
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        string last_name;     //фамилия
        public string Last_name
        {
            set
            {
                last_name = value;
            }
            get
            {
                return last_name;
            }
        }
        string patronymic;    //отчество
        public string Patronymic
        {
            set
            {
                patronymic = value;
            }
            get
            {
                return patronymic;
            }
        }

        DateTime dateOfBirth; //дата рождения
        public DateTime DateOfBirth
        {
            set
            {
                dateOfBirth = value;
            }
            get
            {
                return dateOfBirth;
            }
        }

        protected int group;            //номер группы
        public int Group
        {
            set
            {
                group = value;
            }
            get
            {
                return group;
            }
        }

        protected string specialty;               //специальность
        public string Specialty
        {
            set
            {
                specialty = value;
            }
            get
            {
                return specialty;
            }
        }

        protected string department;    //факультет
        public string Department
        {
            set
            {
                department = value;
            }
            get
            {
                return department;
            }
        }

        protected string university;    //университет
        public string University
        {
            set
            {
                university = value;
            }
            get
            {
                return university;
            }
        }

        /*enum studentStatus
        {
            bachelor = 0,
            master = 1,
            dismembered = 2,
            academic_leave = 3,
            graduated = 4
        }

        protected string status;        //учится, отчислен или окончил
        public string Status
        {
            set
            {
                status = value;
            }
            get
            {
                return status;
            }
        } */        //bachelor, master, dismembered, academic leave, graduated

        //конструкторы
        public Student(string last_name, string name, string patronymic,
            DateTime date, int group, string department, string university, string specialty)
        {
            this.name = name; this.last_name = last_name; this.patronymic = patronymic;
            this.dateOfBirth = date; this.group = group; this.department = department;
            this.university = university; this.specialty = specialty;
        }
        public Student(string last_name, string name, string patronymic, DateTime date)
        {
            this.name = name; this.last_name = last_name; this.patronymic = patronymic;
            this.group = 0; this.dateOfBirth = date;
        }
        //конструктор по умолчанию
        public Student() 
        {
            this.name = "undefined";
        }
        

        //вывод всей информации о студенте
        public void Show()
        {
            Console.WriteLine("{0} {1} {2}, {3}\n {4} group, {5} specialty, {6} department of {7}",
                this.last_name, this.name, this.patronymic, this.dateOfBirth.ToShortDateString(),
                 this.group, this.specialty, this.department, this.university);
        }

        public override string ToString()
        {
            if (this.group!=0)
                return
                this.last_name + " " + this.name + " " + this.patronymic + ", " +
                this.dateOfBirth.ToShortDateString() + ", " + this.group + ", department " + 
                this.Department + ", specialty: " + this.specialty;
            else
                return
                this.last_name + " " + this.name + " " + this.patronymic + ", " +
                this.dateOfBirth.ToShortDateString();
        }
        //вывод имени и тд
        public void ShowName()
        {
            Console.WriteLine("{0} {1} {2}, {3}, {4} group, {5}", this.last_name, this.name, this.patronymic,
                this.dateOfBirth.ToShortDateString(), this.group, this.specialty);
        }

        //перегрузка операций сравнения
        public static bool operator ==(Student student1, Student student2)
        {
            if (student1.name == student2.name && student1.last_name == student2.last_name
                && student1.dateOfBirth == student2.dateOfBirth)
                return true;
            else
                return false;

        }
        public static bool operator !=(Student student1, Student student2)
        {
            if (student1 == student2)
                return false;
            else
                return true;
        }
    }
}
