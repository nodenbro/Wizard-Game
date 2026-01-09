namespace MainMenu;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Title = "Wizard Game";
        MainMenuOptions mainMenu = new MainMenuOptions();
        mainMenu.LoadOrNew();
    }  
}