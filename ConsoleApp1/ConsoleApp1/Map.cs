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

        private List<Field> fields = new List<Field>();
        private List<int> polickoLod = new List<int>(new int[] { 7, 4 });

        public void CreateField(int x, int y)
        {
            fields.Add(new Field() {X = x, Y = x});
        }

        public void WriteFields()
        {
            foreach (Field field in fields)
            {
                Console.Write("x:{0} y:{1}", field.X, field.Y);
            }
        }

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
