using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            GuessingGame();

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        static void GuessingGame() {

            int number;
            Random rand = new Random(); //Create Random number
            int randNum = rand.Next(1, 11); //Random numbers from 1 to 10
            Console.WriteLine("Guess what number I'm thinking!!!");
            number = Convert.ToInt32(Console.ReadLine());
       
            while(number != randNum){ //Will run until both the machine and the user number are equal
                Console.WriteLine("Incorrect, I was thinking of {0}, guess again", randNum);
                randNum = rand.Next(1, 11);
                number = Convert.ToInt32(Console.ReadLine());
                if(number <= 0 || number > 10){ //Will check if number selected by user is between 1 to 10
                    Console.WriteLine("Nope, I'm thinking between 1 and 10");
                }
            }
            Console.WriteLine("Yes, I was thinking of {0}, \"WINNER\"", randNum);
        
        }
    }
}
