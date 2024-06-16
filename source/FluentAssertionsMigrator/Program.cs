using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text.RegularExpressions;

using Migrator;

namespace FluentAssertionsMigrator;

public class Program
{
    private readonly static IConverter _converter;

    public static void Main(string[] args)
    {
        HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

        builder.Services.AddTransient<IConverter, NUnitMigrator.Converter>();

        using IHost host = builder.Build();

        Console.WriteLine("HelloWorld");
    }

    public static void ConvertFile(string filePath, bool copyToNewFile = false)
    {
        Console.WriteLine($"Starting to update file {filePath}");

        if (!File.Exists(filePath))
        {
            Console.WriteLine($"File not found: {filePath}");
            return;
        }

        string content = File.ReadAllText(filePath);
        string output;

        if (!_converter.TryConvert(content, out output))
        {
            Console.WriteLine("Nothing to update");
            return;
        }

        output = AddUsingStatement(output, "using FluentAssertions;");

        Save(content, filePath, copyToNewFile);
    }

    private static string AddUsingStatement(string content, string newUsing)
    {
        return newUsing + Environment.NewLine + content;
    }

    private static void Save(string content, string filePath, bool copyToNewFile)
    {
        if (copyToNewFile)
        {
            string newFilePath = Path.Combine(
                Path.GetDirectoryName(filePath)!,
                Path.GetFileNameWithoutExtension(filePath) + "_FluentAssertions" +
                Path.GetExtension(filePath));

            File.WriteAllText(newFilePath, content);
            Console.WriteLine($"Refactored and saved into {newFilePath}");
        }
        else
        {
            File.WriteAllText(filePath, content);
            Console.WriteLine("Refactored and saved");
        }
    }

    private static string NormalizeLineEndings(string content, string lineEnding)
    {
        // Normalize line endings to \n first to handle all existing variations
        content = Regex.Replace(content, @"\r\n|\r|\n", "\n");
        // Replace \n with the desired line ending
        content = content.Replace("\n", lineEnding);
        return content;
    }
}