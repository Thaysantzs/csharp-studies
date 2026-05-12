using System;
using NUnit.Framework;
using DataStructures.Dictionary;

namespace Estudos.Tests;

[TestFixture]
public class DictionaryTest
{

    // =============================
    // ADD
    // =============================

    [Test]
    public void Add_WhenValueIsNew_ShouldReturnTrueAndIncreaseCount()
    {
        var Dic = new DictionaryCustom<int, string>();

        var result = Dic.Add(1, "Thiago");

        Assert.That(result, Is.True);
        Assert.That(Dic.Count, Is.EqualTo(1));
        Assert.That(Dic.Contains(1), Is.True);
    }

    [Test]
    public void Add_WhenValueAlreadyExists_ShouldReturnFalseAndNotIncreaseCount()
    {
        var Dic = new DictionaryCustom<int, string>();

        Dic.Add(1, "Thiago");
        var result = Dic.Add(1,"Thiago");

        Assert.That(result, Is.False);
        Assert.That(Dic.Count, Is.EqualTo(1));
    }

    // =============================
    // COLLISION
    // =============================

    [Test]
    public void Add_WhenCollisionOccurs_ShouldStoreMultipleValuesInSameBucket()
    {
        var Dic = new DictionaryCustom<int, string>(); // força colisão

        Dic.Add(1, "Thiago");
        Dic.Add(2, "João");
        Dic.Add(3, "Maria");

        Assert.That(Dic.Count, Is.EqualTo(3));
        Assert.That(Dic.Contains(1), Is.True);
        Assert.That(Dic.Contains(2), Is.True);
        Assert.That(Dic.Contains(3), Is.True);
    }

    // =============================
    // CONTAINS
    // =============================

    [Test]
    public void Contains_WhenValueExists_ShouldReturnTrue()
    {
        var Dic = new DictionaryCustom<int, string>();

        Dic.Add(5, "Thiago");

        Assert.That(Dic.Contains(5), Is.True);
    }

    [Test]
    public void Contains_WhenValueDoesNotExist_ShouldReturnFalse()
    {
        var Dic = new DictionaryCustom<int, string>();

        Assert.That(Dic.Contains(99), Is.False);
    }

    // =============================
    // REMOVE
    // =============================

    [Test]
    public void Remove_WhenValueExists_ShouldReturnTrueAndRemoveElement()
    {
        var Dic = new DictionaryCustom<int, string>();

        Dic.Add(1, "Thiago");

        var result = Dic.Remove(1);

        Assert.That(result, Is.True);
        Assert.That(Dic.Contains(1), Is.False);
        Assert.That(Dic.Count, Is.EqualTo(0));
    }

    [Test]
    public void Remove_WhenValueDoesNotExist_ShouldReturnFalse()
    {
        var Dic = new DictionaryCustom<int, string>();

        var result = Dic.Remove(0);

        Assert.That(result, Is.False);
        Assert.That(Dic.Count, Is.EqualTo(0));
    }

    [Test]
    public void Remove_WhenCollisionExists_ShouldRemoveCorrectElementOnly()
    {
        var Dic = new DictionaryCustom<int, string>(); // colisão garantida

        Dic.Add(1, "Thiago");
        Dic.Add(2, "João");
        Dic.Add(3, "Maria");

        Dic.Remove(2);

        Assert.That(Dic.Contains(1), Is.True);
        Assert.That(Dic.Contains(2), Is.False);
        Assert.That(Dic.Contains(3), Is.True);
        Assert.That(Dic.Count, Is.EqualTo(2));
    }

    // =============================
    // CLEAR
    // =============================

    [Test]
    public void Clear_WhenCalled_ShouldRemoveAllElements()
    {
        var Dic = new DictionaryCustom<int, string>();

        Dic.Add(1, "Thiago");
        Dic.Add(2, "João");

        Dic.Clear();

        Assert.That(Dic.Count, Is.EqualTo(0));
        Assert.That(Dic.Contains(1), Is.False);
        Assert.That(Dic.Contains(2), Is.False);
    }

    // =============================
    // GENERICS
    // =============================

    [Test]
    public void HashSet_ShouldWorkWithStrings()
    {
        var Dic = new DictionaryCustom<string, string>();

        Dic.Add("A", "Anna");
        Dic.Add("B", "Bruno");

        Assert.That(Dic.Contains("A"), Is.True);
        Assert.That(Dic.Contains("C"), Is.False);
    }

    [Test]
    public void HashSet_ShouldWorkWithDifferentTypes()
    {
        var intDic = new DictionaryCustom<int, string>();
        var stringDic = new DictionaryCustom<string, string>();

        intDic.Add(1, "Thiago");
        stringDic.Add("X", "Xuxa");

        Assert.That(intDic.Contains(1), Is.True);
        Assert.That(stringDic.Contains("X"), Is.True);
    }

    // =============================
    // STATE CONSISTENCY
    // =============================

    [Test]
    public void MultipleOperations_ShouldMaintainCorrectState()
    {
        var Dic = new DictionaryCustom<int, string>();

        Dic.Add(1,"Thiago");
        Dic.Add(2, "Maria");
        Dic.Remove(1);
        Dic.Add(3, "Bruno");

        Assert.That(Dic.Contains(1), Is.False);
        Assert.That(Dic.Contains(2), Is.True);
        Assert.That(Dic.Contains(3), Is.True);
        Assert.That(Dic.Count, Is.EqualTo(2));
    }

    // =============================
    // GET
    // =============================

    [Test]
    public void Get_WhenCalledGet_ShouldThrowValue()
    {
        var Dic = new DictionaryCustom<int, string>();

        Dic.Add(1,"Thiago");
        Dic.Add(2, "Maria");
        Dic.Remove(1);
        Dic.Add(3, "Bruno");

        Assert.That(Dic.Get(2), Is.EqualTo("Maria"));
        Assert.That(Dic.Get(3), Is.EqualTo("Bruno"));
        Assert.That(Dic.Count, Is.EqualTo(2));
    }

    [Test]
    public void Get_WhenGetIsNotValid_ShouldKeyNotFoundExceptionReturnException()
    {
        var Dic = new DictionaryCustom<int, string>();

        Dic.Add(1,"Thiago");
        Dic.Add(2, "Maria");
        Dic.Remove(1);
        Dic.Add(3, "Bruno");

        Assert.That(Dic.Count, Is.EqualTo(2));
        Assert.Throws<KeyNotFoundException>(() => {var s = Dic.Get(1);});
    }
}
