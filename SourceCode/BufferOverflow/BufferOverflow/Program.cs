using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BufferOverflow
{
    class Program
    {
        private static string b(string s)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(s));
        }
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                if (args[0].Length > 32 + 3 && args[0].Contains("true") && args[0].Contains("||"))
                    Console.WriteLine(b(b("VUdGemN6b2dWMlZzWTI5dFpURT0=")));
                else if (args[0].Length == 0)
                    Console.WriteLine("Specify the password as parameter after the program name");
                else Console.WriteLine("Wrong Key");
            }
            else Console.WriteLine("Specify the password as parameter after the program name");
        }
    }
}
