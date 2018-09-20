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

            map.CreateMap();
        }
    }
}
