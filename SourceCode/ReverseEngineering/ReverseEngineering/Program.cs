using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseEngineering
{
    class Program
    {
        static void Main(string[] args)
        {
           string key = args[0];
           char[] keyArray = key.ToCharArray();
           Int64 hash = 1;
           foreach(char c in keyArray) {
               hash *= (int)c + keyArray.Count();
           }
           hash = (hash%900) + 100;
           Console.WriteLine(hash.ToString());
        }
    }
}
