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
    public static class PlayerFactory
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
        public static IPlayer CreatePlayer(string Firstname, string Lastname, string IsCaptain, string Phone, string Email, string HasRestriction)
        {
            return new Player(Firstname.Trim(), Lastname.Trim(), Phone: Phone.Trim(), Email: Email.Trim(), HasRestriction: HasRestriction.Trim(),
                IsCaptain: captainStrings.Contains(IsCaptain.ToUpperInvariant()));
        }
    }
}