using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using wizard_namespace;


class WizardGame 
{
    static void Main ()
    {
        Console.WriteLine("What is your name galiant wizard");
        string player1 = Console.ReadLine();
        player1 = string.IsNullOrEmpty(player1) ? "Nameless Zesty Wizaaaard" : player1;

        Random rnd = new Random();

        Wizard wizard01 = new Wizard(player1, Console.ReadLine());

        Console.WriteLine(wizard01.affinity);

        // Console.Title = "The Tales of a Young Wizard";
        // Console.ForegroundColor = ConsoleColor.DarkRed;
        // Console.WriteLine("Hello Young Wizard, my name is Aldros");
        // Console.WriteLine("What is your name?");
        // Console.ForegroundColor = ConsoleColor.White;
        // username = Console.ReadLine();

        if(string.IsNullOrEmpty(player1))
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            player1 = "Nameless Zesty Wizaaaard";
            Console.WriteLine("Since you refuse to give me your name, I'll refer to you as " + player1);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(player1 + ", you say?");
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
            Console.WriteLine("What element are you feeling more connected with?\n");
            Console.ForegroundColor = ConsoleColor.White;
            wizard01.affinity = Console.ReadLine();
            string lcaseAffinity = wizard01.affinity.ToLower();

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
                    Console.WriteLine("Choose a proper Element please.\n");
                    // Console.ReadKey();
                    incorrectAffinity = true;
                    break;
            }
        }while (incorrectAffinity != false);

        // Keep the console open
        Console.ReadKey();
    }
}
