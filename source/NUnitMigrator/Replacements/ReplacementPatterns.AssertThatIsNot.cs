namespace NUnitMigrator.Replacements;

internal partial class ReplacementPatterns
{
    internal static Dictionary<string, string> AssertThatIsNotItems = new()
    {
        // Assert.That(object, Is.Not.*)
        { @"Assert\.That\((.+),\s*Is\.Not\.Null\);", "$1.Should().NotBeNull();" },
        { @"Assert\.That\((.+),\s*Is\.Not\.Default\);", "$1.Should().NotBe(default);" },
        { @"Assert\.That\((.+),\s*Is\.Not\.True\);", "$1.Should().NotBeTrue();" },
        { @"Assert\.That\((.+),\s*Is\.Not\.False\);", "$1.Should().NotBeFalse();" },
        { @"Assert\.That\((.+),\s*Is\.Not\.Positive\);", "$1.Should().NotBePositive();" },
        { @"Assert\.That\((.+),\s*Is\.Not\.Negative\);", "$1.Should().NotBeNegative();" },
        { @"Assert\.That\((.+),\s*Is\.Not\.Zero\);", "$1.Should().NotBe(0);" },
        { @"Assert\.That\((.+),\s*Is\.Not\.NaN\);", "$1.Should().NotBeNaN();" },
        { @"Assert\.That\((.+),\s*Is\.Not\.Empty\);", "$1.Should().NotBeEmpty();" },
        { @"Assert\.That\((.+),\s*Is\.Not\.Unique\);", "$1.Should().NotContainDuplicates();" },
        { @"Assert\.That\((.+),\s*Is\.Not\.XmlSerializable\);", "$1.Should().NotBeXmlSerializable();" },
        { @"Assert\.That\((.+),\s*Is\.Not\.Ordered\);", "$1.Should().NotBeInAscendingOrder();" },
        { @"Assert\.That\((.+),\s*Is\.Not\.EqualTo\((.+)\)\);", "$1.Should().NotBe($2);" },
        { @"Assert\.That\((.+),\s*Is\.Not\.SameAs\((.+)\)\);", "$1.Should().NotBeSameAs($2);" },
        { @"Assert\.That\((.+),\s*Is\.Not\.GreaterThan\((.+)\)\);", "$1.Should().NotBeGreaterThan($2);" },
        { @"Assert\.That\((.+),\s*Is\.Not\.GreaterThanOrEqualTo\((.+)\)\);", "$1.Should().NotBeGreaterThanOrEqualTo($2);" },
        { @"Assert\.That\((.+),\s*Is\.Not\.AtLeast\((.+)\)\);", "$1.Should().NotBeGreaterThanOrEqualTo($2);" },
        { @"Assert\.That\((.+),\s*Is\.Not\.LessThan\((.+)\)\);", "$1.Should().NotBeLessThan($2);" },
        { @"Assert\.That\((.+),\s*Is\.Not\.LessThanOrEqualTo\((.+)\)\);", "$1.Should().NotBeLessThanOrEqualTo($2);" },
        { @"Assert\.That\((.+),\s*Is\.Not\.AtMost\((.+)\)\);", "$1.Should().NotBeLessThanOrEqualTo($2);" },
        { @"Assert\.That\((.+),\s*Is\.Not\.TypeOf<(.+)>\(\)\);", "$1.Should().NotBeOfType<$2>();" },
        { @"Assert\.That\((.+),\s*Is\.Not\.TypeOf\((.+)\)\);", "$1.Should().NotBeOfType($2);" },
        { @"Assert\.That\((.+),\s*Is\.Not\.InstanceOf<(.+)>\(\)\);", "$1.Should().NotBeAssignableTo<$2>();" },
        { @"Assert\.That\((.+),\s*Is\.Not\.InstanceOf\((.+)\)\);", "$1.Should().NotBeAssignableTo($2);" },
        { @"Assert\.That\((.+),\s*Is\.Not\.AssignableFrom<(.+)>\(\)\);", "$1.Should().NotBeAssignableTo<$2>();" }, // BS
        { @"Assert\.That\((.+),\s*Is\.Not\.AssignableFrom\((.+)\)\);", "$1.Should().NotBeAssignableTo($2);" }, // BS
        { @"Assert\.That\((.+),\s*Is\.Not\.AssignableTo<(.+)>\(\)\);", "$1.Should().NotBeAssignableTo<$2>();" },
        { @"Assert\.That\((.+),\s*Is\.Not\.AssignableTo\((.+)\)\);", "$1.Should().NotBeAssignableTo($2);" },
        { @"Assert\.That\((.+),\s*Is\.Not\.EquivalentTo\((.+)\)\);", "$1.Should().NotBeEquivalentTo($2);" },
        { @"Assert\.That\((.+),\s*Is\.Not\.SubsetOf\((.+)\)\);", "$1.Should().NotBeSubsetOf($2);" },
        { @"Assert\.That\((.+),\s*Is\.Not\.SupersetOf\((.+)\)\);", "$1.Should().NotBeSupersetOf($2);" }, // BS
        { @"Assert\.That\((.+),\s*Is\.Not\.SamePath\((.+)\)\);", "$1.Should().NotBeSamePathAs($2);" }, //BS
        { @"Assert\.That\((.+),\s*Is\.Not\.SubPathOf\((.+)\)\);", "$1.Should().NotBeSubPathOf($2);" }, // BS
        { @"Assert\.That\((.+),\s*Is\.Not\.SamePathOrUnder\((.+)\)\);", "$1.Should().NotBeSameOrUnderPathAs($2);" }, //BS
        { @"Assert\.That\((.+),\s*Is\.Not\.InRange\((.+),\s*(.+)\)\);", "$1.Should().NotBeInRange($2, $3);" },
        { @"Assert\.That\((.+),\s*Is\.Not\.AnyOf\((.+)\)\);", "$1.Should().NotBeOneOf($2);" }
    };
}
