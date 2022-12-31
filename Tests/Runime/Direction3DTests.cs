using NUnit.Framework;
using Quartzified.Mathematics.Directions;
using UnityEngine;

public class Direction3DTests
{
    [Test]
    public void GetDirection3D_Float()
    {
        Directions3D.Direction3D dir1 = Directions3D.GetDirection3D(0f, 0f, 0f, 1f, 0f, 0f);
        Directions3D.Direction3D dir2 = Directions3D.GetDirection3D(0f, 0f, 0f, -1f, 0.5f, 0f);
        Directions3D.Direction3D dir3 = Directions3D.GetDirection3D(0f, 0f, 0f, -10f, 50f, 0f);
        Directions3D.Direction3D dir4 = Directions3D.GetDirection3D(0f, 0f, 0f, -0.5f, -0.5f, 0f);
        Directions3D.Direction3D dir5 = Directions3D.GetDirection3D(0f, 0f, 0f, -10f, 50f, 100f);
        Directions3D.Direction3D dir6 = Directions3D.GetDirection3D(0f, 0f, 0f, -0.5f, -0.5f, -0.5f);

        Assert.AreEqual(Directions3D.Direction3D.Right, dir1);
        Assert.AreEqual(Directions3D.Direction3D.Left, dir2);
        Assert.AreEqual(Directions3D.Direction3D.Up, dir3);
        Assert.AreEqual(Directions3D.Direction3D.Down, dir4);
        Assert.AreEqual(Directions3D.Direction3D.Forward, dir5);
        Assert.AreEqual(Directions3D.Direction3D.Back, dir6);
    }

    [Test]
    public void GetDirection3D_Vector3()
    {
        Directions3D.Direction3D dir1 = Directions3D.GetDirection3D(new Vector3(0f, 0f, 0f), new Vector3(1f, 0f, 0f));
        Directions3D.Direction3D dir2 = Directions3D.GetDirection3D(new Vector3(0f, 0f, 0f), new Vector3(-1f, 0.5f, 0f));
        Directions3D.Direction3D dir3 = Directions3D.GetDirection3D(new Vector3(0f, 0f, 0f), new Vector3(-10f, 50f, 0f));
        Directions3D.Direction3D dir4 = Directions3D.GetDirection3D(new Vector3(0f, 0f, 0f), new Vector3(-0.5f, -0.5f, 0f));
        Directions3D.Direction3D dir5 = Directions3D.GetDirection3D(new Vector3(0f, 0f, 0f), new Vector3(-10f, 50f, 100f));
        Directions3D.Direction3D dir6 = Directions3D.GetDirection3D(new Vector3(0f, 0f, 0f), new Vector3(-0.5f, -0.5f, -0.5f));

        Assert.AreEqual(Directions3D.Direction3D.Right, dir1);
        Assert.AreEqual(Directions3D.Direction3D.Left, dir2);
        Assert.AreEqual(Directions3D.Direction3D.Up, dir3);
        Assert.AreEqual(Directions3D.Direction3D.Down, dir4);
        Assert.AreEqual(Directions3D.Direction3D.Forward, dir5);
        Assert.AreEqual(Directions3D.Direction3D.Back, dir6);
    }
}
