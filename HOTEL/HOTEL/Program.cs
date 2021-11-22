using System;
using System.Collections;


namespace HOTEL
{
    class Program
    {
        static void Main(string[] args)
        {
            var hotel = new Hotel();
            hotel.Rooms = new Room[3, 5] {
                { new Room(100, "Ordinary"), new Room(101, "Ordinary"), new Room(102, "Ordinary"), new Room(103, "Ordinary"), new Room(104, "Ordinary") },
                { new Room(200, "Ordinary"), new Room(201, "Ordinary"), new Room(202, "Ordinary"), new Room(203, "Ordinary"), new Room(204, "Suite") },
                { new Room(300, "Ordinary"), new Room(301, "Suite"), new Room(302, "Ordinary"), new Room(303, "Ordinary"), new Room(304, "Ordinary") }
            };
            while (true)
            {
                int op = 0;
                while (op < 1 || op > 3)
                {
                    Console.Clear();
                    hotel.Print();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("1. Check-in\n2. Check-out\n3. Exit\n");
                    int.TryParse(Console.ReadLine(), out op);
                }
                if (op == 3) break;

                int[] rooms = hotel.ReadRooms();

                if (op == 1) hotel.CheckIn(rooms);
                else if (op == 2) hotel.CheckOut(rooms);
            }
        }

        class Hotel
        {
            public static int floors, roomsNum;

            Room[,] _rooms;

            public Room[,] Rooms
            {
                get => _rooms;
                set
                {
                    _rooms = value;
                    floors = Rooms.GetUpperBound(0) + 1;
                    roomsNum = Rooms.Length / floors;
                }
            }

            public int[] ReadRooms()
            {
                int roomsN = 0;
                while (roomsN < 1 || roomsN > Rooms.Length)
                {
                    Console.Write("Number of rooms to check-in or check-out: ");
                    int.TryParse(Console.ReadLine(), out roomsN);
                }
                int[] rooms = new int[roomsN];

                for (int i = 0; i < roomsN; i++)
                {
                    Console.Write($"Room {i + 1}: ");
                    int.TryParse(Console.ReadLine(), out int room);
                    rooms[i] = room;
                }

                return rooms;
            }

            public void Print()
            {
                for (int i = 0; i < floors; i++)
                {
                    for (int j = 0; j < roomsNum; j++)
                    {
                        Console.ForegroundColor = (ConsoleColor)Rooms[i, j].color;
                        Console.Write(Rooms[i, j].room + "\t");
                    }
                    Console.WriteLine();
                }
            }

            public void CheckIn(params int[] rooms)
            {
                foreach (int r in rooms)
                    foreach (var R in Rooms)
                        if (r == R.room) R.CheckIn(rooms);
            }

            public void CheckOut(params int[] rooms)
            {
                foreach (int r in rooms)
                    foreach (var R in Rooms)
                        if (r == R.room) R.CheckOut(rooms);
            }
        }

        class Room
        {
            int _room;
            bool _access;
            string _state;
            int _color;

            public int room { get => _room; }
            public bool access { get => _access; }
            public string state { get => _state; }
            public int color { get => _color; }

            public Room(int room, string state)
            {
                _room = room;
                _access = true;
                _state = state;
                if (state == "Suite")
                    _color = (int)ConsoleColor.DarkRed;
                else if (state == "Ordinary")
                    _color = (int)ConsoleColor.Cyan;
            }

            public void CheckIn(params int[] rooms)
            {
                _access = false;
                _color = (int)ConsoleColor.Green;
            }

            public void CheckOut(params int[] rooms)
            {
                _access = true;
                if (_state == "Suite")
                    _color = (int)ConsoleColor.DarkRed;
                else if (_state == "Ordinary")
                    _color = (int)ConsoleColor.Cyan;
            }
        }
    }
}
