using System;
using System.Text;

namespace Quartzified.Collections
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// Returns the Array converted into a string.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public static string ToString(this Array input, string separator = ", ")
        {
            var ret = new StringBuilder();
            for (var i = 0; i < input.Length; i++)
            {
                ret.Append(input.GetValue(i));
                if (i != input.Length - 1)
                    ret.Append(separator);
            }
            return ret.ToString();
        }

        /// <summary>
        /// Returns true if a duplicate is found in the Array.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool HasDuplicates(this Array input)
        {
            Array.Sort(input);
            for (int i = 1; i < input.Length; i++)
            {
                if (input.GetValue(i) == input.GetValue(i - 1))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Returns one random entry from the Array.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static object GetRandom(this Array input)
        {
            return input.GetValue(Mathematics.Random.GetRandom(0, input.Length - 1));
        }
    }
}