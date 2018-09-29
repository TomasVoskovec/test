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

        public bool MoveShip = true;
        private int boatID = 0;

        private List<Field> createdFields = new List<Field>();
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
        private List<Field> createMap()
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
        public void CreateShip()
        {
            Console.Clear();
            List<Field> ship = new List<Field>();
            bool shipCreated = true;

            bool correctChose = false;

            while (!correctChose)
            {
                //Console.Clear();

                int type = 0;

                bool chose = true;
                while (chose)
                {
                    try
                    {
                        int key = Convert.ToInt32(Console.ReadLine());
                        type = key;
                        chose = false;
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("Spatne zadany typ lode");
                    }
                }

                //Ponorka
                if (type == 1)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        ship.Add(new Field { X = 1 + i, Y = 1, Type = 1 });
                    }
                    correctChose = true;
                }
                //Torpedoborec
                else if (type == 2)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        ship.Add(new Field { X = 1 + i, Y = 1, Type = 1 });
                    }
                    correctChose = true;
                }
                //Kriznik
                else if (type == 3)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        ship.Add(new Field { X = 1 + i, Y = 1, Type = 1 });
                    }
                    correctChose = true;
                }
                //Bitevni lod
                else if (type == 4)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        ship.Add(new Field { X = 1 + i, Y = 1, Type = 1 });
                    }
                    correctChose = true;
                }
                //Letadlova lod
                else if (type == 5)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        ship.Add(new Field { X = 1 + i, Y = 1, Type = 1 });
                    }
                    correctChose = true;
                }
                //Pristavaci zakladna
                else if (type == 6)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        ship.Add(new Field { X = 1 + i, Y = 1, Type = 1 });
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        ship.Add(new Field { X = 1 + i, Y = 2, Type = 1 });
                    }
                    correctChose = true;
                }
                //Hydroplan
                else if (type == 7)
                {
                    ship.Add(new Field { X = 1, Y = 2, Type = 1 });
                    ship.Add(new Field { X = 2, Y = 1, Type = 1 });
                    ship.Add(new Field { X = 3, Y = 2, Type = 1 });
                    correctChose = true;
                }
                //Kriznik II
                else if (type == 8)
                {
                    ship.Add(new Field { X = 1, Y = 2, Type = 1 });
                    ship.Add(new Field { X = 2, Y = 1, Type = 1 });
                    ship.Add(new Field { X = 2, Y = 2, Type = 1 });
                    ship.Add(new Field { X = 3, Y = 2, Type = 1 });
                    correctChose = true;
                }
                //Tezky kriznik
                else if (type == 9)
                {
                    ship.Add(new Field { X = 1, Y = 2, Type = 1 });
                    ship.Add(new Field { X = 2, Y = 1, Type = 1 });
                    ship.Add(new Field { X = 2, Y = 2, Type = 1 });
                    ship.Add(new Field { X = 2, Y = 3, Type = 1 });
                    ship.Add(new Field { X = 3, Y = 2, Type = 1 });
                    correctChose = true;
                }
                //Katamaran
                else if (type == 10)
                {
                    ship.Add(new Field { X = 1, Y = 1, Type = 1 });
                    ship.Add(new Field { X = 1, Y = 2, Type = 1 });
                    ship.Add(new Field { X = 1, Y = 3, Type = 1 });
                    ship.Add(new Field { X = 2, Y = 2, Type = 1 });
                    ship.Add(new Field { X = 3, Y = 1, Type = 1 });
                    ship.Add(new Field { X = 3, Y = 2, Type = 1 });
                    ship.Add(new Field { X = 3, Y = 3, Type = 1 });
                    correctChose = true;
                }
                //Lehka bitevni lod
                else if (type == 11)
                {
                    ship.Add(new Field { X = 1, Y = 1, Type = 1 });
                    ship.Add(new Field { X = 1, Y = 2, Type = 1 });
                    ship.Add(new Field { X = 2, Y = 2, Type = 1 });
                    correctChose = true;
                }
                //Letadlova lod II
                else if (type == 12)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        ship.Add(new Field { X = 4 + i, Y = 1, Type = 1 });
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        ship.Add(new Field { X = 1 + i, Y = 2, Type = 1 });
                    }
                    correctChose = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Spatne zadany typ lodi");
                    correctChose = false;
                    shipCreated = false;
                }
            }

            if (shipCreated)
            {
                ships.Add(new Ship{ BoatFields = ship });
            }
            boatID++;
        }

        //Ulozeni lodi
        public void placeShip()
        {
            List<Field> ship = ships[boatID-1].BoatFields;

            bool placeControl = true;

            foreach (Field createdField in createdFields)
            {
                foreach (Field shipField in ship)
                {
                    if (shipField.X == createdField.X && shipField.Y == createdField.Y && shipField.Type == createdField.Type || shipField.X - 1 == createdField.X && shipField.Y == createdField.Y && shipField.Type == createdField.Type || shipField.X + 1 == createdField.X && shipField.Y == createdField.Y && shipField.Type == createdField.Type || shipField.X == createdField.X && shipField.Y + 1 == createdField.Y && shipField.Type == createdField.Type || shipField.X == createdField.X && shipField.Y - 1 == createdField.Y && shipField.Type == createdField.Type)
                    {
                        placeControl = false;
                    }
                }
            }
            if (placeControl)
            {
                foreach (Field shipField in ship)
                {
                    createdFields.Add(new Field { X = shipField.X, Y = shipField.Y, Type = 1 });
                }
                CreateShip();
                Console.Clear();
            }
        }

        //Vykresleni Mapy
        public void GenerateMap()
        {
            List<Field> generatedFields = createMap();
            bool otherField = false;

            foreach (Field generatedField in generatedFields)
            {
                bool boatField = false;
                List<Field> ship = ships[boatID-1].BoatFields;
                foreach (Field shipField in ship)
                {
                    if (generatedField.X == shipField.X && generatedField.Y == shipField.Y)
                    {
                        if (shipField.Type == 1)
                        {
                            Console.Write("O");
                            boatField = true;
                            otherField = true;
                        }
                    }
                }
                foreach (Field createdField in createdFields)
                {
                    if (generatedField.X == createdField.X && generatedField.Y == createdField.Y && boatField == false)
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
        public void MoveBoat()
        {
            bool moveBoat = true;

            List<Field> shipFields = ships[boatID-1].BoatFields;

            while (moveBoat)
            {
                bool dirControl = true;
                var key = Console.ReadKey();

                if(key.Key == ConsoleKey.LeftArrow)
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
                            shipField.X--;
                        }
                    }
                }
                if (key.Key == ConsoleKey.UpArrow)
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
                            shipField.Y--;
                        }
                    }
                }
                if (key.Key == ConsoleKey.DownArrow)
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
                            shipField.Y++;
                        }
                    }
                }
                if (key.Key == ConsoleKey.RightArrow)
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
                if (key.Key == ConsoleKey.Enter)
                {
                    moveBoat = false;
                }
                Console.Clear();
                GenerateMap();
            }
            MoveShip = true;
            placeShip();
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
