public class Matrix
{
    private int[][] matrix;
    public Matrix(string input)
    {
        matrix = input.Split("\n").Select(n => n.Split(' ').Select(i => int.Parse(i)).ToArray()).ToArray();
    }
    public int[] Row(int row) => matrix[row-1];
    public int[] Column(int col)=>matrix.Select(i => i[col - 1]).ToArray();    

}