namespace NUnitMigrator.Replacements;

internal partial class ReplacementPatterns
{
    internal static Dictionary<string, string> AssertThatIsItems = new()
    {
        // Assert.That(object, Is.*) 
        { @"Assert\.That\((.+),\s*Is\.Null\);", "$1.Should().BeNull();" },
        { @"Assert\.That\((.+),\s*Is\.Default\);", "$1.Should().Be(default);" },
        { @"Assert\.That\((.+),\s*Is\.True\);", "$1.Should().BeTrue();" },
        { @"Assert\.That\((.+),\s*Is\.False\);", "$1.Should().BeFalse();" },
        { @"Assert\.That\((.+),\s*Is\.Positive\);", "$1.Should().BePositive();" },
        { @"Assert\.That\((.+),\s*Is\.Negative\);", "$1.Should().BeNegative();" },
        { @"Assert\.That\((.+),\s*Is\.Zero\);", "$1.Should().Be(0);" },
        { @"Assert\.That\((.+),\s*Is\.NaN\);", "$1.Should().BeNaN();" },
        { @"Assert\.That\((.+),\s*Is\.Empty\);", "$1.Should().BeEmpty();" },
        { @"Assert\.That\((.+),\s*Is\.Unique\);", "$1.Should().OnlyHaveUniqueItems();" },
        { @"Assert\.That\((.+),\s*Is\.XmlSerializable\);", "$1.Should().BeXmlSerializable();" },
        { @"Assert\.That\((.+),\s*Is\.Ordered\);", "$1.Should().BeInAscendingOrder();" },
        { @"Assert\.That\((.+),\s*Is\.EqualTo\((.+)\)\);", "$1.Should().Be($2);" },
        { @"Assert\.That\((.+),\s*Is\.SameAs\((.+)\)\);", "$1.Should().BeSameAs($2);" },
        { @"Assert\.That\((.+),\s*Is\.GreaterThan\((.+)\)\);", "$1.Should().BeGreaterThan($2);" },
        { @"Assert\.That\((.+),\s*Is\.GreaterThanOrEqualTo\((.+)\)\);", "$1.Should().BeGreaterThanOrEqualTo($2);" },
        { @"Assert\.That\((.+),\s*Is\.AtLeast\((.+)\)\);", "$1.Should().BeGreaterThanOrEqualTo($2);" },
        { @"Assert\.That\((.+),\s*Is\.LessThan\((.+)\)\);", "$1.Should().BeLessThan($2);" },
        { @"Assert\.That\((.+),\s*Is\.LessThanOrEqualTo\((.+)\)\);", "$1.Should().BeLessThanOrEqualTo($2);" },
        { @"Assert\.That\((.+),\s*Is\.AtMost\((.+)\)\);", "$1.Should().BeLessThanOrEqualTo($2);" },
        { @"Assert\.That\((.+),\s*Is\.TypeOf<(.+)>\(\)\);", "$1.Should().BeOfType<$2>();" },
        { @"Assert\.That\((.+),\s*Is\.TypeOf\((.+)\)\);", "$1.Should().BeOfType($2);" },
        { @"Assert\.That\((.+),\s*Is\.InstanceOf<(.+)>\(\)\);", "$1.Should().BeAssignableTo<$2>();" },
        { @"Assert\.That\((.+),\s*Is\.InstanceOf\((.+)\)\);", "$1.Should().BeAssignableTo($2);" },
        { @"Assert\.That\((.+),\s*Is\.AssignableFrom<(.+)>\(\)\);", "$1.Should().BeAssignableTo<$2>();" }, // BS
        { @"Assert\.That\((.+),\s*Is\.AssignableFrom\((.+)\)\);", "$1.Should().BeAssignableTo($2);" }, // BS
        { @"Assert\.That\((.+),\s*Is\.AssignableTo<(.+)>\(\)\);", "$1.Should().BeAssignableTo<$2>();" },
        { @"Assert\.That\((.+),\s*Is\.AssignableTo\((.+)\)\);", "$1.Should().BeAssignableTo($2);" },
        { @"Assert\.That\((.+),\s*Is\.EquivalentTo\((.+)\)\);", "$1.Should().BeEquivalentTo($2);" },
        { @"Assert\.That\((.+),\s*Is\.SubsetOf\((.+)\)\);", "$1.Should().BeSubsetOf($2);" },
        { @"Assert\.That\((.+),\s*Is\.SupersetOf\((.+)\)\);", "$1.Should().BeSupersetOf($2);" }, // BS
        { @"Assert\.That\((.+),\s*Is\.SamePath\((.+)\)\);", "$1.Should().BeSamePathAs($2);" }, // BS
        { @"Assert\.That\((.+),\s*Is\.SubPathOf\((.+)\)\);", "$1.Should().BeSubPathOf($2);" }, // BS
        { @"Assert\.That\((.+),\s*Is\.SamePathOrUnder\((.+)\)\);", "$1.Should().BeSameOrUnderPathAs($2);" }, // BS
        { @"Assert\.That\((.+),\s*Is\.InRange\((.+),\s*(.+)\)\);", "$1.Should().BeInRange($2, $3);" },
        { @"Assert\.That\((.+),\s*Is\.AnyOf\((.+)\)\);", "$1.Should().BeOneOf($2);" }
    };

}
