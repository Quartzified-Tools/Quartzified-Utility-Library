using UnityEngine;

namespace Quartzified.Mathematics
{
    public class Distance
    {
        #region Manhatten Distance

        /// <summary>
        /// Calculates the Manhattan distance between two points.
        /// </summary>
        /// <param name="x1">The first x coordinate</param>
        /// <param name="y1">The first y coordinate</param>
        /// <param name="x2">The second x coordinate</param>
        /// <param name="y2">The second y coordinate</param>
        /// <returns></returns>
        public static int ManhattanDistance(int x1, int y1, int x2, int y2)
        {
            return Mathf.Abs(x1 - x2) + Mathf.Abs(y1 - y2);
        }

        /// <summary>
        /// Calculates the Manhattan distance between two points.
        /// </summary>
        /// <param name="x1">The first x coordinate</param>
        /// <param name="y1">The first y coordinate</param>
        /// <param name="x2">The second x coordinate</param>
        /// <param name="y2">The second y coordinate</param>
        /// <returns></returns>
        public static float ManhattanDistance(float x1, float y1, float x2, float y2)
        {
            return Mathf.Abs(x1 - x2) + Mathf.Abs(y1 - y2);
        }

        /// <summary>
        /// Calculates the Manhattan distance between two points.
        /// </summary>
        /// <param name="a">The first Vector3 coordinates</param>
        /// <param name="b">The second Vector3 coordinates</param>
        /// <returns></returns>
        public static float ManhattanDistance(Vector3 a, Vector3 b)
        {
            return Mathf.Abs(a.x - b.x) + Mathf.Abs(a.y - b.y) + Mathf.Abs(a.z - b.z);
        }

        #endregion

        #region EuclideanDistance

        /// <summary>
        /// Calculates the Euclidean distance between two points.
        /// </summary>
        /// <param name="x1">The first x coordinate</param>
        /// <param name="y1">The first y coordinate</param>
        /// <param name="x2">The second x coordinate</param>
        /// <param name="y2">The second y coordinate</param>
        /// <returns></returns>
        public static int EuclideanDistance(int x1, int y1, int x2, int y2)
        {
            return (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);
        }

        /// <summary>
        /// Calculates the Euclidean distance between two points.
        /// </summary>
        /// <param name="x1">The first x coordinate</param>
        /// <param name="y1">The first y coordinate</param>
        /// <param name="x2">The second x coordinate</param>
        /// <param name="y2">The second y coordinate</param>
        /// <returns></returns>
        public static float EuclideanDistance(float x1, float y1, float x2, float y2)
        {
            return (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);
        }

        /// <summary>
        /// Calculates the Euclidean distance between two points.
        /// </summary>
        /// <param name="a">The first Vector3 coordinates</param>
        /// <param name="b">The second Vector3 coordinates</param>
        /// <returns></returns>
        public static float EuclideanDistance(Vector3 a, Vector3 b)
        {
            return (a.x - b.x) * (a.x - b.x) + (a.y - b.y) * (a.y - b.y) + (a.z - b.z) * (a.z - b.z);
        }

        #endregion

        #region ChebyshevDistance

        /// <summary>
        /// Calculates the Chebyshev distance between two points.
        /// </summary>
        /// <param name="x1">The first x coordinate</param>
        /// <param name="y1">The first y coordinate</param>
        /// <param name="x2">The second x coordinate</param>
        /// <param name="y2">The second y coordinate</param>
        /// <returns></returns>
        public static int ChebyshevDistance(int x1, int y1, int x2, int y2)
        {
            return Mathf.Max(Mathf.Abs(x2 - x1), Mathf.Abs(y2 - y1));
        }

        /// <summary>
        /// Calculates the Chebyshev distance between two points.
        /// </summary>
        /// <param name="x1">The first x coordinate</param>
        /// <param name="y1">The first y coordinate</param>
        /// <param name="x2">The second x coordinate</param>
        /// <param name="y2">The second y coordinate</param>
        /// <returns></returns>
        public static float ChebyshevDistance(float x1, float y1, float x2, float y2)
        {
            return Mathf.Max(Mathf.Abs(x2 - x1), Mathf.Abs(y2 - y1));
        }

        /// <summary>
        /// Calculates the Chebyshev distance between two points.
        /// </summary>
        /// <param name="a">The first Vector3 coordinates</param>
        /// <param name="b">The second Vector3 coordinates</param>
        /// <returns></returns>
        public static float ChebyshevDistance(Vector3 a, Vector3 b)
        {
            return Mathf.Max(Mathf.Abs(b.x - a.x), Mathf.Abs(b.y - a.y), Mathf.Abs(b.z - a.z));
        }

        #endregion
    }
}