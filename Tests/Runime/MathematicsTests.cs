using NUnit.Framework;
using Quartzified.Mathematics;
using System;

public class MathematicsTests
{
    int[] ints = new int[] { 12, 15, 19, 10, 0, 1, 10 };
    float[] floats = new float[] { 12.2f, 15.1f, 19f, 10.9f, 0.2f, 1f, 0.2f };
    double[] doubles = new double[] { 12.256, 15.153, 19.23, 10.9, 0.211, 1.76, 10.9 };
    decimal[] decimals = new decimal[] { 98766, 1123, 1123, 34532, 76547645, 25153545765, 2555555555555 };

    #region GetSum

    [Test]
    public void GetSum_Int()
    {
        int sum = Mathematics.GetSum(ints);

        Assert.AreEqual(67, sum);
        Assert.NotZero(sum);
    }

    [Test]
    public void GetSum_Float()
    {
        float sum = Mathematics.GetSum(floats);

        Assert.AreEqual(58.6f, sum);
        Assert.NotZero(sum);
    }

    [Test]
    public void GetSum_Double()
    {
        double sum = Mathematics.GetSum(doubles);

        Assert.AreEqual(70.41d, sum);
        Assert.NotZero(sum);
    }

    [Test]
    public void GetSum_Decimal()
    {
        decimal sum = Mathematics.GetSum(decimals);

        Assert.AreEqual(2580785784509, sum);
        Assert.NotZero(sum);
    }

    #endregion

    #region GetAverage

    [Test]
    public void GetAverage_Int()
    {
        int avg = Mathematics.GetAverage(ints);

        Assert.AreEqual((int)9.571428571, avg);
        Assert.NotZero(avg);
    }

    [Test]
    public void GetAverage_Float()
    {
        float avg = Mathematics.GetAverage(floats);

        Assert.AreEqual(8.371428571f, avg);
        Assert.NotZero(avg);
    }

    [Test]
    public void GetAverage_Double()
    {
        double avg = Mathematics.GetAverage(doubles);

        // 10.058571428571 apparently wasnt good enough accuracy -.-
        Assert.AreEqual(10.058571428571428d, avg);
        Assert.NotZero(avg);
    }

    [Test]
    public void GetAverage_Decimal()
    {
        decimal avg = Mathematics.GetAverage(decimals);

        Assert.AreEqual(368683683501.28571, avg);
        Assert.NotZero(avg);
    }

    #endregion

    #region GetMedian

    [Test]
    public void GetMedian_Int()
    {
        int median = Mathematics.GetMedian(ints);

        Assert.AreEqual(10, median);
        Assert.NotZero(median);
    }

    [Test]
    public void GetMedian_Float()
    {
        float median = Mathematics.GetMedian(floats);

        Assert.AreEqual(10.9f, median);
        Assert.NotZero(median);
    }

    [Test]
    public void GetMedian_Double()
    {
        double median = Mathematics.GetMedian(doubles);

        Assert.AreEqual(10.9d, median);
        Assert.NotZero(median);
    }

    [Test]
    public void GetMedian_Decimal()
    {
        decimal median = Mathematics.GetMedian(decimals);

        Assert.AreEqual(98766, median);
        Assert.NotZero(median);
    }

    #endregion

    #region GetMode

    [Test]
    public void GetMode_Int()
    {
        int mode = Mathematics.GetMode(ints);

        Assert.AreEqual(10, mode);
        Assert.NotZero(mode);
    }

    [Test]
    public void GetMode_Float()
    {
        float mode = Mathematics.GetMode(floats);

        Assert.AreEqual(0.2f, mode);
        Assert.NotZero(mode);
    }

    [Test]
    public void GetMode_Double()
    {
        double mode = Mathematics.GetMode(doubles);

        Assert.AreEqual(10.9d, mode);
        Assert.NotZero(mode);
    }

    [Test]
    public void GetMode_Decimal()
    {
        decimal mode = Mathematics.GetMode(decimals);

        Assert.AreEqual(1123, mode);
        Assert.NotZero(mode);
    }

