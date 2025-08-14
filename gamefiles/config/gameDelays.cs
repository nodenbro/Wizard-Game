using System;
namespace gamefiles.config;

public class GameDelays
{
    public static void loadDelay()
    {
        Console.WriteLine("Loading your game...\n");
        Random random = new Random();
        int timeDelay = random.Next(2, 4);

        Thread.Sleep(timeDelay * 1000);

        Console.Clear();
    }

    public static void newGameDelay()
    {
        Console.WriteLine("Starting new game...\n");
        Random random = new Random();
        int timeDelay = random.Next(2, 4);

        Thread.Sleep(timeDelay * 1000);

        Console.Clear();
    }

    public static void actionDelay()
    {
        Random random = new Random();
        int timeDelay = random.Next(1, 2);

        Thread.Sleep(timeDelay * 1000);
    }
}