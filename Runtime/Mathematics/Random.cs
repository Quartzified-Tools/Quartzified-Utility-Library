

namespace Quartzified.Mathematics
{
    public class Random
    {
        /// <summary>
        /// Returns a Random int between the min and max(inclusive)
        /// </summary>
        /// <param name="min">Smallest number</param>
        /// <param name="max">Largest number</param>
        /// <returns></returns>
        public static int GetRandom(int min = 0, int max = 100)
        {
            System.Random r = new System.Random();

            int rnd = r.Next(min, max + 1);

            return rnd;
        }

        /// <summary>
        /// Returns a Random float between the min and max
        /// </summary>
        /// <param name="min">Smallest number</param>
        /// <param name="max">Largest number</param>
        /// <returns></returns>
        public static float GetRandom(float min = 0f, float max = 1f)
        {
            System.Random r = new System.Random();

            float rnd = (float)(r.NextDouble() * (max - min) + min);

            return rnd;
        }

        /// <summary>
        /// Returns a Random double between the min and max
        /// </summary>
        /// <param name="min">Smallest number</param>
        /// <param name="max">Largest number</param>
        /// <returns></returns>
        public static double GetRandom(double min = 0.0, double max = 1.0)
        {
            System.Random r = new System.Random();

            double rnd = r.NextDouble() * (max - min) + min;

            return rnd;
        }

        /// <summary>
        /// Returns True if the number is less than the threshold
        /// </summary>
        /// <param name="min">Smallest number</param>
        /// <param name="max">Largest number</param>
        /// <param name="threshold">Number Threshold</param>
        /// <returns></returns>
        public static bool GetRandomThreshold(int min = 0, int max = 100, int threshold = 50)
        {
            int rnd = GetRandom(min, max);

            return rnd < threshold ? true : false;
        }

        /// <summary>
        /// Returns True if the number is less than the threshold
        /// </summary>
        /// <param name="min">Smallest number</param>
        /// <param name="max">Largest number</param>
        /// <param name="threshold">Number Threshold</param>
        /// <returns></returns>
        public static bool GetRandomThreshold(float min = 0f, float max = 1f, float threshold = 0.5f)
        {
            float rnd = GetRandom(min, max);

            return rnd < threshold ? true : false;
        }

        /// <summary>
        /// Returns True if the number is less than the threshold
        /// </summary>
        /// <param name="min">Smallest number</param>
        /// <param name="max">Largest number</param>
        /// <param name="threshold">Number Threshold</param>
        /// <returns></returns>
        public static bool GetRandomThreshold(double min = 0.0, double max = 1.0, double threshold = 0.5)
        {
            double rnd = GetRandom(min, max);

            return rnd < threshold ? true : false;
        }
    }
}