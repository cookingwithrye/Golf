using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LeagueCreator.Players;

namespace LeagueCreator.Factories
{
    public static class TeamFactory
    {
        /// <summary>
        /// Creates a concrete class for a team
        /// </summary>
        /// <returns></returns>
        public static ITeam CreateTeam()
        {
            return new Team();
        }

        /// <summary>
        /// Creates the specified number of empty teams.
        /// </summary>
        /// <param name="numTeams">Number of teams to create</param>
        /// <returns></returns>
        public static IEnumerable<ITeam> CreateTeams(int numTeams)
        {
            for (int i = 0; i < numTeams; i++)
                yield return CreateTeam();
        }
    }
}
