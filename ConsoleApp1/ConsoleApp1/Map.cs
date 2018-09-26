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

        private int boatID;

        private static List<Field> createdFields = new List<Field>();
        private List<Ship> ships = new List<Ship>();

        public int GetArrowKey ()
        {
            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.LeftArrow)
            {
                return 1;
            }
            if (key.Key == ConsoleKey.UpArrow)
            {
                return 2;
            }
            if (key.Key == ConsoleKey.DownArrow)
            {
                return 3;
            }
            if (key.Key == ConsoleKey.RightArrow)
            {
                return 4;
            }
            else
            {
                return 5;
            }
        }

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

        //Prevedeni lode na policka
        private void shipToFields(List<Field> ship)
        {
            foreach (Field shipField in ship)
            {
                AddField(shipField.X, shipField.Y, 1);
            }
        }

        //Pridani lodi
        public void CreateShip(int type)
        {
            List<Field> ship = new List<Field>();
            bool shipCreated = true;

            if (type == 1)
            {
                for (int i = 0; i >= 1; i++)
                {
                    ship.Add(new Field { X = 1 + i, Y = 1, Type = 1 });
                }
            }
            else
            {
                Console.WriteLine("Spatne zadany typ lodi");
                shipCreated = false;
            }

            if (shipCreated)
            {
                ships.Add(new Ship{ BoatFields = ship });
            }
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

        public void moveBoat()
        {
            bool boatSellection = true;

            while (boatSellection)
            {
                int sellection = GetArrowKey();

                if(sellection == 1)
                {

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
