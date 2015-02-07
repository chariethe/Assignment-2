using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class SuperHero : Hero
    {
        //PRIVATE PROPERTIES
        private bool strength = true;
        private bool speed = true;
        private bool health = true;

        public SuperHero(int strength, int speed, int health, string name): base(name)
        {
            this.name = name;
            this.showPowers();
        }
        public void showPowers() 
        {
            Console.WriteLine("Super Powers!");
        }

        //CONSTRUCTOR METHOD
        public static void main(string[] args)
        {
            string[] superPowers = { "Super Speed", "Super Strength", "Body Armour", "Flight", "Fire Generation", "Weather Control" };
            // Literal Notation or Array Initializer
            string[] tempArray = new string[superPowers.Length];
            string[] finalArray = new string[3];
            // constructor Notation
            Random rnd = new Random();
            int randomPowers;

            for (int powers=0; powers < superPowers.Length; powers++ )
            {
                tempArray[powers] = superPowers[powers];
            }
            int index = 0;
            while (index < finalArray.Length)
            {
                randomPowers = generateRandomPowers(rnd, superPowers.Length); // Generate random number
                if (tempArray[randomPowers] != "unavailable")
                {
                    finalArray[index] = tempArray[randomPowers];
                    tempArray[randomPowers] = "unavailable";
                    index++;
                }
            }
            Console.WriteLine("Super Powers");
            Console.WriteLine("------------");
            
            for (index = 0; index < superPowers.Length; index++)
                {
                    Console.WriteLine(superPowers[index]);
                }

            Console.WriteLine("New Super Powers");
            Console.WriteLine("----------------");
            for (index = 0; index < finalArray.Length; index++)
                {
                    Console.WriteLine(finalArray[index]);
                }
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            }
            private static int generateRandomPowers(Random rnd, int max)
                {
                    int number;
                    number = rnd.Next(max);
                    return number;
                }

    }
}
