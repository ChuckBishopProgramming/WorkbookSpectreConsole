using Spectre.Console;

public class Program
{
    static void Main(string[] args)
    {
        AnsiConsole.MarkupLine("[Gold1]Welcome to our Spectre Console Workbook[/]");
        string userSelect2;


        string userSelect = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .Title("[gray]Please select an option[/]")
            .AddChoices("Widget Library", "2", "3", "4", "5", "6")
            );

        if (userSelect == "Widget Library")
        {
            

            userSelect2 = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .Title("[gray]Please select widget type to view[/]")
            .AddChoices("Prompt User", "2", "3", "4", "5", "6")
            );

            switch (userSelect2)
            {
                case ("Prompt User"):
                    AnsiConsole.MarkupLine($"[gold1]Selection Prompt:[/]\n");


                    AnsiConsole.MarkupLine("[Orange3]Select from menu:[/]");
                    AnsiConsole.MarkupLine($"""
                        [blue] string [/] [teal]varName[/] = AnsiConsole.Prompt(
                            new SelectionPrompt<string>()
                            .Title("[green]title prompt[/]")
                            .AddChoices("[gray30]Option 1[/]", "[gray]Option 2[/]", "[gray54]Option 3[/]")
                        );
                        """);
                    Format.Line();

                    AnsiConsole.MarkupLine("[Orange3]Confirm Y/N:[/]");
                    AnsiConsole.MarkupLine("""
                        if (AnsiConsole.Confirm("[green]Do you like pizza?[/]"))
                        {
                        AnsiConsole.MarkupLine("[hotpink]Great! I like pizza too[/]");
                        }
                        """);
                    Format.Line();


                    break;

                case (""):
                    Console.WriteLine("");
                    break;

                case ("1"):
                    Console.WriteLine("");
                    break;

                case ("2"):
                    Console.WriteLine("");
                    break;

                case ("3"):
                    Console.WriteLine("");
                    break;

                case ("4"):
                    Console.WriteLine("");
                    break;
            }
                    

        }


        // Info
        // Examples
        // Widget
        // Reference library

    }
}


