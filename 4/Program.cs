using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                string html = "<ul> <li> <a href=http://softuni.bg>SoftUni</a> </li> </ul>";
          
          
                string pattern = "<a\\shref=(.+)>(.+)<\\/a>";

                Console.WriteLine(Regex.Replace(html, pattern, @"[URL href=$1]$2[/URL]"));
            

        }
    }
}
