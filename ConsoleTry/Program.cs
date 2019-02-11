using System;
using System.Threading.Tasks;

namespace ConsoleTry
{
    public class Janken
    {
        public string poi(string p1, string p2)
        {
            if(p1=="goo"&&p2=="paa" ||
               p1=="thoki"&&p2=="paa")
            return "p1";
            else
            {
                return "p2";
            }
        }

        public static void Main(string[] args)
        {

        }
    }
}
