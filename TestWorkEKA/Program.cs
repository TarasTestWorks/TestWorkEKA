using System;

namespace TestWorkEKA
{
    class Program
    {

        static void Main(string[] args)
        {

            int m = 5;

            int[] copiedIntArray = new int[m];
            int[] intArray = new int[] { 1, 4, 9, 5, 3, 4, 2, 5, 3, 7 };

            Array.Copy(intArray, copiedIntArray, m);

            bool isExisted = Array.Exists<int>(copiedIntArray, x => x.Equals(0));
            var convertedToInt = Convert.ToInt32(isExisted);

            Console.Write((Result)convertedToInt);
            Console.ReadLine();

        }
        internal enum Result
        {
            Yes = 1,
            No = 0,
        }

    }
}
