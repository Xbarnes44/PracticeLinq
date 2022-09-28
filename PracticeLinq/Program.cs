using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqPractice
{
    class program
    {
        public static void Main(string[] args)
        {
            var videogames = new List<string> {"Call of duty", "Halo", "Zelda", "Apex legends" } ;

            var gameLength = videogames.OrderBy(videogames => videogames.Length);

            foreach (var x in gameLength)
            {
                Console.WriteLine(x);
            }
        }
    }
}