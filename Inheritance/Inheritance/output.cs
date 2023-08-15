using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var teacher = new Teacher("Ayshan", "Ismayilova", 50);
            teacher.Study();

            var student = new Student("Fidan", "Ismayilova", 23);
            student.Learn();
        }

    }
}
