using Aulas_C_teste;
using DataStructures.Stack;
using NUnit.Framework;
namespace Estudos.Tests;

[TestFixture]

public class StackTest
{
    [Test]

    public void StackWithoutCapacityTest()
    {
        var stack = new MyStack();
        Assert.That(stack.IsEmpty, Is.True);
        Assert.That(stack.Capacity, Is.EqualTo(int.MaxValue));
        Assert.That(stack.Length, Is.EqualTo(0));
        Assert.That(stack.IsFull, Is.False);
        Assert.Throws<InvalidOperationException>(() => {string s = stack.Peek;});
        Assert.Throws<InvalidOperationException>(() => {string s = stack.Pop();});

        stack.Push("a");
        Assert.That(stack.IsEmpty, Is.False);
        Assert.That(stack.Capacity, Is.EqualTo(int.MaxValue));
        Assert.That(stack.Length, Is.EqualTo(1));
        Assert.That(stack.IsFull, Is.False);

        Assert.That(stack.Peek, Is.EqualTo("a"));
        Assert.That(stack.IsFull, Is.False);
        Assert.That(stack.Length, Is.EqualTo(1));

        Assert.That(stack.Pop(), Is.EqualTo("a"));
        Assert.That(stack.IsEmpty, Is.True);
        Assert.That(stack.Length, Is.EqualTo(0));
        Assert.Throws<InvalidOperationException>(() => {string s = stack.Peek;});
        Assert.Throws<InvalidOperationException>(() => {string s = stack.Pop();});

        stack.Push("a");
        stack.Push("b");
        stack.Push("c");
        Assert.That(stack.Peek, Is.EqualTo("c"));
        Assert.That(stack.IsEmpty, Is.False);
        Assert.That(stack.Length, Is.EqualTo(3));

        Assert.That(stack.Pop(), Is.EqualTo("c"));
        Assert.That(stack.IsEmpty, Is.False);
        Assert.That(stack.Length, Is.EqualTo(2));

        Assert.That(stack.Peek, Is.EqualTo("b"));
        Assert.That(stack.Length, Is.EqualTo(2));
        Assert.That(stack.Pop(), Is.EqualTo("b"));
        Assert.That(stack.IsEmpty, Is.False);
        Assert.That(stack.Length, Is.EqualTo(1));

        Assert.That(stack.Peek, Is.EqualTo("a"));
        Assert.That(stack.Length, Is.EqualTo(1));
        Assert.That(stack.Pop(), Is.EqualTo("a"));
        Assert.That(stack.IsEmpty, Is.True);
        Assert.That(stack.Length, Is.EqualTo(0));

        Assert.Throws<InvalidOperationException>(() => {string s = stack.Peek;});
        Assert.Throws<InvalidOperationException>(() => {string s = stack.Pop();});

        stack = new MyStack();
        for (int i = 1; i <= 100; i++)
        {
            stack.Push($"Item_{i}");
            Assert.That(stack.Length, Is.EqualTo(i));
            Assert.That(stack.IsEmpty, Is.False);
        }

        Assert.That(stack.Length, Is.EqualTo(100));

        for (int i = 1; i <= 100; i++)
        {
            string value = stack.Pop();
            Assert.That(value, Is.EqualTo($"Item_{101 - i}"));
            Assert.That(stack.Length, Is.EqualTo(100 - i));
        }

        Assert.That(stack.IsEmpty, Is.True);
    }

    [Test]
    public void QueueWithCapacityTest()
    {
        var stack = new MyStack(10);
        for (int i = 1; i <= 10; i++)
        {
            stack.Push($"Item_{i}");
        }

        Assert.That(stack.IsFull, Is.True);
        Assert.Throws<InvalidOperationException>(() => stack.Push("xxx"));
    }
}