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
            Map map = new Map();
            map.SizeX = 10;
            map.SizeY = 10;

            bool game = true;

            map.CreateShip();

            while (game)
            {
                Console.Clear();

                //map.placeShip();

                //map.AddField(4, 4, 1);

                map.GenerateMap();

                map.MoveBoat();

                map.AllCreatedFields();
                //map.ReadKey();
            }
        }
    }
}
