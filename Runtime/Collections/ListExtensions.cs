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
        public static string ToString<T>(this List<T> list, bool link, string separator = ", ")
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
        public static bool AddOrSet<T>(this List<T> list, int index, T value)
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

        /// <summary>
        /// Returns true if a duplicate is found in the List.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool HasDuplicates<T>(this List<T> list)
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
        public static List<U> FindDuplicates<T, U>(this List<T> list, Func<T, U> keySelector)
        {
            return list.GroupBy(keySelector)
                .Where(group => group.Count() > 1)
                .Select(group => group.Key).ToList();
        }

        /// <summary>
        /// Returns one random entry from the List.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <returns></returns>
        public static object GetRandom<T>(this List<T> list)
        {
            return list[Mathematics.Random.GetRandom(0, list.Count - 1)];
        }
    }
}