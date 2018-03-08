using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = new Dictionary<string, int>();
            var playersCadrs = new Dictionary<string, string>();
            while (true)
            {
                //{name} – > {email} 
                var name = Console.ReadLine();
                if (name == "JOKER")
                {
                    players = GetValuesOfPlayers(playersCadrs);
                    foreach (var pair in players)
                    {
                        Console.WriteLine($"{pair.Key}: {pair.Value}");
                    }

                    return;
                }
                
                var separted = name
                    .Split(':')
                    .ToList();
                var namePlayer = separted[0];
                var cards = separted[1];
                if (playersCadrs.ContainsKey(namePlayer) == false)
                {
                    playersCadrs.Add(namePlayer, "");
                }

                playersCadrs[namePlayer] += cards;
            }
        }

        static Dictionary<string, int> GetValuesOfPlayers(Dictionary<string, string> players)
        {
            var valuesOfPlayers = new Dictionary<string, int>();
            foreach (var player in players)
            {
                var cards = player.Value
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .ToList();
                var pointsPlayer = 0;
                foreach (var card in cards)
                {
                    char firstElement = card[0];
                    int points = 0;
                    switch (firstElement)
                    {
                        case 'A':
                            points = 14;
                            break;
                        case 'K':
                            points = 13;
                            break;
                        case 'Q':
                            points = 12;
                            break;
                        case 'J':
                            points = 11;
                            break;
                        case '1':
                            points = 10;
                            break;
                        default:
                            points = int.Parse(firstElement.ToString());
                            break;
                    }

                    char lastElement = card[card.Length - 1];
                    switch (lastElement) //(S -> 4, H-> 3, D -> 2, C -> 1).
                    {
                        case 'S':
                            points *= 4;
                            break;
                        case 'H':
                            points *= 3;
                            break;
                        case 'D':
                            points *= 2;
                            break;
                        case 'C':
                            points *= 1;
                            break;
                        default:
                            points *= 0;
                            break;
                    }

                    pointsPlayer += points;
                }

                valuesOfPlayers.Add(player.Key, pointsPlayer);
            }

            return valuesOfPlayers;
        }

        static int GetPower(string powerChar)
        {
            int power = 0;
            switch (powerChar)
            {
                case "J":
                    power = 11;
                    break;
                case "Q":
                    power = 12;
                    break;
                case "K":
                    power = 13;
                    break;
                case "A":
                    power = 14;
                    break;
                default:
                    power = int.Parse(powerChar);
                    break;
            }

            return power;
        }

        static int GetPowerOfType(string powerChar)
        {
            int power = 0;
            switch (powerChar)
            {
                case "S":
                    power = 4;
                    break;
                case "H":
                    power = 3;
                    break;
                case "D":
                    power = 2;
                    break;
                case "C":
                    power = 1;
                    break;
                default:
                    break;
            }

            return power;
        }
    }
}
