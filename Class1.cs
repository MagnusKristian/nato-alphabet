using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodeMedLinn
{
    internal class Class1
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int Age { get; set; }

        public Class1(string name,string description,int age)
        {
            Name = name;
            Description = description;
            Age = age;

        }
    }
}
