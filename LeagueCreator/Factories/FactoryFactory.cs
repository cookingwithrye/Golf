using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeagueCreator.Factories
{
    /// <summary>
    /// Entry point for all factories
    /// </summary>
    public static class FactoryFactory
    {
        public static PlayerFactory GetPlayerFactory { get { return new PlayerFactory(); } }
        public static PlayerSheetFactory GetPlayerSheetFactory { get { return new PlayerSheetFactory(); } }
        public static TeamFactory GetTeamFactory { get { return new TeamFactory(); } }
    }
}