    #endregion

    #region GetMin

    [Test]
    public void GetMin_Int()
    {
        int min = Mathematics.GetMin(ints);

        Assert.AreEqual(0, min);
        Assert.Zero(min);
    }

    [Test]
    public void GetMin_Float()
    {
        float min = Mathematics.GetMin(floats);

        Assert.AreEqual(0.2f, min);
        Assert.NotZero(min);
    }

    [Test]
    public void GetMin_Double()
    {
        double min = Mathematics.GetMin(doubles);

        Assert.AreEqual(0.211d, min);
        Assert.NotZero(min);
    }

    [Test]
    public void GetMin_Decimal()
    {
        decimal min = Mathematics.GetMin(decimals);

        Assert.AreEqual(1123, min);
        Assert.NotZero(min);
    }

    #endregion

    #region GetMax

    [Test]
    public void GetMax_Int()
    {
        int max = Mathematics.GetMax(ints);

        Assert.AreEqual(19, max);
        Assert.NotZero(max);
    }

    [Test]
    public void GetMax_Float()
    {
        float max = Mathematics.GetMax(floats);

        Assert.AreEqual(19f, max);
        Assert.NotZero(max);
    }

    [Test]
    public void GetMax_Double()
    {
        double max = Mathematics.GetMax(doubles);

        Assert.AreEqual(19.23d, max);
        Assert.NotZero(max);
    }

    [Test]
    public void GetMax_Decimal()
    {
        decimal max = Mathematics.GetMax(decimals);

        Assert.AreEqual(2555555555555, max);
        Assert.NotZero(max);
    }

    #endregion

    #region GetRange

    [Test]
    public void GetRange_Int()
    {
        int range = Mathematics.GetRange(ints);

        Assert.AreEqual(19, range);
        Assert.NotZero(range);
    }

    [Test]
    public void GetRange_Float()
    {
        float range = Mathematics.GetRange(floats);

        Assert.AreEqual(18.8f, range);
        Assert.NotZero(range);
    }

    [Test]
    public void GetRange_Double()
    {
        double range = Mathematics.GetRange(doubles);

        // 19.019d just wasnt accurate enough -.-
        double knownRange = 19.23 - 0.211;

        Assert.AreEqual(knownRange, range);
        Assert.NotZero(range);
    }

    [Test]
    public void GetRange_Decimal()
    {
        decimal range = Mathematics.GetRange(decimals);

        Assert.AreEqual(2555555554432, range);
        Assert.NotZero(range);
    }

    #endregion

    #region GetPercentage

    [Test]
    public void GetPercent_Int()
    {
        int percent = Mathematics.GetPercent(10, 90);

        Assert.AreEqual(11, percent);
        Assert.NotZero(percent);
    }

    [Test]
    public void GetPercent_Float()
    {
        float percent = Mathematics.GetPercent(0.1f, 1f);
        float percent2 = Mathematics.GetPercent(5f, 500f);

        Assert.AreEqual(10f, percent);
        Assert.AreEqual(1f, percent2);
        Assert.NotZero(percent);
    }

    [Test]
    public void GetPercent_Double()
    {
        double percent = Mathematics.GetPercent(0.1d, 1d);
        double percent2 = Mathematics.GetPercent(0.25d, 5d);

        Assert.AreEqual(10d, percent);
        Assert.AreEqual(5d, percent2);
        Assert.NotZero(percent);
    }

    [Test]
    public void GetPercent_Decimal()
    {
        decimal percent = (decimal)Mathematics.GetPercent(0.1, 1);
        double percent2 = Mathematics.GetPercent(0.3, 6);

        Assert.AreEqual(10, percent);
        Assert.AreEqual(5.0, percent2);
        Assert.NotZero(percent);
    }

    #endregion

    #region Percent Greater/Less Than

