using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    //public enum PossibleAlgorithms
    //{
    //    ///summary
    //    ///The best sort algorithm
    //    ///</summary>
    //    SuperBuble,
    //    SupSel,
    //    SupIns 
    //}

    internal class Program
    {
        
        static void Main(string[] args)
        {

            //int intValue = int.Parse(Console.ReadLine());

            //Sort(Array.Empty<int>(), (PossibleAlgorithms)intValue);

            int[] array = { 12, 11, 13, 5, 6 };
            BubbleSort(array);
            int[] array2 = { 21, 4, 2, 5, 6 };
            Insertion(array2);
            int[] array1 = { 12, 17, 3, 45, 6 };
            Selection(array1);

            printArray(array);
            printArray(array1);
            printArray(array2);

            Console.ReadKey();
        }

        //public static void Sort(int[] array, PossibleAlgorithms algorithm)
        //{
        //    switch (algorithm)
        //    {
        //        case PossibleAlgorithms.SuperBuble:
        //            BubbleSort(array);
        //            break;
        //        case PossibleAlgorithms.SupIns:
        //            Insertion(array);
        //            break;
        //        case PossibleAlgorithms.SupSel:
        //            Selection(array);
        //            break;
        //    }
        //}
        public static void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (array[j] > array[j + 1])
                    {
                        
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
            printArray(array);
        }
        public static void Selection(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (array[j] < array[min_idx])
                        min_idx = j;

                
                int temp = array[min_idx];
                array[min_idx] = array[i];
                array[i] = temp;
            }
            printArray(array);
        }
        public static void Insertion(int[] array)
        {
            int n = array.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = array[i];
                int j = i - 1;

               
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
            printArray(array);
        }
        static void printArray(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }
    }
    
}
