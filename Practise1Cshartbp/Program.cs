using System;
using System.Collections.Generic;

namespace Practise1Cshartbp
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new List<string>{ "Able", "Mii" };
            foreach(var name in list1)
            {
                Console.WriteLine(name);
            }

        }
    }
}
