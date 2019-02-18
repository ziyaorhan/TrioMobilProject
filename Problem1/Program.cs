using System;

//Write three functions that compute the sum of the numbers in a given list using a for-loop, and recursion.
namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberList = { 1, 3, 7, 40, 300 };
            //1
            Console.WriteLine("Using the recursive method: {0}", SumWithRecursion(numberList).ToString());
            //2
            Console.WriteLine("Using the for-loop method: {0}", SumWithForLoop(numberList).ToString());
            //3
            Console.WriteLine("Using the foreach-loop method: {0}", SumWithForeachLoop(numberList).ToString());
            //4
            Console.WriteLine("Using the while-loop method: {0}", SumWithWhileLoop(numberList).ToString());
            Console.ReadLine();
        }
        //1- recursion method
        static int SumWithRecursion(int[] numberList, int itemIndex = 0)
        {
            if (itemIndex >= numberList.Length)
            {
                return 0;
            }
            return numberList[itemIndex] + SumWithRecursion(numberList, itemIndex + 1);
        }

        //2- for-loop method
        static int SumWithForLoop(int[] numberList)
        {
            int sum = 0;
            for (int i = 0; i < numberList.Length; i++)
            {
                sum += numberList[i];
            }
            return sum;
        }

        //3- foreach-loop method
        static int SumWithForeachLoop(int[] numberList)
        {
            int sum = 0;
            foreach (int number in numberList)
            {
                sum += number;
            }
            return sum;
        }

        //4- while-loop method
        static int SumWithWhileLoop(int[] numberList)
        {
            int sum = 0, itemIndex = 0;
            while (itemIndex < numberList.Length)
            {
                sum += numberList[itemIndex];
                itemIndex++;
            }
            return sum;
        }
    }
}
