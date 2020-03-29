using System;

namespace DynamicObject_End
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic studentDynamic = new
            {
                Id = 1,
                Name = "Florin",
                Age = 29,
            };


            var concreteStudent = new Student
            {
                Id = studentDynamic.Id,
                Name = studentDynamic.Name,
                Age = studentDynamic.Age
            };

        }
    }
}
