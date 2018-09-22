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
            map.SizeX = 20;
            map.SizeY = 10;

            for(int i = 0; i <= 9; i++)
            {
                map.CreateField(i, i);
            }

            //map.CreateField(2,2);

            map.CreateMap();

            map.WriteFields();
        }
    }
}
