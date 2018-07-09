using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCode
{
    static class Example1

    {

        private static void Main(string[] args)
        {
            Console.WriteLine(Example1.SumOfIntegers(100));
            Console.ReadLine();
        }

        //Recursive function to get sum of integers till given number
        public static int SumOfIntegers(int n)
    {
        if (n <= 0)
        {
            return 0;
        }
        return (n + SumOfIntegers(n - 1));
    }
    }
}
