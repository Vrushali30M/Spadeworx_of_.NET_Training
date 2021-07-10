using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class ModifiersEx
    {
        public int accno;
        public String name;
        public static float rateOfInterest = 8.8f;

    

    public ModifiersEx(int accno, String name)
        {
            this.accno = accno;
            this.name = name;
        }


    public void display()
        {
            Console.WriteLine(accno + " " + name + " " + rateOfInterest);
        }
    }
    class TestAccount
    {
        public static void Main(string[] args)
        {
            ModifiersEx a1 = new ModifiersEx(101, "Sonoo");
            ModifiersEx a2 = new ModifiersEx(102, "Mahesh");
            a1.display();
            a2.display();

        }
    }

