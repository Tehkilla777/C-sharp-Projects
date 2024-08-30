using System;

namespace PolymorphismAssignment
{
    class Program
    {
        //makes new employee and lables them as a quitter
        static void Main(string[] args)
        {
            IQuittable NewEmployee = new Employee();

            NewEmployee.firstName = "Guy";
            NewEmployee.lastName = "Man";

            NewEmployee.Quit(NewEmployee);
            Console.ReadLine();
        }
    }
}