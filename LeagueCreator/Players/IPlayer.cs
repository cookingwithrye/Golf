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
        public string FirstName { get; }
        public string LastName { get; }
        public string Phone { get; }
        public string Email { get; }
        
        /// <summary>
        /// Is this player a captain?
        /// </summary>
        public bool IsCaptain { get; }
    }
}
