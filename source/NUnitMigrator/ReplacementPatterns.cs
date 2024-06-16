namespace NUnitMigrator;

internal static class ReplacementPatterns
{
    internal static Dictionary<string, string> Items = new()
    {
        { @"Assert\.AreEqual\((.+),\s*(.+)\);", "$2.Should().Be($1);" },
        { @"Assert\.AreNotEqual\((.+),\s*(.+)\);", "$2.Should().NotBe($1);" },
        { @"Assert\.IsTrue\((.+)\);", "$1.Should().BeTrue();" },
        { @"Assert\.IsFalse\((.+)\);", "$1.Should().BeFalse();" },
        { @"Assert\.IsNull\((.+)\);", "$1.Should().BeNull();" },
        { @"Assert\.NotNull\((.+)\);", "$1.Should().NotBeNull();" },

        // Assert.That(object, Is.*) 
        { @"Assert\.That\((.+),\s*Is\.EqualTo\((.+)\)\);", "$1.Should().Be($2);" },
        { @"Assert\.That\((.+),\s*Is\.Not\.EqualTo\((.+)\)\);", "$1.Should().NotBe($2);" },
        { @"Assert\.That\((.+),\s*Is\.True\);", "$1.Should().BeTrue();" },
        { @"Assert\.That\((.+),\s*Is\.False\);", "$1.Should().BeFalse();" },
        { @"Assert\.That\((.+),\s*Is\.Null\);", "$1.Should().BeNull();" },
        { @"Assert\.That\((.+),\s*Is\.Not\.Null\);", "$1.Should().NotBeNull();" },
      
        // Asser.That(object, Has.*)
        { @"Assert\.That\((.+),\s*Has\.Exactly\((\d+)\)\.Matches<(.+)>\((.+)\)\);", "$1.Where($4).Should().HaveCount($2);" },
        { @"Assert\.That\((.+),\s*Has\.One\.Matches<(.+)>\((.+)\)\);", "$1.Should().ContainSingle($3);" },
        { @"Assert\.That\((.+),\s*Has\.None\.Matches<(.+)>\((.+)\)\);", "$1.Should().NotContain($3);" },
        { @"Assert\.That\(\s*(.+?)\s*\);", "$1.Should().BeTrue();" },

        // Assert.Throws<TException>(Expression)
        { @"Assert\.Throws<(.+)>\(\(\)\s*=>\s*(.+)\);", "Action act = () => $2;\nact.Should().Throw<$1>();" },
    };
}
