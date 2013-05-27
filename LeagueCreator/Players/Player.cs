using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeagueCreator.Players
{
    /// <summary>
    /// Concrete player implementation
    /// </summary>
    public class Player : IPlayer
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }

        /// <summary>
        /// Is this player a captain?
        /// </summary>
        public bool IsCaptain { get; private set; }

        /// <summary>
        /// Creates a player with the given properties.
        /// </summary>
        /// <param name="Firstname">Required</param>
        /// <param name="Lastname">Required</param>
        /// <param name="IsCaptain">True if this player is a captain</param>
        /// <param name="Phone"></param>
        /// <param name="Email"></param>
        /// <returns>New concrete player object</returns>
        public Player(string Firstname, string Lastname, bool IsCaptain, string Phone, string Email)
        {
            if (String.IsNullOrWhiteSpace(Firstname) || String.IsNullOrWhiteSpace(Lastname))
                throw new Exception("All players must have a name");


        }
    }
}
