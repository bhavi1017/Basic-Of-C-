using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();
            //student.roll_number = 1;
            //student.pname = "ABC";
            //student.show();

            //Student student1 = new Student();
            //student1.roll_number = 2;
            //student1.pname = "ABC";

            //List<Student> list = new List<Student>();
            //list.Add(student);
            //list.Add(student1);
            //list.Add(new Student(3, "ABC"));

            //foreach (Student s in list)
            //{
            //    Console.WriteLine("{0}-{1}", s.roll_number, s.pname);
            //}


            Console.WriteLine("Integer");
            GenericClass<int> intObj = new GenericClass<int>(1);
            intObj.show();

            Console.WriteLine("Float");
            GenericClass<float> fObj = new GenericClass<float>(1.0f);
            fObj.show();

            Console.WriteLine("String");
            GenericClass<String> sObj = new GenericClass<String>("Hello!Stay Safe");
            sObj.show();


            Console.ReadKey();
        }
    }
}
