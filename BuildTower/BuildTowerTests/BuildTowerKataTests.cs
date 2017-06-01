using BuildTower;
using NUnit.Framework;

namespace BuildTowerTests
{
    [TestFixture]
    public class BuildTowerKataTests
    {
        private BuildTowerKata _buildTowerKata;

        [OneTimeSetUp]
        public void Setup()
        {
            _buildTowerKata = new BuildTowerKata();
        }

        [Test]
        public void TowerBuilder_BuildOneTower()
        {
            var result = _buildTowerKata.TowerBuilder(1);
            Assert.AreEqual(string.Join(",", "*"), string.Join(",", result));
        }

        [Test]
        public void TowerBuilder_BuildTwoTower()
        {
            var result = _buildTowerKata.TowerBuilder(2);
            Assert.AreEqual(string.Join(",", " * ", "***"), string.Join(",", result));
        }

        [Test]
        public void TowerBuilder_BuildTowerWithThreeLevels()
        {
            var result = _buildTowerKata.TowerBuilder(3);
            Assert.AreEqual(string.Join(",", "  *  ", " *** ", "*****"), string.Join(",", result));
        }

        [Test]
        public void TowerBuilder_BuildTowerWithFourLevels()
        {
            var result = _buildTowerKata.TowerBuilder(4);
            Assert.AreEqual(string.Join(",", "   *   ", "  ***  ", " ***** ", "*******"), string.Join(",", result));
        }
    }
}
