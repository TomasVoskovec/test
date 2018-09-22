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

            map.CreateField(2, 3);
            map.CreateField(7, 7);
            map.CreateField(5, 5);
            map.CreateField(5, 5);

            map.CreateMap();

            map.WriteFields();
        }
    }
}
