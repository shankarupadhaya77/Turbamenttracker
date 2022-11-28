using System;
using System.Collections.Generic;
using System.Text;

namespace TrakerLibrary
{
   public class MatchupEntryModel
    {
        /// <summary>
        /// represents one team in the matchup 
        /// </summary>
        public TeamModel Teamcompeting { get; set; }
        /// <summary>
        /// represents the scope for a particular team
        /// 
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents the matchup that this team came from as the winner
        /// </summary>

        public MatchupModel ParentMatchup { get; set; }
   
    }

}
