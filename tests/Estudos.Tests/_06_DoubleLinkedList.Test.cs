using Aulas_C_teste;
using DataStructures.DoubleLinkedList;
using NUnit.Framework;
namespace Estudos.Tests;

[TestFixture]

public class DoubleLinkedTest
{
    [Test]
    public void AddAtHead()
    {
        var list = new DoubleLinked();

        list.AddAtHead("Node 0");
        Assert.That(list.Head, Is.EqualTo("Node 0"));
        Assert.That(list.Count, Is.EqualTo(1));
        // 1 

        list.AddAtHead("Node 1");
        Assert.That(list.Head, Is.EqualTo("Node 1"));
        Assert.That(list.Count, Is.EqualTo(2));
        // 1 2

        list.AddAtHead("Node 2");
        Assert.That(list.Head, Is.EqualTo("Node 2"));
        Assert.That(list.Count, Is.EqualTo(3));
        // 1 2 3

        list.AddAtHead("Node 3");
        Assert.That(list.Head, Is.EqualTo("Node 3"));
        Assert.That(list.Count, Is.EqualTo(4));
        // 1 2 3 4

    }

    [Test]
    public void AddAtTail()
    {
        var list = new DoubleLinked();

        list.AddAtHead("Node 0");
        Assert.That(list.Head, Is.EqualTo("Node 0"));
        Assert.That(list.Count, Is.EqualTo(1));
        // 0 

        list.AddAtHead("Node 1");
        Assert.That(list.Head, Is.EqualTo("Node 1"));
        Assert.That(list.Count, Is.EqualTo(2));
        // 0 1 

        list.AddAtHead("Node 2");
        Assert.That(list.Head, Is.EqualTo("Node 2"));
        Assert.That(list.Count, Is.EqualTo(3));
        // 0 1 2 

        list.AddAtHead("Node 3");
        Assert.That(list.Head, Is.EqualTo("Node 3"));
        Assert.That(list.Count, Is.EqualTo(4));
        // 0 1 2 3

        list.AddAtTail("Node -1");
        Assert.That(list.Tail, Is.EqualTo("Node -1"));
        Assert.That(list.Count, Is.EqualTo(5));
        // -1 0 1 2 3

        list.AddAtTail("Node -2");
        Assert.That(list.Tail, Is.EqualTo("Node -2"));
        Assert.That(list.Count, Is.EqualTo(6));
        // -2 -1 0 1 2 3

        list.AddAtTail("Node -3");
        Assert.That(list.Tail, Is.EqualTo("Node -3"));
        Assert.That(list.Count, Is.EqualTo(7));
        // -3 -2 -1 0 1 2 3

        list.AddAtTail("Node -4");
        Assert.That(list.Tail, Is.EqualTo("Node -4"));
        Assert.That(list.Count, Is.EqualTo(8));
        // -4 -3 -2 -1 0 1 2 3
    }

    [Test]
    public void GetExceptions()
    {
        var list = new DoubleLinked();

        Assert.Throws<IndexOutOfRangeException>(() => list.Get(-1));
        Assert.Throws<IndexOutOfRangeException>(() => list.Get(1));
    }

    [Test]
    public void GetHead()
    {
        var list = new DoubleLinked();

        list.AddAtTail("Node 0");
        list.AddAtTail("Node 1");
        list.AddAtTail("Node 2");
        list.AddAtTail("Node 3");

        Assert.That(list.Get(0), Is.EqualTo("Node 0"));
    }

    [Test]
    public void GetTail()
    {
        var list = new DoubleLinked();

        list.AddAtTail("Node 0");
        list.AddAtTail("Node 1");
        list.AddAtTail("Node 2");
        list.AddAtTail("Node 3");

        Assert.That(list.Get(3), Is.EqualTo("Node 3"));
    }

    [Test]
    public void Get()
    {
        var list = new DoubleLinked();

        list.AddAtTail("Node 0");
        list.AddAtTail("Node 1");
        list.AddAtTail("Node 2");
        list.AddAtTail("Node 3");

        Assert.That(list.Get(0), Is.EqualTo("Node 0"));
        Assert.That(list.Get(1), Is.EqualTo("Node 1"));
        Assert.That(list.Get(2), Is.EqualTo("Node 2"));
        Assert.That(list.Get(3), Is.EqualTo("Node 3"));
    }

    [Test]
    public void AddAtException()
    {
        var list = new DoubleLinked();

        Assert.Throws<IndexOutOfRangeException>(() => list.AddAt("Node 0", -1));
        Assert.Throws<IndexOutOfRangeException>(() => list.AddAt("Node 0", 1));
        Assert.That(list.Count, Is.EqualTo(0));
    }

