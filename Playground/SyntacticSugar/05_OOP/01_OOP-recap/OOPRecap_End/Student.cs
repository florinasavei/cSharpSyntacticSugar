using System;
using System.Collections.Generic;
using System.Text;

namespace OOPRecap_End
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        private string _address;
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = !string.IsNullOrWhiteSpace(value) ? value : "Brasov";
            }
        }

        public int ShoeSize { get;  set; }


        public List<float> Grades { get; set; }
    }
}
