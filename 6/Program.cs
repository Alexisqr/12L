using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var h = Console.ReadLine();
            var str = " This is my cat! And this is my dog. We happily live in Paris – the most beautiful city in the world! Isn’t it great? Well it is :)";
            string rg = string.Format(@"[\w\s]*\b{0}\b[\w\s]*[.|!|?]", h);
            Regex rx = new Regex(rg);
            MatchCollection data = rx.Matches(str);
          
      
           
            foreach (var dat in data)
            {
                         
                    Console.WriteLine(dat);
           
            }
   
        }
    }
}
