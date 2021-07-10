using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class ReadOnlyModifier
    {
        public readonly string str1;
        public readonly string str2;

        public ReadOnlyModifier(string a, string b)
        {

            str1 = a;
            str2 = b;
            Console.WriteLine("Display value of string 1 {0}, "
                             + "and string 2 {1}", str1, str2);
        }

        static public void Main()
        {
            
                ReadOnlyModifier ob = new ReadOnlyModifier("GeeksforGeeks", "GFG");
            
            
        }
    }
}
