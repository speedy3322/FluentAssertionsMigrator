using FluentAssertions;

namespace NUnitMigrator.Test
{

    [TestFixture]
    public class AssertThatIsPatternTest : ConvertContentBaseTest
    {

        [TestCaseSource(nameof(_testCaseData))]
        public void ConvetContent_AssertThatIsEqualTo_ConvertedCorrectly(string[] args)
        {
            // Arrange
            string original = $"Assert.That({args[0]}, Is.EqualTo({args[1]}));";
            string expected = $"{args[0]}.Should().Be({args[1]});";

            // Act 
            bool success = _converter.TryConvert(original, out string output);

            // Assert
            success.Should().BeTrue();
            output.Should().Be(expected);
        }

        [TestCaseSource(nameof(_testCaseData))]
        public void ConvetContent_AssertThatIsNotEqualTo_ConvertedCorrectly(string[] args)
        {
            // Arrange
            string original = $"Assert.That({args[0]}, Is.Not.EqualTo({args[1]}));";
            string expected = $"{args[0]}.Should().NotBe({args[1]});";

            // Act 
            bool success = _converter.TryConvert(original, out string output);

            // Assert
            success.Should().BeTrue();
            output.Should().Be(expected);
        }

        [TestCaseSource(nameof(_testCaseData))]
        public void ConvetContent_AssertThatIsTrue_ConvertedCorrectly(string[] args)
        {
            // Arrange
            string original = $"Assert.That({args[0]}, Is.True);";
            string expected = $"{args[0]}.Should().BeTrue();";

            // Act 
            bool success = _converter.TryConvert(original, out string output);

            // Assert
            success.Should().BeTrue();
            output.Should().Be(expected);
        }

        [TestCaseSource(nameof(_testCaseData))]
        public void ConvetContent_AssertThatIsFalse_ConvertedCorrectly(string[] args)
        {
            // Arrange
            string original = $"Assert.That({args[0]}, Is.False);";
            string expected = $"{args[0]}.Should().BeFalse();";

            // Act 
            bool success = _converter.TryConvert(original, out string output);

            // Assert
            success.Should().BeTrue();
            output.Should().Be(expected);
        }

        [TestCaseSource(nameof(_testCaseData))]
        public void ConvetContent_AssertThatIsNull_ConvertedCorrectly(string[] args)
        {
            // Arrange
            string original = $"Assert.That({args[0]}, Is.Null);";
            string expected = $"{args[0]}.Should().BeNull();";

            // Act 
            bool success = _converter.TryConvert(original, out string output);

            // Assert
            success.Should().BeTrue();
            output.Should().Be(expected);
        }

        [TestCaseSource(nameof(_testCaseData))]
        public void ConvetContent_AssertThatIsNotNull_ConvertedCorrectly(string[] args)
        {
            // Arrange
            string original = $"Assert.That({args[0]}, Is.Not.Null);";
            string expected = $"{args[0]}.Should().NotBeNull();";

            // Act 
            bool success = _converter.TryConvert(original, out string output);

            // Assert
            success.Should().BeTrue();
            output.Should().Be(expected);

            Assert.That(output, Is.)
        }
    }
}
