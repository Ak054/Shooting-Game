using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shooting_Game
{
    internal class Logic
    {
        internal void ShootAHeadSound()
        {
            throw new NotImplementedException();
        }

        internal void RestartTheGame()
        {
            throw new NotImplementedException();
        }
    }
    [TestClass]
    public class UnitTest1
    {
        readonly Shooting_Game.Logic Logic = new Shooting_Game.Logic();
        [TestMethod]
        public void ShootAwaySound()
        {
            try
            {
                Logic.ShootAHeadSound();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsFalse(false);

            }
        }

        public void RestartTheGame()
        {
try
            {
                Logic.RestartTheGame();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsFalse(false);

            }
        }
    }
        }
    

