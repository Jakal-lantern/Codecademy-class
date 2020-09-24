using System;
using System.Collections.Generic;
using System.Text;

namespace Codecademy_class
{
    class Profile
    {
        private string name;
        private string inGameName;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] playedGames;

        public Profile(string name, string inGameName, int age, string city, string country, string pronouns = "They/them")
        {
            this.name = name;
            this.inGameName = inGameName;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            this.playedGames = new string[0];
        }

        public string ViewProfile()
        {
            string bio = $"Name : {name}\nIn-Game Name : {inGameName}\nAge : {age}\nCity : {city}\nCountry : {country}\nPronouns : {pronouns}";
            bio += "\nGames :\n";
            foreach (string hobby in playedGames)
            {
                bio += $"- {hobby}\n";
            }
            return bio;
        }

        public void SetGames(string[] playedGames)
        {
            this.playedGames = playedGames;
        }
    }
}
