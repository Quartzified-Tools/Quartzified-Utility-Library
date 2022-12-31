using NUnit.Framework;
using Quartzified.Mathematics.Directions;
using UnityEngine;

public class Direction2DTests
{
    [Test]
    public void GetDirection2D_Float()
    {
        Directions2D.Direction2D dir1 = Directions2D.GetDirection2D(0f,0f, 1f,0f);
        Directions2D.Direction2D dir2 = Directions2D.GetDirection2D(0f, 0f, -1f, 0.5f);
        Directions2D.Direction2D dir3 = Directions2D.GetDirection2D(0f, 0f, -10f, 50f);
        Directions2D.Direction2D dir4 = Directions2D.GetDirection2D(0f, 0f, -0.5f, -0.5f);

        Assert.AreEqual(Directions2D.Direction2D.Right, dir1);
        Assert.AreEqual(Directions2D.Direction2D.Left, dir2);
        Assert.AreEqual(Directions2D.Direction2D.Up, dir3);
        Assert.AreEqual(Directions2D.Direction2D.Down, dir4);
    }

    [Test]
    public void GetDirection2D_Vector2()
    {
        Directions2D.Direction2D dir1 = Directions2D.GetDirection2D(new Vector2(0f, 0f), new Vector2(1f, 0f));
        Directions2D.Direction2D dir2 = Directions2D.GetDirection2D(new Vector2(0f, 0f), new Vector2(-1f, 0.5f));
        Directions2D.Direction2D dir3 = Directions2D.GetDirection2D(new Vector2(0f, 0f), new Vector2(-10f, 50f));
        Directions2D.Direction2D dir4 = Directions2D.GetDirection2D(new Vector2(0f, 0f), new Vector2(-0.5f, -0.5f));

        Assert.AreEqual(Directions2D.Direction2D.Right, dir1);
        Assert.AreEqual(Directions2D.Direction2D.Left, dir2);
        Assert.AreEqual(Directions2D.Direction2D.Up, dir3);
        Assert.AreEqual(Directions2D.Direction2D.Down, dir4);
    }
}
