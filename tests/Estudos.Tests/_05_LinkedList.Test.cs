using Aulas_C_teste;
using DataStructures.LinkedList;
using NUnit.Framework;
namespace Estudos.Tests;

[TestFixture]
public class LinkedListAppTest
{
    [Test]
    public void CountTest()
    {
        LinkedList linkedList = new LinkedList();
        Assert.That(linkedList.Count, Is.EqualTo(0));

        linkedList.AddAtHead("Node 1");
        Assert.That(linkedList.Count, Is.EqualTo(1));

        linkedList.AddAtHead("Node 2");
        Assert.That(linkedList.Count, Is.EqualTo(2));

        linkedList.AddAtHead("Node 3");
        Assert.That(linkedList.Count, Is.EqualTo(3));
    }

    [Test]
    public void AddAtHead()
    {
        LinkedList linkedList = new LinkedList();

        linkedList.AddAtHead("Node 1");
        linkedList.AddAtHead("Node 2");
        linkedList.AddAtHead("Node 3");

        Assert.That(linkedList.Head?.Data, Is.EqualTo("Node 3"));
        Assert.That(linkedList.Head?.Next?.Data, Is.EqualTo("Node 2"));
        Assert.That(linkedList.Head?.Next?.Next?.Data, Is.EqualTo("Node 1"));
    }

    [Test]
    public void AddAtTail()
    {
        LinkedList linkedList = new LinkedList();

        linkedList.AddTail("Node 1");
        linkedList.AddTail("Node 2");
        linkedList.AddTail("Node 3");

        Assert.That(linkedList.Tail?.Data, Is.EqualTo("Node 3"));
        Assert.That(linkedList.Tail?.Next, Is.Null);
    }

    [Test]
    public void GetTestException()
    {
        LinkedList linkedList = new LinkedList();

        linkedList.AddTail("Node 1");
        linkedList.AddTail("Node 2");

        Assert.Throws<IndexOutOfRangeException>(() => linkedList.Get(-1));
        Assert.Throws<IndexOutOfRangeException>(() => linkedList.Get(2)); // Count = 2 → Invalid
    }

    [Test]
    public void GetHead()
    {
        LinkedList linkedList = new LinkedList();

        linkedList.AddTail("Node 1");
        linkedList.AddTail("Node 2");

        Assert.That(linkedList.Get(0)?.Data, Is.EqualTo("Node 1"));
    }

    [Test]
    public void GetTail()
    {
        LinkedList linkedList = new LinkedList();

        linkedList.AddTail("Node 1");
        linkedList.AddTail("Node 2");
        linkedList.AddTail("Node 3");

        Assert.That(linkedList.Get(2)?.Data, Is.EqualTo("Node 3"));
    }

    [Test]
    public void Get()
    {
        LinkedList linkedList = new LinkedList();

        linkedList.AddTail("Node 1");
        linkedList.AddTail("Node 2");
        linkedList.AddTail("Node 3");
        linkedList.AddTail("Node 4");
        linkedList.AddTail("Node 5");

        Assert.That(linkedList.Get(0)?.Data, Is.EqualTo("Node 1"));
        Assert.That(linkedList.Get(1)?.Data, Is.EqualTo("Node 2"));
        Assert.That(linkedList.Get(2)?.Data, Is.EqualTo("Node 3"));
        Assert.That(linkedList.Get(3)?.Data, Is.EqualTo("Node 4"));
        Assert.That(linkedList.Get(4)?.Data, Is.EqualTo("Node 5"));
    }

    [Test]
    public void AddAtInvalid()
    {
        LinkedList linkedList = new LinkedList();

        Assert.Throws<IndexOutOfRangeException>(() => linkedList.AddAt("X", -1));
        Assert.Throws<IndexOutOfRangeException>(() => linkedList.AddAt("X", 1)); // Empty list
    }

    [Test]
    public void AddAtInHead()
    {
        LinkedList linkedList = new LinkedList();

        linkedList.AddTail("Node A");
        linkedList.AddTail("Node B");

        linkedList.AddAt("Node C", 0);

        Assert.That(linkedList.Get(0)?.Data, Is.EqualTo("Node C"));
    }

    [Test]
    public void AddAtInTail()
    {
        LinkedList linkedList = new LinkedList();

        linkedList.AddTail("Node A");
        linkedList.AddTail("Node B");

        linkedList.AddAt("Node C", 2);

        Assert.That(linkedList.Get(2)?.Data, Is.EqualTo("Node C"));
    }

    [Test]
    public void AddAtEveryWhere()
    {
        LinkedList linkedList = new LinkedList();

        linkedList.AddTail("A");
        linkedList.AddTail("B");
        linkedList.AddTail("D");
        linkedList.AddTail("F");
        linkedList.AddTail("G");
        linkedList.AddTail("I");

        linkedList.AddAt("H", 5); 
        // A B D F G H I

        Assert.That(linkedList.Get(5)?.Data, Is.EqualTo("H"));

        linkedList.AddAt("C", 2);
        // A B C D F G H I

        Assert.That(linkedList.Get(2)?.Data, Is.EqualTo("C"));

        linkedList.AddAt("E", 4);
        // A B C D E F G H I

        Assert.That(linkedList.Get(4)?.Data, Is.EqualTo("E"));
    }

    [Test]
    public void DeleteAtHeadExceptionTest()
    {
        LinkedList linkedList = new LinkedList();

        Assert.Throws<Exception>(() => linkedList.DeleteAtHead()); // empty list
    }

