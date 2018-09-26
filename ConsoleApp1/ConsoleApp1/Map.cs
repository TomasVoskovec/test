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

        private int boatID = 0;

        private static List<Field> createdFields = new List<Field>();
        private List<Ship> ships = new List<Ship>();

        //Key to int sipky
        public int GetKey ()
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
                //ship.Add(new Field { X = 1, Y = 1, Type = 1 });
                for (int i = 0; i < 2; i++)
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

        //Ulozeni lodi
        public void placeShip()
        {
            List<Field> ship = ships[boatID].BoatFields;

            foreach (Field shipField in ship)
            {
                createdFields.Add(new Field { X = shipField.X, Y = shipField.Y, Type = 1 });
            }
            boatID++;
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

        //Kontrola souradnic
        /*
        private bool dirControl(List<Field> fields, int dir)
        {
            if (dir == 1)
            {
                foreach (Field field in fields)
                {
                    if ()
                }
            }
        }
        */

        /*
         * Left Arrow == 1
         * Up Arrow == 2
         * Down Arrow == 3
         * Right Arrow == 4
         * 
         * Other Key == 5
        */

        //Pohybovani lodi (sipky)
        public void moveBoat()
        {
            bool boatSellection = true;
            bool dirControl = true;

            List<Field> shipFields = ships[boatID].BoatFields;

            while (boatSellection)
            {
                int move = GetKey();

                if(move == 1)
                {
                    foreach (Field shipField in shipFields)
                    {
                        if (shipField.X == 1)
                        {
                            dirControl = false;
                        }
                    }
                    if (dirControl)
                    {
                        foreach (Field shipField in shipFields)
                        {
                            shipField.X++;
                        }
                    }
                }
                if (move == 2)
                {
                    foreach (Field shipField in shipFields)
                    {
                        if (shipField.Y == 1)
                        {
                            dirControl = false;
                        }
                    }
                    if (dirControl)
                    {
                        foreach (Field shipField in shipFields)
                        {
                            shipField.X++;
                        }
                    }
                }
                if (move == 3)
                {
                    foreach (Field shipField in shipFields)
                    {
                        if (shipField.Y == 10)
                        {
                            dirControl = false;
                        }
                    }
                    if (dirControl)
                    {
                        foreach (Field shipField in shipFields)
                        {
                            shipField.X++;
                        }
                    }
                }
                if (move == 4)
                {
                    foreach (Field shipField in shipFields)
                    {
                        if (shipField.X == 10)
                        {
                            dirControl = false;
                        }
                    }
                    if (dirControl)
                    {
                        foreach (Field shipField in shipFields)
                        {
                            shipField.X++;
                        }
                    }
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
