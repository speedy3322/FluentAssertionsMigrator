using Migrator;
using NUnitMigrator.Replacements;
using System.Text.RegularExpressions;

namespace NUnitMigrator;

public class Converter : IConverter
{
    public bool TryConvert(string content, out string output)
    {
        output = content;

        if (!HasNUnitPatterns(content))
        {
            return false;
        }

        foreach (KeyValuePair<string, string> replacementPattern in ReplacementPatterns.Items)
        {
            output = Regex.Replace(output, replacementPattern.Key, replacementPattern.Value);
        }

        return true;
    }

    private bool HasNUnitPatterns(string content)
    {
        return ReplacementPatterns.Items.Keys.Any(key => Regex.IsMatch(content, key));
    }
}
