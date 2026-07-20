using System;
using DataStructures.Set;
using NUnit.Framework;
namespace Estudos.Tests;

[TestFixture]

public class SetTest
{
    [Test]

    public void SetTesting()
    {
        var mySet = new MySet(100);
        Assert.That(mySet.Size, Is.EqualTo(0));
        
        mySet.Add(5);
        Assert.That(mySet.Size, Is.EqualTo(1));
        Assert.That(mySet.Peek, Is.EqualTo(5));
        mySet.Delete(5);
        Assert.That(mySet.Size, Is.EqualTo(0));

        mySet.Add(2);
        Assert.That(mySet.Size, Is.EqualTo(1));
        Assert.That(mySet.Peek, Is.EqualTo(2));
        mySet.Delete(2);
        Assert.That(mySet.Size, Is.EqualTo(0));

        mySet.Add(9);
        Assert.That(mySet.Size, Is.EqualTo(1));
        Assert.That(mySet.Peek, Is.EqualTo(9));
        mySet.Delete(9);
        Assert.That(mySet.Size, Is.EqualTo(0));

        mySet.Add(13);
        Assert.That(mySet.Size, Is.EqualTo(1));
        Assert.That(mySet.Peek, Is.EqualTo(13));
        
        mySet.Add(4);
        Assert.That(mySet.Size, Is.EqualTo(2));
        Assert.That(mySet.Peek, Is.EqualTo(4));

        mySet.Add(7);
        Assert.That(mySet.Size, Is.EqualTo(3));
        Assert.That(mySet.Peek, Is.EqualTo(7));


        Assert.That(mySet.Contains(5), Is.False);
        Assert.That(mySet.Contains(2), Is.False);
        Assert.That(mySet.Contains(9), Is.False);
        Assert.That(mySet.Contains(13), Is.True);
        Assert.That(mySet.Contains(4), Is.True);
        Assert.That(mySet.Contains(7), Is.True);

        Assert.Throws<InvalidOperationException>(() => mySet.Add(512));
        Assert.Throws<InvalidOperationException>(() => mySet.Add(-1));
        Assert.Throws<InvalidOperationException>(() => mySet.Delete(-2));
        Assert.Throws<InvalidOperationException>(() => mySet.Delete(101));
    }
}