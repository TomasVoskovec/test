using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Map
    {
        public int SizeX = 10;
        public int SizeY = 10;

        private List<int> polickoLod = new List<int>(new int[] {2,2});

        public void CreateMap()
        {
            for (int i = 1; i <= SizeY; i++)
            {
                if (i == polickoLod[1])
                {
                    for (int j = 1; j <= SizeX; j++)
                    {
                        if (j == polickoLod[0])
                        {
                            Console.Write("0");
                        }
                        else
                        {
                            Console.Write("#");
                        }
                    }
                }
                else
                {
                    for (int j = 1; j <= SizeX; j++)
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
