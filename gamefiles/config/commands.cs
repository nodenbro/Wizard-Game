namespace gamefiles.config;

using System;


class Commands
{

        // string input = Console.ReadLine();
        // ProcessCommand(input);
        

    public static void ProcessCommand(string command)
    {
        if (command == "!commands")
        {
            Console.WriteLine("Welcome to the command line interface!");
            Console.WriteLine("Type '!help' to see a list of available commands.");
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "!help":
                    ShowHelp();
                    break;
                case "!exit":
                    ExitGame();
                    break;
                default:
                    Console.WriteLine("Unknown command. Type '!help' for a list of commands.");
                    break;
            }
        }
    }
    public static void ShowHelp()
    {
        Console.WriteLine("Available commands:");
        Console.WriteLine("1. help - Show this help message");
        Console.WriteLine("2. exit - Exit the game");
        Console.Clear();
        
        return;
        // Add more commands as needed
    }

    public static void ExitGame()
    {
        Console.WriteLine("Exiting the game. Goodbye!");

        // Delay the exit text before closing
        Random random = new Random();
        int timeDelay = random.Next(2, 3);
        Thread.Sleep(timeDelay * 1000);

        Environment.Exit(0);
    }
}