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
               hash *= (int)c;
           }
           hash = (hash%900) + 100;
           if(hash==520){
               Console.WriteLine("Key could be correct");
           }
        }
    }
}
