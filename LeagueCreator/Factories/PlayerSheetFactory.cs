using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeagueCreator
{
    /// <summary>
    /// Generates a concrete class for loading and manipulating a player sheet
    /// </summary>
    public class PlayerSheetFactory
    {
        /// <summary>
        /// Retrieves a player sheet from a specified file
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static IPlayerSheet GetPlayerSheet(string filename)
        {
            return new PlayerSheet(filename);
        }
    }
}
