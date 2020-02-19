using Exercises.Classes;
using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Forest.ForestsCreated);
            Forest f = new Forest("Amazon");
            Forest x = new Forest("Sherwood");
            Console.WriteLine(Forest.ForestsCreated);
        }
    }
}
