using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_algorithms_library
{
    public class Utility //<T> where T : IComparable<T>
    {

        public static void BubbleSortAsc<T>(List<T> list) where T : IComparable<T>
        {
            for (int i = 0; i < list.Count-2; i++)
            {
                for (int j = 0; j < list.Count - 2; j++)
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
            for (int i = 0; i < list.Count - 2; i++)
            {
                for (int j = 0; j < list.Count - 2; j++)
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
