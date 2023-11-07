 
 
using System;
using System.Collections.Generic;
using System.Linq;
using dotnetapp.Managers;
using dotnetapp.Models;
 
namespace dotnetapp
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager p = new PlayerManager();
 
 
 
            // p.DisplayAllPlayers();
            // p.AddPlayerToDatabase(player);
            // p.FindPlayer(1);
 
            //
            // p.DeletePlayer(2);
 
            while (true)
            {
                Console.WriteLine("1. Display All Players: ");
                Console.WriteLine("2. Edit Player: ");
                Console.WriteLine("3. Delete Player: ");
                Console.WriteLine("4. Find Player: ");
                Console.WriteLine("5. Add Player To Database: ");
                Console.WriteLine("6. Exit: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n == 1) p.DisplayAllPlayers();
                else if (n == 2)
                {
                    Console.WriteLine($"Enter ID");
                    int id=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter New Name");
                    string? name = Console.ReadLine();
                    Console.WriteLine("Enter Age");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Enter new Category");
                    string? category = Console.ReadLine();
                    Console.WriteLine("Enter new Bidding Price");
                    decimal rating = Convert.ToDecimal(Console.ReadLine());
 
                    Player player = new Player
                    {
                        Name = name,
                        Age = year,
                        Category = category,
                        BiddingPrice = rating
                    };
 
                    p.EditPlayer(id,player);
                }
                else if (n == 3) p.DeletePlayer(2);
                else if (n == 4)
                {
                    Console.WriteLine($"Enter ID");
                    int id=Convert.ToInt32(Console.ReadLine());
                    p.FindPlayer(id);
                }
 
                else if (n == 5)
                {
                    Console.WriteLine("Enter Name");
                    string? name = Console.ReadLine();
                    Console.WriteLine("Enter Age");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Enter Category");
                    string? category = Console.ReadLine();
                    Console.WriteLine("Enter Bidding Price");
                    decimal rating = Convert.ToDecimal(Console.ReadLine());
 
                    Player player = new Player
                    {
                        Name = name,
                        Age = year,
                        Category = category,
                        BiddingPrice = rating
                    };
 
                    p.AddPlayerToDatabase(player);
                }
                else if (n == 6) break;
            }
        }
 
    }
}