using System;

namespace Anonymous_End
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Creating and initializing nested anonymous object 
            //var anony_object = new
            //{
            //    s_id = 149,
            //    s_name = "Soniya",
            //    language = "C#",
            //    anony_ob = new { email = "soniya45@gmail.com" }
            //};

            //// Accessing the object properties 
            //Console.WriteLine("Student id: " + anony_object.s_id);
            //Console.WriteLine("Student name: " + anony_object.s_name);
            //Console.WriteLine("Language: " + anony_object.language);
            //Console.WriteLine("Email: " + anony_object.anony_ob.email);

            var anonymousStudent = new
            {
                Id = 1,
                Name = "Florin",
                Age = 29,
            };

        }
    }
}
