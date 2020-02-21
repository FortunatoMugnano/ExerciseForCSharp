using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Interfaces
{
    interface IFlippable
    {
        int CurrentPage { get; set; }
        void Flip();
    }
}
