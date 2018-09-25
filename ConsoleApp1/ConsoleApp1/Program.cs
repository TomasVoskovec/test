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
            Map.SizeX = 10;
            Map.SizeY = 10;

            map.CreateShip(2);

            Map.GenerateMap();

            map.AllCreatedFields();
            //map.ReadKey();
        }
    }
}
