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
        string[][] colors = new string[19][]; //will be less than 26 not all letters of alphabet used
        colors[0] = new string[] { "Aqua", "Aquamarine1", "Aquamarine1_1", "Aquamarine3" };
        colors[1] = new string[] { "Black", "Blue", "Blue1", "Blue3", "Blue3_1", "BlueViolet"};
        colors[2] = new string[] { "CadetBlue", "CadetBlue_1", "Chartreuse1", "Chartreuse2", "Chartreuse2_1", "Chartreuse3", "Chartreuse3_1", "Chartreuse4", "CornflowerBlue", "Cornsilk1", "Cyan", "Cyan2", "Cyan3" };
        colors[3] = new string[] { "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkMagenta_1", "DarkOliveGreen1", "DarkOliveGreen1_1", "DarkOliveGreen2", "DarkOliveGreen3", "DarkOliveGreen3_1", "DarkOliveGreen3_2", "DarkOrange", "DarkOrange3", "DarkOrange3_1", "DarkRed", "DarkRed_1", "DarkSeaGreen", "DarkSeaGreen1", "DarkSeaGreen1_1", "DarkSeaGreen2", "DarkSeaGreen2_1", "DarkSeaGreen3", "DarkSeaGreen3_1", "DarkSeaGreen4", "DarkSeaGreen4_1", "DarkSlateGray1", "DarkSlateGray2", "DarkSlateGray3", "DarkTurquoise", "DarkViolet", "DarkViolet_1", "DeepPink1", "DeepPink1_1", "DeepPink2", "DeepPink3", "DeepPink3_1", "DeepPink4", "DeepPink4_1", "DeepSkyBlue1", "DeepSkyBlue2", "DeepSkyBlue3", "DeepSkyBlue3_1", "DeepSkyBlue4", "DeepSkyBlue4_1", "DeepSkyBlue4_2", "Default", "DodgerBlue1", "DodgerBlue2", "DodgerBlue3" };
        colors[4] = new string[] { "Fuchsia" };
        colors[5] = new string[] { "Gold1", "Gold3", "Gold3_1", "Gray", "Gray0", "Gray100", "Gray11", "Gray15", "Gray19", "Gray23", "Gray27", "Gray3", "Gray30", "Gray35", "Gray37", "Gray39", "Gray42", "Gray46", "Gray50", "Gray53", "Gray54", "Gray58", "Gray62", "Gray63", "Gray66", "Gray69", "Gray7", "Gray70", "Gray74", "Gray78", "Gray82", "Gray84", "Gray85", "Gray89", "Gray93", "Green", "Green1", "Green3", "Green3_1", "Green4", "GreenYellow", "Grey", "Grey0", "Grey100", "Grey11", "Grey15", "Grey19", "Grey23", "Grey27", "Grey3", "Grey30", "Grey35", "Grey37", "Grey39", "Grey42", "Grey46", "Grey50", "Grey53", "Grey54", "Grey58", "Grey62", "Grey63", "Grey66", "Grey69", "Grey7", "Grey70", "Grey74", "Grey78", "Grey82", "Grey84", "Grey85", "Grey89", "Grey93", };
        colors[6] = new string[] { "HoneyDew2", "HotPink", "HotPink_1", "HotPink2", "HotPink3", "HotPink3_1" };
        colors[7] = new string[] { "IndianRed", "IndianRed_1", "IndianRed1", "IndianRed1_1" };        
        colors[8] = new string[] { "Khaki1", "Khaki3" };
        colors[9] = new string[] { "LightCoral", "LightCyan1", "LightCyan3", "LightGoldenrod1", "LightGoldenrod2", "LightGoldenrod2_1", "LightGoldenRod2_2", "LightGoldenrod3", "LightGreen", "LightGreen_1", "LightPink1", "LightPink3", "LightPink4", "LightSalmon1", "LightSalmon3", "LightSalmon3_1", "LightSeaGreen", "LightSkyBlue1", "LightSkyBlue3", "LightSkyBlue3_1", "LightSlateBlue", "LightSlateGrey", "LightSteelBlue", "LightSteelBlue1", "LightSteelBlue3", "LightYellow3", "Lime" };
        colors[10] = new string[] { "Magenta", "Magenta1", "Magenta2", "Magenta2_1", "Magenta3", "Magenta3_1", "Magenta3_2", "Maroon", "MediumOrchid", "MediumOrchid1", "MediumOrchid1_1", "MediumOrchid3", "MediumPurple", "MediumPurple1", "MediumPurple2", "MediumPurple2_1", "MediumPurple3", "MediumPurple3_1", "MediumPurple4", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MistyRose1", "MistyRose3" };
        colors[11] = new string[] { "NavajoWhite1", "NavajoWhite3", "Navy", "NavyBlue" };
        colors[12] = new string[] { "Olive", "Orange1", "Orange3", "Orange4", "Orange4_1", "OrangeRed1", "Orchid", "Orchid1", "Orchid2" };
        colors[13] = new string[] { "PaleGreen1", "PaleGreen1_1", "PaleGreen3", "PaleGreen3_1", "PaleTurquoise1", "PaleTurquoise4", "PaleVioletRed1", "Pink1", "Pink3", "Plum1", "Plum2", "Plum3", "Plum4", "Purple", "Purple_1", "Purple_2", "Purple3", "Purple4", "Purple4_1", "Red", "Red1", "Red3", "Red3_1", "RosyBrown", "RoyalBlue1" };
        colors[14] = new string[] { "Salmon1", "SandyBrown", "SeaGreen1", "SeaGreen1_1", "SeaGreen2", "SeaGreen3", "Silver", "SkyBlue1", "SkyBlue2", "SkyBlue3", "SlateBlue1", "SlateBlue3", "SlateBlue3_1", "SpringGreen1", "SpringGreen2", "SpringGreen2_1", "SpringGreen3", "SpringGreen3_1", "SpringGreen4", "SteelBlue", "SteelBlue1", "SteelBlue1_1", "SteelBlue3" };
        colors[15] = new string[] { "Tan", "Teal", "Thistle1", "Thistle3", "Turquoise2", "Turquoise4" };
        colors[16] = new string[] { "Violet" };
        colors[17] = new string[] { "Wheat1", "Wheat4", "White" };
        colors[18] = new string[] { "Yellow", "Yellow1", "Yellow2", "Yellow3", "Yellow3_1", "Yellow4", "Yellow4_1" };
        

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