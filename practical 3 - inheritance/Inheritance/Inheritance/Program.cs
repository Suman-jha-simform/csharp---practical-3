using System;

namespace Inheritance
{
    class Sponsor
    {
        protected string owner = "Rakuteen";
    }
    class Team : Sponsor
    {
        private string _teamName;

        public Team(string teamname)
        {
            this._teamName= teamname;
        }
        /// <summary>
        /// This method returns the concated value of owner and teamname varibales.
        /// </summary>
        /// <returns>string</returns>
        public string PrintInfo()
        {
            return $"{owner} {_teamName}";
        }

        public static void Main()
        {
            Team team = new Team("Lions");
            string ownerandteam = team.PrintInfo();
            Console.WriteLine(ownerandteam);
        }
    }
}