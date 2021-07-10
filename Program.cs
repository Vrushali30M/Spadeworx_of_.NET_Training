using System;
using TestAccesss;
namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)

        {
            /*
                        Console.WriteLine("Access Specifier");

                        int x = 0;


                        Class1 ob = new Class1();
                      //  x = ob.getAccess(); // Private method

                        string ename = ob.getData();  //public method

                      //  int pp=ob.getDisplay  Protected Method



                        Console.WriteLine("X is" +x);
                            */

            /*
            Console.WriteLine(".......................Using Looping................");
            Class1 cls = new Class1();

            Console.WriteLine("\n While Loop Assignment");

            cls.usingWhileLoop();

            Console.WriteLine("\n Do While Loop Assignment");
            cls.usingDoWhile();

            Console.WriteLine("\n For Loop Assignment");

            cls.usingForLoop();

            Console.WriteLine("\n ForEach Loop Statement Assignment");
            cls.usingForEach();

            Console.WriteLine("\n GoTo and Label Statement Assignment");
            //cls.usingGoToLable();

            */
            /*     Console.WriteLine(".......................Using Flow Control Statement................");
                 FlowControl1 ob2 = new FlowControl1();
                 ob2.validateAge(18);
                 ob2.usingNestedIf();
                 ob2.usingLadderr();
                 ob2.usingSwitchCase();*/

            /*  SwitchCaseTraill ob = new SwitchCaseTraill();
                  ob.caseSwtich1();
                  ob.caseSwtich2();*/

            /*LocalGlovalVar lc = new LocalGlovalVar();
            lc.getVariables();
           
            lc.counter = 5;
            Console.WriteLine("Global Variable: " + lc.counter);



            Console.WriteLine("\n Unary Operator ");
            UnaryOperator un = new UnaryOperator();
            un.prefixOperator();
            un.postfixOperator();

            Console.WriteLine("\n Unary Boxing and Unboxing      ");
            BoxingUnboxingcs box = new BoxingUnboxingcs();
            box.usingBoxing();
            box.usingUnBoxing();

*/

            /*        ConstrctorAss obj = new ConstrctorAss("Vrushali");
                ConstrctorAss obj1 = new ConstrctorAss("Vrusha");
    */

            Student ob = new Student();
            ob.Name = "Vrushali";
            ob.Id = 101;

            Console.WriteLine("Name is = " +ob.Name);
            Console.WriteLine("Id is = " +ob.Id);
            Console.WriteLine("Hello I am Vrushali Mahajan");


        }
    }
}
