namespace gamefiles.config;

using System;
using System.Text.Json;
using wizard_char;

public class AutoSave
{
    public static void SavingProgress(Wizard wizard)
    {
        // Serialize the object to JSON
        var options = new JsonSerializerOptions { WriteIndented = true };

        // Define the path where the JSON file will be saved
        string savePath = wizard.SavePath;

        // Serialize the wizard object to a JSON string
        string jsonString = JsonSerializer.Serialize(wizard, options);

        // Write the JSON string to a file
        File.WriteAllText(savePath, jsonString);

        // Output the JSON data
        Console.WriteLine("Game auto-saved successfully! ");
    }
}