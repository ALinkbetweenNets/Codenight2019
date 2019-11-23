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
            List<char> charList = new List<char>();
            charList.Add((char)((int)'g'+-19));
            charList.Add((char)((int)'p'+-8));
            charList.Add((char)((int)'G'+40));
            charList.Add((char)((int)'P'+37));
            charList.Add((char)((int)'Z'+-18));
            charList.Add((char)((int)'<'+37));
            charList.Add((char)((int)'m'+13));
            charList.Add((char)((int)'I'+17));
            charList.Add((char)((int)'l'+-7));
            charList.Add((char)((int)'K'+0));
            charList.Add((char)((int)'>'+39));
            charList.Add((char)((int)'^'+27));

            if (args.Contains(string.Join("",charList)))
                Console.WriteLine("Key");
        }
    }
}
