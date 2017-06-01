namespace BuildTower
{
    class BuildTowerKata1
    {
        public string[] TowerBuilder(int nFloors)
        {
            var result = new string[nFloors];
            for (var i = 0; i < nFloors; i++)
            {
                result[i] = string.Concat(new string(' ', nFloors - i - 1), new string('*', 2 * i + 1), new string(' ', nFloors - i - 1));
            }
            return result;
        }
    }
}
