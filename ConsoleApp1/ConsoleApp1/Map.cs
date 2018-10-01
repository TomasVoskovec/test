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

        public bool Hit = false;

        private bool ponorka = true;
        private bool torpedoborec = true;
        private bool kriznik = true;
        /*private bool bitevniLod = true;
        private bool letadlovaLod = true;
        private bool pristavaciZakladna = true;
        private bool hydroplan = true;
        private bool kriznikII = true;
        private bool tezkyKriznik = true;
        private bool katamaran = true;
        private bool lehkaBitevniLod = true;
        private bool letadlovaLodII = true;*/

        private Field scope = new Field
        {
            X = 1,
            Y = 1,
            Type = 2
        };

        private List<int> selectedBoats = new List<int>();

        private List<Field> createdFields = new List<Field>();
        private List<Field> shotFields = new List<Field>();
        private List<Ship> ships = new List<Ship>();

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
            bool choseControl = true;

            if (!IsShipSelection())
            {
                correctChose = true;
                shipCreated = false;
            }

            while (!correctChose)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("1: ■ (ponorka)");

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("2: ■■ (torpedoborec)");

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("3: ■■■ (kriznik)");

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("4: ■■■■ (bitevni lod)");

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("5: ■■■■■ (letadlova lod)");

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("   ■■■");
                Console.WriteLine("6: ■■■ (pristavaci zakladna)");

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("    ■");
                Console.WriteLine("7: ■ ■ (hydroplan)");

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("    ■");
                Console.WriteLine("8: ■■■ (kriznik II)");

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("    ■");
                Console.WriteLine("9: ■■■ (tezky kriznik)");
                Console.WriteLine("    ■");

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("    ■ ■");
                Console.WriteLine("10: ■■■ (katamaran)");
                Console.WriteLine("    ■ ■");

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("    ■");
                Console.WriteLine("11: ■■ (lehka bitevni lod)");

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("       ■■");
                Console.WriteLine("12: ■■■■■ (letadlova lod II)");
                Console.WriteLine("-----------------------------------");

                int type = 0;

                bool chose = true;
                while (chose)
                {
                    if (selectedBoats.Count != 0)
                    {
                        Console.Write("Vybrane lode: ");
                        foreach (int selectedBoat in selectedBoats)
                        {
                            Console.Write("{0} ", selectedBoat);
                        }
                    }
                    Console.WriteLine();
                    Console.Write("Vyberte lod: ");

                    try
                    {
                        int key = Convert.ToInt32(Console.ReadLine());
                        type = key;
                        chose = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Spatne zadany typ lode");
                    }
                    catch
                    {

                    }

                    /*foreach (int selectedBoat in selectedBoats)
                    {
                        if (selectedBoat == type)
                        {
                        }
                    }

                    if (type == 0 || type > 12)
                    {
                        choseControl = false;
                    }

                    if (!choseControl)
                    {
                        chose = true;
                        choseControl = false;
                    }*/
                }

                //Ponorka
                if (type == 1 && ponorka)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        ship.Add(new Field { X = 1 + i, Y = 1, Type = 1 });
                    }
                    ponorka = false;
                    correctChose = true;
                    selectedBoats.Add(1);
                }
                //Torpedoborec
                else if (type == 2 && torpedoborec)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        ship.Add(new Field { X = 1 + i, Y = 1, Type = 1 });
                    }
                    torpedoborec = false;
                    correctChose = true;
                    selectedBoats.Add(2);
                }
                //Kriznik
                else if (type == 3 && kriznik)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        ship.Add(new Field { X = 1 + i, Y = 1, Type = 1 });
                    }
                    kriznik = false;
                    correctChose = true;
                    selectedBoats.Add(3);
                }/*
                //Bitevni lod
                else if (type == 4 && bitevniLod)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        ship.Add(new Field { X = 1 + i, Y = 1, Type = 1 });
                    }
                    bitevniLod = false;
                    correctChose = true;
                    selectedBoats.Add(4);
                }
                //Letadlova lod
                else if (type == 5 && letadlovaLod)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        ship.Add(new Field { X = 1 + i, Y = 1, Type = 1 });
                    }
                    letadlovaLod = false;
                    correctChose = true;
                    selectedBoats.Add(5);
                }
                //Pristavaci zakladna
                else if (type == 6 && pristavaciZakladna)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        ship.Add(new Field { X = 1 + i, Y = 1, Type = 1 });
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        ship.Add(new Field { X = 1 + i, Y = 2, Type = 1 });
                    }
                    pristavaciZakladna = false;
                    correctChose = true;
                    selectedBoats.Add(6);
                }
                //Hydroplan
                else if (type == 7 && hydroplan)
                {
                    ship.Add(new Field { X = 1, Y = 2, Type = 1 });
                    ship.Add(new Field { X = 2, Y = 1, Type = 1 });
                    ship.Add(new Field { X = 3, Y = 2, Type = 1 });
                    hydroplan = false;
                    correctChose = true;
                    selectedBoats.Add(7);
                }
                //Kriznik II
                else if (type == 8 && kriznikII)
                {
                    ship.Add(new Field { X = 1, Y = 2, Type = 1 });
                    ship.Add(new Field { X = 2, Y = 1, Type = 1 });
                    ship.Add(new Field { X = 2, Y = 2, Type = 1 });
                    ship.Add(new Field { X = 3, Y = 2, Type = 1 });
                    kriznikII = false;
                    correctChose = true;
                    selectedBoats.Add(8);
                }
                //Tezky kriznik
                else if (type == 9 && tezkyKriznik)
                {
                    ship.Add(new Field { X = 1, Y = 2, Type = 1 });
                    ship.Add(new Field { X = 2, Y = 1, Type = 1 });
                    ship.Add(new Field { X = 2, Y = 2, Type = 1 });
                    ship.Add(new Field { X = 2, Y = 3, Type = 1 });
                    ship.Add(new Field { X = 3, Y = 2, Type = 1 });
                    tezkyKriznik = false;
                    correctChose = true;
                    selectedBoats.Add(9);
                }
                //Katamaran
                else if (type == 10 && katamaran)
                {
                    ship.Add(new Field { X = 1, Y = 1, Type = 1 });
                    ship.Add(new Field { X = 1, Y = 2, Type = 1 });
                    ship.Add(new Field { X = 1, Y = 3, Type = 1 });
                    ship.Add(new Field { X = 2, Y = 2, Type = 1 });
                    ship.Add(new Field { X = 3, Y = 1, Type = 1 });
                    ship.Add(new Field { X = 3, Y = 2, Type = 1 });
                    ship.Add(new Field { X = 3, Y = 3, Type = 1 });
                    katamaran = false;
                    correctChose = true;
                    selectedBoats.Add(10);
                }
                //Lehka bitevni lod
                else if (type == 11 && lehkaBitevniLod)
                {
                    ship.Add(new Field { X = 1, Y = 1, Type = 1 });
                    ship.Add(new Field { X = 1, Y = 2, Type = 1 });
                    ship.Add(new Field { X = 2, Y = 2, Type = 1 });
                    lehkaBitevniLod = false;
                    correctChose = true;
                    selectedBoats.Add(11);
                }
                //Letadlova lod II
                else if (type == 12 && letadlovaLodII)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        ship.Add(new Field { X = 4 + i, Y = 1, Type = 1 });
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        ship.Add(new Field { X = 1 + i, Y = 2, Type = 1 });
                    }
                    letadlovaLodII = false;
                    correctChose = true;
                    selectedBoats.Add(12);
                }*/
                else
                {
                    Console.WriteLine("Lod je jiz zabrana nebo jste spatne zadal typ lodi");
                    correctChose = false;
                    shipCreated = false;
                }
            }

            if (shipCreated)
            {
                ships.Add(new Ship{ BoatFields = ship });
                boatID++;
            }
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
                            Console.Write("■");
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
                        if (createdField.Type == 3)
                        {
                            Console.Write("X");
                            otherField = true;
                        }
                    }
                }
                //Kontrola vypsani znaku
                if (!otherField)
                {
                    Console.Write("#");
                }
                otherField = false;
                //Kontrola radku
                if (generatedField.X == SizeX)
                {
                    Console.WriteLine();
                }
            }
        }

        //Vykresleni Mapy (Shooting)
        public void GenerateMapShoot()
        {
            List<Field> generatedFields = createMap();
            bool otherField = false;
            bool scopeField = false;

            foreach (Field generatedField in generatedFields)
            {

                if (generatedField.X == scope.X && generatedField.Y == scope.Y)
                {
                    Console.Write("¤");
                    otherField = true;
                    scopeField = true;
                }

                foreach (Field shotField in shotFields)
                {
                    if (generatedField.X == shotField.X && generatedField.Y == shotField.Y && !scopeField)
                    {
                        if (shotField.Type == 3)
                        {
                            Console.Write("X");
                            otherField = true;
                        }
                        if (shotField.Type == 4)
                        {
                            Console.Write("■");
                            otherField = true;
                        }
                    }
                }
                //Kontrola vypsani znaku
                if (!otherField)
                {
                    Console.Write("#");
                }
                otherField = false;
                scopeField = false;
                //Kontrola radku
                if (generatedField.X == SizeX)
                {
                    Console.WriteLine();
                }
            }
        }

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
                        if (shipField.Y == SizeY)
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
                        if (shipField.X == SizeX)
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
                Console.WriteLine("Posouvejte lod pomoci sipek a potvrdte klavesou 'Enter'");
                GenerateMap();
            }
            MoveShip = true;
            placeShip();
        }

        //Vypsani souradnic vsech vytvorenych policek
        public void AllCreatedFields()
        {
            foreach (Field createdField in createdFields)
            {
                Console.WriteLine("{{X: {0}, Y: {1}, Type: {2}}} ", createdField.X, createdField.Y, createdField.Type);
            }
        }

        //Vypsani souradnic vsech vytvorenych policek
        public void AllShotFields()
        {
            foreach (Field shotField in shotFields)
            {
                Console.WriteLine("{{X: {0}, Y: {1}, Type: {2}}} ", shotField.X, shotField.Y, shotField.Type);
            }
        }

        public bool IsShipSelection()
        {
            if(!ponorka && !torpedoborec && !kriznik /*&& !bitevniLod && !letadlovaLod && !pristavaciZakladna && !hydroplan && !kriznikII && !tezkyKriznik && !katamaran && !lehkaBitevniLod && !letadlovaLodII*/)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Strileni
        public void Shoot()
        {
            bool shoot = true;
            bool hit = false;
            bool hited = false;
            Hit = false;

            int type = 3;

            List<Field> shipFields = new List<Field>();

            foreach (Ship ship in ships)
            {
                foreach (Field shipField in ship.BoatFields)
                {
                    shipFields.Add(shipField);
                }
            }

            while (shoot)
            {
                bool dirControl = true;
                var key = Console.ReadKey();

                if (key.Key == ConsoleKey.LeftArrow)
                {
                    if (scope.X == 1)
                    {
                        dirControl = false;
                    }

                    if (dirControl)
                    {
                        scope.X--;
                    }
                }

                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (scope.Y == 1)
                    {
                        dirControl = false;
                    }

                    if (dirControl)
                    {
                        scope.Y--;
                    }
                }

                if (key.Key == ConsoleKey.DownArrow)
                {
                    if (scope.Y == SizeY)
                    {
                        dirControl = false;
                    }

                    if (dirControl)
                    {
                        scope.Y++;
                    }
                }

                if (key.Key == ConsoleKey.RightArrow)
                {
                    if (scope.X == SizeX)
                    {
                        dirControl = false;
                    }

                    if (dirControl)
                    {
                        scope.X++;
                    }
                }

                if (key.Key == ConsoleKey.Enter)
                {
                    shoot = false;
                    foreach (Field shipField in shipFields)
                    {
                        if (shipField.X == scope.X && shipField.Y == scope.Y)
                        {
                            hit = true;
                        }
                    }
                }

                Console.Clear();
                Console.WriteLine("Vyberte pole pomoci sipek a potvrdte klavesou 'Enter'");
                GenerateMapShoot();
            }
            if (hit)
            {
                type = 4;
                Hit = true;

                Field scopeField = new Field { X = scope.X, Y = scope.Y, Type = type };

                foreach (Field shotField in shotFields)
                {
                    if (scopeField.X == shotField.X && scopeField.Y == shotField.Y)
                    {
                        hited = true;
                    }
                    else
                    {
                        hited = false;
                    }
                }
            }
            if (!hited)
            {
                shotFields.Add(new Field
                {
                    X = scope.X,
                    Y = scope.Y,
                    Type = type
                });
            }
        }
        
        //Kontrola zdali hrac nevyhral
        public bool IsWinner()
        {
            List<Field> shipFields = new List<Field>();

            int shots = 0;

            foreach (Ship ship in ships)
            {
                foreach (Field shipField in ship.BoatFields)
                {
                    shipFields.Add(shipField);
                }
            }

            foreach (Field shipField in shotFields)
            {
                foreach (Field shotField in shotFields)
                {
                    if (shipField.X == shotField.X && shipField.Y == shotField.Y)
                    {
                        shots++;
                    }
                }
            }

            if (shipFields.Count == shots)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}