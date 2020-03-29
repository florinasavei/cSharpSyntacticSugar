using System;
using System.Collections.Generic;
using System.Text;

namespace Props_End
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Name
        {
            get { return $"{FirstName} {LastName}"; }
            set
            {
                string[] valueSplit = value.Split(" ");
                FirstName = valueSplit[0];
                FirstName = valueSplit[1];
            }
        }

        public int Age { get; set; }

        public int ShoeSize { get; set; } = 41;

        public List<float> Grades { get; set; }

    }
}
