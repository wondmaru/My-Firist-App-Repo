using System;
namespace Lessons
{
    public class BottleOfBeer
    {

         


        
        public string BottleOfBeerSong()
        {
           
            int beernum = 99;
            string word = "bottles", result = "";
            

            while (beernum > 0)
            {
                if (beernum == 1)
                {
                    word = "bottle";
                }
                Console.WriteLine(beernum + " " + "of beer on the wall.");
                Console.WriteLine(beernum + " " + " of beer.");
                Console.WriteLine(" Take it one down");
                Console.WriteLine("Pass it around.");
                beernum--;
                if (beernum > 0)
                {
                    Console.WriteLine(beernum + " " + "of beer on the wall.");
                }
                else
                {
                    result = " No more bottles of beer on the wall";
                   
                }
            }
            return result;
        }
        public void BottleOfBeerSong(int numbeer, string can)
        {
            numbeer = 99;
             can = "bottles";
            for (int i = 99; i >= 1; i--)
            {
                Console.WriteLine(numbeer + can + "of beer on the wall.");
                Console.WriteLine(numbeer + can + " of beer.");
                Console.WriteLine(" Take it one down");
                Console.WriteLine("Pass it around.");
                numbeer--;
            }
            if (numbeer==1)
            {
               Console.WriteLine(numbeer + can + "of beer on the wall.");
 
            }
            else
            Console.WriteLine(" No more bottles of beer on the wall.");

        }
    }
}