    [Test]
    public void AddAtHeadAndTail()
    {
        var list = new DoubleLinked();

        list.AddAt("Node 0", 0);
        Assert.That(list.Get(0), Is.EqualTo("Node 0"));

        list.AddAt("Node 1", 1);
        Assert.That(list.Get(1), Is.EqualTo("Node 1"));
    }

    [Test]
    public void AddAt()
    {
        var list = new DoubleLinked();

        list.AddAtTail("Node 0");
        Assert.That(list.Count, Is.EqualTo(1));
        list.AddAtTail("Node 1");
        Assert.That(list.Count, Is.EqualTo(2));
        list.AddAtTail("Node 2");
        Assert.That(list.Count, Is.EqualTo(3));
        list.AddAtTail("Node 3");
        Assert.That(list.Count, Is.EqualTo(4));

        list.AddAt("Node 2/5", 3);
        Assert.That(list.Count, Is.EqualTo(5));
        list.AddAt("Node 1/5", 2);
        Assert.That(list.Count, Is.EqualTo(6));
        list.AddAt("Node 0/5", 1);
        Assert.That(list.Count, Is.EqualTo(7));
        list.AddAt("Node 3/5", 7);
        Assert.That(list.Count, Is.EqualTo(8));


        Assert.That(list.Get(0), Is.EqualTo("Node 0"));
        Assert.That(list.Get(1), Is.EqualTo("Node 0/5"));
        Assert.That(list.Get(2), Is.EqualTo("Node 1"));
        Assert.That(list.Get(3), Is.EqualTo("Node 1/5"));
        Assert.That(list.Get(4), Is.EqualTo("Node 2"));
        Assert.That(list.Get(5), Is.EqualTo("Node 2/5"));
        Assert.That(list.Get(6), Is.EqualTo("Node 3"));
        Assert.That(list.Get(7), Is.EqualTo("Node 3/5"));
    }

    [Test]
    public void DeleteAtHeadException()
    {
        var list = new DoubleLinked();
        Assert.Throws<Exception>(() => list.DeleteAtHead());
        Assert.That(list.Count, Is.EqualTo(0));
    }

    [Test]
    public void DeleteAtHead()
    {
        var list = new DoubleLinked();

        list.AddAtTail("0");
        list.AddAtTail("1");
        list.AddAtTail("2");
        list.AddAtTail("3");
        list.AddAtTail("4");
        list.AddAtTail("5");

        list.DeleteAtHead();
        Assert.That(list.Get(0), Is.EqualTo("1"));  // return 1
        Assert.That(list.Count, Is.EqualTo(5));

        list.DeleteAtHead();
        Assert.That(list.Get(0), Is.EqualTo("2")); // return 2
        Assert.That(list.Count, Is.EqualTo(4));

        list.DeleteAtHead();
        Assert.That(list.Get(0), Is.EqualTo("3")); // return 3
        Assert.That(list.Count, Is.EqualTo(3));

        list.DeleteAtHead();
        Assert.That(list.Get(0), Is.EqualTo("4")); // return 4 
        Assert.That(list.Count, Is.EqualTo(2));

        list.DeleteAtHead();
        Assert.That(list.Get(0), Is.EqualTo("5")); // return 5
        Assert.That(list.Count, Is.EqualTo(1));

        list.DeleteAtHead();
        Assert.That(list.Head, Is.EqualTo(null)); // return null
        Assert.That(list.Tail, Is.EqualTo(null)); // return null
        Assert.That(list.Count, Is.EqualTo(0));
    }

    [Test]
    public void DeleteAtTailException()
    {
        var list = new DoubleLinked();
        Assert.Throws<Exception>(() => list.DeleteAtTail());
        Assert.That(list.Count, Is.EqualTo(0));
    }

    [Test]
    public void DeleteAtTail()
    {
        var list = new DoubleLinked();

        list.AddAtTail("0");
        list.AddAtTail("1");
        list.AddAtTail("2");
        list.AddAtTail("3");
        list.AddAtTail("4");
        list.AddAtTail("5");

        list.DeleteAtTail();
        Assert.That(list.Get(4), Is.EqualTo("4"));  // return 1
        Assert.That(list.Count, Is.EqualTo(5));

        list.DeleteAtTail();
        Assert.That(list.Get(3), Is.EqualTo("3")); // return 2
        Assert.That(list.Count, Is.EqualTo(4));

        list.DeleteAtTail();
        Assert.That(list.Get(2), Is.EqualTo("2")); // return 3
        Assert.That(list.Count, Is.EqualTo(3));

        list.DeleteAtTail();
        Assert.That(list.Get(1), Is.EqualTo("1")); // return 4 
        Assert.That(list.Count, Is.EqualTo(2));

        list.DeleteAtTail();
        Assert.That(list.Get(0), Is.EqualTo("0")); // return 5
        Assert.That(list.Count, Is.EqualTo(1));

        list.DeleteAtTail();
        Assert.That(list.Head, Is.EqualTo(null)); // return null
        Assert.That(list.Tail, Is.EqualTo(null)); // return null
        Assert.That(list.Count, Is.EqualTo(0));
    }