    [Test]
    public void PercentGreaterThan()
    {
        bool intP = Mathematics.PercentGreaterThan(10, 90, 10);
        bool floatP = Mathematics.PercentGreaterThan(0.1f, 1f, 9.9f);
        bool doubleP = Mathematics.PercentGreaterThan(0.1d, 1d, 9.9d);
        bool decimalP = Mathematics.PercentGreaterThan(0.3, 6, 4.9);

        Assert.IsTrue(intP);
        Assert.IsTrue(floatP);
        Assert.IsTrue(doubleP);
        Assert.IsTrue(decimalP);
    }


    [Test]
    public void PercentLessThan()
    {
        bool intP = Mathematics.PercentLessThan(10, 90, 12);
        bool floatP = Mathematics.PercentLessThan(0.1f, 1f, 10.9f);
        bool doubleP = Mathematics.PercentLessThan(0.1d, 1d, 10.9d);
        bool decimalP = Mathematics.PercentLessThan(0.3, 6, 5.9);

        Assert.IsTrue(intP);
        Assert.IsTrue(floatP);
        Assert.IsTrue(doubleP);
        Assert.IsTrue(decimalP);
    }


    #endregion

    #region Clamp

    [Test]
    public void Clamp_Int()
    {
        int clamp1 = Mathematics.Clamp(12, 0, 20);
        int clamp2 = Mathematics.Clamp(21, 0, 20);
        int clamp3 = Mathematics.Clamp(-1, 0, 20);

        Assert.AreEqual(12, clamp1);
        Assert.AreEqual(20, clamp2);
        Assert.AreEqual(0, clamp3);
    }

    [Test]
    public void Clamp_Float()
    {
        float clamp1 = Mathematics.Clamp(12f, 0.1f, 20.1f);
        float clamp2 = Mathematics.Clamp(21f, 0.1f, 20.1f);
        float clamp3 = Mathematics.Clamp(-1f, 0.1f, 20.1f);

        Assert.AreEqual(12f, clamp1);
        Assert.AreEqual(20.1f, clamp2);
        Assert.AreEqual(0.1f, clamp3);
    }

    [Test]
    public void Clamp_Double()
    {
        double clamp1 = Mathematics.Clamp(12d, 0.1d, 20.1d);
        double clamp2 = Mathematics.Clamp(21d, 0.1d, 20.1d);
        double clamp3 = Mathematics.Clamp(-1d, 0.1d, 20.1d);

        Assert.AreEqual(12d, clamp1);
        Assert.AreEqual(20.1d, clamp2);
        Assert.AreEqual(0.1d, clamp3);
    }

    [Test]
    public void Clamp_Decimal()
    {
        decimal clamp1 = (decimal)Mathematics.Clamp(12, 0.1, 20.1);
        decimal clamp2 = (decimal)Mathematics.Clamp(21, 0.1, 20.1);
        decimal clamp3 = (decimal)Mathematics.Clamp(-1, 0.1, 20.1);

        Assert.AreEqual(12d, clamp1);
        Assert.AreEqual(20.1d, clamp2);
        Assert.AreEqual(0.1d, clamp3);
    }

    [Test]
    public void Clamp_Long()
    {
        long clamp1 = Mathematics.Clamp(4126352045844375721, 0, 9223372036854775800);
        long clamp2 = Mathematics.Clamp(9223372036854775806, 0, 9223372036854775800);
        long clamp3 = Mathematics.Clamp(-1, 0, 9223372036854775800);

        Assert.AreEqual(4126352045844375721, clamp1);
        Assert.AreEqual(9223372036854775800, clamp2);
        Assert.AreEqual(0, clamp3);
    }

    [Test]
    public void Clamp01()
    {
        float clamp1 = Mathematics.Clamp01(1.3f);
        float clamp2 = Mathematics.Clamp01(-8.2f);
        float clamp3 = Mathematics.Clamp01(0.4f);

        Assert.AreEqual(1, clamp1);
        Assert.AreEqual(0f, clamp2);
        Assert.AreEqual(0.4f, clamp3);
    }

    #endregion

    #region Rounding

