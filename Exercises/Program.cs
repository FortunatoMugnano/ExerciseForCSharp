using Exercises.Classes;
using Exercises.Interfaces;
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


            /*Another Exercise, Interfaces */

            Sedan s = new Sedan(60);
            Console.WriteLine($"Sedan with license plate {s.LicensePlate} and {s.Wheels} wheels, driving at {s.Speed} km/h.");
            s.SpeedUp();
            Console.WriteLine($"Sedan's faster speed: {s.Speed}");

            Sedan s2 = new Sedan(70);
            Console.WriteLine($"Sedan with license plate {s2.LicensePlate} and {s2.Wheels} wheels, driving at {s2.Speed} km/h.");
            s2.SpeedUp();
            Console.WriteLine($"Sedan's faster speed: {s2.Speed}");

            Truck t = new Truck(45, 500);
            Console.WriteLine($"Truck with license plate {t.LicensePlate} and {t.Wheels} wheels, driving at {t.Speed} km/h.");
            t.SpeedUp();
            Console.WriteLine($"Truck's faster speed: {t.Speed}");


            /*Another Exercise, Inheritance */

            Console.WriteLine(s.Describe());
            Console.WriteLine(t.Describe());

            Bicycle b = new Bicycle(10);
            b.SpeedUp();
            Console.WriteLine(b.Describe());





            /* REFERENCES EXERCISE */


            // Two references to the same object
            Dissertation diss1 = new Dissertation();
            Dissertation diss2 = diss1;
            diss1.CurrentPage = 31;
            diss1.Flip();
            Console.WriteLine(diss1.CurrentPage);
            Console.WriteLine(diss2.CurrentPage);
            // Both print 32


            // Referential equality when comparing reference types
            Dissertation d1 = new Dissertation(50);
            Dissertation d2 = new Dissertation(50);
            Console.WriteLine(d1 == d2);
            // Prints false


            // Value equality when comparing value types
            int int1 = 6;
            int int2 = 6;
            Console.WriteLine(int1 == int2);
            // Prints true

            // Reference to object with implemented interface
            Dissertation diss = new Dissertation(50);
            IFlippable flip = diss;
            diss.Flip();
            flip.Flip();
            Console.WriteLine(diss.Define());
            // This causes an error!
            // Console.WriteLine(f.Define());

            // Reference to object with inherited superclass
            Dissertation diss3 = new Dissertation(19);
            Book bdiss3 = diss3;
            Console.WriteLine(diss3.Author);
            Console.WriteLine(bdiss3.Author);
            Console.WriteLine(diss3.Define());
            // This causes an error!
            // bdiss3.Define();


            // Arrays of references
            IFlippable[] flippers = new IFlippable[] { new Dissertation(), new Diary() };
            foreach (IFlippable flipper in flippers)
            {
                flipper.Flip();
            }


            // Same reference type but different behavior (using virtual/override)
            Book bdiss = new Dissertation();
            Book bk = new Book();
            Console.WriteLine(bdiss.Stringify());
            Console.WriteLine(bk.Stringify());
            // Output:
            // "This is a Dissertation object!"
            // "This is a Book object!"


            // Null reference
            Diary dy = null;
            // Unassigned reference
            Diary dy2;
            // Unassigned references in array
            Diary[] dys = new Diary[5];




            /* INTRODUCTION TO OBJECT */

            Book book = new Book("Ta-Nehisi Coates", "Between the World and Me");
            Diary dyar = new Diary(38);
            Random rand = new Random();
            int i = 9;

            Object[] objects = { book, dyar, rand, i };

            foreach (Object obj in objects)
            {
                Console.WriteLine(obj.GetType());
                Console.WriteLine(obj);
            }

            bool bol = true;
            Console.WriteLine(bol);
            Console.WriteLine(bol.ToString());



            /* STRING, THE EXEPTION */

            // Example 1
            string dog = "chihuahua";
            string tinyDog = dog;
            dog = "dalmation";
            Console.WriteLine(dog);
            // Output: "dalmation"
            Console.WriteLine(tinyDog);
            // Output: "chihuahua"

            // Example 2
            string s1 = "Hello ";
            string s3 = s1;
            s1 += "World";
            System.Console.WriteLine(s1);
            // Output: "Hello World"
            System.Console.WriteLine(s3);
            // Output: "Hello"

        }
    }
}
