using System;

namespace interfaces
{
    //Creating the person class and gets a first and last name
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public abstract void SayName();
    }
}