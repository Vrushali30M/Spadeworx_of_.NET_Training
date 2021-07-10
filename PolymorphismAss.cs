using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class PolymorphismAss
    {
        static void Main(string[] args)
        {
            Poly obj = new Poly();
            obj.Add();

            obj.Add(12.05f, 6);
            obj.Add(5, 6);

        }
    }

    class Poly
    {
        public void Add()
        {
            Console.WriteLine("Overloading Assignment");
        }

       

        public void Add(float a,int b)
        {
            Console.WriteLine(a+b);
        }



        public int Add(int a,int b)
        {
            int total= a + b;
            Console.WriteLine(total);
            return total;
        }

    }
}
