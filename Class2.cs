using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAccesss;


namespace FirstProject
{
    class Class2
    {
        static void Main(string[] args)
        {
            Bank b = new Bank();
            b.rateOfInterest();
            Bank b1 = new ICICI();
            b1.rateOfInterest();
            ICICI i1 = new ICICI();
            i1.rateOfInterest();
            // ICICI b3 = new Bank();



        }
    }
}
