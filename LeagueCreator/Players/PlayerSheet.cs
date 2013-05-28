using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeagueCreator
{
    public class PlayerSheet : IPlayerSheet
    {
        /// <summary>
        /// Exposes the collection of players in this player sheet
        /// </summary>
        public IEnumerable<IPlayer> Players { get; private set; }

        /// <summary>
        /// Splits the loaded players into the specified number of teams, ensuring that each team has at least one captain
        /// </summary>
        /// <param name="numTeams">Number of teams to generate from the player sheet</param>
        /// <returns>Collection of teams</returns>
        public IEnumerable<ITeam> CreateTeams(int numTeams)
        {
            if (numTeams <= 0)
                throw new Exception("There needs to be at least one team in a league");
            
            //verify that there are enough captains for the number of teams specified
            var captains = this.Players.Where(c => c.IsCaptain);
            
            if (captains.Count() < numTeams)
                throw new Exception("Not enough captains for the desired number of teams.");
            
            //create the number of empty teams needed
            var teams = Factories.TeamFactory.CreateTeams(numTeams);

            //generate a random number object.
            //NOTE: The player objects should respect any restrictions that are required for grouping them with other players
            Random random = new Random();

            //randomly distribute the captains amongst the number of desired teams. The player receives a collection of teams that he/she could be placed on and adds himself to the list.
            var captainsMixed = new List<IPlayer>();
            captainsMixed.AddRange(captains);

            //for a random number of iterations, pick two numbers and swap them. This avoids a bias where two captains that were next to each other in the list would never end up on the same team
            int captainCount = captains.Count();
            int mixCount = random.Next(captainCount * 100); //TODO: theoretically we should just need to swap out each position once to guarantee randomness instead of doing it this many times
            while (mixCount-- > 0)
            {
                int a = random.Next(captainCount);
                int b = random.Next(captainCount);

                IPlayer temp = captainsMixed[a];
                captainsMixed[a] = captainsMixed[b];
                captainsMixed[b] = temp;
            }
            
            //now put the captains on the team
            foreach (var captain in captains)
                captain.putMeOnTeam(teams, random);

            //randomly distribute the remaining players amongst the teams
            foreach (var player in this.Players.Where(c => !c.IsCaptain))
                player.putMeOnTeam(teams, random);
            
            //TODO: attempt to ensure that the teams are reasonably balanced numerically

            return teams;
        }

        /// <summary>
        /// Load the player sheet from the specified file
        /// </summary>
        /// <param name="filename">The XLS file to load the player information from</param>
        public PlayerSheet(string filename)
        {
            //verify that the file exists
            if (!System.IO.File.Exists(filename))
                throw new Exception(String.Format("No file '{0}' found.", filename));

            //TODO: verify the file format and load the data row-by-row. Based on code from here: http://msdn.microsoft.com/library/bb332058.aspx
            //ignore the first two rows as per the sample specification
        }
    }
}
