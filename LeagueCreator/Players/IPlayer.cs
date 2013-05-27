using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeagueCreator
{
    /// <summary>
    /// Player objects must have these properties
    /// </summary>
    public interface IPlayer
    {
        string FirstName { get; }
        string LastName { get; }
        string Phone { get; }
        string Email { get; }
        
        /// <summary>
        /// Is this player a captain?
        /// </summary>
        bool IsCaptain { get; }

        /// <summary>
        /// Does this player have some kind of restriction that is supposed to keep them matched up with another (possibly multiple other) players?
        /// </summary>
        string HasRestriction { get; }

        /// <summary>
        /// Puts this player on one of the given teams.
        /// </summary>
        /// <param name="Teams">The available teams to choose from</param>
        /// <param name="random">The random-number generator being used to place players on different teams</param>
        void putMeOnTeam(IEnumerable<ITeam> Teams, Random random);
    }
}
