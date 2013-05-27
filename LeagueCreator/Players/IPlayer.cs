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
    }
}
