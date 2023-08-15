using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Teacher : Person
    {
        public Teacher(string name, string surname, int age) : base(name, surname, age) { }
        public void Study()
        {
            Console.WriteLine("Explaining...");
        }
    }
}

