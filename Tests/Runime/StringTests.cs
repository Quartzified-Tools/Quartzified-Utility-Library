using NUnit.Framework;
using Quartzified.Collections;

public class StringTests
{
    public string testNull = null;
    public string testEmpty = "";
    public string testWhitespace = "   ";
    public string testOne = "Hello";
    public string testTwo = "hello";
    public string testThree = "How are you doing?";
    public string testFour = "I had 4 ice cream today :)";
    public string testFive = "I am @ the store right now. Where are you?";
    public string testNumeric = "20230403";

    public string testEmail = "throwaway@testemail.com";


    [Test]
    public void AreEqual()
    {
        Assert.IsTrue(testOne.AreEqual(testTwo));
        Assert.IsFalse(testTwo.AreEqual(testThree));
    }

    [Test]
    public void AreNotEqual()
    {
        Assert.IsFalse(testOne.AreNotEqual(testTwo));
        Assert.IsTrue(testTwo.AreNotEqual(testThree));
    }

    [Test]
    public void IsNull()
    {
        Assert.IsTrue(testNull.IsNull());
        Assert.IsFalse(testEmpty.IsNull());
        Assert.IsFalse(testOne.IsNull());
    }

    [Test]
    public void IsNotNull()
    {
        Assert.IsFalse(testNull.IsNotNull());
        Assert.IsTrue(testEmpty.IsNotNull());
        Assert.IsTrue(testOne.IsNotNull());
    }

    [Test]
    public void Reverse()
    {
        Assert.AreEqual(testOne.Reverse(), "olleH");
        Assert.AreEqual(testThree.Reverse(), "?gniod uoy era woH");
    }

    [Test]
    public void IsNumeric()
    {
        Assert.IsTrue(testNumeric.IsNumeric());
        Assert.IsFalse(testOne.IsNumeric());
    }

    [Test]
    public void IsEmail()
    {
        Assert.IsTrue(testEmail.IsEmail());
        Assert.IsFalse(testFive.IsEmail());
    }
}
