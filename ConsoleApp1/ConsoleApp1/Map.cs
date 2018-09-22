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
            if (!fields.Contains(new Field {X = x, Y = x}))
            {
                fields.Add(new Field { X = x, Y = y });
            }
        }

        public void WriteFields()
        {
            foreach (Field field in fields)
            {
                Console.Write("x:{0} y:{1}, ", field.X, field.Y);
            }
        }

        public void CreateMap()
        {
            List<int> fieldsX = new List<int>();
            List<int> fieldsY = new List<int>();

            foreach (Field field in fields)
            {
                fieldsX.Add(field.X);
                fieldsY.Add(field.Y);
            }
            int z = 0;
            for (int i = 1; i <= SizeY; i++)
            {
                if (fieldsY.Contains(i))
                {
                    int currFieldX = fieldsY.IndexOf(i);
                    for (int j = 1; j <= SizeX; j++)
                    {
                        if (j == fieldsX[currFieldX])
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
