using System;
using UnityEngine;

namespace Quartzified.Mathematics
{
    public class Round
    {
        /// <summary>
        /// Round value to the Nearast Half
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float RoundToNearestHalf(float value)
        {
            return (float)Math.Round(value * 2, MidpointRounding.AwayFromZero) / 2;
        }

        /// <summary>
        /// Round value to the Nearast Half
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double RoundToNearestHalf(double value)
        {
            return Math.Round(value * 2, MidpointRounding.AwayFromZero) / 2;
        }

        /// <summary>
        /// Round Vector2 to the Nearast Half
        /// </summary>
        /// <param name="vector2"></param>
        /// <returns></returns>
        public static Vector2 RoundToNearestHalf(Vector2 vector2)
        {
            return new Vector2(RoundToNearestHalf(vector2.x), RoundToNearestHalf(vector2.y));
        }

        /// <summary>
        /// Round Vector3 to the Nearast Half
        /// </summary>
        /// <param name="vector3"></param>
        /// <returns></returns>
        public static Vector3 RoundToNearestHalf(Vector3 vector3)
        {
            return new Vector3(RoundToNearestHalf(vector3.x), RoundToNearestHalf(vector3.y), RoundToNearestHalf(vector3.z));
        }
    }
}