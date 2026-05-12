using Aulas_C_teste;
using NUnit.Framework;
namespace Estudos.Tests;

[TestFixture]

public class TextFileprocessing_1Test
{
    [Test]
    public void TestFiles()
    {
        // Arange
        string expectedOutput = "1: 10" + System.Environment.NewLine + 
                                "2: 20" + System.Environment.NewLine +
                                "3: 30" + System.Environment.NewLine + 
                                "Invalid value " + System.Environment.NewLine +
                                "4: 40" + System.Environment.NewLine + 
                                "Sum: 100: " + System.Environment.NewLine +
                                "Average: 25";

        // Act
        string actualOutput;
        using(StringWriter writer = new StringWriter())
        {
            Console.SetOut(writer);
            TextFileprocessing.Main(null);
            actualOutput = writer.ToString().Trim();
        }

        // Assert
        Assert.That(actualOutput, Is.EqualTo(expectedOutput));
    }
}