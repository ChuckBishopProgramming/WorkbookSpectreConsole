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
        colors[3] = new string[] { "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkMagenta_1", "DarkOliveGreen1", "DarkOliveGreen1_1", "DarkOliveGreen2", "DarkOliveGreen3", "DarkOliveGreen3_1", "DarkOliveGreen3_2", "DarkOrange", "DarkOrange3", "DarkOrange3_1", "DarkRed", "DarkRed_1", "DarkSeaGreen", "DarkSeaGreen1", "DarkSeaGreen1_1", "DarkSeaGreen2", "DarkSeaGreen2_1", "DarkSeaGreen3", "DarkSeaGreen3_1", "DarkSeaGreen4", "DarkSeaGreen4_1", "DarkSlateGray1", "DarkSlateGray2", "DarkSlateGray3", "DarkTurquoise", "DarkViolet", "DarkViolet_1", "DeepPink1", "DeepPink1_1", "DeepPink2", "DeepPink3", "DeepPink3_1", "DeepPink4", "DeepPink4_1", "DeepSkyBlue1", "DeepSkyBlue2", "DeepSkyBlue3", "DeepSkyBlue3_1", "DeepSkyBlue4", "DeepSkyBlue4_1", "DeepSkyBlue4_2", "Default", "DodgerBlue1", "DodgerBlue2", "DodgerBlue3" };
        colors[4] = new string[] { "Fuchsia" };
        colors[5] = new string[] { "Gold1", "Gold3", "Gold3_1", "Gray", "Gray0", "Gray100", "Gray11", "Gray15", "Gray19", "Gray23", "Gray27", "Gray3", "Gray30", "Gray35", "Gray37", "Gray39", "Gray42", "Gray46", "Gray50", "Gray53", "Gray54", "Gray58", "Gray62", "Gray63", "Gray66", "Gray69", "Gray7", "Gray70", "Gray74", "Gray78", "Gray82", "Gray84", "Gray85", "Gray89", "Gray93", "Green", "Green1", "Green3", "Green3_1", "Green4", "GreenYellow", "Grey", "Grey0", "Grey100", "Grey11", "Grey15", "Grey19", "Grey23", "Grey27", "Grey3", "Grey30", "Grey35", "Grey37", "Grey39", "Grey42", "Grey46", "Grey50", "Grey53", "Grey54", "Grey58", "Grey62", "Grey63", "Grey66", "Grey69", "Grey7", "Grey70", "Grey74", "Grey78", "Grey82", "Grey84", "Grey85", "Grey89", "Grey93", };
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