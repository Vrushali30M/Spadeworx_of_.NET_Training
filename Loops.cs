using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Loops
    {
        public void usingWhileLoop()
        {
            int count = 0;
            while (count <= 10)
            {
                count++;
                Console.WriteLine(count);
            }
        }

        public void usingDoWhile()
        {
            int num = 1;
            do
            {
                Console.WriteLine(" Value of Number  " + num);
                num++;

            } while (num <= 5);


        }

        public void usingForLoop()
        {
            int n = 5;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Hello I am Vrushali Mahajan");
            }


        }

        public void usingGoToLable()
        {

            string name = "Vrushali";

        label:



            Console.WriteLine("Welcome {0}", name);


            goto label;
        }

        public void usingForEach()
        {
            char[] arr = { 'V', 'r', 'u', 's', 'h', 'a', 'l', 'i' };

            foreach (char ch in arr)
            {
                Console.WriteLine(ch);
            }
        }

            
    }
}
