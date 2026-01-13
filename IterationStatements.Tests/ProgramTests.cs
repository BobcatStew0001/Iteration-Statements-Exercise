using System;
using System.IO;
using Xunit;
using IterationStatements;

namespace IterationStatements.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void PrintNumbers_ShouldPrintFrom1000ToNeg1000()
        {
            // Arrange
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            Program.PrintNumbers();

            // Assert
            var output = stringWriter.ToString();
            var lines = output.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            Assert.Equal(2001, lines.Length);
            Assert.Equal("1000", lines[0]);
            Assert.Equal("0", lines[1000]);
            Assert.Equal("-1000", lines[2000]);
        }
    }
}