    [Test]
    public void DeleteAtException()
    {
        var list = new DoubleLinked();
        Assert.Throws<IndexOutOfRangeException>(() => list.DeleteAt(-1));
        Assert.Throws<IndexOutOfRangeException>(() => list.DeleteAt(1));
        Assert.That(list.Count, Is.EqualTo(0));
    }

    [Test]
    public void DeleteHead()
    {
        var list = new DoubleLinked();

        list.AddAtTail("0");
        list.AddAtTail("1");
        list.AddAtTail("2");
        list.AddAtTail("3");
        list.AddAtTail("4");
        list.AddAtTail("5");

        list.DeleteAt(0);
        Assert.That(list.Get(0), Is.EqualTo("1"));  // return 1
        Assert.That(list.Count, Is.EqualTo(5));

        list.DeleteAt(0);
        Assert.That(list.Get(0), Is.EqualTo("2")); // return 2
        Assert.That(list.Count, Is.EqualTo(4));

        list.DeleteAt(0);
        Assert.That(list.Get(0), Is.EqualTo("3")); // return 3
        Assert.That(list.Count, Is.EqualTo(3));

        list.DeleteAt(0);
        Assert.That(list.Get(0), Is.EqualTo("4")); // return 4 
        Assert.That(list.Count, Is.EqualTo(2));

        list.DeleteAt(0);
        Assert.That(list.Get(0), Is.EqualTo("5")); // return 5
        Assert.That(list.Count, Is.EqualTo(1));

        list.DeleteAt(0);
        Assert.That(list.Head, Is.EqualTo(null)); // return null
        Assert.That(list.Tail, Is.EqualTo(null)); // return null
        Assert.That(list.Count, Is.EqualTo(0));
    }

    [Test]
    public void DeleteTail()
    {
        var list = new DoubleLinked();

        list.AddAtTail("0");
        list.AddAtTail("1");
        list.AddAtTail("2");
        list.AddAtTail("3");
        list.AddAtTail("4");
        list.AddAtTail("5");

        list.DeleteAt(5);
        Assert.That(list.Get(4), Is.EqualTo("4"));  // return 1
        Assert.That(list.Count, Is.EqualTo(5));

        list.DeleteAt(4);
        Assert.That(list.Get(3), Is.EqualTo("3")); // return 2
        Assert.That(list.Count, Is.EqualTo(4));

        list.DeleteAt(3);
        Assert.That(list.Get(2), Is.EqualTo("2")); // return 3
        Assert.That(list.Count, Is.EqualTo(3));

        list.DeleteAt(2);
        Assert.That(list.Get(1), Is.EqualTo("1")); // return 4 
        Assert.That(list.Count, Is.EqualTo(2));

        list.DeleteAt(1);
        Assert.That(list.Get(0), Is.EqualTo("0")); // return 5
        Assert.That(list.Count, Is.EqualTo(1));

        list.DeleteAt(0);
        Assert.That(list.Head, Is.EqualTo(null)); // return null
        Assert.That(list.Tail, Is.EqualTo(null)); // return null
        Assert.That(list.Count, Is.EqualTo(0));
    }

    [Test]
    public void DeleteAt()
    {
        var list = new DoubleLinked();

        list.AddAtTail("0"); // x
        list.AddAtTail("1"); // x
        list.AddAtTail("2"); // x
        list.AddAtTail("3");
        list.AddAtTail("4"); // x
        list.AddAtTail("5"); // x

        list.DeleteAt(2);
        Assert.That(list.Get(2), Is.EqualTo("3"));  // return 3
        Assert.That(list.Count, Is.EqualTo(5));

        list.DeleteAt(3);
        Assert.That(list.Get(3), Is.EqualTo("5")); // return 5
        Assert.That(list.Count, Is.EqualTo(4));

        list.DeleteAt(1);
        Assert.That(list.Get(1), Is.EqualTo("3")); // return 3
        Assert.That(list.Count, Is.EqualTo(3));

        list.DeleteAt(2);
        Assert.That(list.Get(1), Is.EqualTo("3")); // return 3
        Assert.That(list.Count, Is.EqualTo(2));

        list.DeleteAt(0);
        Assert.That(list.Get(0), Is.EqualTo("3")); // return 3
        Assert.That(list.Count, Is.EqualTo(1));

        list.DeleteAt(0);
        Assert.That(list.Head, Is.EqualTo(null)); // return null
        Assert.That(list.Tail, Is.EqualTo(null)); // return null
        Assert.That(list.Count, Is.EqualTo(0));
    }
}