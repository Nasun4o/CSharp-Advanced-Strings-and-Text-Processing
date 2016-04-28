namespace StringLenght
{
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < 20; i++)
            {
                if (i < input.Length)
                {
                    result.Append(input[i]);
                }
                else
                {
                    result.Append('*');
                }
            }

            Console.WriteLine(result);
        }
    }
}
