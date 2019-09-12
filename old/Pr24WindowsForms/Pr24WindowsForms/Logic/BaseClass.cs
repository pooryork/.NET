using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr24WindowsForms
{
    abstract class BaseClass<T>
    {
        protected string name;
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

        abstract public void Add(T obj);    //добавить элемент
        abstract public void Delete(T obj); //удалить элемент
        abstract public void Show();   //показать информацию об элементе
    }
}
