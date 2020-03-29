using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqAnonymous_End
{
    class Program
    {
        class Geeks
        {

            public int A_no;
            public string Aname;
            public string language;
            public int age;
        }

        static void Main(string[] args)
        {
            List<Geeks> g = new List<Geeks>
            {

                new Geeks{ A_no = 123, Aname = "Shilpa",
                    language = "C#", age = 23 },
                new Geeks{ A_no = 124, Aname = "Shilpi",
                    language = "C#", age = 20 },
                new Geeks{ A_no = 125, Aname = "Soniya",
                    language = "C#", age = 22 },
                new Geeks{ A_no = 126, Aname = "Sonaly",
                    language = "C#", age = 25 },

            };

            // select query showing result 
            // using anonymous type 
            var anony_ob = g
                .Select(geek => new  {  geek.A_no, geek.Aname, geek.language })
                .Where(t => t.A_no % 2 == 0)
                .OrderByDescending(t => t.A_no);

            var concrete_ob = g
                .Select(geek => new Geeks { A_no = geek.A_no, Aname = geek.Aname, language = geek.language })
                .Where(t => t.A_no % 2 == 0)
                .OrderByDescending(t => t.A_no);

            var sonya = g.FirstOrDefault(t => t.Aname == "Soniya");

            foreach (var i in anony_ob)
            {
                Console.WriteLine("Author id = " + i.A_no + "\nAuthor name = "
                                  + i.Aname + "\nLanguage = " + i.language);
                Console.WriteLine();
            }
        }
    }
}

