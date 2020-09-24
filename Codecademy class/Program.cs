using System;

namespace Codecademy_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile alex = new Profile("Alex Sarene", "Jakal", 18, "Canfield", "USA", "he/him");
            string[] hobbyList = { "League of Legends", "Valorant", "CSGO", "Among Us"};
            alex.SetGames(hobbyList);
            Console.WriteLine(alex.ViewProfile());
        }
    }
}
