namespace Migrator;

public interface IConverter
{
    /// <summary>
    /// Tries to converts all assertions to FluentAssertions using Regex patterns, store it in output and returns true.
    /// If none, then false is returned and output the original content
    /// </summary>
    /// <param name="content">content to be converted</param>
    /// <param name="output">converted content</param>
    /// <returns></returns>
    public bool TryConvert(string content, out string output);

}
