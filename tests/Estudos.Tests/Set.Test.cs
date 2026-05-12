using System;
using NUnit.Framework;
using DataStructures.NewSet;
namespace Estudos.Tests;

[TestFixture]
public class NewSetTest
{
    // =============================
    // Add
    // =============================

    [Test]
    public void Add_WhenCalled_ShouldAddElement()
    {
        var set = new NewSet<int>();
        
        set.Add(1);

        Assert.That(set.Count, Is.EqualTo(1));
        Assert.That(set.Contains(1), Is.True);
    }

    [Test]
    public void Add_WhenSetIsFull_ShouldThrowException()
    {
        var set = new NewSet<int>(2);

        set.Add(1);
        set.Add(2);

        Assert.Throws<InvalidOperationException>(() => set.Add(3));
    }

    [Test]
    public void Add_WhenValueAlreadyExists_ShouldNotAddDuplicate()
    {
        var set = new NewSet<int>();

        set.Add(1);
        set.Add(1);

        Assert.That(set.Count, Is.EqualTo(1));
    }

    [Test]
    public void Add_WhenValueIsNew_ShouldReturnTrue()
    {
        var set = new NewSet<int>();

        var result = set.Add(1);

        Assert.That(result, Is.True);
    }

    [Test]
    public void Add_WhenValueAlreadyExists_ShouldReturnFalse()
    {
        var set = new NewSet<int>();

        set.Add(1);
        set.Add(2);
        var result = set.Add(2);

        Assert.That(set.Count, Is.EqualTo(2));
        Assert.That(result, Is.False);
    }

    // =============================
    // Remove
    // =============================

    [Test]
    public void Remove_WhenCalled_ShouldRemoveElement()
    {
        var set = new NewSet<int>();

        set.Add(1);
        set.Add(2);
        set.Remove(2);

        Assert.That(set.Count, Is.EqualTo(1));
        Assert.That(set.Contains(2), Is.False);
    }

    [Test]
    public void Remove_WhenValueDoesNotExist_ShouldThrowException()
    {
        var set = new NewSet<int>();

        Assert.That(set.Count, Is.EqualTo(0));
        Assert.Throws<KeyNotFoundException>(() => set.Remove(1));
    }

    [Test]
    public void Remove_WhenLastElementIsRemoved_SetShouldBeEmpty()
    {
        var set = new NewSet<int>();

        set.Add(1);
        set.Remove(1);

        Assert.That(set.Count, Is.EqualTo(0));
    }

    // =============================
    // Contains
    // =============================

    [Test]
    public void Contains_WhenValueExists_ShouldReturnTrue()
    {
        var set = new NewSet<int>();

        set.Add(1);

        Assert.That(set.Contains(1), Is.True);
    }

    [Test]
    public void Contains_WhenValueDoesNotExist_ShouldReturnFalse()
    {
        var set = new NewSet<int>();

        Assert.That(set.Contains(10), Is.False);
    }
}