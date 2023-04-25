using CompilerRunner.Worker;
using Spectre.Console;
using static System.Net.Mime.MediaTypeNames;

public static class Program {
    public static void Main(string[] args)
    {
        Tui myTui = new Tui();
        myTui.MainMenu();
        

    }
}