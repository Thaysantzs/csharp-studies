using System;
using NUnit.Framework;
using DataStructures.NewStack;
namespace Estudos.Tests;

[TestFixture]
public class NewStackTest
{
    // =============================
    // Push
    // =============================

    [Test]
    public void Push_WhenCalled_ShouldAddElementToStack()
    {
        var stack = new NewStack<int>();

        stack.Push(1);

        Assert.That(stack.Length, Is.EqualTo(1));
        Assert.That(stack.Peek, Is.EqualTo(1));
    }

    [Test]
    public void Push_WhenStackIsFull_ShouldThrowException()
    {
        var stack = new NewStack<int>(2);

        stack.Push(1);
        stack.Push(2);

        Assert.Throws<InvalidOperationException>(() => stack.Push(3));
    }

    // =============================
    // Pop
    // =============================

    [Test]
    public void Pop_WhenCalled_ShouldRemoveFirstElement()
    {
        var stack = new NewStack<int>();

        stack.Push(1);
        stack.Push(2);

        var removed = stack.Pop();

        Assert.That(removed, Is.EqualTo(2));
        Assert.That(stack.Peek, Is.EqualTo(1));
    }

    [Test]
    public void Pop_WhenCalled_ShouldDecreaseLenght()
    {
        var stack = new NewStack<int>();

        stack.Push(1);
        stack.Push(2);

        stack.Pop();

        Assert.That(stack.Length, Is.EqualTo(1));
    }

    [Test]
    public void Pop_WhenStackIsEmpty_ShouldthrowException()
    {
        var stack = new NewStack<int>();

        Assert.Throws<InvalidOperationException>(() => stack.Pop());
    }

    // =============================
    // PEEK
    // =============================

    [Test]
    public void Peek_WhenCalled_ShouldReturnFirstElement()
    {
        var stack = new NewStack<int>();

        stack.Push(10);
        stack.Push(20);

        var value = stack.Peek;

        Assert.That(value, Is.EqualTo(20));
    }

    [Test]
    public void Peek_WhenCalled_ShouldNotRemoveElement()
    {
        var stack = new NewStack<int>();

        stack.Push(1);
        stack.Push(2);

        var value = stack.Peek;

        Assert.That(value, Is.EqualTo(2));
        Assert.That(stack.Length, Is.EqualTo(2));
    }

    [Test]
    public void Peek_WhenStackIsEmpty_ShouldThrowException()
    {
        var stack = new NewStack<int>();

        Assert.Throws<InvalidOperationException>(() => { var _ = stack.Peek; });
    }

    // =============================
    // LIFO
    // =============================

    [Test]
    public void Satck_ShouldFollowLIFOOrder()
    {
        var stack = new NewStack<int>();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);

        Assert.That(stack.Pop(), Is.EqualTo(4));
        Assert.That(stack.Pop(), Is.EqualTo(3));
        Assert.That(stack.Pop(), Is.EqualTo(2));
        Assert.That(stack.Pop(), Is.EqualTo(1));
    }

    // =============================
    // STATE (EMPTY / FULL)
    // =============================

    [Test]
    public void IsEmpty_WhenSatckIsCreated_ShouldBeTrue()
    {
        var stack = new NewStack<int>();

        Assert.That(stack.IsEmpty, Is.True);
    }

    [Test]
    public void IsEmpty_WhenStackHasItems_ShouldBeFalse()
    {
        var stack = new NewStack<int>();

        stack.Push(1);

        Assert.That(stack.IsEmpty, Is.False);
    }

     [Test]
    public void IsFull_WhenCapacityIsReached_ShouldBeTrue()
    {
        var stack = new NewStack<int>(2);

        stack.Push(1);
        stack.Push(2);

        Assert.That(stack.IsFull, Is.True);
    }

    [Test]
    public void IsFull_WhenNotAtCapacity_ShouldBeFalse()
    {
        var stack = new NewStack<int>(2);

        stack.Push(1);

        Assert.That(stack.IsFull, Is.False);
    }

    // =============================
    // GENERICS
    // =============================

    [Test]
    public void Stack_ShouldWorkWithDifferentTypes()
    {
        var intStack = new NewStack<int>();
        var stringStack = new NewStack<string>();

        intStack.Push(1);
        stringStack.Push("A");

        Assert.That(intStack.Peek, Is.EqualTo(1));
        Assert.That(stringStack.Peek, Is.EqualTo("A"));
    }
}


