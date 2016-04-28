using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    class Program
    {
        static void Main()
        {
            string[] bannedList = Console.ReadLine().Split(new[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries ).ToArray();
            string userInput = Console.ReadLine();
            string[] censoredStrings = new string[bannedList.Count()];

            for (int i = 0; i < bannedList.Count(); i++)
            {
                censoredStrings[i] = new string('*', bannedList[i].Length);
                userInput = userInput.Replace(bannedList[i], censoredStrings[i]);
            }
            
            Console.WriteLine($"\n{userInput}");


        }
    }

}
  