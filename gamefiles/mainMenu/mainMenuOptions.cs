namespace MainMenu;

using System.IO;
using gamefiles.config;

class MainMenuOptions
{
    public int loadNumberInput { get; set; }
    public void LoadOrNew()
    {
        Console.WriteLine("Welcome to the Wizard Game! You are in the main Menu, Would you like to continue your adventure or would you like to start anew? (Load/New)\n");
        string loadInput;
        string input = Console.ReadLine()?.ToLower();
        
        switch (input)
        {
            case "load":

                Console.WriteLine("Choose your savefile number to load (only nubmers bruv)");
                foreach (var file in Directory.GetFiles("gamefiles/saves", "wizard_*.json"))
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    Console.WriteLine(fileName.Replace("wizard_", ""));
                };

                // int loadNumberInput = int.Parse(Console.ReadLine());

                loadInput = Console.ReadLine();


                if (int.TryParse(loadInput, out _))
                {
                    loadNumberInput = int.Parse(loadInput);

                    if(loadNumberInput < 1 || loadNumberInput > Directory.GetFiles("gamefiles/saves", "wizard_*.json").Length)
                        {
                            Console.WriteLine("Invalid savefile number. Come on man, choose a valid number for crying out loud");
                            Console.ReadKey();
                            return;
                        }
                        else
                    {
                        
                        Console.WriteLine("Loading your savefile number: " + loadNumberInput);

                        // Load existing game save
                        Console.ReadKey();
                        LoadGame loadGame = new LoadGame();
                        Console.Clear();
                        loadGame.Load(loadNumberInput); 
                    }
                }
                else
                {
                    Console.WriteLine("Aren't you a sneaky rule breaker. Choose a number now");
                    Console.ReadKey();
                    return;
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
                Console.ReadKey(); 
                break;
        }
    }
}