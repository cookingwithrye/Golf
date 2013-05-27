using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LeagueCreator.Players;

namespace LeagueCreator.Factories
{
    /// <summary>
    /// Generates players
    /// </summary>
    public class PlayerFactory
    {
        /// <summary>
        /// All valid strings which indicate that a player is a captain
        /// </summary>
        private static string[] captainStrings = new string[] { "Y", "YES" };
        
        /// <summary>
        /// Creates a player with the given properties.
        /// </summary>
        /// <param name="Firstname">Required</param>
        /// <param name="Lastname">Required</param>
        /// <param name="IsCaptain">'Y', 'YES', case-insensitive will evaluate to true in concrete object. All other values will result in false</param>
        /// <param name="Phone"></param>
        /// <param name="Email"></param>
        /// <returns>New concrete player object</returns>
        public static IPlayer CreatePlayer(string Firstname, string Lastname, string IsCaptain, string Phone, string Email)
        {
            return new Player(Firstname, Lastname, Phone: Phone, Email: Email,
                IsCaptain: captainStrings.Contains(IsCaptain.ToUpperInvariant()));
        }
    }
}