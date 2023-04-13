using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quartzified.Collections
{
    public static class ListExtensions
    {
        /// <summary>
        /// Returns the List converted into a string.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="link"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public static string ToString<T>(this IList<T> list, bool link, string separator = ", ")
        {
            if (!link) return list.ToString();

            var stringBuilder = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                stringBuilder.Append(list[i].ToString());
                if (i < list.Count - 1)
                    stringBuilder.Append(separator);
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Sets a value at a specific index.
        ///  If the index does not exist, keep adding empty positions until the index can be set.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="index"></param>
        /// <param name="value"></param>
        /// <returns>Returns whether the index position existed (False upon development)</returns>
        public static bool AddOrSet<T>(this IList<T> list, int index, T value)
        {
            if (list.Count > index)
            {
                list[index] = value;
                return true;
            }
            else
            {
                while (list.Count < index)
                {
                    list.Add(default(T));
                }
                list.Add(value);
                return false;
            }
        }

        #region Duplicates

        /// <summary>
        /// Returns true if a duplicate is found in the List.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool HasDuplicates<T>(this IList<T> list)
        {
            return list.Count != list.Distinct().Count();
        }

        /// <summary>
        /// Returns a List of duplicate entries found in the given List.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="list"></param>
        /// <param name="keySelector"></param>
        /// <returns></returns>
        public static IList<U> FindDuplicates<T, U>(this IList<T> list, Func<T, U> keySelector)
        {
            return list.GroupBy(keySelector)
                .Where(group => group.Count() > 1)
                .Select(group => group.Key).ToList();
        }

        #endregion

        public static void ShuffleInto<T>(this IReadOnlyList<T> source, IList<T> target)
        {
            for (int i = 0; i < source.Count; i++)
            {
                int j = Mathematics.Random.GetRandom(0, i);
                if (j != i)
                {
                    target[i] = target[j];
                }
                target[j] = source[i];
            }
        }

        public static void FillRandomIntegerPermutation(this IList<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int j = Mathematics.Random.GetRandom(0, i);
                if (j != i)
                {
                    list[i] = list[j];
                }
                list[j] = i;
            }
        }

        public static void Reverse<T>(this IList<T> list)
        {
            int i = 0;
            int j = list.Count - 1;
            while (i < j)
            {
                T temp = list[i];
                list[i] = list[j];
                list[j] = temp;
                i++;
                j--;
            }
        }

        #region Random

        /// <summary>
        /// Returns one random entry from the List.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <returns></returns>
        public static T GetRandom<T>(this IList<T> list)
        {
            return list[Mathematics.Random.GetRandom(0, list.Count - 1)];
        }

        /// <summary>
        /// Returns one random entry from the Collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static T GetRandom<T>(this ICollection<T> list)
        {
            return list.ElementAt(Mathematics.Random.GetRandom(0, list.Count - 1));
        }

        /// <summary>
        /// Returns a random entry and swaps their position.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static T PickRandomAndSwap<T>(this IList<T> list, ref int size)
        {
            int index = Mathematics.Random.GetRandom(0, size - 1);

            T temp = list[index];

            list[index] = list[size - 1];
            list[size - 1] = temp;

            size--;

            return temp;
        }

        /// <summary>
        /// Shuffles the list randomly.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public static void Shuffle<T>(this IList<T> list)
        {
            for (int size = list.Count; size > 1; PickRandomAndSwap(list, ref size));
        }

        #endregion
    }
}