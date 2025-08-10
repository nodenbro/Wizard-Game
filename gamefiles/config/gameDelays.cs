using System;
namespace gamefiles.config;
public class GameDelays
{
    public void loadDelay()
    {
        Console.WriteLine("Loading your game...\n");
        Random random = new Random();
        int timeDelay = random.Next(2, 4);

        Thread.Sleep(timeDelay * 1000);

        Console.Clear();
    }

    public void newGameDelay()
    {
        Console.WriteLine("Starting new game...\n");
        Random random = new Random();
        int timeDelay = random.Next(2, 4);

        Thread.Sleep(timeDelay * 1000);

        Console.Clear();
    }
}