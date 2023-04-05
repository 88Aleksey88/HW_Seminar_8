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
void MinString (int [, ] matrix)
{
    int index = 0;
    int minsum = 1000000; // как сделать очень большое число
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {   
            sum += matrix [i,j];
        }
        Console.WriteLine(sum);
        if (sum < minsum)
        {
            minsum = sum;
            index = i;
        }
    }
    Console.WriteLine($"Индекс строки с наименьшей суммой элементов: {index}");  
}
Console.Clear();
int [, ] matrix = InputArray();
PrintMatrix (matrix);
MinString(matrix);