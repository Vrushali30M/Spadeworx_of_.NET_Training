using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Protected
    {
        protected string name = "Shashikant";
        protected void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }
    class Program2
    {
        static void Main(string[] args)
        {
            Protected protectedTest = new Protected();

            // Accessing protected variable  

          /*  Console.WriteLine("Hello " + protectedTest.name);

            // Accessing protected function
            // 
            protectedTest.Msg("Vrushali Mahajan");*/
        }
    }
}

