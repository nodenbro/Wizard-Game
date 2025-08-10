using wizard_char;

class WizardGame_oldCode 
{
    static void Old_code ()
    {
        Console.Title = "The Tales of a Young Wizard";
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Hello Young Wizard, my name is Aldros!");
        string narrator = "Aldros"; 

        Console.WriteLine(narrator + ": What is your name galiant wizard?\n");
        string player1 = "\n" +  Console.ReadLine() ;

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

        // wizard01.CastSpell();

        Console.WriteLine("That's a name befitting a Grand Wizard, I'm sure of it.\n");
        Console.WriteLine("There are six elements that exist.\n");

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Fire\n" + "Water\n" + "Earth\n" + "Light\n" + "Darkness\n" + "Lightning\n");

        Random rnd = new Random();
        Console.WriteLine("What is your affinity, yound wizard!");
        Wizard wizard01 = new Wizard(player1, Console.ReadLine());

        // Console.ForegroundColor = ConsoleColor.DarkBlue;
        // Console.WriteLine("Water\n");

        // Console.ForegroundColor = ConsoleColor.DarkGreen;
        // Console.WriteLine("Earth\n");

        // Console.ForegroundColor = ConsoleColor.Yellow;
        // Console.WriteLine("Light\n");

        // Console.ForegroundColor = ConsoleColor.DarkGray;
        // Console.WriteLine("Darkness\n");

        // Console.ForegroundColor = ConsoleColor.DarkYellow;
        // Console.WriteLine("Lightning\n");

        bool incorrectAffinity = false;
        do{

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("What element are you feeling more connected with?\n");
            Console.ForegroundColor = ConsoleColor.White;
            wizard01.Affinity = Console.ReadLine();

            string lcaseAffinity = wizard01.Affinity.ToLower();

            switch (lcaseAffinity)
            {

                case "fire":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Aha, so you chose fire I see");
                    Console.ForegroundColor = ConsoleColor.White;

                    incorrectAffinity = false;
                    break;
                case "water":

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Aha, so you chose water I see");
                    Console.ForegroundColor = ConsoleColor.White;

                    incorrectAffinity = false;
                    break;
                case "earth":

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Aha, so you chose earth I see");
                    Console.ForegroundColor = ConsoleColor.White;

                    incorrectAffinity = false;
                    break;
                case "light":

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Aha, so you chose light I see");
                    Console.ForegroundColor = ConsoleColor.White;

                    incorrectAffinity = false;
                    break;
                case "darkness":

                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Aha, so you chose darkness I see");
                    Console.ForegroundColor = ConsoleColor.White;

                    incorrectAffinity = false;
                    break;
                case "lightning":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Aha, so you chose lightning I see");
                    Console.ForegroundColor = ConsoleColor.White;

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