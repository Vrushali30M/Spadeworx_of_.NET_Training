using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    interface InterfaceEx
    {
        void Display();



    }
    interface Simple1
    {


    }
    interface Simple2
    {

    }
    interface Simple3 : Simple1, Simple2
    {

    }
    public class TestEx : Simple1, Simple2, Simple3
    {
        public void Display()
        {
            Console.WriteLine("This TestEx class");
        }

    }
    public class TestExamp : TestEx, Simple1, Simple2, Simple3
    {
    }

    public abstract class TestExample : TestEx, Simple1, Simple2, Simple3
    {

    }

    class InterfaceExample1
    {
        static void Main(string[] arg)
        {
            /*InterfaceExample obj = new InterfaceExample();
            TestExample obj1 = new TestExample();
*/
            //give declare method name 
            TestEx t = new TestEx();
            t.Display();
            //InterfaceEx i;
            //i.Display();

        }
    }
}