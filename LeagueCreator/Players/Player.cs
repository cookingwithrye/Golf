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

        public string HasRestriction { get; private set; }

        /// <summary>
        /// Creates a player with the given properties.
        /// </summary>
        /// <param name="Firstname">Required</param>
        /// <param name="Lastname">Required</param>
        /// <param name="IsCaptain">True if this player is a captain</param>
        /// <param name="Phone"></param>
        /// <param name="Email"></param>
        /// <returns>New concrete player object</returns>
        public Player(string Firstname, string Lastname, bool IsCaptain, string Phone, string Email, string HasRestriction)
        {
            if (String.IsNullOrWhiteSpace(Firstname) || String.IsNullOrWhiteSpace(Lastname))
                throw new Exception("All players must have a name");

            this.FirstName = FirstName;
            this.LastName = LastName;
            this.IsCaptain = IsCaptain;
            this.Phone = Phone;
            this.Email = Email;
            this.HasRestriction = HasRestriction.Trim();
        }

        /// <summary>
        /// Puts this player on one of the given teams.
        /// </summary>
        public void putMeOnTeam(IEnumerable<ITeam> Teams, Random random)
        {
            if (!String.IsNullOrEmpty(this.HasRestriction))
            {
                //see if another player from this group has already been placed on a team, and if so then this player must also go there. Otherwise this player can go on any team
                ITeam otherPlayersTeam = Teams.FirstOrDefault(c => c.Players.Contains(this));
                if (otherPlayersTeam != null)
                {
                    otherPlayersTeam.AddPlayer(this);
                    return;
                }
            }
            
            //FIX: If too many players are grouped together then it could create weird counting for the teams. This could be corrected here by checking to see if any teams are more than two less in count than the others.
            
            //otherwise just randomly add this player to any of the given teams
            Teams.Skip(random.Next(Teams.Count())).First().AddPlayer(this);
        }
    }
}
