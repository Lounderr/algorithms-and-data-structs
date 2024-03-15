namespace All
{
    public class Dump
    {
        private static int GetZeros(int[] ints)
        {
            int countZeros = 0;

            List<int> multipliers = new List<int>();

            for (int i = 0; i < ints.Length; i++)
            {
                multipliers.AddRange(GetSimpleMultipliers(ints[i]));
            }

            // Can be optimized in one for cycle
            int count2s = multipliers.Count(x => x == 2);
            int count5s = multipliers.Count(x => x == 5);

            countZeros += Math.Min(count2s, count5s);

            return countZeros;
        }

        private static int GetZerosPower(int n)
        {
            int countZeros = 0;
            for (int i = 0; i < n; i++)
            {

                List<int> multipliers = GetSimpleMultipliers(n);

                // Can be optimized in one for cycle
                int count2s = multipliers.Count(x => x == 2);
                int count5s = multipliers.Count(x => x == 5);

                countZeros += Math.Min(count2s, count5s);
            }

            return countZeros;
        }

        private static List<int> GetSimpleMultipliers(int n)
        {
            List<int> result = new List<int>();

            int d = 2;

            while (n != 1)
            {
                if (n % d == 0)
                {
                    n /= d;
                    result.Add(d);
                }
                else
                    d++;
            }

            return result;
        }

    }
}