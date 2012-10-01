using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGameKata
{
    [TestClass]
    public class BowlingGameTest
    {
        private Game game;

        [TestInitialize]
        public void TestInitialize()
        {
            game = new Game();
        }

        public void RollMany(int pins, int rolls)
        {
            for (int i = 0; i < rolls; i++)
			{
                game.Roll(pins);
			}
        }

        [TestMethod]
        public void Only1sEquals20()
        {
            RollMany(1, 20);

            Assert.AreEqual(20, game.Score());
        }

        [TestMethod]
        public void ASpareGivesDoubleTheNextRoll()
        {
            game.Roll(5);
            game.Roll(5); // spare
            RollMany(1, 18);
            Assert.AreEqual(29, game.Score(), "Because of the spare, the first roll after the spare counts double");
        }

        [TestMethod]
        public void AStrikeGivesDoubleTheTwoNextBallsRolled()
        {
            game.Roll(10);
            game.Roll(1);
            game.Roll(1);
            RollMany(0, 17);
            Assert.AreEqual(14, game.Score());
        }

        [TestMethod]
        public void ASpareOnTenthFrameIsAllowedAnExtraRollToCompleteTheFrame()
        {
            RollMany(1, 19);
            game.Roll(9); // spare
            game.Roll(1);
            Assert.AreEqual(29, game.Score());
        }

        [TestMethod]
        public void APerfectGame()
        {
            RollMany(10, 12);
            Assert.AreEqual(300, game.Score());
        }

        class Game
        {
            List<int> rolls = new List<int>();

            public int Score()
            {
                int sum = 0;

                int i = 0;
                for (int frame = 0; frame < 10; frame++)
                {
                    if (rolls[i] == 10)
                    {
                        sum += 10 + rolls[i + 1] + rolls[i + 2];
                        i += 1;
                    }
                    else if (rolls[i] + rolls[i + 1] == 10)
                    {
                        sum += 10 + rolls[i + 2];
                        i += 2;
                    }
                    else
                    {
                        sum += rolls[i] + rolls[i + 1];
                        i += 2;
                    }
                }

                return sum;
            }

            internal void Roll(int pins)
            {
                rolls.Add(pins);
            }
        }
    }
}
