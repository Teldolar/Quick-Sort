using System;
using Library1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var quickSortArray = new int[10]
            {
                1234,345,63413,72547,2,534,61,275,345,72
            };
            PrintArray(quickSortArray);
            Console.WriteLine("---------------------");
            quickSortArray = QuickSortClass.quicksort(quickSortArray,0,quickSortArray.Length-1);
            PrintArray(quickSortArray);
        }

        private static void PrintArray(int[] myArray)
        {
            foreach (var t in myArray)
            {
                Console.WriteLine(t);
            }
        }
    }
}