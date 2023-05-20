/*
    Name: Christian Jay Putol  
    Date Created: 04/20/2023
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create an array called scores with a double data type
            double[] scores = new double[8];

            //also create a variable called sum for the total scores and also using a double data type
            double sum = 0;

            //this loop will repeatedly ask for the scores that judges gave and will stop until judge 8
            for(int i = 0; i<scores.Length; i++)
            {
                Console.Write($"Enter the score of judge [{i + 1}] : ");
                scores[i] = Convert.ToDouble(Console.ReadLine());
            }

            //this method is pre-defined method and this method will sort all the given scores from lowest to highest
            //Array.Sort(scores);

            //this array will remove the first and last scores from the sorted array and total it
            for(int j = 0; j<8; j++)
            {
                if (scores[j] > scores[j])
                sum += scores[j];
            }
            Console.WriteLine($"\nThe contestant receives a total of {sum:N2} points");
            Console.ReadKey();
        }
    }
}
