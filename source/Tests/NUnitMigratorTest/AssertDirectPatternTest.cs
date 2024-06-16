using FluentAssertions;

namespace NUnitMigrator.Test
{

    [TestFixture]
    public class AssertDirectPatternTest : ConvertContentBaseTest
    {

        [TestCaseSource(nameof(_testCaseData))]
        public void ConvetContent_AssertAreEqual_ConvertedCorrectly(string[] args)
        {
            // Arrange
            string original = $"Assert.AreEqual({args[0]}, {args[1]});";
            string expected = $"{args[1]}.Should().Be({args[0]});";

            // Act 
            bool success = _converter.TryConvert(original, out string output);

            // Assert
            success.Should().BeTrue();
            output.Should().Be(expected);
        }

        [TestCaseSource(nameof(_testCaseData))]
        public void ConvetContent_AssertAreNotEqual_ConvertedCorrectly(string[] args)
        {
            // Arrange
            string original = $"Assert.AreNotEqual({args[0]}, {args[1]});";
            string expected = $"{args[1]}.Should().NotBe({args[0]});";

            // Act 
            bool success = _converter.TryConvert(original, out string output);

            // Assert
            success.Should().BeTrue();
            output.Should().Be(expected);
        }

        [TestCaseSource(nameof(_testCaseData))]
        public void ConvetContent_AssertIsTrue_ConvertedCorrectly(string[] args)
        {
            // Arrange
            string original = $"Assert.IsTrue({args[0]});";
            string expected = $"{args[0]}.Should().BeTrue();";

            // Act 
            bool success = _converter.TryConvert(original, out string output);

            // Assert
            success.Should().BeTrue();
            output.Should().Be(expected);
        }

        [TestCaseSource(nameof(_testCaseData))]
        public void ConvetContent_AssertIsFalse_ConvertedCorrectly(string[] args)
        {
            // Arrange
            string original = $"Assert.IsFalse({args[0]});";
            string expected = $"{args[0]}.Should().BeFalse();";

            // Act 
            bool success = _converter.TryConvert(original, out string output);

            // Assert
            success.Should().BeTrue();
            output.Should().Be(expected);
        }

        [TestCaseSource(nameof(_testCaseData))]
        public void ConvetContent_AssertIsNull_ConvertedCorrectly(string[] args)
        {
            // Arrange
            string original = $"Assert.IsNull({args[0]});";
            string expected = $"{args[0]}.Should().BeNull();";

            // Act 
            bool success = _converter.TryConvert(original, out string output);

            // Assert
            success.Should().BeTrue();
            output.Should().Be(expected);
        }

        [TestCaseSource(nameof(_testCaseData))]
        public void ConvetContent_AssertNotNull_ConvertedCorrectly(string[] args)
        {
            // Arrange
            string original = $"Assert.NotNull({args[0]});";
            string expected = $"{args[0]}.Should().NotBeNull();";

            // Act 
            bool success = _converter.TryConvert(original, out string output);

            // Assert
            success.Should().BeTrue();
            output.Should().Be(expected);
        }
    }
}
