using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Cake_Ingr
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredient = "";
            var countOfIngredient = 0;

            do
            {
                ingredient = Console.ReadLine();
                if (ingredient != "Bake!")
                {
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                    countOfIngredient++;
                }
                
            } while (ingredient != "Bake!");
            
            Console.WriteLine($"Preparing cake with {countOfIngredient} ingredients.");
        }
    }
}
