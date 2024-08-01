using System;
using System.Collections.Generic;


class WizardGame 
{
    static void Main ()
    {
        string username;
        string affinity;

        Console.Title = "The Tales of a Young Wizard";
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Hello Young Wizard, my name is Aldros");
        Console.WriteLine("What is your name?");
        Console.ForegroundColor = ConsoleColor.White;
        username = Console.ReadLine();

        if(string.IsNullOrEmpty(username))
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            username = "The one without a Name";
            Console.WriteLine("Since you refuse to give me your name, I'll refer to you as " + username);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(username + ", you say?");
        }

        Console.WriteLine("That's a name befitting a Grand Wizard, I'm sure of it.");
        Console.WriteLine("There are six elements that exist.\n");

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Fire\n");

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Water\n");

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Earth\n");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Light\n");

        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Darkness\n");

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Lightning\n");


        bool incorrectAffinity = false;
        do{

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("What element are you feeling more connected with?");
            Console.ForegroundColor = ConsoleColor.White;
            affinity = Console.ReadLine() ?? "fire";
            string lcaseAffinity = affinity.ToLower();
            

            switch (lcaseAffinity)
            {

                case "fire":
                    Console.WriteLine("Aha, so you chose fire I see");
                    incorrectAffinity = false;
                    break;
                case "water":
                    Console.WriteLine("Aha, so you chose water I see");
                    incorrectAffinity = false;
                    break;
                case "earth":
                    Console.WriteLine("Aha, so you chose earth I see");
                    incorrectAffinity = false;
                    break;
                case "light":
                    Console.WriteLine("Aha, so you chose light I see");
                    incorrectAffinity = false;
                    break;
                case "darkness":
                    Console.WriteLine("Aha, so you chose darkness I see");
                    incorrectAffinity = false;
                    break;
                case "lightning":
                    Console.WriteLine("Aha, so you chose lightning I see");
                    incorrectAffinity = false;
                    break;
                default:
                    Console.WriteLine("Choose a proper Element please.");
                    Console.ReadKey();
                    incorrectAffinity = true;
                    break;
            }
        }while (incorrectAffinity != false);

        // Keep the console open
        Console.ReadKey();
    }
}
