using System;
using System.Reflection.Metadata.Ecma335;

namespace Generics_End
{
    class Program
    {
        public class Anything<T>
        {

            // private data members 
            private T data;

            // using properties 
            public T value
            {

                // using accessors 
                get
                {
                    return this.data;
                }
                set
                {
                    this.data = value;
                }
            }

            // Generics method 
            public void Display<T>(string msg, T value) // where T :  struct, IComparable
            {
                Console.WriteLine("{0}:{1}", msg, value);
            }
        }

        static void Main(string[] args)
        {

            // instance of string type 
            var name = new Anything<string>();

            name.value = "Some string";
            name.Display<string>("A String :", name.value);

            // instance of float type 
            Anything<float> version = new Anything<float>();
            version.value = 5.0F;
            name.Display<float>("A Float :", version.value);


            // display Some string 
            Console.WriteLine(name.value);
            // display 5 
            Console.WriteLine(version.value);
        }
    }
}