    [Test]
    public void DeleteAtHeadTest()
    {
        LinkedList linkedList = new LinkedList();

        linkedList.AddTail("0");
        linkedList.AddTail("1");
        linkedList.AddTail("2");
        linkedList.AddTail("3");
        linkedList.AddTail("4");
        linkedList.AddTail("5");

        linkedList.DeleteAtHead();
        Assert.That(linkedList.Get(0)?.Data, Is.EqualTo("1"));  // return 1
        Assert.That(linkedList.Count, Is.EqualTo(5));

        linkedList.DeleteAtHead();
        Assert.That(linkedList.Get(0)?.Data, Is.EqualTo("2")); // return 2
        Assert.That(linkedList.Count, Is.EqualTo(4));

        linkedList.DeleteAtHead();
        Assert.That(linkedList.Get(0)?.Data, Is.EqualTo("3")); // return 3
        Assert.That(linkedList.Count, Is.EqualTo(3));

        linkedList.DeleteAtHead();
        Assert.That(linkedList.Get(0)?.Data, Is.EqualTo("4")); // return 4 
        Assert.That(linkedList.Count, Is.EqualTo(2));

        linkedList.DeleteAtHead();
        Assert.That(linkedList.Get(0)?.Data, Is.EqualTo("5")); // return 5
        Assert.That(linkedList.Count, Is.EqualTo(1));

        linkedList.DeleteAtHead();
        Assert.That(linkedList.Head, Is.EqualTo(null)); // return null
        Assert.That(linkedList.Tail, Is.EqualTo(null)); // return null
        Assert.That(linkedList.Count, Is.EqualTo(0));
    }

    [Test]
    public void DeleteAtTailExceptionTest()
    {
        LinkedList linkedList = new LinkedList();

        Assert.Throws<Exception>(() => linkedList.DeleteAtTail());
    }

    [Test]
    public void DeleteAtTailTest()
    {
        LinkedList linkedList = new LinkedList();

        linkedList.AddTail("0");
        linkedList.AddTail("1");
        linkedList.AddTail("2");
        linkedList.AddTail("3");
        linkedList.AddTail("4");
        linkedList.AddTail("5");
        // 0 - 1 - 2 - 3 - 4 - 5 

        linkedList.DeleteAtTail();
        Assert.That(linkedList.Get(4)?.Data, Is.EqualTo("4"));
        Assert.That(linkedList.Count, Is.EqualTo(5)); // Count 5
        // 0 - 1 - 2 - 3 - 4

        linkedList.DeleteAtTail();
        Assert.That(linkedList.Get(3)?.Data, Is.EqualTo("3"));
        Assert.That(linkedList.Count, Is.EqualTo(4)); // Count 4
        // 0 - 1 - 2 - 3

        linkedList.DeleteAtTail();
        Assert.That(linkedList.Get(2)?.Data, Is.EqualTo("2"));
        Assert.That(linkedList.Count, Is.EqualTo(3)); // Count 3
        // 0 - 1 - 2

        linkedList.DeleteAtTail();
        Assert.That(linkedList.Get(1)?.Data, Is.EqualTo("1"));
        Assert.That(linkedList.Count, Is.EqualTo(2)); // Count 2
        // 0 - 1

        linkedList.DeleteAtTail();
        Assert.That(linkedList.Get(0)?.Data, Is.EqualTo("0"));
        Assert.That(linkedList.Count, Is.EqualTo(1)); // Count 1
        // 0 

        linkedList.DeleteAtTail();
        Assert.That(linkedList.Head, Is.EqualTo(null));
        Assert.That(linkedList.Tail, Is.EqualTo(null));
        Assert.That(linkedList.Count, Is.EqualTo(0)); // Count 0
        // x 
    }

    [Test]
    public void DeleteAtExceptionTest()
    {
        LinkedList linkedList = new LinkedList();
        
        Assert.Throws<IndexOutOfRangeException>(() => linkedList.DeleteAt(-1));
        Assert.Throws<IndexOutOfRangeException>(() => linkedList.DeleteAt(0));
        Assert.Throws<IndexOutOfRangeException>(() => linkedList.DeleteAt(1)); // Invalid Count
    }

    [Test]
    public void DeleteAt()
    {
        LinkedList linkedList = new LinkedList();

        linkedList.AddTail("0");
        linkedList.AddTail("1");
        linkedList.AddTail("2");
        linkedList.AddTail("3");
        linkedList.AddTail("4");
        linkedList.AddTail("5");
        // 0 - 1 - 2 - 3 - 4 - 5 

        linkedList.DeleteAt(0);
        Assert.That(linkedList.Get(0)?.Data, Is.EqualTo("1"));
        // x - 1 - 2 - 3 - 4 - 5 

        linkedList.DeleteAt(4);
        Assert.That(linkedList.Get(3)?.Data, Is.EqualTo("4"));
        // x - 1 - 2 - 3 - 4 - X 
    }

    [Test]
    public void DeleteAtIndex()
    {
        LinkedList linkedList = new LinkedList();

        linkedList.AddTail("0");
        linkedList.AddTail("1");
        linkedList.AddTail("2");
        linkedList.AddTail("3");
        linkedList.AddTail("4");
        linkedList.AddTail("5");
        // 0 - 1 - 2 - 3 - 4 - 5 

        linkedList.DeleteAt(2);
        Assert.That(linkedList.Get(2)?.Data, Is.EqualTo("3"));
        // 0 - 1 - x - 3 - 4 - 5 

        linkedList.DeleteAt(3);
        Assert.That(linkedList.Get(3)?.Data, Is.EqualTo("5"));
        // 0 - 1 - x - 3 - x - 5 

        linkedList.DeleteAt(2);
        Assert.That(linkedList.Get(2)?.Data, Is.EqualTo("5"));
        // 0 - 1 - x - x - x - 5 

        linkedList.DeleteAt(1);
        Assert.That(linkedList.Get(1)?.Data, Is.EqualTo("5"));
        // 0 - 1 - x - x - x - 5 
    }
}