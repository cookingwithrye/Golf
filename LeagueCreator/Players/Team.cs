using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeagueCreator.Players
{
    /// <summary>
    /// Concrete implementation of the team
    /// </summary>
    public class Team : ITeam
    {
        /// <summary>
        /// Players that are part of this team
        /// </summary>
        public IList<IPlayer> Players { get; private set; }

        public Team()
        {
            Players = new List<IPlayer>();
        }
        
        /// <summary>
        /// Adds a player to a specified team.
        /// </summary>
        /// <param name="Player">The player to add to this team</param>
        public void AddPlayer(IPlayer Player)
        {
            Players.Add(Player);
        }
    }
}
