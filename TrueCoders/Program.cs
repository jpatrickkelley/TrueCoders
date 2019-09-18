using System;
using System.Collections.Generic;

namespace TrueCoders
{
    class Program
    {
        class People
        {
            public string Age { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string HairColor { get; set; }
        }


        static void Main(string[] args)
        {

            People person1 = new People();
            person1.FirstName = "Jack";
            person1.LastName = "Rabbit";
            person1.HairColor = "White";
            person1.Age = "3";


            People person2 = new People();
            person2.FirstName = "Virginia";
            person2.LastName = "Hamm";
            person2.HairColor = "Red";
            person2.Age = "32";


            People person3 = new People();
            person3.FirstName = "River";
            person3.LastName = "Benz";
            person3.HairColor = "Brown";
            person3.Age = "27";


            People person4 = new People();
            person4.FirstName = "Cheryl";
            person4.LastName = "Franklin";
            person4.HairColor = "Brown";
            person4.Age = "16";


            List<People> TrueCoders = new List<People>();
            TrueCoders.Add(person1);
            TrueCoders.Add(person2);
            TrueCoders.Add(person3);
            TrueCoders.Add(person4);

            foreach (var person in TrueCoders)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} {person.Age} {person.HairColor}");

            }




            //Console.WriteLine($"{person1.FirstName} {person1.LastName} {person1.Age} {person1.HairColor}");
            //Console.WriteLine($"{person2.FirstName} {person2.LastName} {person2.Age} {person2.HairColor}");
            //Console.WriteLine($"{person3.FirstName} {person3.LastName} {person3.Age} {person3.HairColor}");
            //Console.WriteLine($"{person4.FirstName} {person4.LastName} {person4.Age} {person4.HairColor}");

            Console.WriteLine();

        }

    }



}
