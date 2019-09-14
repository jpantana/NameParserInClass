using System;
using NameParserInClass;
using Xunit;

namespace NameParserInClass.Tests
{
    public class NameParsingTests
    {
        [Fact]
        public void FirstAndLastNameShouldBeParsedAccurately()
        {
            // A - Arrange
            var name = "Martin Cross";
            var parser = new Parser();

            // B - Act
            var result = parser.ParseName(name);

            // C - Assert
            Assert.Equal("Martin", result.FirstName); // first param is expected, second is actual. test code stops after first failed Assert
            Assert.Equal("Cross", result.LastName);

        }

        [Fact] // Fact is always public, always returns void, and never takes in arguments
        public void ThreePartNamesShouldBeParsedAccurately()
        {
            // Arrange
            var name = "Martin Zachariah Cross";
            var parser = new Parser();

            // Act
            var result = parser.ParseName(name);

            // Assert
            Assert.Equal("Martin", result.FirstName);
            Assert.Equal("Cross", result.LastName);
        }
    }
}
