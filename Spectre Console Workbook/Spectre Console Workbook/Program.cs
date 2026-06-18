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
            .AddChoices("Widget Library", "Reference Library", "Info Library")
            );

        switch (userSelect)
        {
            case ("Widget Library"):

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

                            Widget.Confirm();
                            Format.Line();

                            Widget.MenuSelect();
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
                break;

            case ("Reference Library"):

                break;

            case ("Info Library"):

                break;

            default:
                break;

        }

    }
}


