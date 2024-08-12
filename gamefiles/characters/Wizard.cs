using System.Collections.Generic;
using System;
using Microsoft.VisualBasic;
using System.Globalization;
namespace wizard_char;


class Wizard 
{
    public string name;
    public string affinity;
    private int mana;
    private int remainingMana;
    private float experience;

    private float expToLvlUp;
    private int level;


    public Wizard(string _name, string _affinity)
    {

        name = _name;

        affinity = _affinity;

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
                Console.WriteLine(name + " casts " + spells[rnd.Next(0, 7)] +"\n");
                Console.ForegroundColor = ConsoleColor.White;

                remainingMana -= 50;
                Console.WriteLine("\nYou have " + remainingMana + " mana\n");
                experience += 3;
            }
            else
            {
                Console.WriteLine("Oh no, " + name + " is out of blue juice.\n");
                Console.WriteLine("Quickly, replenish the mana. \n");
                Meditate();
            }

            if (experience >= expToLvlUp)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Congratulations " + name + " , you have Leveled Up.\n");

                level += 1;

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(name + " is now level " + level + "\n");
                Console.ForegroundColor = ConsoleColor.White;

                mana += 50;
                remainingMana = mana;

                experience -= expToLvlUp;

                expToLvlUp += 10;
            }
        }

        public void Meditate()
        {
            Console.WriteLine(name + " gathers mana from their surrounding and replenishes their mana.\n");
            remainingMana = mana;
            Console.WriteLine("Your mana is back to " + remainingMana + "\n");
        }
}