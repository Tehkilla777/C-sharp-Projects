using System;

namespace Interfaces
{
    //Creates the IQuittable interface
    interface IQuittable
    {
        void Quit(IQuittable Quitter);
    }
}