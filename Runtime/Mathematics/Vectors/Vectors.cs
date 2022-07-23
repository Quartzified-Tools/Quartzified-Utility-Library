using System.Collections.Generic;
using UnityEngine;

namespace Quartzified.Mathematics.Vectors
{
    public class Vectors
    {
        /// <summary>
        /// Returns random Coordinate around startPosition
        /// </summary>
        /// <param name="startPosition"> Center Point</param>
        /// <param name="radius"> Area Radius</param>
        /// <returns></returns>
        public static Vector2 GetRandomVectorArea(Vector2 startPosition, float radius)
        {
            System.Random r1 = new System.Random();

            float rndX = (float)r1.NextDouble() * radius;
            float rndY = (float)r1.NextDouble() * radius;

            Vector2 newPosition = new Vector2(startPosition.x + rndX, startPosition.y + rndY);

            return newPosition;
        }

        /// <summary>
        /// Returns random Coordinate around startPosition within range
        /// </summary>
        /// <param name="startPosition">Center Point</param>
        /// <param name="radiusMin">Min Radius Area</param>
        /// <param name="radiusMax">Max Radius Area</param>
        /// <returns></returns>
        public static Vector2 GetRandomVectorAreaRange(Vector2 startPosition, float radiusMin, float radiusMax)
        {
            System.Random r1 = new System.Random();

            float rndX = (float)r1.NextDouble() * (radiusMax - radiusMin) + radiusMin;
            float rndY = (float)r1.NextDouble() * (radiusMax - radiusMin) + radiusMin;

            Vector2 newPosition = new Vector2(startPosition.x + rndX, startPosition.y + rndY);

            return newPosition;
        }

        /// <summary>
        /// Returns random Coordinate around startPosition
        /// </summary>
        /// <param name="startPosition"> Center Point</param>
        /// <param name="radius"> Area Radius</param>
        /// <returns></returns>
        public static Vector3 GetRandomVectorArea(Vector3 startPosition, float radius)
        {
            System.Random r1 = new System.Random();

            float rndX = (float)r1.NextDouble() * radius;
            float rndY = (float)r1.NextDouble() * radius;
            float rndZ = (float)r1.NextDouble() * radius;

            Vector3 newPosition = new Vector3(startPosition.x + rndX, startPosition.y + rndY, startPosition.z + rndZ);

            return newPosition;
        }

        /// <summary>
        /// Returns random Coordinate around startPosition within range
        /// </summary>
        /// <param name="startPosition">Center Point</param>
        /// <param name="radiusMin">Min Radius Area</param>
        /// <param name="radiusMax">Max Radius Area</param>
        /// <returns></returns>
        public static Vector3 GetRandomVectorAreaRange(Vector3 startPosition, float radiusMin, float radiusMax)
        {
            System.Random r1 = new System.Random();

            float rndX = (float)r1.NextDouble() * (radiusMax - radiusMin) + radiusMin;
            float rndY = (float)r1.NextDouble() * (radiusMax - radiusMin) + radiusMin;
            float rndZ = (float)r1.NextDouble() * (radiusMax - radiusMin) + radiusMin;

            Vector3 newPosition = new Vector3(startPosition.x + rndX, startPosition.y + rndY, startPosition.z + rndZ);

            return newPosition;
        }

        /// <summary>
        ///  Returns the closest transform from a list
        /// </summary>
        /// <param name="transforms">List of Transforms</param>
        /// <param name="location">Location to determine distance from Transform</param>
        /// <returns></returns>
        public static Transform GetNearestTransform(List<Transform> transforms, Vector2 location)
        {
            Transform closest = null;
            foreach (Transform target in transforms)
            {
                if (closest == null || Vector2.Distance(target.position, location) < Vector2.Distance(closest.position, location)) closest = target;
            }
            return closest;
        }

        /// <summary>
        ///  Returns the closest transform from a list
        /// </summary>
        /// <param name="transforms">List of Transforms</param>
        /// <param name="location">Location to determine distance from Transform</param>
        /// <returns></returns>
        public static Transform GetNearestTransform(List<Transform> transforms, Vector3 location)
        {
            Transform closest = null;
            foreach (Transform target in transforms)
            {
                if (closest == null || Vector3.Distance(target.position, location) < Vector3.Distance(closest.position, location)) closest = target;
            }
            return closest;
        }

        public static float GetClosestDistance(Transform a, Transform b)
        {
            float distance = Vector3.Distance(a.transform.position, b.gameObject.transform.position);

            float radiusA = BoundsRadius(a.GetComponent<Collider>().bounds);
            float radiusB = BoundsRadius(b.GetComponent<Collider>().bounds);

            float distanceInside = distance - radiusA - radiusB;

            return Mathf.Max(distanceInside, 0);
        }
        public static float BoundsRadius(Bounds bounds) => (bounds.extents.x + bounds.extents.z) / 2;

    }
}
