using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _12L
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var str = "aaaaabbbbbcdddeeeedssaa";
            str = Regex.Replace(str, @"(.)\1+", "$1");
            Console.WriteLine(str);
        }
    }
}
