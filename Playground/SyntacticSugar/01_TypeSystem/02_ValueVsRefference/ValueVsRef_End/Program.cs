using System;

namespace ValueVsRef_End
{
    class Program
    {
        class Student
        {
            public string Name;

            public int Age;

            public override string ToString()
            {
                return $"Name: {Name}, Age: {Age}";
            }
        }

        static void Main(string[] args)
        {

            int myAge = 28;
            int myAgeCopy = myAge;
            myAge++;

            Console.WriteLine("my age" + myAge);
            Console.WriteLine("my age copy: " +myAgeCopy);

            Student vasile = new Student();
            vasile.Age = 21;
            vasile.Name = "Vasile";

            Student twinVasile = new Student();

            twinVasile = vasile;

            vasile.Age = 22;

            Console.WriteLine(vasile); //calling the override ToString method
            Console.WriteLine(twinVasile);


        }
    }
}
