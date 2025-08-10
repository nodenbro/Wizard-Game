namespace Wizard_Game;

using System.IO;
using gamefiles.config;
public class LoadGame
{
    // Loading Screen

    public void Load()
    {
        Console.WriteLine("Welcome to the Wizard Game! Would you like to continue your load game or would you like to start a new game? (Y/N)\n");
        string input = Console.ReadLine()?.ToLower();

        if (input == "y")
        {
            // Check if the save file exists
            if (File.Exists("gamefiles/saves/wizard_test05.json"))
            {
                try
                {
                    GameDelays loadDelay = new GameDelays();
                    loadDelay.loadDelay();
                    // Load the main game file
                    WizardGame game = new WizardGame();
                    game.Start();
                }
                catch (Exception err)
                {
                    Console.WriteLine("Error loading the game: " + err.Message);
                }
            }
            else
            {
                Console.WriteLine("No save file found. Starting a new game...\n");

                // Here you load the new game file after waiting for a few seconds to execute

                GameDelays startDelay = new GameDelays();
                startDelay.newGameDelay();

                WizardGame game = new WizardGame();
                game.Start();
                Console.ReadKey();
            }
        }
        else if (input == "n")
        {
            Console.WriteLine("Starting a new game...");
            // Here you load the new game file
            Console.ReadKey();
        }
    }
}