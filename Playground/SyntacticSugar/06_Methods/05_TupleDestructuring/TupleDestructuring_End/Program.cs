// exampele from: https://www.geeksforgeeks.org/c-sharp-deconstructors-with-tuples/
using System;

namespace TupleDestructuring_End
{
    public class Pet
    {

        // This method returns the Pet details 
        public (string, string, int, int, string) PetDetails(string type, string name, int height, int age, string color)
        {
            string p_type = type;
            string p_name = name;
            int p_height = height;
            int p_age = age;
            string p_color = color;

            return (p_type, p_name, p_height, p_height, p_color);
        }

    }

    class Program
    {


        // Main method 
        static void Main(string[] args)
        {
            // Creating object of pet class 
            Pet p = new Pet();

            // Deconstruct the given tuple 
            // So that we can directly access individual fields 
            // By explicitly declaring types 
            (string type, string name, int height, int age, string color) = p.PetDetails("Dog", "Dollar", 124, 3, "White");
            Console.WriteLine("Pet Details:");
            Console.WriteLine("Type: " + type);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Color: " + color);

            (var type2, var name2, var height2, var age2, var color2) = p.PetDetails("Cat", "Poo", 104, 1, "Black&White");
            Console.WriteLine("\nPet Details:");
            Console.WriteLine("Type: " + type2);
            Console.WriteLine("Name: " + name2);
            Console.WriteLine("Height: " + height2);
            Console.WriteLine("Age: " + age2);
            Console.WriteLine("Color: " + color2);


            Console.ReadLine();

        }
    }
}
