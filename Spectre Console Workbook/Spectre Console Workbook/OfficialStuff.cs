using Spectre.Console;

public class OfficialStuff
{

    public static bool MainLoop { get; set; } = true;
    public static bool SubLoop { get; set; } = false;

    public static void PromptReturn()
    {
        AnsiConsole.MarkupLine("Press x to return to main menu");
        string userInput = Console.ReadLine();

        if (userInput != "Y")
        {
          
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