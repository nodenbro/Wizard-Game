namespace MainMenu;

using System.IO;
using wizard_char;
using System.Text.Json;
using gamefiles.config;
using gamefiles.epilogue;


class GameLoader 
{  
    epilogue_chap_1 epilogue = new epilogue_chap_1();
    // Starts the game
    public void StartQuest(Wizard wizard)
    {
        Console.WriteLine("I'm inside the GameLoader class and the StartQuest method, and I have access to the wizard object passed from LoadGame.cs");

        Console.WriteLine($"Wizard's name: {wizard.Name}");
        Console.WriteLine($"Affinity: {wizard.Affinity}");  

        
        epilogue.StartEpilogueCh1(wizard);

        // Keep the console open
        Console.ReadKey();
    }

    public void ChapterLoader(Wizard wizard)
    {
        
    }
}
