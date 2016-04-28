using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    using System.Runtime.InteropServices;

    class Program
    {
        static void Main()
        {
          string userInput = Console.ReadLine();

            foreach (char input in userInput)
            {
                Console.Write("\\u{0:x4}", Convert.ToInt16(input));
            }
            Console.WriteLine();
        }
          //public  static string GetEncode(string s)
          //  {
          //      StringBuilder sb = new StringBuilder();
          //      foreach (char c in s)
          //      {
          //          sb.Append("\\u");
          //          sb.Append(String.Format("{0:x4", (int)c));
          //      }
          //      return sb.ToString();
          //  }
    }
}
