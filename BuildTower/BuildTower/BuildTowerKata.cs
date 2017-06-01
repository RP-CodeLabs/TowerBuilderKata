using System.Collections.Generic;
using System.Linq;

namespace BuildTower
{
    public class BuildTowerKata
    {
        public string[] TowerBuilder(int nFloors)
        {
            var tower = new List<string>();
            for (var level = 1; level <= nFloors; level++)
            {
                var floor = SetFloorForTower(nFloors);
                FormatFloor(floor, level);
                tower.Add(new string(floor));
            }
            return tower.ToArray();
        }

        private void FormatFloor(IList<char> floor, int level)
        {
            var noOfStars = Length(level);
            for (var i = 0; i < (floor.Count - 1) - noOfStars; i++)
            {
                if (floor.Count(x => x == '*') == noOfStars) continue;
                floor[i] = ' ';
                floor[(floor.Count - 1) - i] = ' ';
            }
        }

        private char[] SetFloorForTower(int nFloors)
        {
            var towerLength = Length(nFloors);
            var floor = new char[towerLength];
            for (var j = 0; j < towerLength; j++)
            {
                floor[j] = '*';
            }
            return floor;
        }

        private int Length(int n)
        {
            return n + (n - 1);
        }
    }
}
