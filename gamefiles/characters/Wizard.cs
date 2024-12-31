using System.Collections.Generic;
using System;
using System.Text.Json;
using Microsoft.VisualBasic;
using System.Globalization;
using System.Text.Json.Serialization;
namespace wizard_char;


public class Wizard 
{
    [JsonPropertyName("name")]
    public string Name { get; set;}

    [JsonPropertyName("affinity")]
    public string Affinity { get; set;}
    private int mana;
    private int remainingMana;
    private float experience;
    private float expToLvlUp;
    private int level;

    [JsonConstructor]
    public Wizard(string name, string affinity)
    {

        Name = name ?? "Random Wizard Name";

        Affinity = affinity ?? "Random affinity";

        mana = 400;

        remainingMana = 400;

        experience = 0f;

        expToLvlUp = 3f;

        level = 1;
    }

    public void CastSpell()
    {
        string[] spells = 
            {
                "Pink Fire",
                "Midget Flame",
                "Dark Lords Semen",
                "My girlfriends anger issues",
                "i had no idea what to write here",
                "avadakadabra kurwaaa",
                "random bullshit go"
            };
        if (remainingMana >= 50)
        {
            Random rnd = new Random();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(Name + " casts " + spells[rnd.Next(0, 7)] +"\n");
            Console.ForegroundColor = ConsoleColor.White;

            remainingMana -= 50;
            Console.WriteLine("\nYou have " + remainingMana + " mana\n");
            experience += 3;
        }
        else
        {
            Console.WriteLine("Oh no, " + Name + " is out of blue juice.\n");
            Console.WriteLine("Quickly, replenish the mana. \n");
            Meditate();
        }

        if (experience >= expToLvlUp)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Congratulations " + Name + " , you have LEVELED UP!.\n");

            level += 1;

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(Name + " is now level " + level + "\n");
            Console.ForegroundColor = ConsoleColor.White;

            mana += 50;
            remainingMana = mana;

            experience -= expToLvlUp;

            expToLvlUp += 10;
        }
    }

    public void Meditate()
    {
        Console.WriteLine(Name + " gathers mana from their surrounding and replenishes their mana.\n");
        remainingMana = mana;
        Console.WriteLine("Your mana is back to " + remainingMana + "\n");
    }
}