    [Test]
    public void Round()
    {
        float round1 = Mathematics.Round(2.15f, 1);
        float round2 = Mathematics.Round(16.9f);
        double round3 = Mathematics.Round(2.4651d, 2);
        double round4 = Mathematics.Round(16.95d, 1);

        Assert.AreEqual(2.2f, round1);
        Assert.AreEqual(17f, round2);
        Assert.AreEqual(2.47d, round3);
        Assert.AreEqual(17d, round4);
    }

    [Test]
    public void RoundToInt()
    {
        int round1 = Mathematics.RoundToInt(2.1f);
        int round2 = Mathematics.RoundToInt(16.9f);
        int round3 = Mathematics.RoundToInt(2.1d);
        int round4 = Mathematics.RoundToInt(16.9d);

        Assert.AreEqual(2, round1);
        Assert.AreEqual(17, round2);
        Assert.AreEqual(2, round3);
        Assert.AreEqual(17, round4);
    }

    [Test]
    public void Floor()
    {
        float round1 = Mathematics.Floor(2.15f);
        float round2 = Mathematics.Floor(16.9f);
        double round3 = Mathematics.Floor(2.15d);
        double round4 = Mathematics.Floor(16.9d);

        Assert.AreEqual(2f, round1);
        Assert.AreEqual(16f, round2);
        Assert.AreEqual(2d, round3);
        Assert.AreEqual(16d, round4);
    }

    [Test]
    public void FloorToInt()
    {
        int round1 = Mathematics.FloorToInt(2.1f);
        int round2 = Mathematics.FloorToInt(16.9f);
        int round3 = Mathematics.FloorToInt(2.1d);
        int round4 = Mathematics.FloorToInt(16.9d);

        Assert.AreEqual(2, round1);
        Assert.AreEqual(16, round2);
        Assert.AreEqual(2, round3);
        Assert.AreEqual(16, round4);
    }

    [Test]
    public void Ceil()
    {
        float round1 = Mathematics.Ceil(2.15f);
        float round2 = Mathematics.Ceil(16.9f);
        double round3 = Mathematics.Ceil(2.15d);
        double round4 = Mathematics.Ceil(16.9d);

        Assert.AreEqual(3f, round1);
        Assert.AreEqual(17f, round2);
        Assert.AreEqual(3d, round3);
        Assert.AreEqual(17d, round4);
    }

    [Test]
    public void CeilToInt()
    {
        int round1 = Mathematics.CeilToInt(2.1f);
        int round2 = Mathematics.CeilToInt(16.9f);
        int round3 = Mathematics.CeilToInt(2.1d);
        int round4 = Mathematics.CeilToInt(16.9d);

        Assert.AreEqual(3, round1);
        Assert.AreEqual(17, round2);
        Assert.AreEqual(3, round3);
        Assert.AreEqual(17, round4);
    }

    #endregion

    #region To Value

    [Test]
    public void ToInt()
    {
        Assert.AreEqual(12, "12".ToInt());
        Assert.AreEqual(1, true.ToInt());
        Assert.Zero("a".ToInt());
    }

    [Test]
    public void ToFloat()
    {
        Assert.AreEqual(12.4f, "12.4".ToFloat());
        Assert.AreEqual(1f, true.ToFloat());
        Assert.Zero("a".ToFloat());
    }

    [Test]
    public void ToLong()
    {
        Assert.AreEqual(126775334524, "126775334524".ToLong());
        Assert.Zero("a".ToLong());
    }

    #endregion

    #region Lerp

    [Test]
    public void Lerp_Int()
    {
        int lerp1 = Mathematics.Lerp(0, 40, 0.1f);
        int lerp2 = Mathematics.Lerp(25, 100, 0.666f);
        int lerp3 = Mathematics.Lerp(25, 100, 2f);

        Assert.AreEqual(4, lerp1);
        Assert.AreEqual(74, lerp2);
        Assert.AreEqual(100, lerp3);
    }

