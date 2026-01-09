namespace MainMenu;

using System.IO;
using gamefiles.config;

class MainMenuOptions
{
    public void LoadOrNew()
    {
        Console.WriteLine("Welcome to the Wizard Game! You are in the main Menu, Would you like to continue your load game or would you like to start a new game? (Y/N)\n");
        string input = Console.ReadLine()?.ToLower();

        if (input == "y")
        {
            // Load existing game save
            LoadGame loadGame = new LoadGame();
            Console.Clear();
            loadGame.Load();
        }
        else if (input == "n")
        {
            Console.WriteLine("Starting a new game...");
            StartGame newGame = new StartGame();
            Console.Clear();
            newGame.NewGame();
            // Here you create a new game save file
            Console.ReadKey();
        }

    }
}