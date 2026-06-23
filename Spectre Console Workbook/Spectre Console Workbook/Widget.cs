using Spectre.Console;
public class Widget : Library
{
    //PROMPT USER
    public static void Confirm()
    {
        AnsiConsole.MarkupLine("[Orange3]Confirm Y/N:[/]");
        Format.Code();
        AnsiConsole.MarkupLine("""
                        if (AnsiConsole.Confirm("[green]Do you like pizza?[/]"))
                        {
                        AnsiConsole.MarkupLine("[green]Great! I like pizza too[/]");
                        }
                        """);
    }
    public static void MenuSelect()
    {
        AnsiConsole.MarkupLine("[Orange3]Select from menu (returns a string):[/]");
        Format.Code();
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
        Format.Code();
        AnsiConsole.MarkupLine($"""
            [blue] string [/] [teal]varName[/] = AnsiConsole.Prompt(
                new MultiSelectionPrompt<string>()
                .Title("[green]title prompt[/]")
                .AddChoices("[gray30]Option 1[/]", "[gray]Option 2[/]", "[gray54]Option 3[/]")
            );
            """);
    }

    //TEXT FORMAT

    public static void TextJustification()
    {
        Format.Example();
        Panel panel = new Panel(new Rows(
            new Text("Left aligned text").LeftJustified(),
            Text.NewLine,
            new Text("Center aligned text").Centered(),
            Text.NewLine,
            new Text("Right aligned text").RightJustified()

            ))
            .Header("Text Justification")
            .Expand();


        AnsiConsole.Write(panel);

        Format.Code();
        AnsiConsole.MarkupLine($"""
            Panel panel = new Panel(new Rows(            
                new Text("[green]Left aligned text[/]").LeftJustified(),
                Text.NewLine,
                new Text("[green]Center aligned text[/]").Centered(),
                Text.NewLine,
                new Text("[green]Right aligned text[/]").RightJustified()

            ))
            .Header("[green]Text Justification[/]")
            .Expand(); 

            Console.WriteLine(panel);
            """);
    }
}