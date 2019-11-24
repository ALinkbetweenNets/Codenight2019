using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamSearch
{
    class Program
    {
        private static string b(string s)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(s));
        }
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (string s in File.ReadAllLines("output.txt"))
            {
                stringBuilder.Append(s);
            }
            string enco = stringBuilder.ToString();
            for (int i = 0; i < 50; i++)
            {
                enco = b(enco);
            }
            Console.ReadKey();
        }
    }
}
