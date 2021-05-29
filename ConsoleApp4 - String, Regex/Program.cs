using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4___String__Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Ahoj";
            string b = "AHoj";
            string c = "Ahoj";
            string d = "Beta";
            string e = "Ahoj kamarádi";
            string f = "Nazdar ahoj kamarádi";
            string quote = "The main intent of the \"Intro C#\" book is, to introduce, t,he C# programming to newbies C#.";

            //a[2] = 'F';                   NELZE!!!

            Console.WriteLine(a.Equals(b)); //POROVNÁVÁNÍ: jestli jsou stejné
            Console.WriteLine(a.Equals(c));

            Console.WriteLine(a.CompareTo(c)); //POROVNÁVÁNÍ: které je abecedně dřív
            Console.WriteLine(a.CompareTo(d));

            Console.WriteLine(a.ToUpper());
            Console.WriteLine(b.ToLower());

            Console.WriteLine(e.IndexOf(a)); //VYHLEDÁVÁNÍ: vrátí pozici nalezeného stringu
            Console.WriteLine(f.IndexOf(a));
            Console.WriteLine(f.IndexOf(a.ToLower()));

            int index = quote.IndexOf("C#");
            while (index != -1)
            {
                Console.WriteLine($"C# nalezeno na pozici {index}");
                index = quote.IndexOf("C#", index + 1);
            }

            Console.WriteLine(quote.Substring(3, 15)); //VÝBĚR

            char[] separators = new char[] { ' ', ',' };

            foreach (var item in quote.Split(separators))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(a.Replace("Ah", b));

            DateTime date = new DateTime(2001, 7, 23);
            Console.WriteLine($"{date:yy MM dd}");

            string format = String.Format("Datum je: {0:F}",date);
            Console.WriteLine(format);

            StringBuilder sb = new StringBuilder();
            sb.Append("AAIDJisdJOIDA");
            sb.Remove(4, 3);
            sb.Insert(4, "Nazdar");
            sb.Replace("Nazdar", "Zdravim");
            sb.Clear();
            sb.Append("Znovu");
            sb[2] = 'B';
            Console.WriteLine(sb.ToString());



            Console.ReadLine();
        }
    }
}
