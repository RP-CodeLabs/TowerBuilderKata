using System.Linq;

namespace BuildTower
{
    public class BuildTowerKata2
    {
        public string[] TowerBuilder(int nFloors)
        {
            return Enumerable.Range(1, nFloors)
                .Select(n => string.Format("{0}{1}{0}", n == nFloors ? "" : new string(' ', nFloors - 1), new string('*', 2 * n - 1))).ToArray();
        }
    }
}
