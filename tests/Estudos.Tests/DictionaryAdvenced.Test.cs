using System;
using NUnit.Framework;
using DataStructures.Dictionary;

namespace Estudos.Tests;

[TestFixture]
public class DictionaryAdvancedTest
{
    // =============================
    // INDEXER
    // =============================

    [Test]
    public void Indexer_WhenKeyExists_ShouldUpdateValue()
    {
        var dic = new DictionaryCustom<int, string>();

        dic.Add(1, "Old");
        dic[1] = "New";

        Assert.That(dic[1], Is.EqualTo("New"));
        Assert.That(dic.Count, Is.EqualTo(1));
    }

    [Test]
    public void Indexer_WhenKeyDoesNotExist_ShouldAddValue()
    {
        var dic = new DictionaryCustom<int, string>();

        dic[1] = "Value";

        Assert.That(dic[1], Is.EqualTo("Value"));
        Assert.That(dic.Count, Is.EqualTo(1));
    }

    // =============================
    // NULL KEY
    // =============================

    [Test]
    public void Add_WhenKeyIsNull_ShouldThrowArgumentNullException()
    {
        var dic = new DictionaryCustom<string, string>();

        Assert.Throws<ArgumentNullException>(() => dic.Add(null, "value"));
    }

    // =============================
    // GET EDGE CASES
    // =============================

    [Test]
    public void Get_WhenBucketIsNull_ShouldThrowKeyNotFoundException()
    {
        var dic = new DictionaryCustom<int, string>();

        Assert.Throws<KeyNotFoundException>(() => dic.Get(99));
    }

    // =============================
    // REMOVE EDGE CASES
    // =============================

    [Test]
    public void Remove_WhenBucketIsNull_ShouldReturnFalse()
    {
        var dic = new DictionaryCustom<int, string>();

        var result = dic.Remove(10);

        Assert.That(result, Is.False);
    }

    // =============================
    // CLEAR + REUSE
    // =============================

    [Test]
    public void Clear_AfterClear_ShouldAllowReuse()
    {
        var dic = new DictionaryCustom<int, string>();

        dic.Add(1, "A");
        dic.Clear();

        dic.Add(2, "B");

        Assert.That(dic.Count, Is.EqualTo(1));
        Assert.That(dic.Contains(2), Is.True);
    }

    // =============================
    // FORCED COLLISION
    // =============================

    [Test]
    public void Add_WhenForcedCollision_ShouldStoreAllValues()
    {
        var dic = new DictionaryCustom<int, string>(1); // tudo no mesmo bucket

        dic.Add(1, "A");
        dic.Add(2, "B");
        dic.Add(3, "C");

        Assert.That(dic.Count, Is.EqualTo(3));
        Assert.That(dic.Contains(1), Is.True);
        Assert.That(dic.Contains(2), Is.True);
        Assert.That(dic.Contains(3), Is.True);
    }

    [Test]
    public void Remove_WhenCollisionExists_ShouldRemoveCorrectItem()
    {
        var dic = new DictionaryCustom<int, string>(1);

        dic.Add(1, "A");
        dic.Add(2, "B");
        dic.Add(3, "C");

        dic.Remove(2);

        Assert.That(dic.Contains(1), Is.True);
        Assert.That(dic.Contains(2), Is.False);
        Assert.That(dic.Contains(3), Is.True);
        Assert.That(dic.Count, Is.EqualTo(2));
    }

    // =============================
    // INDEXER + COLLISION
    // =============================

    [Test]
    public void Indexer_WhenCollisionExists_ShouldUpdateCorrectElement()
    {
        var dic = new DictionaryCustom<int, string>(1);

        dic.Add(1, "A");
        dic.Add(2, "B");

        dic[2] = "Updated";

        Assert.That(dic[2], Is.EqualTo("Updated"));
        Assert.That(dic[1], Is.EqualTo("A"));
    }

    // =============================
    // MULTIPLE OPERATIONS EDGE
    // =============================

    [Test]
    public void MultipleOperations_WithCollisions_ShouldMaintainConsistency()
    {
        var dic = new DictionaryCustom<int, string>(1);

        dic.Add(1, "A");
        dic.Add(2, "B");
        dic.Remove(1);
        dic[2] = "Updated";
        dic.Add(3, "C");

        Assert.That(dic.Count, Is.EqualTo(2));
        Assert.That(dic.Contains(1), Is.False);
        Assert.That(dic.Contains(2), Is.True);
        Assert.That(dic.Contains(3), Is.True);
        Assert.That(dic[2], Is.EqualTo("Updated"));
    }
}