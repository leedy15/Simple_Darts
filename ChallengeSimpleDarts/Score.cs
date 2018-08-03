using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace ChallengeSimpleDarts
{
    public class Score
    {
        public static int Bullseye(Player player, Dart dart)
        {
            int bullseyeScore = 0;
            if (dart.IsTriple && dart.Score == 0) bullseyeScore = 50;
            else if (dart.Score == 0) bullseyeScore = 25;
            return bullseyeScore;
        }

        public static void ScoreDart(Player player, Dart dart)
        {
            int score = 0;
            if (dart.IsDouble) score = dart.Score * 2;
            else if (dart.IsTriple) score = dart.Score * 3;
            else score = dart.Score;
            score += Bullseye(player, dart);
            player.Score += score;
            
        }
    }
}