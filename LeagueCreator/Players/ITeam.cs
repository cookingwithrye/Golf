using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeagueCreator
{
    /// <summary>
    /// Team objects must have these properties
    /// </summary>
    public interface ITeam
    {
        /// <summary>
        /// Players that are part of this team
        /// </summary>
        IEnumerable<IPlayer> Players { get; }

        /// <summary>
        /// Adds a player to a specified team.
        /// </summary>
        /// <param name="Player">The player to add to this team</param>
        void AddPlayer(IPlayer Player);
    }
}
