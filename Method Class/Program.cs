using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodClass class1 = new MethodClass();

            Console.WriteLine(class1.Thing(7, 3));
        }
    }
}