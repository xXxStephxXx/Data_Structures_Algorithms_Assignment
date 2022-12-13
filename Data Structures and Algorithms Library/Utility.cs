using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data_structures_algorithms_library
{
    public class Utility //<T> where T : IComparable<T>
    {
        public static void BubbleSortAsc<T>(List<T> list) where T : IComparable<T>
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j].CompareTo(list[j + 1]) > 0)
                    {
                        var temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }

        public static void BubbleSortDesc<T>(List<T> list) where T : IComparable<T>
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j].CompareTo(list[j + 1]) < 0)
                    {
                        var temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }

        //public static object BinarySearchDisplay(int[] arr, int key)
        public static object BinarySearchDisplay<T>(T[] array, T item) where T : IComparable<T>
        {
            int minNum = 0;
            int maxNum = array.Length - 1;

            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                int max;
                int min;
                if (item.CompareTo(array[mid]) == 0)
                //if (item == array[mid])
                {
                    return ++mid;
                }
                else if (item.CompareTo(array[mid]) < 0) //  < array[mid])
                //else if (item < array[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }

        public static int LinearSearch<T>(T[] array, T item) where T : IComparable<T>// O(n)
        {
            for (int i = 0; i < array.Length; i++)
                // array[i] == item 
                if (item.CompareTo(array[i]) == 0) // array Comparer<T>.Default.Compare(array[i], item) == 0)
                //if (array Comparer<T>.Default.Compare(array[i], item) == 0)
                    return i;

            return -1; // Not found
        }

        //public static void sequentialSearch<T>(IEnumerable<T> list, IEnumerable<T> target) where T : IComparable<T>
        //{
        //    for(int i = 0; i < list.Count; i++)
        //    {
        //        if (list[i].CompareTo(target))
        //        {
        //            return true;
        //        }


        //        //foreach item in list

        //        //if ()
        //    }

        //}

        //private static int LinearSearchSequence<T>(IEnumerable<T> list, IEnumerable<T> target) where T : IComparable
        //{
        //    var targetArray = target.ToArray();
        //    var targetLength = targetArray.Length;
        //    var listLength = list.Count();
        //    for (int i = 0; i <= listLength - targetLength; i++)
        //    {
        //        for (int matchIndex = 0; matchIndex < targetLength; matchIndex++)
        //        {
        //            var item = list.ElementAt(i + matchIndex);
        //            var targetItem = targetArray[matchIndex];
        //            if (item.CompareTo(targetItem) != 0)
        //            {
        //                break;
        //            }

        //            if (matchIndex == targetLength - 1)
        //            {
        //                return i;
        //            }
        //        }
        //    }

        //    return -1;
        //}



        //    class LinearSearch
        //{
        //    public static int search(int[] arr, int x)
        //    {
        //        int N = arr.Length;
        //        for (int i = 0; i < N; i++)
        //        {
        //            if (arr[i] == x)
        //                return i;
        //        }
        //        return -1;
        //    }

        //    // Driver's code
        //    public static void Main()
        //    {
        //        int[] arr = { 2, 3, 4, 10, 40 };
        //        int x = 10;

        //        // Function call
        //        int result = search(arr, x);
        //        if (result == -1)
        //            Console.WriteLine(
        //            "Element is not present in array");
        //        else
        //            Console.WriteLine("Element is present at index "
        //            + result);
        //    }
        //}



        //// don't need the below methods
        //public void SortAsc(T[] items)
        //{
        //    for (int i = 0; i < items.Length; i++)
        //    {
        //        for (int j = 0; j < items.Length - 1 - i; j++)
        //        {
        //            if (items[j].CompareTo(items[j + 1]) > 0)
        //            {
        //                var temp = items[j];
        //                items[j] = items[j + 1];
        //                items[j + 1] = temp;
        //            }
        //        }
        //    }
        //}


        //public void SortDesc(T[] items)
        //{
        //    for (int i = 0; i < items.Length; i++)
        //    {
        //        for (int j = 0; j < items.Length - 1 - i; j++)
        //        {
        //            if (items[j].CompareTo(items[j + 1]) < 0)
        //            {
        //                var temp = items[j];
        //                items[j] = items[j + 1];
        //                items[j + 1] = temp;
        //            }
        //        }
        //    }
        //}

    }
}
