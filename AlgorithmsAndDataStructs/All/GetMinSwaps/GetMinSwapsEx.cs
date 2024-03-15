using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All.GetMinSwaps
{
    internal class GetMinSwapsEx
    {
        public static int GetMinSwaps(List<int> elements)
        {
            List<int> ordered = elements.OrderBy(x => x).ToList();

            int swaps = 0;

            for (int i = 0; i < elements.Count; i++)
            {
                for (int j = 0; j < elements.Count; j++)
                {
                    if (elements[i] == ordered[j])
                    {
                        if (elements.SequenceEqual(ordered))
                            return swaps;

                        if (i == j)
                            break;

                        Swap(elements, i, j);
                        swaps++;
                    }
                }
            }

            return swaps;
        }

        private static void Swap(List<int> elements, int i, int j)
        {
            int temp = elements[i];
            elements[i] = elements[j];
            elements[j] = temp;
        }
    }
}
