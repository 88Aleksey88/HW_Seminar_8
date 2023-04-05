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
void MultMatrix (int [, ] matrix1, int [, ] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0)) Console.WriteLine ("Невозможно выполнить произведение матриц!");
    else
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int k = 0; k < matrix2.GetLength(1); k++)
                {
                    int sum = 0;
                    for (int j = 0; j < matrix1.GetLength(1); j++)
                        {
                        sum += matrix1 [i,j]*matrix2 [j,k];
                        }
                    Console.Write($"{sum} \t");
                }
            Console.WriteLine();        
        }
    }
}
Console.Clear();
int [, ] matrix1 = InputArray();
PrintMatrix(matrix1);
int [, ] matrix2 = InputArray();
PrintMatrix(matrix2);
MultMatrix (matrix1, matrix2);