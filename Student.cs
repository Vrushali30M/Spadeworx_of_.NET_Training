using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
 

    class Student
    {

        private string name; // field
        private int id; // field

        public string Name   // property
        {
            get { return name; }
            set { name = value; }
        }

        public int Id   // property
        {
            get { return id; }
            set { id = value; }
        }
    }
}
