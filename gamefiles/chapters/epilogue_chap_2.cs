namespace gamefiles.epilogue;

using wizard_char;
using gamefiles.config;

class epilogue_chap_2
{
    public void StartEpilogueCh2(Wizard wizard)
    {
        

        Console.WriteLine("Epilogue Chapter 2 begins...");
        GameDelays.actionDelay();

        // Example of using the wizard object in the epilogue
        Console.WriteLine($"Welcome back, {wizard.Name}, to the continuation of your journey!");
        GameDelays.actionDelay();

        // Additional epilogue logic can be added here

        

        // Keep the console open
        Console.ReadKey();
    }
}