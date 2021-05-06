using System;
using System.Collections.Generic;
using System.Linq;


namespace Challenge_1
{
    class Program
    {

    // roll the dice - need to store dice roll inside function //

            static public int Random() {
            
            Random random = new Random();
            int dice = random.Next(1,7);
            return dice;
            }
            
            static void Main(string[] args)
            {

            Console.WriteLine("Press enter to roll the dice.");
            Console.ReadLine();
            Random random = new Random();
            int dice = random.Next(1,7);

    // storing dice rolls into array //

            List<int> DiceRoll = new List<int>();
            DiceRoll.Add(dice);

            int result = DiceRoll.Count();

            foreach (int dice in DiceRoll) {

    // asking user if they'd like to roll again //
                
                Console.WriteLine("Press the enter if you'd like to roll again.");
                string enter = Console.ReadLine();
                int anotherRoll = int.Parse(enter);
                int counter = 0;

                if (counter < anotherRoll ) {
                    break;

                }
                
                    else {

                    }
    // looping dice roll for each user input //

                while (counter < anotherRoll) {
                int counter2 = 0;


                }
            
            }






            


    
    




            
        }
    }
}
