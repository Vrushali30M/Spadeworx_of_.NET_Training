using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class BoxingUnboxingcs
    {
        public void usingBoxing()
        {
         
            int num = 500;     // assigned int value 500 to num
       

            
            object obj = num;   //boxing

            // value of num to be change
            num = 100;

            System.Console.WriteLine("Value - type value of num is : {0}", num);
            System.Console.WriteLine("Object - type value of obj is : {0}", obj);
        }

        public void usingUnBoxing()
        {

            // assigned int value
            // 23 to num
            int num = 23;

            // boxing
            object obj = num;

            // unboxing
            int i = (int)obj;

            // Display result
            Console.WriteLine("Value of ob object is : " + obj);
            Console.WriteLine("Value of i is : " + i);
        }
    }
}
