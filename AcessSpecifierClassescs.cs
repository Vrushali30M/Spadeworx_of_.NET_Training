using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class AcessSpecifierClassescs
    {
        public string name = "Shantosh Kumar";
        public void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }

        internal string ename = "Vrushali Mahajan";
        internal void getEName(string nm)
        {
            Console.WriteLine("Welcome " + nm);
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            AcessSpecifierClassescs publicTest = new AcessSpecifierClassescs();
            // Accessing public variable  
            Console.WriteLine("Hello " + publicTest.name);
            // Accessing public function  
            publicTest.Msg("Peter Decosta");


            Console.WriteLine("Hello " + publicTest.name);
            // Accessing internal function  
            publicTest.Msg("Peter Decosta");
        }
    }
}

