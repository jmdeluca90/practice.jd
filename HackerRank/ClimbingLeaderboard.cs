using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.jd.HackerRank
{
    public  class ClimbingLeaderboard
    {
        public static List<int> climbingDaLeaderboard(List<int> ranked, List<int> player)
        {
            List<int> playerRankings = new List<int>();
            List<int> rankedNoDups = ranked.Distinct().ToList();
            int count = rankedNoDups.Count;
            int end = count - 1;
            foreach (int score in player)
            {
                while (end >= 0 && score >= rankedNoDups[end])
                {
                    end--;
                }
                playerRankings.Add(end + 2);
            }
            return playerRankings;
        }
    }
}
