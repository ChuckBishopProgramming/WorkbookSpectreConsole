using Spectre.Console;
public class Colors
{

    //gray3
    //gray30
    //gray54
    //gold1 
    //orange3
    //teal
    //blue
    //hotpink
    //green
    public static string[][] ColorInit()
    {
        string[][] colors = new string[26][];
        colors[0] = new string[] { "Aqua", "Aquamarine1", "Aquamarine1_1", "Aquamarine3" };
        colors[1] = new string[] { "Black", "Blue", "Blue1", "Blue3", "Blue3_1", "BlueViolet"};
        colors[2] = new string[] { "CadetBlue", "CadetBlue_1", "Chartreuse1", "Chartreuse2", "Chartreuse2_1", "Chartreuse3", "Chartreuse3_1", "Chartreuse4", "CornflowerBlue", "Cornsilk1", "Cyan", "Cyan2", "Cyan3" };
        colors[3] = new string[] { "" };
        colors[4] = new string[] { "" };
        colors[5] = new string[] { "" };
        colors[6] = new string[] { "" };
        colors[7] = new string[] { "" };
        colors[8] = new string[] { "" };
        colors[9] = new string[] { "" };
        colors[10] = new string[] { "" };
        colors[11] = new string[] { "" };
        colors[12] = new string[] { "" };
        colors[13] = new string[] { "" };
        colors[14] = new string[] { "" };
        colors[15] = new string[] { "" };
        colors[16] = new string[] { "" };
        colors[17] = new string[] { "" };
        colors[18] = new string[] { "" };
        colors[19] = new string[] { "" };
        colors[20] = new string[] { "" };
        colors[21] = new string[] { "" };
        colors[22] = new string[] { "" };
        colors[23] = new string[] { "" };
        colors[24] = new string[] { "" };
        colors[25] = new string[] { "" };

        return colors;
    }

    public static void ColorPrint()
    {
        foreach (string[] arr in ColorInit())
        {
            foreach (string line in arr)
            {
                //Console.WriteLine(line);
                AnsiConsole.MarkupLine($"[{Markup.Escape(line)}]{line}[/]");
            }

        }
    }

    public static void Aqua()
    {
        Console.WriteLine("[Aqua]Aqua[/]");
    }

    public static void Aquamarine1()
    {
        Console.WriteLine("[Aquamarine1]Aquamarine1[/]");
    }
    
    public static void Aquamarine1_1()
    {
        Console.WriteLine("[Aquamarine1_1]Aquamarine1_1[/]");
    }
    
    public static void Aquamarine3()
    {
        Console.WriteLine("[Aquamarine3]Aquamarine3[/]");
    }    
    
    public static void Black()
    {
        Console.WriteLine("[Black]Black[/]");
    }

    public static void Blue()
    {
        Console.WriteLine("[Blue]Blue[/]");
    }

    public static void Blue1()
    {
        Console.WriteLine("[Blue1]Blue1[/]");
    }

    public static void Blue3()
    {
        Console.WriteLine("[Blue3]Blue3[/]");
    }





    public static void Green()
    {
        Console.WriteLine("[green]green[/]");
    }

}