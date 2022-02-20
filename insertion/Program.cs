using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace CommonInsertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stop = Stopwatch.StartNew();
            stop.Start();
                Random rnd = new Random();
         int[] arr = new int[300000];
          for(int j = 0; j < 300000; j++)
          {
              arr[j]=(rnd.Next(1, 300000));
          }
            Console.WriteLine("\nSorted");
            PrintIntegerArray(InsertionSort(arr));
			Console.WriteLine("\n");
             Console.WriteLine("Time = " + stop.ElapsedMilliseconds);
            }

        static int[] InsertionSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                  }
            }
            return inputArray;         
        }
        public static void PrintIntegerArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i.ToString() + "  ");
            }
         }

       
        public static int[] InsertionSortByShift(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                int j;
                var insertionValue = inputArray[i];
                for (j = i; j > 0; j--)
                {
                    if (inputArray[j - 1] > insertionValue)
                    {
                        inputArray[j] = inputArray[j - 1];
                    }
                }
                inputArray[j] = insertionValue;
            }
            return inputArray;
        }

     }
}