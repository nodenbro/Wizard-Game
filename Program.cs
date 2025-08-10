using System;

namespace Wizard_Game;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Title = "Wizard Game";
        LoadGame loadGame = new LoadGame();
        loadGame.Load();
    }  
}