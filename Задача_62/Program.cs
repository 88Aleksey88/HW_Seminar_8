
int [, ] FillMatrix (int [, ]matrix, int n)
{
    for (int j = n + 1; j < matrix.GetLength(1) - n; j++) 
    {
        matrix [n, j] = matrix [n, j-1]+1;
    }
    for (int i = n + 1; i < matrix.GetLength(0) - n; i++) 
    {
        matrix [i, matrix.GetLength(1)-n-1] = matrix[i-1, matrix.GetLength(1)-n-1] + 1;
    }
    for (int j = matrix.GetLength(1) - n - 2; j >= n; j--) 
    {
        matrix [matrix.GetLength(0)-1-n, j] = matrix [matrix.GetLength(0)-1-n, j+1]+1;
    }
    for (int i = matrix.GetLength(0) - 2 - n; i > n; i--)
    {
        matrix [i, n] = matrix [i+1, n] + 1;
    }
    if (matrix [n+1, n+1] == 0) 
    {
    matrix[n+1,n+1]=matrix[n+1,n]+1;
    FillMatrix(matrix,n+1);
    }
    return matrix;
}
void PrintMatrix(int[, ] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            System.Console.Write($"{matrix[rows, columns]} \t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
Console.Clear();
Console.Write("Введите размер матрицы через пробел: ");
int [] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int [,] matrix = new int [size[0], size[1]];
matrix[0,0] = 1;
FillMatrix(matrix,0);
PrintMatrix(matrix);