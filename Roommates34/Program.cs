using Roommates34.Models;
using Roommates34.Repositories;
using System;

namespace Roommates34
{

    class Program
    {
        //  This is the address of the database.
        //  We define it here as a constant since it will never change.
        private const string CONNECTION_STRING = @"server=localhost\SQLExpress;database=Roommates;integrated security=true";

        static void Main(string[] args)
        {
            bool runProgram = true;
            while (runProgram)
            {
                string selection = GetMenuSelection();

                switch (selection)
                {
                    case ("Show all rooms"):
                        // Do stuff
                        break;
                    case ("Search for room"):
                        // Do stuff
                        break;
                    case ("Add a room"):
                        // Do stuff
                        break;
                    case ("Exit"):
                        runProgram = false;
                        break;
                }
            }

        }

        static string GetMenuSelection()
        {
            Console.Clear();

            List<string> options = new List<string>()
            {
                "Show all rooms",
                "Search for room",
                "Add a room",
                "Exit"
            };

            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {options[i]}");
            }

            while (true)
            {
                try
                {
                    Console.WriteLine();
                    Console.Write("Select an option > ");

                    string input = Console.ReadLine();
                    int index = int.Parse(input) - 1;
                    return options[index];
                }
                catch (Exception)
                {

                    continue;
                }
            }

        }

        static void ShowAllRooms(RoomRepository roomRepo)
        {
            Console.Write("Room Name: ");
            string name = Console.ReadLine();
            int max = int.Parse(Console.ReadLine());

            Room room = new Room()
            {
                Name = name,
                MaxOccupancy = max
            };

            roomRepo.Insert(room);

            Console.WriteLine($"{room.Name} has been added to the database and given the ID of {room.Id}");
            Console.ReadKey();
            
        }

 //       static void DeleteRoom(RoomRepository roomRepo)
 //       {
 //           Console.Write("What is the ID of the room wou want to delete?);
 //
 //           int roomId = int.Parse(Console.WriteLine)
 //       }
        
    }
}