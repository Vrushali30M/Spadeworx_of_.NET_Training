using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class MethodOverride
    {/*
        static void Main(string[] args)
        {
            Bank b = new Bank();
            b.rateOfInterest();
            Bank b1 = new ICICI();
            b1.rateOfInterest();
            ICICI i1 = new ICICI();
            i1.rateOfInterest();
           // ICICI b3 = new Bank();

        }*/
    }

    class Bank
    {
        public virtual float rateOfInterest()
        {
            float irr = 4.5f;
            Console.WriteLine("IRR" + irr);
            return 4.5f;
        }

    }

    class ICICI : Bank
    {
        public override float rateOfInterest()
        {
            float ir = 3.5f;
            Console.WriteLine("IR" + ir);
            return 3.5f;
        }
    }

    
}
