using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverTheRoad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OverTheRoad(3,3));
            Console.ReadLine();
        }

        public static long OverTheRoad(long address, long n)
        {


            return (address + (n - address) + (n + 1 - address)); 
        }

        public static long overTheRoad(long a, long n) => 2 * n - a + 1;
    }
}
