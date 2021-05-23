using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    class GenericClass<T,u,k,J>
    {
        T field1;
        public T pfield1
        {
            get
            {
                return field1;
            }
            set
            {
                field1 = value;
            }
        }

        public GenericClass(T p1)
        {
            field1 = p1;
        }

        public GenericClass()
        {

        }

        public void show()
        {
            Console.WriteLine(field1);
        }
    }
}
