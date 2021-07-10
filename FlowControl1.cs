using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class FlowControl1
    {
        int num;
        public void validateAge(int n)
        {
            num = n;
            if (num > 18)
            {
                Console.WriteLine(" You are eligible for Voting ");
            }
            else if(num==18)
            {
                Console.WriteLine(" You are 18 year old ");
            }
            else
            {
                Console.WriteLine(" You are not eligible ");
            }
        }

        public void usingNestedIf()
        {
            int FirstNo = 30, SecondNo = 56, ThirdNo = 10;

            if(FirstNo > SecondNo)
            {
                    if(FirstNo > ThirdNo)
                {
                    Console.WriteLine(" Largest Number = " +FirstNo);
                }
                    else
                {
                    Console.WriteLine(" Largest Number = " + ThirdNo);
                }
            }
            else
            {
                if (SecondNo > ThirdNo)
                {
                    Console.WriteLine(" Largest Number = " + SecondNo);
                }
                else
                {
                    Console.WriteLine(" Largest Number = " + ThirdNo);
                }
            }
        }

        public void usingLadderr()
        {
            String day = "Sunday";

            if(day=="Monday")
            {
                Console.WriteLine("Day is " +day);
            }
            else if (day == "Wensday")
            {
                Console.WriteLine("Day is " + day);
            }
            else if (day == "Sunday")
            {
                Console.WriteLine("Day is " + day);
            }
            else
            {
                Console.WriteLine(" Day Not Match ");
            }
        }

        public void usingSwitchCase()
        {
            
             int number = 20;
            
            switch (number)
            {
                 
                case 10:
                    Console.WriteLine("Num is 10");
                    break;

                case 20:
                    Console.WriteLine("Num is 10");
                    break;

                case 30:
                    Console.WriteLine("Num is 10");
                    break;

                case 40:
                    Console.WriteLine("Num is 10");
                    break;
                
                default:
                    Console.WriteLine("No match found");
                    break;
            }
        }





    }
}
