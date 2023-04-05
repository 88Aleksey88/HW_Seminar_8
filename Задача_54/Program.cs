int [, ] InputArray()
{
    Console.Write("Введите размер матрицы: ");
    int[] SizeOfMatrix = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int[,] matrix = new int[SizeOfMatrix[0], SizeOfMatrix[1]];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) matrix [i,j] = new Random().Next(1,10);
    }
    return matrix;
}
void PrintArray(int[,] matrix)
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
void SortRows (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = j+1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, j] < matrix [i, k])
                    {
                        int temp = matrix [i, j];
                        matrix [i, j] = matrix [i, k];
                        matrix [i, k] = temp;
                    }
            }
            Console.Write($"{matrix[i,j]} \t");            
        }
        Console.WriteLine();
    }
    
}
Console.Clear();
int[, ] matrix = InputArray();
PrintArray(matrix);
SortRows(matrix);