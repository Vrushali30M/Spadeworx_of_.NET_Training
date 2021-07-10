using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    

    class ConstrctorAss
    {
         static int a=10;
        int x = 50;
        static ConstrctorAss()
        {
            a++;
            Console.WriteLine("Value of static :" + a);
        }

        public ConstrctorAss(String nm)
        {
            Console.WriteLine("Name" + nm);
        }
      /*  static void Main(string[] args)
        {
            ConstrctorAss obj = new("Vrushali");
        }*/
    }
}
