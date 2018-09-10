using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCode.BinarySearch
{
    class BinarySearch
    {
        private static void Main(string[] args)
        {
            var array = new int[]{1,2,3,4,5};
            BinarySearch.printunorderedPairs(array);
            Console.ReadLine();
        }
        public static void printunorderedPairs(int[] array )
        {
            for (int i = 0; i < array.Length; i++)
            {
                 for (int j = i + 1; j < array.Length; j++)
                {
                    Console.WriteLine(array[i] + "," +array[j]);
                }
                 }
             }
    }
}
