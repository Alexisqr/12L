using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> output = new List<string>();
            string input = Console.ReadLine();
            string[] Tags = { "main", "header", "nav", "article", "section", "aside", "footer" };
           
            Regex start = new Regex(@"<div.*((id|class)\s?=\s?""(.*?)"").*?>");          
            Regex closers = new Regex(@"</div>\s.*?(\w+)\s*-->");
            while (input != "END")
            {
                MatchCollection matches = start.Matches(input);
                foreach (Match match in matches)
                {
                    string id = match.Groups[1].Value;//(id|class)\s?=\s?""(.*?)"")
                    string idValue = match.Groups[3].Value;//"(.*?)

                    if (Tags.Contains(idValue))//перевірка чи в tag є idValue
                    {
                        int i= 0;
                        for( i = 0; i < Tags.Length; i++)
                        {
                            if (Tags[i]== idValue)
                            {
                                break;
                            }
                        }
                        string replaceTag = Regex.Replace(match.ToString(), "div", Tags[i]);//Заміняємо div на Tags[i]
                        replaceTag = Regex.Replace(replaceTag, id, "");
                        replaceTag = Regex.Replace(replaceTag, "\\s*>", ">");
                        replaceTag = Regex.Replace(replaceTag, "\\s{2,}", " ");
                        input = Regex.Replace(input, match.ToString(), replaceTag);
                    }
                }
                MatchCollection matches2 = closers.Matches(input);
                foreach (Match match in matches2)
                {
                    string idValue = match.Groups[1].Value;
                    if (Tags.Contains(idValue))
                    {
                        input = Regex.Replace(input, match.ToString(), "</" + idValue + ">");
                    }
                }
                output.Add(input);
                input = Console.ReadLine();
            }
            for (int i = 0; i < output.Count; i++)
            {
                Console.WriteLine(output[i]);
            }
        }
    }
}
