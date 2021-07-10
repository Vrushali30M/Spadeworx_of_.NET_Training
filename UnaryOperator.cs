using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class UnaryOperator
    {
        public void prefixOperator()
        {
            int a, b;
            a = 50;
            Console.WriteLine(++a);

            b = a;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        public void postfixOperator()
        {
            int a, b;
            a = 10;
            Console.WriteLine(a++);

            b = a;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
