using System;

//Write a function that combines two lists by alternatingly taking elements from each of them.For example: given the two lists[a, b, c] and[1, 2, 3], the function should return [a, 1, b, 2, c, 3].
namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] list1;
            int[] list2;
            string[] ResultList;

            //1- list1.Length==list2.Length
            list1 = new string[] { "a", "b", "c" };
            list2 = new int[] { 1, 2, 3 };
            ResultList = AlternatinglyMerge(list1, list2);
            ListWriter(ResultList, "1- list1.Length== list2.Length :");

            //2- list1.Length > list2.Length
            list1 = new string[] { "a", "b", "c", "d", "e", "f" };
            list2 = new int[] { 1, 2, 3 };
            ResultList = AlternatinglyMerge(list1, list2);
            ListWriter(ResultList, "2- list1.Length > list2.Length :");

            //3- list1.Length < list2.Length
            list1 = new string[] { "a", "b", "c" };
            list2 = new int[] { 1, 2, 3, 4, 5, 6 };
            ResultList = AlternatinglyMerge(list1, list2);
            ListWriter(ResultList, "3- list1.Length < list2.Length :");

            Console.ReadLine();
        }
        static string[] AlternatinglyMerge(string[] list1, int[] list2)
        {
            string[] list3 = new string[list1.Length + list2.Length];
            int i = 0;
            int j = 0;
            int k = 0;
            //if list1.Length is equal to list2.Length, it is entered.
            while (i < list1.Length && j < list2.Length)
            {
                list3[k++] = list1[i++];
                list3[k++] = list2[j++].ToString();
            }
            //if list1.Length is greater than list2.Length, it is entered.
            while (i < list1.Length)
            {
                list3[k++] = list1[i++];
            }
            //if list1.Length is smaller than list2.Length, it is entered.
            while (j < list2.Length)
            {
                list3[k++] = list2[j++].ToString();
            }
            return list3;
        }
        static void ListWriter(string[] list, string text)
        {
            Console.Write(text);
            foreach (string item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
