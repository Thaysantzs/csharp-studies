using System;
using DataStructures.HashTable;
using NUnit.Framework;
namespace Estudos.Tests;

[TestFixture]

public class MyHashTableTest
{
    [Test]
    public void HashTableTest()
    {
        var MyHash = new MyHashTable();

        MyHash.add(1);
        Assert.That(MyHash.Size, Is.EqualTo(1));
        Assert.That(MyHash.Contains(1), Is.True);
        Assert.That(MyHash.Contains(2), Is.False);

        MyHash.add(5);
        Assert.That(MyHash.Size, Is.EqualTo(2));
        Assert.That(MyHash.Contains(5), Is.True);
        Assert.That(MyHash.Contains(1), Is.True);
        Assert.That(MyHash.Contains(2), Is.False);

        MyHash.Remove(1);
        Assert.That(MyHash.Size, Is.EqualTo(1));
        Assert.That(MyHash.Contains(5), Is.True);
        Assert.That(MyHash.Contains(1), Is.False);
        Assert.That(MyHash.Contains(2), Is.False);

        MyHash.add(2);
        Assert.That(MyHash.Size, Is.EqualTo(2));
        Assert.That(MyHash.Contains(5), Is.True);
        Assert.That(MyHash.Contains(1), Is.False);
        Assert.That(MyHash.Contains(2), Is.True);

        MyHash.Remove(1);

        MyHash.add(2);
        Assert.That(MyHash.Size, Is.EqualTo(2));
        Assert.That(MyHash.Contains(5), Is.True);
        Assert.That(MyHash.Contains(1), Is.False);
        Assert.That(MyHash.Contains(2), Is.True);

        MyHash.add(1);
        MyHash.add(9);
        MyHash.add(8);
        MyHash.add(7);
        MyHash.add(50);
        MyHash.add(6);
        Assert.That(MyHash.Size, Is.EqualTo(8));
        Assert.That(MyHash.Contains(5), Is.True);
        Assert.That(MyHash.Contains(1), Is.True);
        Assert.That(MyHash.Contains(2), Is.True);
        Assert.That(MyHash.Contains(9), Is.True);
        Assert.That(MyHash.Contains(8), Is.True);
        Assert.That(MyHash.Contains(7), Is.True);
        Assert.That(MyHash.Contains(50), Is.True);
        Assert.That(MyHash.Contains(6), Is.True);
    }
}