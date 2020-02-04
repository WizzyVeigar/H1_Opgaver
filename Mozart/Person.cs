using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozart
{
    abstract class Person
    {

        public Person(string name)
        {
            Name = name;
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
