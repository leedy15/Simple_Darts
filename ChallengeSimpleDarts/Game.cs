using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace ChallengeSimpleDarts
{
    public class Game
    {
        private Player _player1;
        private Player _player2;

        private Random _random;

        public Game(string Player1, string Player2)
        {
            _player1 = new Player();
            _player1.Name = "Player 1";
            _player2 = new Player();
            _player2.Name = "Player 2";

            _random = new Random();
        }

        public string Play()
        {
            while (_player1.Score < 300 && _player2.Score < 300)
            {
                playRound(_player1);
                playRound(_player2);
            }
            return displayResults();
        }

        private string displayResults()
        {
            string result = String.Format("Player 1: {0}<br/> Player 2: {1}<br />", _player1.Score, _player2.Score);
            return result += "Winner: " + (_player1.Score > _player2.Score ? _player1.Name : _player2.Name);
        }

        private void playRound(Player player)
        {
            for (int i = 0; i < 3; i++)
            {
                Dart dart = new Dart(_random);
                dart.Throw();
                Score.ScoreDart(player, dart);
            }
        }
    }
}