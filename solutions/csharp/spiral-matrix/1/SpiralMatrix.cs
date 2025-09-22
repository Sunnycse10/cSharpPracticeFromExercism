public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        int[,] matrix = new int[size, size];
        int count = 1;
        int RowMax = size-1, ColMax = size-1, RowMin=0, ColMin=0;
        while (count <= size * size)
        {
            for (int i = ColMin; i <= ColMax; i++)
            {
                matrix[RowMin,i] = count++;
            }
            RowMin++;
            for (int i = RowMin; i <= RowMax; i++) {
                matrix[i, ColMax]= count++;
            }
            ColMax--;
            for (int i = ColMax; i >= ColMin; i--)
            {
                matrix[RowMax, i] = count++;
            }
            RowMax--;
            for(int i=RowMax;i>=RowMin;i--)
            {
                matrix[i, ColMin] = count++;

            }
            ColMin++;
            
        }
        return matrix;
    }
}
