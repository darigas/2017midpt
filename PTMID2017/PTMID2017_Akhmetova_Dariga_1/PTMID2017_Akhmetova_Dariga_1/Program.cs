using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static bool IsDivisible(int number)
        {
            if (number % 15 != 0)
            {
                if (number % 1000 == 0)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                int t = int.Parse(args[i]);
                if (IsDivisible(t))
                {
                    Console.WriteLine(t);
                }
            }
        }
    }
}