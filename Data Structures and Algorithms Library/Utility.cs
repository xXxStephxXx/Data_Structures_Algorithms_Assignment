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

        public static object BinarySearch<T>(T[] array, T item) where T : IComparable<T>
        {
            int minNum = 0;
            int maxNum = array.Length - 1;

            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                int max;
                int min;
                if (item.CompareTo(array[mid]) == 0)
                {
                    return "The object was found"; //+ array[mid];
                }
                else if (item.CompareTo(array[mid]) < 0)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return "Not found";
        }


        public static int LinearSearch<T>(List<T> list, T item) where T : IComparable<T>
        {
            for (int i = 0; i < list.Count; i++)
                if (item.CompareTo(list[i]) == 0)
                
                    return i;

            return -1; 
        }

    }
}
