using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Map
    {
        public static int SizeX = 10;
        public static int SizeY = 10;

        private static List<Field> createdFields = new List<Field>();

        //Vytvoreni prazdnych poli
        private static List<Field> createMap()
        {
            List<Field> fields = new List<Field>();
            //Y
            for (int i = 1; i <= SizeY; i++)
            {
                //X
                for (int j = 1; j <= SizeX; j++)
                {
                    fields.Add(new Field
                    {
                        X = j,
                        Y = i
                    });
                }
            }
            return fields;
        }

        //Pridani funkcniho pole
        public void AddField(int x, int y, int type)
        {
            createdFields.Add(new Field
            {
                X = x,
                Y = y,
                Type = type
            });
        }

        //Generovani Mapy
        public static void GenerateMap()
        {
            List<Field> generatedFields = createMap();
            bool otherField = false;

            foreach (Field generatedField in generatedFields)
            {
                foreach (Field createdField in createdFields)
                {
                    if (generatedField.X == createdField.X && generatedField.Y == createdField.Y)
                    {
                        if (createdField.Type == 1)
                        {
                            Console.Write("■");
                            otherField = true;
                        }
                    }
                }
                //Kontrola vypsani znaku
                if (!otherField)
                {
                    Console.Write("L");
                }
                otherField = false;
                //Kontrola radku
                if (generatedField.X == SizeX)
                {
                    Console.WriteLine();
                }
            }
        }

        public void AllCreatedFields()
        {
            foreach (Field createdField in createdFields)
            {
                Console.WriteLine("{{X: {0}, Y: {1}, Type: {2}}} ", createdField.X, createdField.Y, createdField.Type);
            }
        }
    }
}
