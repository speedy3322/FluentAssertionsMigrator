using FluentAssertions;

namespace NUnitMigrator.Test
{

    [TestFixture]
    public class AssertThatHasPatternTest : ConvertContentBaseTest
    {

        [TestCaseSource(nameof(_testCaseData))]
        public void ConvetContent_AssertThatHasExatlyMatches_ConvertedCorrectly(string[] args)
        {
            // Arrange
            string original = $"Assert.That({args[0]}, Has.Exactly(9).Matches<Type>({args[1]}));";
            string expected = $"{args[0]}.Where({args[1]}).Should().HaveCount(9);";

            // Act 
            bool success = _converter.TryConvert(original, out string output);

            // Assert
            success.Should().BeTrue();
            output.Should().Be(expected);
        }

        [TestCaseSource(nameof(_testCaseData))]
        public void ConvetContent_AssertThatHasOneMatches_ConvertedCorrectly(string[] args)
        {
            // Arrange
            string original = $"Assert.That({args[0]}, Has.One.Matches<Type>({args[1]}));";
            string expected = $"{args[0]}.Should().ContainSingle({args[1]});";

            // Act 
            bool success = _converter.TryConvert(original, out string output);

            // Assert
            success.Should().BeTrue();
            output.Should().Be(expected);
        }

        [TestCaseSource(nameof(_testCaseData))]
        public void ConvetContent_AssertThatHasNoneMatches_ConvertedCorrectly(string[] args)
        {
            // Arrange
            string original = $"Assert.That({args[0]}, Has.None.Matches<Type>({args[1]}));";
            string expected = $"{args[0]}.Should().NotContain({args[1]});";

            // Act 
            bool success = _converter.TryConvert(original, out string output);

            // Assert
            success.Should().BeTrue();
            output.Should().Be(expected);
        }
    }
}
