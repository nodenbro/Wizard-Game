using System.Text.Json.Serialization;
using System.Linq;

namespace wizard_char;

public class Wizard 
{
    [JsonPropertyName("name")]
    public string Name { get; set;}

    [JsonPropertyName("affinity")]
    public string Affinity { get; set;}

    [JsonPropertyName("mana")]
    public int Mana { get; set;}

    [JsonPropertyName("remainingMana")]
    public int RemainingMana { get; set;}

    [JsonPropertyName("experience")]
    public float Experience { get; set;}

    [JsonPropertyName("expToLvlUp")]
    public float ExpToLvlUp { get; set;}

    [JsonPropertyName("level")]
    public int Level { get; set;}
    
    [JsonPropertyName("savepath")]
    public string SavePath { get; set;}

    [JsonConstructor]
    public Wizard(string name, string affinity)
    {

        Name = name;

        Affinity = affinity;

        Mana = 400;

        RemainingMana = 400;

        Experience = 0f;

        ExpToLvlUp = 3f;

        Level = 1;

        SavePath = "";
    }

    public void CastSpell()
    {
        var spellCost = new Dictionary<string, int>
        {
            { "HUUUUGE small fireball", 5},
            { "FUS RO DUH", 32},
            { "Dark Lord's Semen", 69},
            { "My girlfriend's anger issues", 74},
            { "i had no idea what to write here", 99},
            { "Xanax Attack", 1500},
            { "random bullshit go", 510},
            { "Zeus, your son has returned... wrong move, just shoot fireball or something", 777}
        };
            
        if (RemainingMana > 50)
        {
            // Random rnd = new Random();
            // Console.ForegroundColor = ConsoleColor.Magenta;
            // Console.WriteLine($"{Name} casts {spells[rnd.Next(0, 7)]}\n");
            // Console.ForegroundColor = ConsoleColor.White;

            Random randomNum = new Random();

            KeyValuePair<string, int> randomSpell = spellCost.ElementAt(randomNum.Next(spellCost.Count - 1));

            // var testingSpell = spell[randomNum.Next(0, 7)];

            if(randomSpell.Value > RemainingMana)
            {
                Console.WriteLine($"Nice try, bucko, but you don't have enough Mana for this one.\n");
                Console.WriteLine("Quickly, replenish the Mana. \n");
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"{Name} casts {randomSpell.Key} which costs {randomSpell.Value} Mana.\n");
                Console.ForegroundColor = ConsoleColor.White;
                RemainingMana -= randomSpell.Value;
            }

            
            Console.WriteLine($"\nYou have {RemainingMana}/{Mana} Mana\n");
            Experience += 3;
        }
        else
        {
            Console.WriteLine($"Oh no, {Name} is out of blue juice.\n");
            Console.WriteLine("Quickly, replenish the Mana. \n");
            Meditate();
        }

        if (Experience >= ExpToLvlUp)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Congratulations {Name}, you have LEVELED UP!.\n");

            Level += 1;

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{Name} is now Level {Level}\n");
            Console.ForegroundColor = ConsoleColor.White;

            Mana += 50;
            RemainingMana = Mana;

            Experience -= ExpToLvlUp;

            ExpToLvlUp += 10;
        }
    }

    public void Meditate()
    {
        Console.WriteLine($"{Name} gathers Mana from their surrounding and replenishes their Mana.\n");
        RemainingMana = Mana;
        Console.WriteLine($"Your Mana is back to {RemainingMana}/{Mana}\n");
    }

    public void SetSavePath(string saveFilePath)
    {
        SavePath = saveFilePath;
    }
}