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
            //TODO: Have the teams created
            return Enumerable.Empty<ITeam>();
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
