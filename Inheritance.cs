using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Inheritance
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.show();

            Test1 t1 = new Test1();
            t1.display();
            t1.show();

            Test2 t2 = new Test2();
            t2.show();
            t2.display();
            t2.display2();

            Test1 t4 = new Test2();
            t4.display();
            t4.show();

            //Ass.  t4.Display2(); // can not access

            Test t5 = new Test1();
            t5.show();  //only show() is accessible
            
            
            
        }

    }

    class Test
    {
        public void show()
        {
            Console.WriteLine("Wlcome");
        }
    }

    class Test1 : Test   // single level Inheritance
    {
        public void display() 
        {
            Console.WriteLine("Vrushali");
        }
    }

    class Test2 : Test1     // multi level inheritance
    {
        public void display2()
        {
            Console.WriteLine("mahajan");
        }
    }

   /* class Test3 : Test1,Test2   // can not have multiple base classes
    {
        public void display2()
        {
            Console.WriteLine("mahajan");
        }
    }*/


}
