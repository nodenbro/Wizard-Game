namespace gamefiles.epilogue;

using wizard_char;
using gamefiles.config;

class epilogue_chap_1
{
    public void StartEpilogueCh1(Wizard wizard)
    {
        

        Console.WriteLine("Epilogue Chapter 1 begins...");
        GameDelays.actionDelay();

        // Example of using the wizard object in the epilogue
        Console.WriteLine($"Welcome back, {wizard.Name}, to the epilogue of your journey!");
        GameDelays.actionDelay();

        // Additional epilogue logic can be added here

        epilogue_chap_2 epilogue2 = new epilogue_chap_2();
        epilogue2.StartEpilogueCh2(wizard);

        // Keep the console open
        Console.ReadKey();
    }
}