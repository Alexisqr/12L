using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> valid = new List<string>();
            while (input != "end")
            {
                Regex rx = new Regex(@"^\b[A-Z][a-z]{2,}[ ]{0,1}[A-Z][a-z]{2,}\b$");
                if (rx.IsMatch(input))
                {

                    valid.Add(input);
                }
                input = Console.ReadLine();
            }
            for (int i = 0; i < valid.Count; i++)
            {
                Console.WriteLine(valid[i]);
            }
        }
    }
}
