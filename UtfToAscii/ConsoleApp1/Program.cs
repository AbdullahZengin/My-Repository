using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Abdullah ZENGİN";

            Console.WriteLine(Utf8ToAscii(input));

            Console.ReadKey();
        }

        static string Utf8ToAscii(string input)
        {
            string asciiCode = "";
            var utf8bytes = Encoding.UTF8.GetBytes(input);
            var win1252Bytes = Encoding.Convert(Encoding.UTF8, Encoding.ASCII, utf8bytes);
            foreach (var item in win1252Bytes)
            {
                asciiCode += item + " ";
            }

            return asciiCode;
        }
    }
}
