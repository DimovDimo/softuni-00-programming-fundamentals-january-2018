using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Pokemon_Evolution
{
    class Evolutions
    {
        public string Type { get; set; }
        public int Index { get; set; }//long
    }

    class Pokemon
    {
        public string Name { get; set; }
        public List<Evolutions> Evolutions { get; set; }
        //public List<string> Evolutions { get; set; }
        //public Evolutions Evolution { get; set; }
        //public List<Evolutions> Evolutions { get; set; }
        //public List<Evolutions> AddToEvolutionsCurrentEvolution()
        //{
        //    var newEvolutions = new List<Evolutions>();
        //    foreach (var item in Evolutions)
        //    {
        //        newEvolutions.Add(item);
        //    }
        //
        //    newEvolutions.Add(Evolution);
        //    return newEvolutions;
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            var pokemons = new List<Pokemon>();
            var line = Console.ReadLine();
            var patternNewPokemon = @"(.+) -> (.+) -> (.+)";
            while (line != "wubbalubbadubdub")
            {
                if (Regex.IsMatch(line, patternNewPokemon))
                {
                    MatchCollection matches = Regex.Matches(line, patternNewPokemon);
                    var currentPokemon = new Pokemon();
                    currentPokemon.Name = matches[0].Groups[1].Value;
                    var currentEvolution = new Evolutions();
                    currentEvolution.Type = matches[0].Groups[2].Value;
                    currentEvolution.Index = int.Parse(matches[0].Groups[3].Value);
                    var evolutions = new List<Evolutions>();
                    evolutions.Add(currentEvolution);
                    currentPokemon.Evolutions = evolutions;
                    if (pokemons.Any(x => x.Name == currentPokemon.Name) == false)
                    {
                        pokemons.Add(currentPokemon);
                    }
                    else
                    {
                        var pokemonFirst = pokemons.First(x => x.Name == currentPokemon.Name);
                        pokemonFirst.Evolutions.Add(currentEvolution);
                    }
                }
                else
                {
                    if (pokemons.Any(x => x.Name == line))
                    {
                        var pokemonFirst = pokemons.First(x => x.Name == line);
                        Console.WriteLine($"# {pokemonFirst.Name}");
                        foreach (var evolution in pokemonFirst.Evolutions)
                        {
                            Console.WriteLine($"{evolution.Type} <-> {evolution.Index}");
                        }
                    }
                }

                line = Console.ReadLine();
            }

            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"# {pokemon.Name}");
                foreach (var evolution in pokemon.Evolutions.OrderByDescending(x => x.Index))// without thenby
                {
                    Console.WriteLine($"{evolution.Type} <-> {evolution.Index}");
                }
            }
        }
    }
}
