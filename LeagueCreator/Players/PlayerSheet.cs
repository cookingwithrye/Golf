using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using OfficeHelpers;

namespace LeagueCreator
{
    public class PlayerSheet : IPlayerSheet
    {
        /// <summary>
        /// Exposes the collection of players in this player sheet
        /// </summary>
        public IEnumerable<IPlayer> Players { get { return _players.AsEnumerable(); } }
        private IList<IPlayer> _players;

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

            for (int i = 0; i < captainCount; i++)
            {
                //pick a new random position for this captain in the sequence of captains
                int a = random.Next(captainCount);
                IPlayer temp = captainsMixed[a];

                captainsMixed[a] = captainsMixed[i];
                captainsMixed[i] = temp;
            }
            
            //now put the captains on the team
            foreach (var captain in captainsMixed)
                captain.putMeOnTeam(teams, random);

            //randomly distribute the remaining players amongst the teams
            foreach (var player in this.Players.Where(c => !c.IsCaptain))
                player.putMeOnTeam(teams, random);
            
            //UPGRADE: attempt to ensure that the teams are reasonably balanced numerically by placing the grouped players onto teams first

            return teams;
        }

        /// <summary>
        /// Load the player sheet from the specified file
        /// </summary>
        /// <param name="filename">The XLS file to load the player information from</param>
        public PlayerSheet(string filename)
        {
            //initialize the players on this sheet
            _players = new List<IPlayer>();
            
            //verify that the file exists
            if (!System.IO.File.Exists(filename))
                throw new Exception(String.Format("No file '{0}' found.", filename));

            //load the xls file into a dataset, assuming that headers are present
            DataSet unstructuredData = OfficeHelpers.Excel.ImportExcelXLS(filename, hasHeaders:true);

            //TODO: verify that the file format matches the expected file input format. Could be specified more formally later.

            //read in players until we encounter one without both a first and last name
            bool done = false;
            while (!done)
            {
                //generate the player object
                IPlayer newPlayer = 
                    Factories.PlayerFactory.CreatePlayer(
                        Firstname: Excel.GiveMeCellValue(unstructuredData, 0, 0),
                        Lastname: Excel.GiveMeCellValue(unstructuredData, 0, 0),
                        IsCaptain: Excel.GiveMeCellValue(unstructuredData, 0, 0),
                        Phone: Excel.GiveMeCellValue(unstructuredData, 0, 0),
                        Email: Excel.GiveMeCellValue(unstructuredData, 0, 0),
                        HasRestriction: Excel.GiveMeCellValue(unstructuredData, 0, 0),
                        MemberID: Excel.GiveMeCellValue(unstructuredData, 0, 0)
                    );

                if (String.IsNullOrWhiteSpace(newPlayer.FirstName) && String.IsNullOrWhiteSpace(newPlayer.LastName))
                    done = true;
                else
                    _players.Add(newPlayer);
            }
        }
    }
}
