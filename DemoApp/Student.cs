using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    class Student
    {
        int rn;
        String name;

        public int roll_number
        {
            get
            {
                return rn;
            }
            set
            {
                rn = value;
            }
        }

        public String pname
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Student(int rn,String nm)
        {
            this.rn = rn;
            this.name = nm;
        }

        public Student()
        {

        }

        public void show()
        {
            Console.WriteLine("{0} - {1}",rn,name);
        }
    }
}
