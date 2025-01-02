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
        if (RemainingMana >= 50)
        {
            Random rnd = new Random();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(Name + " casts " + spells[rnd.Next(0, 7)] +"\n");
            Console.ForegroundColor = ConsoleColor.White;

            RemainingMana -= 50;
            Console.WriteLine("\nYou have " + RemainingMana + " Mana\n");
            Experience += 3;
        }
        else
        {
            Console.WriteLine("Oh no, " + Name + " is out of blue juice.\n");
            Console.WriteLine("Quickly, replenish the Mana. \n");
            Meditate();
        }

        if (Experience >= ExpToLvlUp)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Congratulations " + Name + " , you have LEVELED UP!.\n");

            Level += 1;

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(Name + " is now Level " + Level + "\n");
            Console.ForegroundColor = ConsoleColor.White;

            Mana += 50;
            RemainingMana = Mana;

            Experience -= ExpToLvlUp;

            ExpToLvlUp += 10;
        }
    }

    public void Meditate()
    {
        Console.WriteLine(Name + " gathers Mana from their surrounding and replenishes their Mana.\n");
        RemainingMana = Mana;
        Console.WriteLine("Your Mana is back to " + RemainingMana + "\n");
    }
}