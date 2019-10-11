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
            Random rand = new Random();
            int randNum = rand.Next(1, 10);
            Console.WriteLine("Guess the number!!!");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number is {0}", number);
            
            while(number != randNum){
                Console.WriteLine("Incorrect the computer select {0}, guess again", randNum);
                randNum = rand.Next(1, 10);
                number = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Equal {0} and  {1}, good guess", randNum, number);
        
        }
    }
}
