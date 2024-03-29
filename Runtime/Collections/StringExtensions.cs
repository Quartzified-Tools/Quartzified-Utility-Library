using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Quartzified.Collections
{
    public static class StringExtensions
    {
        public static bool AreEqual(this string input1, string input2)
        {
            return string.Equals(input1, input2, StringComparison.InvariantCultureIgnoreCase);
        }
        public static bool AreNotEqual(this string input1, string input2)
        {
            return !AreEqual(input1, input2);
        }

        public static bool AreTrimEqual(this string input1, string input2)
        {
            return string.Equals(input1?.Trim(), input2?.Trim(), StringComparison.InvariantCultureIgnoreCase);
        }
        public static bool AreNotTrimEqual(this string input1, string input2)
        {
            return !AreTrimEqual(input1, input2);
        }

        public static bool IsNull(this string input)
        {
            return null == input;
        }
        public static bool IsNotNull(this string input)
        {
            return !IsNull(input);
        }

        public static bool IsNullOrEmpty(this string input)
        {
            return string.IsNullOrEmpty(input);
        }
        public static bool IsNotNullOrEmpty(this string input)
        {
            return !IsNullOrEmpty(input);
        }

        public static bool IsNullOrWhiteSpace(this string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }
        public static bool IsNotNullOrWhiteSpace(this string input)
        {
            return !IsNullOrWhiteSpace(input);
        }

        public static string Trim(this string input)
        {
            return input?.Trim();
        }
        public static string TrimStart(this string input)
        {
            return input?.TrimStart();
        }
        public static string TrimEnd(this string input)
        {
            return input?.TrimEnd();
        }

        public static string ToUpper(this string input)
        {
            return input?.ToUpper();
        }
        public static string ToLower(this string input)
        {
            return input?.ToLower();
        }

        public static string ToTitleCase(this string input)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input);
        }

        /// <summary>
        /// Find the position of the searchString inside the masterString.
        /// </summary>
        /// <param name="masterString"></param>
        /// <param name="searchString"></param>
        /// <returns></returns>
        public static int FindStringPositionWithinString(this string masterString, string searchString)
        {
            return IsNull(masterString) || IsNull(searchString)
                ? -1
                : masterString.IndexOf(searchString, StringComparison.Ordinal);
        }

        /// <summary>
        /// Replaces the badString with goodString inside the masterString.
        /// </summary>
        /// <param name="masterString">The main string in which the replacement will be done.</param>
        /// <param name="goodString"></param>
        /// <param name="badString"></param>
        /// <returns></returns>
        public static string ReplaceString(this string masterString, string goodString, string badString)
        {
            return IsNullOrEmpty(masterString) ? masterString : masterString.Replace(badString, goodString);
        }

        /// <summary>
        /// Replaces the first occurrence of a specified substring with another string.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="oldValue"></param>
        /// <param name="newValue"></param>
        /// <returns></returns>
        public static string ReplaceFirstOccurrence(this string input, string oldValue, string newValue)
        {
            int startIndex = input.IndexOf(oldValue);
            if (startIndex == -1)
                return input;

            return input.Remove(startIndex, oldValue.Length).Insert(startIndex, newValue);  
        }

        /// <summary>
        /// Reverse the string [World -> dlroW]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Reverse(this string input)
        {
            var ret = new StringBuilder();
            for (var i = input.Length - 1; i >= 0; i--)
            {
                ret.Append(input.Substring(i, 1));
            }
            return ret.ToString();
        }

        /// <summary>
        /// Capitalize the string [hey there -> Hey there]
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Capitalize(this string input)
        {
            if (input.Length == 0) return string.Empty;
            if (input.Length == 1) return input.ToUpper();

            return input.Substring(0, 1).ToUpper() + input.Substring(1);
        }

        /// <summary>
        /// Checks if the input string starts capitalized.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsCapitalized(this string input)
        {
            if (input.Length == 0) return false;
            return string.CompareOrdinal(input.Substring(0, 1), input.Substring(0, 1).ToUpper()) == 0;
        }

        /// <summary>
        /// Checks if the input input string is fully upper case.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsUpperCase(this string input)
        {
            for (var i = 0; i < input.Length; i++)
            {
                if (string.CompareOrdinal(input.Substring(i, 1), input.Substring(i, 1).ToUpper()) != 0)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Checks if the input string is fully lower case.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsLowerCase(this string input)
        {
            for (var i = 0; i < input.Length; i++)
            {
                if (string.CompareOrdinal(input.Substring(i, 1), input.Substring(i, 1).ToLower()) != 0)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Returns the total count of chars found in the input string.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="chars"></param>
        /// <param name="ignoreCases"></param>
        /// <returns></returns>
        public static int CountTotal(this string input, string chars, bool ignoreCases)
        {
            var count = 0;
            for (var i = 0; i < input.Length; i++)
            {
                if (!(i + chars.Length > input.Length) &&
                    string.Compare(input.Substring(i, chars.Length), chars, ignoreCases) == 0)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Checks if the input string contains vowels.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="ignoreY">Determines whether to ignore or include the vowel Y</param>
        /// <returns></returns>
        public static bool HasVowels(this string input, bool ignoreY = true)
        {
            string currentLetter;
            for (var i = 0; i < input.Length; i++)
            {
                currentLetter = input.Substring(i, 1);
                if (ignoreY)
                {
                    if (string.Compare(currentLetter, "a", StringComparison.OrdinalIgnoreCase) == 0 ||
                        string.Compare(currentLetter, "e", StringComparison.OrdinalIgnoreCase) == 0 ||
                        string.Compare(currentLetter, "i", StringComparison.OrdinalIgnoreCase) == 0 ||
                        string.Compare(currentLetter, "o", StringComparison.OrdinalIgnoreCase) == 0 ||
                        string.Compare(currentLetter, "u", StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        return true;
                    }
                }
                else
                {
                    if (string.Compare(currentLetter, "a", StringComparison.OrdinalIgnoreCase) == 0 ||
                        string.Compare(currentLetter, "e", StringComparison.OrdinalIgnoreCase) == 0 ||
                        string.Compare(currentLetter, "i", StringComparison.OrdinalIgnoreCase) == 0 ||
                        string.Compare(currentLetter, "o", StringComparison.OrdinalIgnoreCase) == 0 ||
                        string.Compare(currentLetter, "u", StringComparison.OrdinalIgnoreCase) == 0 ||
                        string.Compare(currentLetter, "y", StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Checks if the input string is only made of spaces.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsSpaces(this string input)
        {
            if (input.Length == 0) return false;
            return input.Replace(" ", "").Length == 0;
        }

        /// <summary>
        /// Checks if the input string is only made of the same letter or number.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsRepeatedChar(this string input)
        {
            if (input.Length == 0) return false;
            return input.Replace(input.Substring(0, 1), "").Length == 0;
        }

        /// <summary>
        /// Checks if the input string is only made of numbers.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsNumeric(this string input)
        {
            for (var i = 0; i < input.Length; i++)
            {
                if (!(Convert.ToInt32(input[i]) >= 48 && Convert.ToInt32(input[i]) <= 57))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Checks if the input string contains numbers.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool HasNumbers(this string input)
        {
            return Regex.IsMatch(input, "\\d+");
        }

        /// <summary>
        /// Checks if the input string is only made of letters and numbers.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsAlphaNumeric(this string input)
        {
            char currentLetter;
            for (var i = 0; i < input.Length; i++)
            {
                currentLetter = input[i];

                if (!(Convert.ToInt32(currentLetter) >= 48 && Convert.ToInt32(currentLetter) <= 57) &&
                    !(Convert.ToInt32(currentLetter) >= 65 && Convert.ToInt32(currentLetter) <= 90) &&
                    !(Convert.ToInt32(currentLetter) >= 97 && Convert.ToInt32(currentLetter) <= 122))
                {
                    //Not a number or a letter
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Checks if the input string is only made of letters.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsLetters(this string input)
        {
            char currentLetter;
            for (var i = 0; i < input.Length; i++)
            {
                currentLetter = input[i];

                if (!(Convert.ToInt32(currentLetter) >= 65 && Convert.ToInt32(currentLetter) <= 90) &&
                    !(Convert.ToInt32(currentLetter) >= 97 && Convert.ToInt32(currentLetter) <= 122))
                {
                    //Not a letter
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Checks if the input string contains spaces.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool HasSpaces(this string input) => input.Contains(" ");

        /// <summary>
        /// Removes all spaces from the input string.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string RemoveWhitespaces(this string input)
        {
            return new string(input.ToCharArray().Where(c => !Char.IsWhiteSpace(c)).ToArray());
        }

        /// <summary>
        /// Truncates the input to a specified length and adds an ellipsis at the end if the string was to long.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="maxLength"></param>
        /// <returns></returns>
        public static string Truncate(this string input, int maxLength)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return input.Length <= maxLength ? input : input.Substring(0, maxLength) + "...";
        }

        /// <summary>
        /// Checks if the input is a valid Email address.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsEmail(this string input)
        {
            if (input.IsNullOrWhiteSpace())
                return false;

            if (input.HasSpaces())
                return false;

            Regex regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return regex.IsMatch(input);
        }

        #region Split

        public static string[] SplitInPartsArray(this string input, int partLength = 2)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            if (partLength <= 0)
            {
                throw new ArgumentException("Part length has to be positive.", nameof(partLength));
            }

            string[] temp = new string[input.Length / partLength];
            int c = 0;

            for (var i = 0; i < input.Length; i += partLength)
            {
                temp[c] = input.Substring(i, Math.Min(partLength, input.Length - i));
                c++;
            }

            return temp;
        }

        public static IEnumerable<string> SplitInParts(this string input, int partLength)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            if (partLength <= 0)
            {
                throw new ArgumentException("Part length has to be positive.", nameof(partLength));
            }

            for (var i = 0; i < input.Length; i += partLength)
            {
                yield return input.Substring(i, Math.Min(partLength, input.Length - i));
            }
        }

        // Alloc Free Method
        public static IEnumerable<ReadOnlyMemory<char>> SplitInPartsFree(this string input, int partLength)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            if (partLength <= 0)
            {
                throw new ArgumentException("Part length has to be positive.", nameof(partLength));
            }

            for (var i = 0; i < input.Length; i += partLength)
            {
                yield return input.AsMemory().Slice(i, Math.Min(partLength, input.Length - i));
            }
        }

        #endregion

        static Regex lastNountRegEx = new Regex(@"([A-Z][a-z]*)");
        public static string ParseLastNoun(string text)
        {
            MatchCollection matches = lastNountRegEx.Matches(text);
            return matches.Count > 0 ? matches[matches.Count - 1].Value : "";
        }

        public static int GetStableHashCode(this string text)
        {
            unchecked
            {
                int hash = 23;
                foreach (char c in text)
                    hash = hash * 31 + c;
                return hash;
            }
        }
    }

}