using Spectre.Console;
public class Format
{
    public static void Line()
    {
        Console.WriteLine();
    }

    public static void Example()
    {
        Console.MarkupLine("[green]EXAMPLE:[/]");
    }
    
    public static void Code()
    {
        Console.MarkupLine("[green]CODE:[/]");
    }
}