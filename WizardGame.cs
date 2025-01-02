using System;
using System.IO;
using wizard_char;
using System.Text.Json;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;

class WizardGame 
{
    static void Main()
    {
        if(File.Exists("gamefiles/saves/wizard_test05.json"))
        {
            try
            {
                // Step 2: Define the path of the JSON file to read
                string filePath = "gamefiles/saves/wizard_test05.json";

                // Step 3: Read the JSON file into a string
                string jsonString = File.ReadAllText(filePath);
                Console.WriteLine(jsonString);

                // Step 4: Deserialize the JSON string to a C# object
                Wizard wizard = JsonSerializer.Deserialize<Wizard>(jsonString);

                // Step 5: Access the deserialized object properties
                Console.WriteLine($"Wizard's name: {wizard.Name}");
                Console.WriteLine($"Affinity: {wizard.Affinity}");

                wizard.CastSpell();

                wizard.CastSpell();

                wizard.CastSpell();

                Console.WriteLine($"Your level is: {wizard.Level}");

                Console.WriteLine($"Your Mana is: {wizard.Mana}");

                Console.WriteLine($"Your Remaining Mana is: {wizard.RemainingMana}");

                // Serialize the object to JSON
                var options = new JsonSerializerOptions { WriteIndented = true };
                string saveProgress = JsonSerializer.Serialize(wizard, options);

                // Define the path where the JSON file will be saved
                string saveFilePath = "gamefiles/saves/wizard_test05.json";

                // Write the JSON string to a file
                File.WriteAllText(saveFilePath, saveProgress);

                // Output the JSON data
                Console.WriteLine("Game saved created successfully!");

                // Do something with the person object
            }
            catch (Exception err)
            {
                Console.WriteLine($"Error reading or deserializing the file: {err.Message}");
            }
        }else
        {
            // Set console title and color
            Console.Title = "The Tales of a Young Wizard";
            Console.ForegroundColor = ConsoleColor.White;
            
            // Greet the player and get their name
            string narrator = "Aldros"; 
            Console.WriteLine($"{narrator}: Hello Young Wizard, my name is Aldros!\n");

            Console.WriteLine($"{narrator}: What is your name, gallant wizard?\n");
            string playerName = GetplayerName();



            // Describe the elements and ask for affinity
            DescribeElements();

            string affinity = GetWizardAffinity();

            // Store the player's name and affinity to the Wizard.cs file
            Wizard wizard01 = new Wizard(playerName, affinity);

            Console.WriteLine($"{wizard01.Level}");

            // Display the chosen affinity with corresponding color
            DisplayAffinity(affinity);

            // Serialize the object to JSON
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(wizard01, options);

            // Define the path where the JSON file will be saved
            string filePath = "gamefiles/saves/wizard_test05.json";

            // Write the JSON string to a file
            File.WriteAllText(filePath, jsonString);

            // Output the JSON data
            Console.WriteLine("Gamefile created successfully!");
            
        }
       

        
        // Keep the console open
        Console.ReadKey();
    }

    // Function to get player's name (with default if blank)
    static string GetplayerName()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        string playerName = Console.ReadLine();
        if (string.IsNullOrEmpty(playerName))
        {
            playerName = "nameless Zesty Wizaaaard";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Since you refuse to give me your name, I'll refer to you as {playerName}");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{playerName}, you say?");
        }
        return playerName;
    }

    // Function to describe the elements available
    static void DescribeElements()
    {
        Console.WriteLine("There are six elements that exist.\n");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Fire\nWater\nEarth\nLight\nDarkness\nLightning\n");
    }

    // Function to get the wizard's affinity and ensure it's valid
    static string GetWizardAffinity()
    {
        string[] validAffinities = { "fire", "water", "earth", "light", "darkness", "lightning" };
        bool isValid = false;
        string affinity = string.Empty;

        while (!isValid)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("What element are you feeling more connected with?\n");
            Console.ForegroundColor = ConsoleColor.White;
            affinity = Console.ReadLine()?.ToLower();

            if (Array.Exists(validAffinities, element => element == affinity))
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine("Choose a valid element please.\n");
            }
        }
        return affinity;
    }

    // Function to display the affinity with the corresponding color
    static void DisplayAffinity(string affinity)
    {
        // Dictionary mapping affinity to color
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
