using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> valid = new List<string>();
            while (input != "end")
            {
                Regex rx = new Regex(@"^([\+][359]{3}[\s][0-9]{1}[\s][0-9]{3}[\s][0-9]{4})|([\+][359]{3}[-][0-9]{1}[-][0-9]{3}[-][0-9]{4})$");
                if (rx.IsMatch(input))
                {
                    
                    valid.Add(input);
                }
                input = Console.ReadLine();
            }
            for(int i = 0; i < valid.Count; i++)
            {
                Console.WriteLine(valid[i]);
            }
           
        }
    }
}
