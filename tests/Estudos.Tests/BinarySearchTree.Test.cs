using DataStructures.BinarySearch;
using NUnit.Framework;
namespace Estudos.Tests;

[TestFixture]
public class BinarySearchTreeTests
{
    private BinarySearchTree _tree = null!;

    [SetUp]
    public void Setup()
    {
        _tree = new BinarySearchTree();

        _tree.Add(50);
        _tree.Add(30);
        _tree.Add(70);
        _tree.Add(20);
        _tree.Add(40);
        _tree.Add(60);
        _tree.Add(80);
    }

    [Test]
    public void Add_ShouldIncreaseCount()
    {
        _tree.Add(90);

        Assert.That(_tree.Count, Is.EqualTo(8));
    }

    [Test]
    public void Contains_ShouldReturnTrue_WhenValueExists()
    {
        var result = _tree.Contains(40);

        Assert.That(result, Is.True);
    }

    [Test]
    public void Contains_ShouldReturnFalse_WhenValueDoesNotExist()
    {
        var result = _tree.Contains(500);

        Assert.That(result, Is.False);
    }

    [Test]
    public void Remove_LeafNode_ShouldRemoveCorrectly()
    {
        _tree.Remove(20);

        Assert.That(_tree.Contains(20), Is.False);
        Assert.That(_tree.Count, Is.EqualTo(6));
    }

    [Test]
    public void Remove_NodeWithOneChild_ShouldRemoveCorrectly()
    {
        _tree.Add(65);

        _tree.Remove(60);

        Assert.That(_tree.Contains(60), Is.False);
        Assert.That(_tree.Contains(65), Is.True);
    }

    [Test]
    public void Remove_NodeWithTwoChildren_ShouldRemoveCorrectly()
    {
        _tree.Remove(70);

        Assert.That(_tree.Contains(70), Is.False);
        Assert.That(_tree.Contains(60), Is.True);
        Assert.That(_tree.Contains(80), Is.True);
    }

    [Test]
    public void Clear_ShouldRemoveAllNodes()
    {
        _tree.Clear();

        Assert.That(_tree.Count, Is.EqualTo(0));
    }

    [Test]
    public void Height_ShouldReturnThree()
    {
        var height = _tree.Height();

        Assert.That(height, Is.EqualTo(3));
    }

    [Test]
    public void Count_ShouldReturnNumberOfNodes()
    {
        Assert.That(_tree.Count, Is.EqualTo(7));
    }

    [Test]
    public void Remove_NonExistingValue_ShouldNotChangeCount()
    {
        _tree.Remove(999);

        Assert.That(_tree.Count, Is.EqualTo(7));
    }

    [Test]
    public void EmptyTree_ShouldHaveHeightZero()
    {
        var tree = new BinarySearchTree();

        Assert.That(tree.Height(), Is.EqualTo(0));
    }

    [Test]
    public void EmptyTree_ShouldNotContainValues()
    {
        var tree = new BinarySearchTree();

        Assert.That(tree.Contains(10), Is.False);
    }

    [Test]
    public void InOrder_ShouldPrintSortedValues()
    {
        using var writer = new StringWriter();

        Console.SetOut(writer);

        _tree.InOrderTraversal();

        var result = writer.ToString().Trim();

        Assert.That(result, Is.EqualTo("20 30 40 50 60 70 80"));
    }
}