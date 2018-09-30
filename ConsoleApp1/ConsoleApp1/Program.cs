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
            bool game = true;

            int winner = 0;

            //Mapa pro hrace 1
            Map map1 = new Map();

            bool shipSelection1 = true;

            map1.CreateShip();

            while (shipSelection1)
            {
                Console.Clear();

                shipSelection1 = map1.IsShipSelection();

                map1.GenerateMap();

                map1.MoveBoat();

                //map1.AllCreatedFields();
            }

            //Mapa pro hrace 2
            Map map2 = new Map();

            bool shipSelection2 = true;

            map2.CreateShip();

            while (shipSelection2)
            {
                Console.Clear();

                shipSelection2 = map2.IsShipSelection();

                map2.GenerateMap();

                map2.MoveBoat();

                //map2.AllCreatedFields();
            }

            //Hra

            bool player1 = true;
            bool player2 = false;

            while (game)
            {
                while (player1)
                {
                    Console.Write("Vyberte pole pomoci sipek a potvrdte klavesou 'Enter' \n### Hraje  HRAC 1 ###");
                    Console.WriteLine();
                    map2.GenerateMapShoot();
                    map2.Shoot();
                    Console.Clear();
                    if (map2.Hit)
                    {
                        Console.WriteLine("Trefa!!!");
                        player1 = true;
                        player2 = false;
                    }
                    else
                    {
                        Console.WriteLine("Minul jsi... ");
                        player1 = false;
                        player2 = true;
                    }
                    if (map2.IsWinner())
                    {
                        game = false;
                        player1 = false;
                        player2 = false;
                        winner = 1;
                    }
                }
                while (player2)
                {
                    Console.Write("Vyberte pole pomoci sipek a potvrdte klavesou 'Enter' \n### Hraje  HRAC 2 ###");
                    Console.WriteLine();
                    map1.GenerateMapShoot();
                    map1.Shoot();
                    Console.Clear();
                    if (map1.Hit)
                    {
                        Console.WriteLine("Trefa!!!");
                        player1 = false;
                        player2 = true;
                    }
                    else
                    {
                        Console.WriteLine("Minul jsi... ");
                        player1 = true;
                        player2 = false;
                    }
                    if (map1.IsWinner())
                    {
                        game = false;
                        player1 = false;
                        player2 = false;
                        winner = 2;
                    }
                }
            }

            //Vypsani vyteze
            Console.Clear();
            
            if (winner == 1)
            {
                Console.WriteLine("Hrac 1 vyhral");
            }
            else if (winner == 2)
            {
                Console.WriteLine("Hrac 2 vyhral");
            }
        }
    }
}