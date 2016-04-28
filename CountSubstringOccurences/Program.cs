using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstringOccurences
{
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();
            string subString = Console.ReadLine().ToLower();
            int counter = input.Select((c, i) => input.Substring(i)).Count(sub => sub.StartsWith(subString));
            Console.WriteLine(counter);

            ////var matches = Regex.Matches(input, substring);
            ////Console.WriteLine("Counts {0}", matches.Count);

            //List<int> position = new List<int>();
            //int pos = 0;

            //while ((pos < input.Length) && (pos = input.IndexOf(substring, pos)) != -1)
            //{
            //    position.Add(pos);
            //    pos += substring.Length;
            //}
            //Console.WriteLine("{0} counts", position.Count);

        }

    }
}
