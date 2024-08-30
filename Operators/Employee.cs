using System;

namespace OperatorsAssignment
{
    class Employee : Person
    {
        public int Id { get; set; }

        //Overloading the is equal to operator

        public static bool operator==(Employee employee, Employee employee2)
        {
            if (employee.Id == employee2.Id)
                
                return true;
            else
                return false;
        }

        public override bool Equals(object obj)
        {
            Person person = obj as Person;
            if (person == null)
                return false;

            return this.ID.Equals(person.ID);
        }
    }
}