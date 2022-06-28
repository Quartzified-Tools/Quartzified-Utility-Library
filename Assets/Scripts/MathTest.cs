using System.Collections.Generic;
using UnityEngine;
using Quartzified.Mathematics;

public class MathTest : MonoBehaviour
{
    public int testInt1 = 5;
    public List<int> testInt2 = new List<int>() { 1,3,6,8,1,4,1,4,8,1,3,5,8,9,4,7};

    public float testFloat1 = 1.2f;
    public float testFloat2 = 63401.843f;
    public List<float> testFloat3 = new List<float>() { 23.1f, 33.1f, 23.5f, 76.43f, 23.46f, 34.5f,97f, 12.34f, 9.87f, 86f, 7.4f, 5.4f, 84f, 25.6f, 83f, 7f };

    private void Start()
    {
        Debug.Log("Mode 2 i: " + Mathematics.GetMode(testInt2.ToArray()));
        Debug.Log("Median 2 i: " + Mathematics.GetMedian(testInt2.ToArray()));
        Debug.Log("Mode 3 f: " + Mathematics.GetMode(testFloat3.ToArray()));
        Debug.Log("Median 3 f: " + Mathematics.GetMedian(testFloat3.ToArray()));

        Debug.Log("Nearest Half 1: " + Round.RoundToNearestHalf(testFloat1));
        Debug.Log("Nearest Half 2: " + Round.RoundToNearestHalf(testFloat2));
    }
}
