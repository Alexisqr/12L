using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
     
            var str = " Many users @ SoftUni confuse email addresses. \r\nWe @ Softuni.BG provide high-quality training @ \r\nhome or @ class. –- steve.parker@softuni.de";
           
            Regex rx = new Regex(@"(\s)[a-zA-Z0-9]+[\w\-\.]*@[a-zA-Z]+(\.[a-zA-Z]+)+");
            MatchCollection data = rx.Matches(str);



            foreach (var dat in data)
            {

                Console.WriteLine(dat);

            }

        }
    }
}
