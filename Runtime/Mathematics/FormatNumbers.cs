using System.Collections.Generic;
using System.Linq;

namespace Quartzified.Mathematics
{
    public static class FormatNumbers
    {
        static Dictionary<string, double> largeNumbersAbbreviations = new Dictionary<string, double>
        {
            {"k", 1e3 },
            {"M", 1e6 },
            {"B", 1e9 },
            {"T", 1e12 },
            {"Qa", 1e15 },
            {"Qi", 1e18 },
            {"Sx", 1e21 },
            {"Sp", 1e24 },
            {"Oc", 1e27 },
            {"No", 1e30 },
            {"Dc", 1e33 },
            {"Ud", 1e36 },
            {"Dd", 1e39 },
            {"Td", 1e42 },
            {"Qad", 1e45 },
            {"Qid", 1e48 },
            {"Sxd", 1e51 },
            {"Spd", 1e54 },
            {"Ocd", 1e57 },
            {"Nod", 1e60 },
            {"Vg", 1e63 },
            {"Uvg", 1e66 },
        };
        static Dictionary<string, double> largeNumbersNotations = new Dictionary<string, double>
        {
            {"Thousand", 1e3 },
            {"Million", 1e6 },
            {"Billion", 1e9 },
            {"Trillion", 1e12 },
            {"Quadrillion", 1e15 },
            {"Quintillion", 1e18 },
            {"Sextillion", 1e21 },
            {"Septillion", 1e24 },
            {"Octillion", 1e27 },
            {"Nonillion", 1e30 },
            {"Decillion", 1e33 },
            {"Undecillion", 1e36 },
            {"Duodecillion", 1e39 },
            {"Tredecillion", 1e42 },
            {"Quattuordecillion", 1e45 },
            {"Quindecillion", 1e48 },
            {"Sexdecillion", 1e51 },
            {"Septendecillion", 1e54 },
            {"Octodecillion", 1e57 },
            {"Novemdecillion", 1e60 },
            {"Vigintillion", 1e63 },
            {"Unvigintillion", 1e66 },
        };

        public static Dictionary<string, double> LargeNumberAbbreviations => largeNumbersAbbreviations;
        public static Dictionary<string, double> LargeNumberNotations => largeNumbersNotations;

        static string DoubleToShortAbbreviation(double value, bool showDecimal = false, bool showTrailingZeroes = true)
        {
            string prefix = "";
            if (value < 0)
            {
                value = -value;
                prefix = "-";
            }

            if(value < 10)
            {
                if(showDecimal)
                    return prefix + value.ToString(showTrailingZeroes ? "N2" : "0.##");
                else
                    return prefix + ((int)value).ToString(showTrailingZeroes ? "N2" : "0.##");
            }
            
            if(value < 100)
            {
                if (showDecimal)
                    return prefix + value.ToString(showTrailingZeroes ? "N1" : "0.#");
                else
                    return prefix + ((int)value).ToString(showTrailingZeroes ? "N1" : "0.#");
            }

            if (value < 1000)
            {
                if (showDecimal)
                    return prefix + value.ToString("N0");
                else
                    return prefix + ((int)value).ToString("N0");
            }

            KeyValuePair<string, double> latest = new KeyValuePair<string, double>("", 1e3);
            foreach (KeyValuePair<string, double> kvp in LargeNumberAbbreviations)
            {
                if(value < kvp.Value)
                {
                    if(value >= latest.Value * 100d)
                    {
                        return prefix + (value / latest.Value).ToString("N0") + latest.Key;
                    }

                    if (value >= latest.Value * 10d)
                    {
                        return prefix + (value / latest.Value).ToString("N1") + latest.Key;
                    }

                    return prefix + (value / latest.Value).ToString("N2") + latest.Key;
                }
                latest = kvp;
            }

            KeyValuePair<string, double> last = largeNumbersAbbreviations.Last();
            return prefix + (value / last.Value).ToString("N2") + last.Key;
        }

        static string DoubleToNotation(double value, bool showDecimal = false, bool showTrailingZeroes = true)
        {
            string prefix = "";
            if (value < 0)
            {
                value = -value;
                prefix = "-";
            }

            if (value < 10)
            {
                if (showDecimal)
                    return prefix + value.ToString(showTrailingZeroes ? "N2" : "0.##");
                else
                    return prefix + ((int)value).ToString(showTrailingZeroes ? "N2" : "0.##");
            }

            if (value < 100)
            {
                if (showDecimal)
                    return prefix + value.ToString(showTrailingZeroes ? "N1" : "0.#");
                else
                    return prefix + ((int)value).ToString(showTrailingZeroes ? "N1" : "0.#");
            }

            if (value < 1000)
            {
                if (showDecimal)
                    return prefix + value.ToString("N0");
                else
                    return prefix + ((int)value).ToString("N0");
            }

            KeyValuePair<string, double> latest = new KeyValuePair<string, double>("", 1e3);
            foreach (KeyValuePair<string, double> kvp in LargeNumberNotations)
            {
                if (value < kvp.Value)
                {
                    if (value >= latest.Value * 100)
                    {
                        return prefix + Mathematics.Truncate(value / latest.Value).ToString("N0") + " " + latest.Key;
                    }

                    if (value >= latest.Value * 10)
                    {
                        return prefix + (Mathematics.Truncate(value / latest.Value * 10) / 10).ToString("N1") + " " + latest.Key;
                    }

                    return prefix + (Mathematics.Truncate(value / latest.Value * 100) / 100).ToString("N2") + " " + latest.Key;
                }
                latest = kvp;
            }

            KeyValuePair<string, double> last = LargeNumberNotations.Last();
            return prefix + (value / last.Value).ToString("N2") + " " + last.Key;
        }

        #region Quick Conversion

        public static string ToShortAbbreviation(this int value) => DoubleToShortAbbreviation(value);
        public static string ToShortAbbreviation(this float value) => DoubleToShortAbbreviation(value);
        public static string ToShortAbbreviation(this double value) => DoubleToShortAbbreviation(value);

        public static string ToNotation(this int value) => DoubleToNotation(value);
        public static string ToNotation(this float value) => DoubleToNotation(value);
        public static string ToNotation(this double value) => DoubleToNotation(value);

        #endregion

        #region Custom Conversion

        public static string ToShortAbbreviation(this int value, bool showDecimal = false, bool showTrailingZeroes = true) => DoubleToShortAbbreviation(value, showDecimal, showTrailingZeroes);
        public static string ToShortAbbreviation(this float value, bool showDecimal = true, bool showTrailingZeroes = true) => DoubleToShortAbbreviation(value, showDecimal, showTrailingZeroes);
        public static string ToShortAbbreviation(this double value, bool showDecimal = true, bool showTrailingZeroes = true) => DoubleToShortAbbreviation(value, showDecimal, showTrailingZeroes);

        public static string ToNotation(this int value, bool showDecimal = false, bool showTrailingZeroes = true) => DoubleToNotation(value, showDecimal, showTrailingZeroes);
        public static string ToNotation(this float value, bool showDecimal = true, bool showTrailingZeroes = true) => DoubleToNotation(value, showDecimal, showTrailingZeroes);
        public static string ToNotation(this double value, bool showDecimal = true, bool showTrailingZeroes = true) => DoubleToNotation(value, showDecimal, showTrailingZeroes);

        #endregion
    }
}
