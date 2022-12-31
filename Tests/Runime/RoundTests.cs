using NUnit.Framework;
using Quartzified.Mathematics;
using UnityEngine;

public class RoundTests
{
    [Test]
    public void RoundToNearestHalf_Float()
    {
        float half1 = Round.RoundToNearestHalf(2.5f);
        float half2 = Round.RoundToNearestHalf(5.3f);
        float half3 = Round.RoundToNearestHalf(127.2f);
        float half4 = Round.RoundToNearestHalf(64.8f);
        float half5 = Round.RoundToNearestHalf(64.4f);

        Assert.AreEqual(2.5f, half1);
        Assert.AreEqual(5.5f, half2);
        Assert.AreEqual(127f, half3);
        Assert.AreEqual(65f, half4);
        Assert.AreEqual(64.5f, half5);
    }

    [Test]
    public void RoundToNearestHalf_Double()
    {
        double half1 = Round.RoundToNearestHalf(2.5d);
        double half2 = Round.RoundToNearestHalf(5.3d);
        double half3 = Round.RoundToNearestHalf(127.2d);
        double half4 = Round.RoundToNearestHalf(64.8d);
        double half5 = Round.RoundToNearestHalf(64.4d);

        Assert.AreEqual(2.5d, half1);
        Assert.AreEqual(5.5d, half2);
        Assert.AreEqual(127d, half3);
        Assert.AreEqual(65d, half4);
        Assert.AreEqual(64.5d, half5);
    }

    [Test]
    public void RoundToNearestHalf_Vector2()
    {
        Vector2 half1 = Round.RoundToNearestHalf(new Vector2(1.25f, 1.1f));
        Vector2 half2 = Round.RoundToNearestHalf(new Vector2(5.3f, 1.6f));
        Vector2 half3 = Round.RoundToNearestHalf(new Vector2(127.2f, 1.4f));
        Vector2 half4 = Round.RoundToNearestHalf(new Vector2(64.8f, 1.2f));
        Vector2 half5 = Round.RoundToNearestHalf(new Vector2(64.4f, 1.95f));

        Assert.AreEqual(new Vector2(1.5f, 1f), half1);
        Assert.AreEqual(new Vector2(5.5f, 1.5f), half2);
        Assert.AreEqual(new Vector2(127f, 1.5f), half3);
        Assert.AreEqual(new Vector2(65f, 1f), half4);
        Assert.AreEqual(new Vector2(64.5f, 2f), half5);
    }

    [Test]
    public void RoundToNearestHalf_Vector3()
    {
        Vector3 half1 = Round.RoundToNearestHalf(new Vector3(1.25f, 1.1f, 0.1f));
        Vector3 half2 = Round.RoundToNearestHalf(new Vector3(5.3f, 1.6f, 0.12f));
        Vector3 half3 = Round.RoundToNearestHalf(new Vector3(127.2f, 1.4f, 0.14f));
        Vector3 half4 = Round.RoundToNearestHalf(new Vector3(64.8f, 1.2f, 0.13f));
        Vector3 half5 = Round.RoundToNearestHalf(new Vector3(64.4f, 1.95f, 0.11f));

        Assert.AreEqual(new Vector3(1.5f, 1f, 0), half1);
        Assert.AreEqual(new Vector3(5.5f, 1.5f, 0), half2);
        Assert.AreEqual(new Vector3(127f, 1.5f, 0), half3);
        Assert.AreEqual(new Vector3(65f, 1f, 0), half4);
        Assert.AreEqual(new Vector3(64.5f, 2f, 0), half5);
    }
}
