using NUnit.Framework;
using Quartzified.Common;
using UnityEngine;

public class EnumTest
{
    public enum TestEnum
    {
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten
    }

    [Test]
    public void GetRandomEnum()
    {
        bool different = false;
        TestEnum temp = EnumExtensions.GetRandomEnum<TestEnum>();
        for (int i = 0; i < 100; i++)
        {
            if(EnumExtensions.GetRandomEnum<TestEnum>() != temp)
            {
                different = true;
                break;
            }
        }

        Assert.IsNotNull(temp);
        Assert.IsTrue(different);
    }
}
