using System;
using System.Collections.Generic;

namespace Quartzified.Mathematics
{
    public static class Mathematics
    {

        #region GetSum

        /// <summary>
        /// Returns the Sum of all inputs added together
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static int GetSum(int[] inputs)
        {
            int sum = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                sum += inputs[i];
            }

            return sum;
        }

        /// <summary>
        /// Returns the Sum of all inputs added together
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static float GetSum(float[] inputs)
        {
            float sum = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                sum += inputs[i];
            }

            return sum;
        }

        /// <summary>
        /// Returns the Sum of all inputs added together
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static double GetSum(double[] inputs)
        {
            double sum = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                sum += inputs[i];
            }

            return sum;
        }

        /// <summary>
        /// Returns the Sum of all inputs added together
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static decimal GetSum(decimal[] inputs)
        {
            decimal sum = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                sum += inputs[i];
            }

            return sum;
        }

        #endregion

        #region GetAverage

        /// <summary>
        /// Returns the Average (Does not return decimals)
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static int GetAverage(int[] inputs)
        {
            int average = GetSum(inputs) / inputs.Length;
            return average;
        }

        /// <summary>
        /// Returns the Average
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static float GetAverage(float[] inputs)
        {
            float average = GetSum(inputs) / inputs.Length;
            return average;
        }

        /// <summary>
        /// Returns the Average
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static double GetAverage(double[] inputs)
        {
            double average = GetSum(inputs) / inputs.Length;
            return average;
        }

        /// <summary>
        /// Returns the Average
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static decimal GetAverage(decimal[] inputs)
        {
            decimal average = GetSum(inputs) / inputs.Length;
            return average;
        }

        #endregion

        #region GetMedian

        /// <summary>
        /// Returns the Median
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static int GetMedian(int[] inputs)
        {
            int[] temp = inputs;
            Array.Sort(temp);

            int count = temp.Length;
            if (count == 0)
            {
                throw new InvalidOperationException("Empty Collection");
            }
            else if (count % 2 == 0)
            {
                int a = temp[count / 2 - 1];
                int b = temp[count / 2];
                return (a + b) / 2;
            }
            else
            {
                return temp[count / 2];
            }
        }

        /// <summary>
        /// Returns the Median
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static float GetMedian(float[] inputs)
        {
            float[] temp = inputs;
            Array.Sort(temp);

            int count = temp.Length;
            if (count == 0)
            {
                throw new InvalidOperationException("Empty Collection");
            }
            else if (count % 2 == 0)
            {
                float a = temp[count / 2 - 1];
                float b = temp[count / 2];
                return (a + b) / 2;
            }
            else
            {
                return temp[count / 2];
            }
        }

        /// <summary>
        /// Returns the Median
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static double GetMedian(double[] inputs)
        {
            double[] temp = inputs;
            Array.Sort(temp);

            int count = temp.Length;
            if (count == 0)
            {
                throw new InvalidOperationException("Empty Collection");
            }
            else if (count % 2 == 0)
            {
                double a = temp[count / 2 - 1];
                double b = temp[count / 2];
                return (a + b) / 2;
            }
            else
            {
                return temp[count / 2];
            }
        }

        /// <summary>
        /// Returns the Median
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static decimal GetMedian(decimal[] inputs)
        {
            decimal[] temp = inputs;
            Array.Sort(temp);

            int count = temp.Length;
            if (count == 0)
            {
                throw new InvalidOperationException("Empty Collection");
            }
            else if (count % 2 == 0)
            {
                decimal a = temp[count / 2 - 1];
                decimal b = temp[count / 2];
                return (a + b) / 2m;
            }
            else
            {
                return temp[count / 2];
            }
        }

        #endregion

        #region GetMode

        /// <summary>
        /// Returns the Mode
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static int GetMode(int[] inputs)
        {
            int mode = 0;

            if (inputs != null && inputs.Length > 0)
            {
                Dictionary<int, int> counts = new Dictionary<int, int>();

                foreach (int e in inputs)
                {
                    if (counts.ContainsKey(e))
                        counts[e]++;
                    else counts.Add(e, 1);
                }

                int max = 0;
                foreach (KeyValuePair<int, int> count in counts)
                {
                    if (count.Value > max)
                    {
                        mode = count.Key;
                        max = count.Value;
                    }
                }
            }

            return mode;
        }

        /// <summary>
        /// Returns the Mode
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static float GetMode(float[] inputs)
        {
            float mode = 0;

            if (inputs != null && inputs.Length > 0)
            {
                Dictionary<float, int> counts = new Dictionary<float, int>();

                foreach (float e in inputs)
                {
                    if (counts.ContainsKey(e))
                        counts[e]++;
                    else counts.Add(e, 1);
                }

                int max = 0;
                foreach (KeyValuePair<float, int> count in counts)
                {
                    if (count.Value > max)
                    {
                        mode = count.Key;
                        max = count.Value;
                    }
                }
            }

            return mode;
        }

        /// <summary>
        /// Returns the Mode
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static double GetMode(double[] inputs)
        {
            double mode = 0;

            if (inputs != null && inputs.Length > 0)
            {
                Dictionary<double, int> counts = new Dictionary<double, int>();

                foreach (double e in inputs)
                {
                    if (counts.ContainsKey(e))
                        counts[e]++;
                    else counts.Add(e, 1);
                }

                int max = 0;
                foreach (KeyValuePair<double, int> count in counts)
                {
                    if (count.Value > max)
                    {
                        mode = count.Key;
                        max = count.Value;
                    }
                }
            }

            return mode;
        }

        /// <summary>
        /// Returns the Mode
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static decimal GetMode(decimal[] inputs)
        {
            decimal mode = 0;

            if (inputs != null && inputs.Length > 0)
            {
                Dictionary<decimal, int> counts = new Dictionary<decimal, int>();

                foreach (decimal e in inputs)
                {
                    if (counts.ContainsKey(e))
                        counts[e]++;
                    else counts.Add(e, 1);
                }

                int max = 0;
                foreach (KeyValuePair<decimal, int> count in counts)
                {
                    if (count.Value > max)
                    {
                        mode = count.Key;
                        max = count.Value;
                    }
                }
            }

            return mode;
        }

        #endregion

        #region GetMin

        /// <summary>
        /// Returns the Smallest Number
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static int GetMin(int[] inputs)
        {
            if (inputs.Length == 0)
                return 0;

            int min = inputs[0];
            for (int i = 1; i < inputs.Length; i++)
            {
                if (inputs[i] < min)
                    min = inputs[i];
            }

            return min;
        }

        /// <summary>
        /// Returns the Smallest Number
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static float GetMin(float[] inputs)
        {
            if (inputs.Length == 0)
                return 0;

            float min = inputs[0];
            for (int i = 1; i < inputs.Length; i++)
            {
                if (inputs[i] < min)
                    min = inputs[i];
            }

            return min;
        }

        /// <summary>
        /// Returns the Smallest Number
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static double GetMin(double[] inputs)
        {
            if (inputs.Length == 0)
                return 0;

            double min = inputs[0];
            for (int i = 1; i < inputs.Length; i++)
            {
                if (inputs[i] < min)
                    min = inputs[i];
            }

            return min;
        }

        /// <summary>
        /// Returns the Smallest Number
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static decimal GetMin(decimal[] inputs)
        {
            if (inputs.Length == 0)
                return 0;

            decimal min = inputs[0];
            for (int i = 1; i < inputs.Length; i++)
            {
                if (inputs[i] < min)
                    min = inputs[i];
            }

            return min;
        }

        #endregion

        #region GetMax

        /// <summary>
        /// Returns the Largest Number
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static int GetMax(int[] inputs)
        {
            if (inputs.Length == 0)
                return 0;

            int max = inputs[0];
            for (int i = 1; i < inputs.Length; i++)
            {
                if (inputs[i] > max)
                    max = inputs[i];
            }

            return max;
        }

        /// <summary>
        /// Returns the Largest Number
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static float GetMax(float[] inputs)
        {
            if (inputs.Length == 0)
                return 0;

            float max = inputs[0];
            for (int i = 1; i < inputs.Length; i++)
            {
                if (inputs[i] > max)
                    max = inputs[i];
            }

            return max;
        }

        /// <summary>
        /// Returns the Largest Number
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static double GetMax(double[] inputs)
        {
            if (inputs.Length == 0)
                return 0;

            double max = inputs[0];
            for (int i = 1; i < inputs.Length; i++)
            {
                if (inputs[i] > max)
                    max = inputs[i];
            }

            return max;
        }

        /// <summary>
        /// Returns the Largest Number
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static decimal GetMax(decimal[] inputs)
        {
            if (inputs.Length == 0)
                return 0;

            decimal max = inputs[0];
            for (int i = 1; i < inputs.Length; i++)
            {
                if (inputs[i] > max)
                    max = inputs[i];
            }

            return max;
        }

        #endregion

        #region GetRange

        /// <summary>
        /// Returns the Range
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static int GetRange(int[] inputs) => GetMax(inputs) - GetMin(inputs);

        /// <summary>
        /// Returns the Range
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static float GetRange(float[] inputs) => GetMax(inputs) - GetMin(inputs);

        /// <summary>
        /// Returns the Range
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static double GetRange(double[] inputs) => GetMax(inputs) - GetMin(inputs);

        /// <summary>
        /// Returns the Range
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static decimal GetRange(decimal[] inputs) => GetMax(inputs) - GetMin(inputs);

        #endregion

        #region GetPercent

        /// <summary>
        /// Returns the Percentage
        /// </summary>
        /// <param name="value"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public static int GetPercent(int value, int total) => (value * 100) / total;

        /// <summary>
        /// Returns the Percentage
        /// </summary>
        /// <param name="value"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public static float GetPercent(float value, float total) => (value* 100f) / total;

        /// <summary>
        /// Returns the Percentage
        /// </summary>
        /// <param name="value"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public static double GetPercent(double value, double total) => (value * 100d) / total;

        /// <summary>
        /// Returns the Percentage
        /// </summary>
        /// <param name="value"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public static decimal GetPercent(decimal value, decimal total) => (value * 100) / total;

        #endregion

        public static float Sqrt(float a) => (float)Math.Sqrt(a);
        public static double Sqrt(double a) => (double)Math.Sqrt(a);

        public static float Abs(float a) => (float)Math.Abs(a);
        public static double Abs(double a) => (double)Math.Abs(a);

        #region Percent Utility

        /// <summary>
        /// Returns true if Percentage is greater than the threshold
        /// </summary>
        /// <param name="value"></param>
        /// <param name="total"></param>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public static bool PercentGreaterThan(int value, int total, int threshold)
        {
            return GetPercent(value, total) > threshold ? true : false;
        }

        /// <summary>
        /// Returns true if Percentage is greater than the threshold
        /// </summary>
        /// <param name="value"></param>
        /// <param name="total"></param>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public static bool PercentGreaterThan(float value, float total, float threshold)
        {
            return GetPercent(value, total) > threshold ? true : false;
        }

        /// <summary>
        /// Returns true if Percentage is greater than the threshold
        /// </summary>
        /// <param name="value"></param>
        /// <param name="total"></param>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public static bool PercentGreaterThan(double value, double total, double threshold)
        {
            return GetPercent(value, total) > threshold ? true : false;
        }

        /// <summary>
        /// Returns true if Percentage is greater than the threshold
        /// </summary>
        /// <param name="value"></param>
        /// <param name="total"></param>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public static bool PercentGreaterThan(decimal value, decimal total, decimal threshold)
        {
            return GetPercent(value, total) > threshold ? true : false;
        }

        /// <summary>
        /// Returns true if Percentage is less than the threshold
        /// </summary>
        /// <param name="value"></param>
        /// <param name="total"></param>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public static bool PercentLessThan(int value, int total, int threshold)
        {
            return GetPercent(value, total) < threshold ? true : false;
        }

        /// <summary>
        /// Returns true if Percentage is less than the threshold
        /// </summary>
        /// <param name="value"></param>
        /// <param name="total"></param>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public static bool PercentLessThan(float value, float total, float threshold)
        {
            return GetPercent(value, total) < threshold ? true : false;
        }

        /// <summary>
        /// Returns true if Percentage is less than the threshold
        /// </summary>
        /// <param name="value"></param>
        /// <param name="total"></param>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public static bool PercentLessThan(double value, double total, double threshold)
        {
            return GetPercent(value, total) < threshold ? true : false;
        }

        /// <summary>
        /// Returns true if Percentage is less than the threshold
        /// </summary>
        /// <param name="value"></param>
        /// <param name="total"></param>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public static bool PercentLessThan(decimal value, decimal total, decimal threshold)
        {
            return GetPercent(value, total) < threshold ? true : false;
        }

        #endregion

        #region Clamp

        /// <summary>
        /// Clamp Integer between 2 values
        /// </summary>
        /// <param name="value">Value to Clamp</param>
        /// <param name="min">Smallest Number</param>
        /// <param name="max">Largest Number</param>
        /// <returns></returns>
        public static int Clamp(int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        /// <summary>
        /// Clamp Float between 2 values
        /// </summary>
        /// <param name="value">Value to Clamp</param>
        /// <param name="min">Smallest Number</param>
        /// <param name="max">Largest Number</param>
        /// <returns></returns>
        public static float Clamp(float value, float min, float max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        /// <summary>
        /// Clamp Double between 2 values
        /// </summary>
        /// <param name="value">Value to Clamp</param>
        /// <param name="min">Smallest Number</param>
        /// <param name="max">Largest Number</param>
        /// <returns></returns>
        public static double Clamp(double value, double min, double max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        /// <summary>
        /// Clamp Decimal between 2 values
        /// </summary>
        /// <param name="value">Value to Clamp</param>
        /// <param name="min">Smallest Number</param>
        /// <param name="max">Largest Number</param>
        /// <returns></returns>
        public static decimal Clamp(decimal value, decimal min, decimal max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        /// <summary>
        /// Clamp Long between 2 values
        /// </summary>
        /// <param name="value">Value to Clamp</param>
        /// <param name="min">Smallest Number</param>
        /// <param name="max">Largest Number</param>
        /// <returns></returns>
        public static long Clamp(long value, long min, long max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        /// <summary>
        /// Clamp T between 2 values
        /// </summary>
        /// <param name="value">Value to Clamp</param>
        /// <param name="min">Smaller Value</param>
        /// <param name="max">Bigger Value</param>
        /// <returns></returns>
        public static T Clamp<T>(T value, T max, T min) where T : System.IComparable<T>
        {
            return value.CompareTo(max) > 0 ?
                max : value.CompareTo(min) < 0 ?
                min : value;
        }

        public static float Clamp01(float value)
        {
            value = value > 1f ? 1 : value;
            value = value < 0f ? 0 : value;

            return value;
        }

        #endregion

        #region Round / Floor / Ceil

        #region Round

        public static float Round(float a, int digits = 0) => (float)Math.Round(a, digits);
        public static double Round(double a, int digits = 0) => Math.Round(a, digits);

        public static int RoundToInt(float a) => (int)Math.Round(a);
        public static int RoundToInt(double a) => (int)Math.Round(a);

        #endregion

        #region Floor

        public static float Floor(float a) => (float)Math.Floor(a);
        public static double Floor(double a) => (double)Math.Floor(a);

        public static int FloorToInt(float a) => (int)Math.Floor(a);
        public static int FloorToInt(double a) => (int)Math.Floor(a);

        #endregion

        #region Ceil

        public static float Ceil(float a) => (float)Math.Ceiling(a);
        public static double Ceil(double a) => Math.Ceiling(a);

        public static int CeilToInt(float a) => (int)Math.Ceiling(a);
        public static int CeilToInt(double a) => (int)Math.Ceiling(a);

        #endregion

        #endregion

        #region To Type

        public static int ToInt(this string value, int defaultValue = 0)
        {
            int.TryParse(value, out defaultValue);
            return defaultValue;
        }
        public static int ToInt(this bool boolean) => boolean ? 1 : 0;

        public static float ToFloat(this string value, float defaultValue = 0)
        {
            float.TryParse(value, out defaultValue);
            return defaultValue;
        }
        public static float ToFloat(this bool boolean) => boolean ? 1f : 0f;

        public static long ToLong(this string value, long defaultValue = 0)
        {
            long.TryParse(value, out defaultValue);
            return defaultValue;
        }

        #endregion

        #region Remap

        public static float Remap(float value, float f1, float t1, float f2, float t2)
        {
            return (value - f1) / (t1 - f1) * (t2 - f2) + f2;
        }

        public static double Remap(double value, double f1, double t1, double f2, double t2)
        {
            return (value - f1) / (t1 - f1) * (t2 - f2) + f2;
        }

        public static decimal Remap(decimal value, decimal f1, decimal t1, decimal f2, decimal t2)
        {
            return (value - f1) / (t1 - f1) * (t2 - f2) + f2;
        }

        #endregion

        #region Lerp

        public static int Lerp(int a, int b, float t)
        {
            return a + (int)((b - a) * Clamp01(t));
        }

        public static float Lerp(float a, float b, float t)
        {
            return a + (b - a) * Clamp01(t);
        }

        public static double Lerp(double a, double b, float t)
        {
            return a + (b - a) * Clamp01(t);
        }

        public static float LerpUnclamped(float a, float b, float t)
        {
            return a + (b - a) * t;
        }

        #endregion

        #region Angles

        #region Basics

        public static float Sin(float a) => (float)Math.Sin(a);
        public static double Sin(double a) => Math.Sin(a);

        public static float Cos(float a) => (float)Math.Cos(a);
        public static double Cos(double a) => Math.Cos(a);

        public static float Tan(float a) => (float)Math.Tan(a);
        public static double Tan(double a) => Math.Tan(a);

        public static float Asin(float a) => (float)Math.Asin(a);
        public static double Asin(double a) => Math.Asin(a);

        public static float Acos(float a) => (float)Math.Acos(a);
        public static double Acos(double a) => Math.Acos(a);

        public static float Atan(float a) => (float)Math.Atan(a);
        public static double Atan(double a) => Math.Atan(a);

        public static float Atan(float x, float y) => (float)Math.Atan2(y, x);
        public static double Atan(double x, double y) => (double)Math.Atan2(y, x);

        #endregion

        public static float Angle(float x1, float y1, float x2, float y2)
        {
            return (float)(Math.Atan2(y2 - y1, x2 - x1) * 180 / Math.PI);
        }

        public static float AngleAverage(float a, float b)
        {
            return Lerp(a, b, 0.5f);
        }

        #endregion

        #region Quick Conversion

        public static float ToDeg(this float v)
        {
            return v * 180 / (float)Math.PI;
        }

        public static double ToDeg(this double v)
        {
            return v * 180 / Math.PI;
        }

        public static float ToRad(this float v)
        {
            return v * (float)Math.PI / 180;
        }

        public static double ToRad(this double v)
        {
            return v * Math.PI / 180;
        }

        #endregion

        public static decimal Truncate(decimal a) => Math.Truncate(a);
        public static double Truncate(double a) => Math.Truncate(a);
    }
}