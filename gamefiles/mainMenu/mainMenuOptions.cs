namespace MainMenu;

using System.Text.Json;
using wizard_char;
using System.IO;
using gamefiles.config;

class MainMenuOptions
{
    public void LoadOrNew()
    {
        Console.WriteLine("Welcome to the Wizard Game! You are in the main Menu, Would you like to continue your adventure or would you like to start anew? (Load/New)\n");
        string loadInput;
        bool isLoadNameTrue = false;
        string saveFilePath;
        string input = Console.ReadLine()?.ToLower();
        
        switch (input)
        {
            case "load":

                Console.WriteLine("Choose your savefile number to load (only nubmers bruv)");

                foreach (var file in Directory.GetFiles("gamefiles/saves", "wizard_*.json"))
                {

                    // Reads the JSON file into a string
                    string jsonString = File.ReadAllText(file);


                    // Turns the JSON string to a C# object
                    Wizard wizard = JsonSerializer.Deserialize<Wizard>(jsonString);

                    Console.WriteLine(wizard.Name);
                };

                loadInput = Console.ReadLine();



                // if (int.TryParse(loadInput, out _))
                // {
                //     while()

                //     if(loadNumberInput < 1 || loadInput != Directory.GetFiles("gamefiles/saves", "wizard_*.json"))
                //     {
                //             Console.WriteLine("Invalid savefile number. Come on man, choose a valid number for crying out loud");
                //             Console.ReadKey();
                //             return;
                //     }
                //     else
                //     {
                        
                //         Console.WriteLine("Loading your savefile number: " + loadNumberInput);

                //         // Load existing game save
                //         Console.ReadKey();
                //         LoadGame loadGame = new LoadGame();
                //         Console.Clear();
                //         loadGame.Load(loadNumberInput); 
                //     }
                // }



                foreach (var file in Directory.GetFiles("gamefiles/saves", "wizard_*.json"))
                {
                    // Reads the JSON file into a string
                    string jsonString = File.ReadAllText(file);


                    // Turns the JSON string to a C# object
                    Wizard wizard = JsonSerializer.Deserialize<Wizard>(jsonString);

                    if (wizard.Name == loadInput)
                    {
                        isLoadNameTrue = true;
                        Console.WriteLine("Loading your savefile number: " + loadInput);

                        // Load existing game save
                        Console.ReadKey();
                        LoadGame loadGame = new LoadGame();
                        Console.Clear();
                        saveFilePath = file;
                        loadGame.Load(loadInput, saveFilePath);
                        break;
                    }
                    else
                    {
                        isLoadNameTrue = false;
                    }
                };

                if (!isLoadNameTrue)
                {         
                    Console.WriteLine("Want to be a wizard? Try again with a valid savefile name or just make a new one man. Come on, try again");
                    GameDelays.actionDelay();

                    Console.WriteLine("Please enter a valid savefile name this time for the love of god:");
                    loadInput = Console.ReadLine();

                    foreach (var file in Directory.GetFiles("gamefiles/saves", "wizard_*.json"))
                    {
                        string jsonString = File.ReadAllText(file);
                        Wizard wizard = JsonSerializer.Deserialize<Wizard>(jsonString);
                        if (wizard.Name == loadInput)
                        {
                            isLoadNameTrue = true;
                            Console.WriteLine("Loading your savefile number: " + loadInput);

                            // Load existing game save
                            Console.ReadKey();
                            LoadGame loadGame = new LoadGame();
                            Console.Clear();
                            saveFilePath = file;
                            loadGame.Load(loadInput, saveFilePath);
                            break;
                        }
                        else
                        {
                            isLoadNameTrue = false;
                            Console.WriteLine("We just went through this... actually, never mind, I'll do it for you!");
                            GameDelays.actionDelay();
                            // Here you create a new game save file
                            Console.WriteLine("Starting a new game...");
                            StartGame forcedNewGame = new StartGame();
                            Console.Clear();
                            forcedNewGame.NewGame();
                            break;
                        }
                    }                 
                }
                break;

            case "new":
                // Here you create a new game save file
                Console.WriteLine("Starting a new game...");
                StartGame newGame = new StartGame();
                Console.Clear();
                newGame.NewGame();
                break;

            default:
                Console.WriteLine("Unknown command. Please type 'load' to continue your adventure or 'new' to start a new game.");
                // Console.ReadKey(); 
                break;
        }
    }
}