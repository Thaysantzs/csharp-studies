using System.Diagnostics;
using Aulas_C_teste;
using NUnit.Framework;
namespace Estudos.Tests;

[TestFixture]
public class TextFileProcessing_2Test
{
  [Test]
  public void TestProduceLines()
  {
    // Arrange
    TextFileProcessor processor = new TextFileProcessor("InputFile.txt");

    // Act
    List<string> lines = processor.ProduceLines();

    // Assert
    Assert.That(lines[0], Is.EqualTo("1: 10"));
    Assert.That(lines[1], Is.EqualTo("2: 20"));
    Assert.That(lines[2], Is.EqualTo("3: 30"));
    Assert.That(lines[3], Is.EqualTo("Invalid number!"));
    Assert.That(lines[4], Is.EqualTo("4: 40"));
    Assert.That(lines[5], Is.EqualTo("Sum: 100"));
    Assert.That(lines[6], Is.EqualTo("Average: 25"));
    Assert.That(lines.Count, Is.EqualTo(7));
  }
}