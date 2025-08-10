using System.Collections.Generic;
using System;
using System.Text.Json;
using Microsoft.VisualBasic;
using System.Globalization;
using System.Text.Json.Serialization;
using System.IO;
namespace game_commands;

class Commands
{

        string input = Console.ReadLine();
        // ProcessCommand(input);

    public static void ProcessCommand(string command)
    {
        Console.WriteLine("Welcome to the command line interface!");
        Console.WriteLine("Type 'help' to see a list of available commands.");
        switch (command.ToLower())
        {
            case "help":
                ShowHelp();
                break;
            case "exit":
                ExitGame();
                break;
            default:
                Console.WriteLine("Unknown command. Type 'help' for a list of commands.");
                break;
        }
    }
    public static void ShowHelp()
    {
        Console.WriteLine("Available commands:");
        Console.WriteLine("1. help - Show this help message");
        Console.WriteLine("2. exit - Exit the game");
        // Add more commands as needed
    }

    public static void ExitGame()
    {
        Console.WriteLine("Exiting the game. Goodbye!");
        Environment.Exit(0);
    }
}