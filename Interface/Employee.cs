using System;

namespace PolymorphismAssignment
{

    //Taking from person and iquittable
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        //employee is labled as quitter
        public void Quit(IQuittable Quitter)
        {
            Console.WriteLine(Employee.firstName + " " + Employee.lastName + " has quit.");
        }
    }
}