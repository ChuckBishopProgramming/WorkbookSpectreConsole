using Spectre.Console;

public class OfficialStuff
{

    public static bool MainLoop { get; set; } = true;
    public static bool SubLoop { get; set; } = false;

    public static void PromptReturn()
    {
        AnsiConsole.MarkupLine("[red]Press x to return to the main menu[/]");

        string userSelect3 = Console.ReadLine();
        if (userSelect3 == "x")
        {
            OfficialStuff.SubLoop = OfficialStuff.Off();
            OfficialStuff.MainLoop = OfficialStuff.On();
        }
    }

    public static bool Off()
    {
        return false;
    }
    public static bool On()
    {
        return true;
    }
    //public static void SubLoopOff()
    //{
    //    MainLoop = false;
    //}
    //public static void SubLoopOn()
    //{
    //    MainLoop = true;
    //}








}