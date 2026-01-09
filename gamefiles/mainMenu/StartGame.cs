namespace MainMenu;

using wizard_char;
using gamefiles.epilogue;
using System.Text.Json;
using System;

class StartGame
{
    // New game start method
    public void NewGame()
    {
         // Set console title and color
        Console.Title = "The Tales of a Young Wizard";
        Console.ForegroundColor = ConsoleColor.White;

        // Greet the player and get their name
        string narrator = "Aldros";
        Console.WriteLine($"{narrator}: Hello Young Wizard, my name is Aldros!\n");

        Console.WriteLine($"{narrator}: What is your name, gallant wizard?\n");
        string playerName = WizardGame.GetplayerName();
        



        // Describe the elements and ask for affinity
        WizardGame.DescribeElements();

        string affinity = WizardGame.GetWizardAffinity();

        // Store the player's name and affinity to the Wizard.cs file
        Wizard wizard01 = new Wizard(playerName, affinity);

        Console.WriteLine($"{wizard01.Level}");

        // Display the chosen affinity with corresponding color
        WizardGame.DisplayAffinity(affinity);

        // Serialize the object to JSON
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(wizard01, options);

        // Define the path where the JSON file will be saved
        string filePath = "gamefiles/saves/wizard_test05.json";

        // Write the JSON string to a file
        File.WriteAllText(filePath, jsonString);

        // Output the JSON data
        Console.WriteLine("Gamefile created successfully!");

        epilogue_chap_1 epilogue = new epilogue_chap_1();
        epilogue.StartEpilogueCh1(wizard01);
    }
}