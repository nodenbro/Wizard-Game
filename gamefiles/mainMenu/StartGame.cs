namespace MainMenu;

using wizard_char;
using gamefiles.epilogue;
using gamefiles.config;
using System.Text.Json;
using System;

class StartGame
{
    // Starts a new game with a new wizard character

    //The variable is used as a placeholder for the savefile number to check if a savefile exists and add to it.
    int loadNumber = 1;
    public void NewGame()
    {
         // Set console title and color
        Console.Title = "The Tales of a Young Wizard";
        Console.ForegroundColor = ConsoleColor.White;

        // Greet the player and get their name
        string narrator = "Aldros";
        Console.WriteLine($"{narrator}: Hello Young Wizard, my name is Aldros!\n");

        Console.WriteLine($"{narrator}: What is your name, gallant wizard?\n");

        // Function to get player's name (with default if blank)

        string playerName = GetPlayerName();
        

        DescribeElements();

        string affinity = GetWizardAffinity();

        Wizard wizard = new Wizard(playerName, affinity);

        // Display the chosen affinity with corresponding color
        DisplayAffinity(affinity);

        // Serialize the object to JSON
        var options = new JsonSerializerOptions { WriteIndented = true };
        
        // Define the path where the JSON file will be saved
        while(File.Exists("gamefiles/saves/wizard_" + loadNumber + ".json"))
        {
            loadNumber++;
        }

        string filePath = "gamefiles/saves/wizard_" + loadNumber + ".json";

        wizard.SetSavePath(filePath);

        string jsonString = JsonSerializer.Serialize(wizard, options);

        // Write the JSON string to a file
        File.WriteAllText(filePath, jsonString);

        // Output the JSON data
        Console.WriteLine("Gamefile created successfully! " + filePath);

        GameLoader gameLoader = new GameLoader();
        gameLoader.StartQuest(wizard);
    }

        public static string GetPlayerName()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        string playerName = Console.ReadLine();

        if (playerName == "!commands")
        {
            Commands.ProcessCommand("!commands");
            playerName = "";
        }

        if (string.IsNullOrEmpty(playerName))
        {
            playerName = "The Grumpy One";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Since you refuse to give me your name, I'll refer to you as {playerName}");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"\n{playerName}, you say?");
        }
        return playerName;
    }

    // Function to describe the elements available

    public static void DescribeElements()
    {
        Console.WriteLine("There are six elements that exist.");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        // Console.WriteLine("Fire\nWater\nEarth\nLight\nDarkness\nLightning\n");

        // Dictionary mapping affinity to color
        var affinityColors = new Dictionary<string, ConsoleColor>
        {
            { "Fire", ConsoleColor.Red },
            { "Water", ConsoleColor.Blue },
            { "Earth", ConsoleColor.DarkGreen },
            { "Light", ConsoleColor.Yellow },
            { "Darkness", ConsoleColor.DarkMagenta },
            { "Lightning", ConsoleColor.Yellow }
        };

        foreach (var affinityColor in affinityColors)
        {
            Console.ForegroundColor = affinityColor.Value;
            Console.WriteLine("\n" + affinityColor.Key);
        }

    }

    // The function is used to get the wizard's affinity and ensure it's valid
    public static string GetWizardAffinity()
    {
        string[] validAffinities = { "fire", "water", "earth", "light", "darkness", "lightning" };
        bool isValid = false;
        string affinity = string.Empty;

        while (!isValid)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nWhat element are you feeling more connected with?\n");
            Console.ForegroundColor = ConsoleColor.White;
            affinity = Console.ReadLine()?.ToLower();

            if(affinity == "!commands")
            {
                Commands.ProcessCommand("!commands");
            }

            if (Array.Exists(validAffinities, element => element == affinity))
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine("\nChoose a valid element please.\n");
            }
        }
        return affinity;
    }

    // Function to display the affinity with the corresponding color
    public static void DisplayAffinity(string affinity)
    {
        // // Dictionary mapping affinity to color
        var affinityColors = new Dictionary<string, ConsoleColor>
        {
            { "fire", ConsoleColor.Red },
            { "water", ConsoleColor.Blue },
            { "earth", ConsoleColor.DarkGreen },
            { "light", ConsoleColor.Yellow },
            { "darkness", ConsoleColor.DarkMagenta },
            { "lightning", ConsoleColor.Yellow }
        };

        // Display message with corresponding color
        Console.ForegroundColor = affinityColors[affinity];
        Console.WriteLine($"Aha, so you chose {affinity} I see");
        Console.ForegroundColor = ConsoleColor.White;
        
    }
}