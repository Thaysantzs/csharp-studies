using System;
using DataStructures.NewLinked;
using NUnit.Framework;
using System.Linq;
namespace Estudos.Tests;

[TestFixture]
public class DoublyLinkedListTests
{
    private DoublyLinkedList<string> CreateList(int size = 7)
    {
        var list = new DoublyLinkedList<string>();
        for (int i = 0; i < size; i++)
        {
            list.AddAtTail($"Node {i}");
        }
        return list;
    }

    [Test]
    public void AddAtHead_ShouldInsertAtBeginning()
    {
        var list = new DoublyLinkedList<string>();

        list.AddAtHead("A");
        list.AddAtHead("B");

        Assert.That(list.Count, Is.EqualTo(2));
        Assert.That(list.Get(0), Is.EqualTo("B"));
        Assert.That(list.Head, Is.EqualTo("B"));
    }

    [Test]
    public void AddAtTail_ShouldInsertAtEnd()
    {
        var list = new DoublyLinkedList<string>();

        list.AddAtTail("A");
        list.AddAtTail("B");

        Assert.That(list.Count, Is.EqualTo(2));
        Assert.That(list.Get(1), Is.EqualTo("B"));
        Assert.That(list.Tail, Is.EqualTo("B"));
    }

    [Test]
    public void AddAt_ShouldInsertAtSpecificPosition()
    {
        var list = CreateList();

        list.AddAt("New Node", 3);

        Assert.That(list.Count, Is.EqualTo(8));
        Assert.That(list.Get(3), Is.EqualTo("New Node"));
    }

    [Test]
    public void AddAt_ShouldThrowException_WhenIndexIsInvalid()
    {
        var list = CreateList();

        Assert.Throws<IndexOutOfRangeException>(() => list.AddAt("Error", -1));
        Assert.Throws<IndexOutOfRangeException>(() => list.AddAt("Error", list.Count + 1));
    }

    [Test]
    public void Get_ShouldReturnCorrectElement()
    {
        var list = CreateList();

        Assert.That(list.Get(0), Is.EqualTo("Node 0"));
        Assert.That(list.Get(6), Is.EqualTo("Node 6"));
    }

    [Test]
    public void Get_ShouldThrowException_WhenIndexIsInvalid()
    {
        var list = CreateList();

        Assert.Throws<IndexOutOfRangeException>(() => list.Get(-1));
        Assert.Throws<IndexOutOfRangeException>(() => list.Get(list.Count));
    }

    [Test]
    public void RemoveHead_ShouldRemoveFirstElement()
    {
        var list = CreateList();

        list.RemoveHead();

        Assert.That(list.Count, Is.EqualTo(6));
        Assert.That(list.Get(0), Is.EqualTo("Node 1"));
    }

    [Test]
    public void RemoveHead_ShouldThrowException_WhenListIsEmpty()
    {
        var list = new DoublyLinkedList<string>();

        Assert.Throws<InvalidOperationException>(() => list.RemoveHead());
    }

    [Test]
    public void RemoveTail_ShouldRemoveLastElement()
    {
        var list = CreateList();

        list.RemoveTail();

        Assert.That(list.Count, Is.EqualTo(6));
        Assert.That(list.Get(5), Is.EqualTo("Node 5"));
    }

    [Test]
    public void RemoveTail_ShouldThrowException_WhenListIsEmpty()
    {
        var list = new DoublyLinkedList<string>();

        Assert.Throws<InvalidOperationException>(() => list.RemoveTail());
    }

    [Test]
    public void RemoveAt_ShouldRemoveCorrectElement()
    {
        var list = CreateList();

        list.RemoveAt(3);

        Assert.That(list.Count, Is.EqualTo(6));
        Assert.That(list.Get(3), Is.EqualTo("Node 4"));
    }

    [Test]
    public void RemoveAt_ShouldThrowException_WhenIndexIsInvalid()
    {
        var list = CreateList();

        Assert.Throws<IndexOutOfRangeException>(() => list.RemoveAt(-1));
        Assert.Throws<IndexOutOfRangeException>(() => list.RemoveAt(list.Count));
    }

    [Test]
    public void HeadAndTail_ShouldReturnCorrectValues()
    {
        var list = new DoublyLinkedList<int>();

        list.AddAtHead(10);
        list.AddAtTail(20);

        Assert.That(list.Head, Is.EqualTo(10));
        Assert.That(list.Tail, Is.EqualTo(20));
    }

    [Test]
    public void IEnumerable_ShouldIterateThroughList()
    {
        var list = CreateList();

        var result = list.ToList();

        Assert.That(result.Count, Is.EqualTo(7));
        Assert.That(result[0], Is.EqualTo("Node 0"));
        Assert.That(result[6], Is.EqualTo("Node 6"));
    }
}