namespace MainMenu;

using System.IO;
using gamefiles.config;
using wizard_char;
using System.Text.Json;
// using gamefiles.epilogue;
public class LoadGame
{
    // Loading Screen

    public void Load(int loadNumber)
    {
        // Console.WriteLine("Welcome to the Wizard Game! Would you like to continue your load game or would you like to start a new game? (Y/N)\n");
        // string input = Console.ReadLine()?.ToLower();

        // if (input == "y")
        // {

            

            // Check if the save file exists
            if (File.Exists("gamefiles/saves/wizard_" + loadNumber + ".json"))
            {
                try
                {
                    Console.WriteLine("The path is: " + "gamefiles/saves/wizard_" + loadNumber + ".json");
                    GameDelays.loadDelay();
                    // Load the main game file

            try
            {
                // Defines the path of the JSON savefile to read
                string filePath = "gamefiles/saves/wizard_" + loadNumber + ".json";

                // Reads the JSON file into a string
                string jsonString = File.ReadAllText(filePath);


                // Step 4: Deserializes the JSON string to a C# object
                Wizard wizard = JsonSerializer.Deserialize<Wizard>(jsonString);

                // Uses the deserialized object to use the properties as well as add delay
                Console.WriteLine($"Wizard's name: {wizard.Name}");
                Console.WriteLine($"Affinity: {wizard.Affinity}");

                wizard.CastSpell();
                GameDelays.actionDelay();

                wizard.CastSpell();
                GameDelays.actionDelay();

                wizard.CastSpell();
                GameDelays.actionDelay();

                Console.WriteLine($"Your level is: {wizard.Level}");
                GameDelays.actionDelay();

                Console.WriteLine($"Your Mana is: {wizard.Mana}");
                GameDelays.actionDelay();

                Console.WriteLine($"Your Remaining Mana is: {wizard.RemainingMana}");
                GameDelays.actionDelay();

                // Serialize the object to JSON
                var options = new JsonSerializerOptions { WriteIndented = true };
                string saveProgress = JsonSerializer.Serialize(wizard, options);

                // Define the path where the JSON file will be saved
                string saveFilePath = "gamefiles/saves/wizard_" + loadNumber + ".json";

                // Write the JSON string to a file
                File.WriteAllText(saveFilePath, saveProgress);

                // Output the JSON data
                Console.WriteLine("Game saved successfully!");

            }
            catch (Exception err)
            {
                Console.WriteLine($"Error reading or deserializing the file: {err.Message}");
            }

                    // WizardGame game = new WizardGame();
                    // game.Start();
                }
                catch (Exception err)
                {
                    Console.WriteLine("Error loading the game: " + err.Message);
                }
            }
            else
            {
                Console.WriteLine(loadNumber);
                Console.WriteLine("No save file found. Starting a new game...\n");

                // Here you load the new game file after waiting for a few seconds to execute

                GameDelays.newGameDelay();

                StartGame game = new StartGame();
                game.NewGame();
                Console.ReadKey();
            }
        // }
        // else if (input == "n")
        // {
        //     Console.WriteLine("Starting a new game...");
        //     StartGame newGame = new StartGame();
        //     newGame.NewGame();
        //     // Here you load the new game file
        //     Console.ReadKey();
        // }
    }
}