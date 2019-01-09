using System;
namespace Lessons
{
    public class BottleOfBeer
    {
        public string BottleOfBeerSong()
        {
            int beernum = 99;
            string word = "bottles" , result = "" ;
           
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
            return result ;
        }
    }
}