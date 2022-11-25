using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "chico/ gosho \\ sapunerka (3sas) mazut lelQ_Van4e ";
                //Console.ReadLine();          
           
            MatchCollection matches = Regex.Matches(input, @"(?<=[\s\/\\(\)]|^)([A-Za-z]\w{3,25})(?=[\s\/\\(\)]|$)");
            //?= є позитивним прогнозом, типом твердження нульової ширини . Це говорить про те, що за записаним
            //збігом має слідувати все, що знаходиться в дужках, але ця частина не зафіксована.
            //?=Позитивна випереджальна умова
            //?<= Позитивна ретроспективна умова
            int Max = 0;
            int ind = 0;
            for (int i = 0; i < matches.Count - 1; i++)
            {
                int potSum = matches[i].Length + matches[i + 1].Length;
                if (potSum > Max)
                {
                   Max = potSum;
                   ind = i;
                }
            }

            Console.WriteLine(matches[ind]);
            Console.WriteLine(matches[ind + 1]);
        }
    }
}
