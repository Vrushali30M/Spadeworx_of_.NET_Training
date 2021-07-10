using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class SwitchCaseTraill
    {
        public void caseSwtich1()
        {
            string var = "switch";

            switch (var)
            {
                case "if.else":
                    Console.WriteLine("if...else statement");
                    break;
                case "ternary":
                    Console.WriteLine("Ternary operator");
                    break;
                case "switch":
                    Console.WriteLine("switch statement");
                    break;
            }
        }

        //Multiple cases can be combined to execute the same statements.

        public void caseSwtich2()
        {
            int x = 5;

            switch (x)
            {
                case 1:
                    Console.WriteLine("x = 1");
                    break;
                case 2:
                    Console.WriteLine("x = 2");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("x = 4 or x = 5");
                    break;
                default:
                    /*Console.WriteLine("x > 5");*/
                    break;
            }
        }

        public void caseSwtich3()
        {
            char grade = 'A';
            switch (grade)
            {
                /*case 'A':
                    Console.WriteLine("Excellent\n");
                    break;
                case 'B':
                    Console.WriteLine("\n\n\nKeep it up!\n\nNo break statement\n\nHence all the case following this(but not the ones above this) except the default case will get executed !\n\n");
                case 'C':
                    Console.WriteLine("\n\n\t\tCase C : Well done !\n\n");
                case 'D':
                    Console.WriteLine("\t\tCase D : You passed!\n\n");
                case 'F':
                    Console.WriteLine("\t\tCase E : Better luck next time\n\n\n");
                default:
                    Console.WriteLine("\t\tDefault Case : Invalid grade\n\n\n");*/
            }
        }


        static void Main(string[] args)
        {
            SwitchCaseTraill ob = new SwitchCaseTraill();
            ob.caseSwtich1();
            ob.caseSwtich2();
            ob.caseSwtich3();

        }


    }

    
}
