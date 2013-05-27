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
        public IEnumerable<IPlayer> Players { get; }


    }
}
