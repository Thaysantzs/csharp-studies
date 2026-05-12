using System;
using NUnit.Framework;
using DataStructures.HashSet;

namespace Estudos.Tests;

[TestFixture]
public class HashSetCustomTests
{
    // =============================
    // CONSTRUCTOR
    // =============================

    [Test]
    public void Constructor_WhenCapacityIsZero_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new HashSetCustom<int>(0));
    }

    [Test]
    public void Constructor_WhenValidCapacity_ShouldInitializeEmptySet()
    {
        var set = new HashSetCustom<int>(10);

        Assert.That(set.Count, Is.EqualTo(0));
    }

    // =============================
    // ADD
    // =============================

    [Test]
    public void Add_WhenValueIsNew_ShouldReturnTrueAndIncreaseCount()
    {
        var set = new HashSetCustom<int>(10);

        var result = set.Add(1);

        Assert.That(result, Is.True);
        Assert.That(set.Count, Is.EqualTo(1));
        Assert.That(set.Contains(1), Is.True);
    }

    [Test]
    public void Add_WhenValueAlreadyExists_ShouldReturnFalseAndNotIncreaseCount()
    {
        var set = new HashSetCustom<int>(10);

        set.Add(1);
        var result = set.Add(1);

        Assert.That(result, Is.False);
        Assert.That(set.Count, Is.EqualTo(1));
    }

    // =============================
    // COLLISION
    // =============================

    [Test]
    public void Add_WhenCollisionOccurs_ShouldStoreMultipleValuesInSameBucket()
    {
        var set = new HashSetCustom<int>(1); // força colisão

        set.Add(1);
        set.Add(2);
        set.Add(3);

        Assert.That(set.Count, Is.EqualTo(3));
        Assert.That(set.Contains(1), Is.True);
        Assert.That(set.Contains(2), Is.True);
        Assert.That(set.Contains(3), Is.True);
    }

    // =============================
    // CONTAINS
    // =============================

    [Test]
    public void Contains_WhenValueExists_ShouldReturnTrue()
    {
        var set = new HashSetCustom<int>(10);

        set.Add(5);

        Assert.That(set.Contains(5), Is.True);
    }

    [Test]
    public void Contains_WhenValueDoesNotExist_ShouldReturnFalse()
    {
        var set = new HashSetCustom<int>(10);

        Assert.That(set.Contains(99), Is.False);
    }

    // =============================
    // REMOVE
    // =============================

    [Test]
    public void Remove_WhenValueExists_ShouldReturnTrueAndRemoveElement()
    {
        var set = new HashSetCustom<int>(10);

        set.Add(1);

        var result = set.Remove(1);

        Assert.That(result, Is.True);
        Assert.That(set.Contains(1), Is.False);
        Assert.That(set.Count, Is.EqualTo(0));
    }

    [Test]
    public void Remove_WhenValueDoesNotExist_ShouldReturnFalse()
    {
        var set = new HashSetCustom<int>(10);

        var result = set.Remove(100);

        Assert.That(result, Is.False);
        Assert.That(set.Count, Is.EqualTo(0));
    }

    [Test]
    public void Remove_WhenCollisionExists_ShouldRemoveCorrectElementOnly()
    {
        var set = new HashSetCustom<int>(1); // colisão garantida

        set.Add(1);
        set.Add(2);
        set.Add(3);

        set.Remove(2);

        Assert.That(set.Contains(1), Is.True);
        Assert.That(set.Contains(2), Is.False);
        Assert.That(set.Contains(3), Is.True);
        Assert.That(set.Count, Is.EqualTo(2));
    }

    // =============================
    // CLEAR
    // =============================

    [Test]
    public void Clear_WhenCalled_ShouldRemoveAllElements()
    {
        var set = new HashSetCustom<int>(10);

        set.Add(1);
        set.Add(2);

        set.Clear();

        Assert.That(set.Count, Is.EqualTo(0));
        Assert.That(set.Contains(1), Is.False);
        Assert.That(set.Contains(2), Is.False);
    }

    // =============================
    // GENERICS
    // =============================

    [Test]
    public void HashSet_ShouldWorkWithStrings()
    {
        var set = new HashSetCustom<string>(10);

        set.Add("A");
        set.Add("B");

        Assert.That(set.Contains("A"), Is.True);
        Assert.That(set.Contains("C"), Is.False);
    }

    [Test]
    public void HashSet_ShouldWorkWithDifferentTypes()
    {
        var intSet = new HashSetCustom<int>(10);
        var stringSet = new HashSetCustom<string>(10);

        intSet.Add(1);
        stringSet.Add("X");

        Assert.That(intSet.Contains(1), Is.True);
        Assert.That(stringSet.Contains("X"), Is.True);
    }

    // =============================
    // STATE CONSISTENCY
    // =============================

    [Test]
    public void MultipleOperations_ShouldMaintainCorrectState()
    {
        var set = new HashSetCustom<int>(10);

        set.Add(1);
        set.Add(2);
        set.Remove(1);
        set.Add(3);

        Assert.That(set.Contains(1), Is.False);
        Assert.That(set.Contains(2), Is.True);
        Assert.That(set.Contains(3), Is.True);
        Assert.That(set.Count, Is.EqualTo(2));
    }
}
