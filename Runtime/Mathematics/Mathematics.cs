using System;
using System.Collections.Generic;

namespace Quartzified.Mathematics
{
    public class Mathematics
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
        /// Returns the Median (Does not return decimals)
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
            int[] temp = inputs;
            Array.Sort(temp);

            return temp[0];
        }

        /// <summary>
        /// Returns the Smallest Number
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static float GetMin(float[] inputs)
        {
            float[] temp = inputs;
            Array.Sort(temp);

            return temp[0];
        }

        /// <summary>
        /// Returns the Smallest Number
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static double GetMin(double[] inputs)
        {
            double[] temp = inputs;
            Array.Sort(temp);

            return temp[0];
        }

        /// <summary>
        /// Returns the Smallest Number
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static decimal GetMin(decimal[] inputs)
        {
            decimal[] temp = inputs;
            Array.Sort(temp);

            return temp[0];
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
            int[] temp = inputs;
            Array.Sort(temp);

            return temp[temp.Length - 1];
        }

        /// <summary>
        /// Returns the Largest Number
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static float GetMax(float[] inputs)
        {
            float[] temp = inputs;
            Array.Sort(temp);

            return temp[temp.Length - 1];
        }

        /// <summary>
        /// Returns the Largest Number
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static double GetMax(double[] inputs)
        {
            double[] temp = inputs;
            Array.Sort(temp);

            return temp[temp.Length - 1];
        }

        /// <summary>
        /// Returns the Largest Number
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static decimal GetMax(decimal[] inputs)
        {
            decimal[] temp = inputs;
            Array.Sort(temp);

            return temp[temp.Length - 1];
        }

        #endregion

        #region GetRange

        /// <summary>
        /// Returns the Range
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static int GetRange(int[] inputs)
        {
            return GetMax(inputs) - GetMin(inputs);
        }

        /// <summary>
        /// Returns the Range
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static float GetRange(float[] inputs)
        {
            return GetMax(inputs) - GetMin(inputs);
        }

        /// <summary>
        /// Returns the Range
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static double GetRange(double[] inputs)
        {
            return GetMax(inputs) - GetMin(inputs);
        }

        /// <summary>
        /// Returns the Range
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static decimal GetRange(decimal[] inputs)
        {
            return GetMax(inputs) - GetMin(inputs);
        }

        #endregion

        #region GetPercent

        /// <summary>
        /// Returns the Percentage
        /// </summary>
        /// <param name="value"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public static int GetPercent(int value, int total)
        {
            return (value * 100) / total;
        }

        /// <summary>
        /// Returns the Percentage
        /// </summary>
        /// <param name="value"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public static float GetPercent(float value, float total)
        {
            return (value * 100f) / total;
        }

        /// <summary>
        /// Returns the Percentage
        /// </summary>
        /// <param name="value"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public static double GetPercent(double value, double total)
        {
            return (value * 100) / total;
        }

        /// <summary>
        /// Returns the Percentage
        /// </summary>
        /// <param name="value"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public static decimal GetPercent(decimal value, decimal total)
        {
            return (value * 100) / total;
        }

        #endregion

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

        public static float Clamp01(float value)
        {
            value = value > 1f ? 1 : value;
            value = value < 0f ? 0 : value;

            return value;
        }

        #endregion

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

        public static float Lerp(float a, float b, float t)
        {
            return a + (b - a) * Clamp01(t);
        }

        public static float LerpUnclamped(float a, float b, float t)
        {
            return a + (b - a) * t;
        }

        #region Angles

        public static float Angle(float x1, float y1, float x2, float y2)
        {
            return (float)(Math.Atan2(y2 - y1, x2 - x1) * 180 / Math.PI);
        }

        public static float AngleAverage(float a, float b)
        {
            return Lerp(a, b, 0.5f);
        }

        #endregion
    }
}