    [Test]
    public void Lerp_Float()
    {
        float lerp1 = Mathematics.Lerp(0.0f, 40f, 0.1f);
        float lerp2 = Mathematics.Lerp(0f, 100f, 0.666f);
        float lerp3 = Mathematics.Lerp(0f, 100f, 2f);

        Assert.AreEqual(4f, lerp1);
        Assert.AreEqual(66.6f, lerp2);
        Assert.AreEqual(100f, lerp3);
    }

    [Test]
    public void Lerp_Double()
    {
        double lerp1 = Mathematics.Lerp(0d, 40d, 0.1f);
        double v1 = 40d * 0.1f;

        double lerp2 = Mathematics.Lerp(1d, 100d, 0.1452f);
        double v2 = 1d + (100d - 1d) * 0.1452f;

        double lerp3 = Mathematics.Lerp(0d, 100d, 2f);

        Assert.AreEqual(v1, lerp1);
        Assert.AreEqual(v2, lerp2);
        Assert.AreEqual(100d, lerp3);
    }

    [Test]
    public void LerpUnclamped()
    {
        float lerp1 = Mathematics.LerpUnclamped(0.0f, 40f, 0.1f);
        float lerp2 = Mathematics.LerpUnclamped(0f, 100f, 2f);
        float lerp3 = Mathematics.LerpUnclamped(0f, 100f, 15f);
        float lerp4 = Mathematics.LerpUnclamped(0.0f, 40f, -0.1f);

        Assert.AreEqual(4f, lerp1);
        Assert.AreEqual(200f, lerp2);
        Assert.AreEqual(1500f, lerp3);
        Assert.AreEqual(-4f, lerp4);
    }

    #endregion

    [Test]
    public void Sqrt()
    {
        float sqrt1 = Mathematics.Sqrt(4f);
        float sqrt2 = Mathematics.Sqrt(9f);
        double sqrt3 = Mathematics.Sqrt(25d);

        Assert.AreEqual(2f, sqrt1);
        Assert.AreEqual(3f, sqrt2);
        Assert.AreEqual(5d, sqrt3);
    }

    [Test]
    public void Abs()
    {
        float abs1 = Mathematics.Abs(1.3f);
        float abs2 = Mathematics.Abs(-8.2f);
        double abs3 = Mathematics.Abs(24.1d);
        double abs4 = Mathematics.Abs(-24.1d);

        Assert.AreEqual(1.3f, abs1);
        Assert.AreEqual(8.2f, abs2);
        Assert.AreEqual(24.1d, abs3);
        Assert.AreEqual(24.1d, abs4);
    }

    [Test]
    public void Remap()
    {
        float remap1 = Mathematics.Remap(2f, 1f, 3f, 0f, 10f);
        double remap2 = Mathematics.Remap(5d, 0d, 10d, 0d, 500d);

        Assert.AreEqual(5f, remap1);
        Assert.AreEqual(250d, remap2);
    }

    [Test]
    public void Angle()
    {
        float angle1 = Mathematics.Angle(1, 2, 2, 3);
        float angle2 = Mathematics.Angle(1, 2, 1, 5);

        Assert.AreEqual(45f, angle1);
        Assert.AreEqual(90f, angle2);
    }

    [Test]
    public void AngleAverage()
    {
        float angle1 = Mathematics.AngleAverage(45f, 90f);
        float v1 = (45f + 90f) / 2f;

        Assert.AreEqual(v1, angle1);
    }

    [Test]
    public void ToDeg()
    {
        float deg1 = 14f.ToDeg();
        float v1 = (14f * 180) / (float)Math.PI;

        double deg2 = 90d.ToDeg();
        double v2 = (90d * 180) / Math.PI;

        Assert.AreEqual(v1, deg1);
        Assert.AreEqual(v2, deg2);
    }

    [Test]
    public void ToRad()
    {
        float rad1 = 14.1f.ToRad();
        float v1 = (14.1f * (float)Math.PI) / 180;

        double rad2 = 90d.ToRad();
        double v2 = (90d * Math.PI) / 180;

        Assert.AreEqual(v1, rad1);
        Assert.AreEqual(v2, rad2);
    }

}
