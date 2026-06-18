using Spectre.Console;
public class Widget : Library
{
    public static void Confirm()
    {
        AnsiConsole.MarkupLine("[Orange3]Confirm Y/N:[/]");
        AnsiConsole.MarkupLine("""
                        if (AnsiConsole.Confirm("[green]Do you like pizza?[/]"))
                        {
                        AnsiConsole.MarkupLine("[hotpink]Great! I like pizza too[/]");
                        }
                        """);
    }
    public static void MenuSelect()
    {
        AnsiConsole.MarkupLine("[Orange3]Select from menu (returns a string):[/]");
        AnsiConsole.MarkupLine($"""
                        [blue] string [/] [teal]varName[/] = AnsiConsole.Prompt(
                            new SelectionPrompt<string>()
                            .Title("[green]title prompt[/]")
                            .AddChoices("[gray30]Option 1[/]", "[gray]Option 2[/]", "[gray54]Option 3[/]")
                        );
                        """);
    }

    public static void MultiMenuSelect()
    {
        AnsiConsole.MarkupLine("[Orange3]Select multiple from menu (returns a list):[/]");
        AnsiConsole.MarkupLine($"""
            [blue] string [/] [teal]varName[/] = AnsiConsole.Prompt(
                new MultiSelectionPrompt<string>()
                .Title("[green]title prompt[/]")
                .AddChoices("[gray30]Option 1[/]", "[gray]Option 2[/]", "[gray54]Option 3[/]")
            );


            """);
    }

}