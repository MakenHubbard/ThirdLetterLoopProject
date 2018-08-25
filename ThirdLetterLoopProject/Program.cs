using System;
using System.Linq;

namespace ThirdLetterLoopProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // INPUT = cwAt;
            // DESIRED OUTPUT = C-Ww-Aaa-Tttt

            var letters = "cwAt";

            var output = string.Join("-", letters.Select((b, i) => Char.ToUpper(b) + new string(Char.ToLower(b), i)));
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
