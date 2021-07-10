using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Addition
    {
        public void usingUnaryoperator()
        {
            int x = 15;
            int result;

            Console.WriteLine("x is " + x);
            result = x++;
            Console.WriteLine("Post increment of x is " + x);

            Console.WriteLine("x is " + x);
            result = x--;
            Console.WriteLine("Post decrement of x is " + x);

            Console.WriteLine("x is " + x);
            result = ++x;
            Console.WriteLine("Pre increment of x is " + x);

            Console.WriteLine("x is " + x);
            result = --x;
            Console.WriteLine("Pre decrement of x is " + x);
        }


        static void Main(string[] args)
        {



            //Arithmetic Operators
            int a = 5, b = 4;

            Console.WriteLine("Addtion =" + (a + b));
            Console.WriteLine("Substraction =" + (a - b));
            Console.WriteLine("Multiplication =" + (a * b));
            Console.WriteLine("Division =" + (a / b));



            //Assignment Operator
            Console.WriteLine("\n Using Assignment Operator...................");
            int X = 50;
            int Y;
            Y = X;
            Console.WriteLine("After Assigning Value of Y = " + Y);
            Console.WriteLine("After Assigning Value of Y = " + (Y += Y));



            //Relational Operator
            Console.WriteLine("\n Using Relational Operator...................");

            int num1 = 45, num2 = 65;
            Console.WriteLine("\n num1 = " + num1 + " num2 = " + num2);

            Console.WriteLine(num1 == num2);
            Console.WriteLine(num1 != num2);
            Console.WriteLine(num1 > num2);
            Console.WriteLine(num1 < num2);
            Console.WriteLine(num1 <= num2);
            Console.WriteLine(num1 >= num2);


            //Logical Operator
            Console.WriteLine("\n Using Logical Operator...................");
            Console.WriteLine((45 > 36) || (89 < 90));
            Console.WriteLine((45 > 36) && (89 < 90));


            //Bitwise Operator
            Console.WriteLine("\n Bitwise Logical Operator...................");

            int firstNo = 40;
            int secondNo = 50;
            int res;

            res = ~firstNo;
            Console.WriteLine("FirstNo = " + firstNo + "  Result = " + res);

            res = firstNo & secondNo;
            Console.WriteLine("{0} & {1} = {2}", firstNo, secondNo, res);

            res = firstNo | secondNo;
            Console.WriteLine("{0} | {1} = {2}", firstNo, secondNo, res);

            res = firstNo ^ secondNo;
            Console.WriteLine("{0} ^ {1} = {2}", firstNo, secondNo, res);

            res = firstNo << 2;
            Console.WriteLine("{0} << 2 = {1}", firstNo, res);

            res = firstNo >> 2;
            Console.WriteLine("{0} >> 2 = {1}", firstNo, res);

            //Unary 

            Addition aa = new Addition();
            aa.usingUnaryoperator();








        }
    }








}
 