using System;
using NUnit.Framework;
using DataStructures.Newqueue;

namespace Estudos.Tests;

[TestFixture]
public class NewQueueTests
{
    // =============================
    // ENQUEUE
    // =============================

    [Test]
    public void Enqueue_WhenCalled_ShouldAddElementToQueue()
    {
        var queue = new NewQueue<int>();

        queue.Enqueue(1);

        Assert.That(queue.Length, Is.EqualTo(1));
        Assert.That(queue.Peek, Is.EqualTo(1));
    }

    [Test]
    public void Enqueue_WhenQueueIsFull_ShouldThrowException()
    {
        var queue = new NewQueue<int>(2);

        queue.Enqueue(1);
        queue.Enqueue(2);

        Assert.Throws<InvalidOperationException>(() => queue.Enqueue(3));
    }

    // =============================
    // DEQUEUE
    // =============================

    [Test]
    public void Dequeue_WhenCalled_ShouldRemoveFirstElement()
    {
        var queue = new NewQueue<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);

        var removed = queue.Dequeue();

        Assert.That(removed, Is.EqualTo(1));
        Assert.That(queue.Peek, Is.EqualTo(2));
    }

    [Test]
    public void Dequeue_WhenCalled_ShouldDecreaseLength()
    {
        var queue = new NewQueue<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);

        queue.Dequeue();

        Assert.That(queue.Length, Is.EqualTo(1));
    }

    [Test]
    public void Dequeue_WhenQueueIsEmpty_ShouldThrowException()
    {
        var queue = new NewQueue<int>();

        Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
    }

    // =============================
    // PEEK
    // =============================

    [Test]
    public void Peek_WhenCalled_ShouldReturnFirstElement()
    {
        var queue = new NewQueue<int>();

        queue.Enqueue(10);
        queue.Enqueue(20);

        var value = queue.Peek;

        Assert.That(value, Is.EqualTo(10));
    }

    [Test]
    public void Peek_WhenCalled_ShouldNotRemoveElement()
    {
        var queue = new NewQueue<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);

        var value = queue.Peek;

        Assert.That(value, Is.EqualTo(1));
        Assert.That(queue.Length, Is.EqualTo(2));
    }

    [Test]
    public void Peek_WhenQueueIsEmpty_ShouldThrowException()
    {
        var queue = new NewQueue<int>();

        Assert.Throws<InvalidOperationException>(() => { var _ = queue.Peek; });
    }

    // =============================
    // FIFO
    // =============================

    [Test]
    public void Queue_ShouldFollowFIFOOrder()
    {
        var queue = new NewQueue<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Assert.That(queue.Dequeue(), Is.EqualTo(1));
        Assert.That(queue.Dequeue(), Is.EqualTo(2));
        Assert.That(queue.Dequeue(), Is.EqualTo(3));
    }

    // =============================
    // STATE (EMPTY / FULL)
    // =============================

    [Test]
    public void IsEmpty_WhenQueueIsCreated_ShouldBeTrue()
    {
        var queue = new NewQueue<int>();

        Assert.That(queue.IsEmpty, Is.True);
    }

    [Test]
    public void IsEmpty_WhenQueueHasItems_ShouldBeFalse()
    {
        var queue = new NewQueue<int>();

        queue.Enqueue(1);

        Assert.That(queue.IsEmpty, Is.False);
    }

    [Test]
    public void IsFull_WhenCapacityIsReached_ShouldBeTrue()
    {
        var queue = new NewQueue<int>(2);

        queue.Enqueue(1);
        queue.Enqueue(2);

        Assert.That(queue.IsFull, Is.True);
    }

    [Test]
    public void IsFull_WhenNotAtCapacity_ShouldBeFalse()
    {
        var queue = new NewQueue<int>(2);

        queue.Enqueue(1);

        Assert.That(queue.IsFull, Is.False);
    }

    // =============================
    // GENERICS
    // =============================

    [Test]
    public void Queue_ShouldWorkWithDifferentTypes()
    {
        var intQueue = new NewQueue<int>();
        var stringQueue = new NewQueue<string>();

        intQueue.Enqueue(1);
        stringQueue.Enqueue("A");

        Assert.That(intQueue.Peek, Is.EqualTo(1));
        Assert.That(stringQueue.Peek, Is.EqualTo("A"));
    }
}