using System;

namespace PolymorphismAssignment
{
    //Creates the IQuittable interface
    interface IQuittable
    {
        void Quit(IQuittable Quitter);
    }
}