using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCode.Space_Complexity
{
    class Example2
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Example2.PairSumSequence(1));
            Console.ReadLine();
        }

        public static  int PairSumSequence(int n)
        {
            var sum = 0;
            for (var i = 0; i < n; i++)
            {
                sum += PairSum(i, i + 1);
            }
            return sum;
        }

        public static int PairSum(int a, int b)
        {
            return (a + b);
        }

    }
}
