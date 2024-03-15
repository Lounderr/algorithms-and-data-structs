namespace All.FlippingMatrix
{
    internal class FlippingMatrixEx
    {
        private static int FlippingMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0) / 2;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int[] cellPosValues = new int[] {
                        matrix[i, j], matrix[i, 2 * n - 1 - j],
                        matrix[2 * n - 1 - i, j], matrix[2 * n - 1 - i, 2 * n - 1 - j],
                    };

                    sum += cellPosValues.Max();
                }
            }

            return sum;
        }
    }
}
