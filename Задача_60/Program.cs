void InputArray()
{
    Console.Write("Введите размер матрицы: ");
    int[] sizeOfMatrix = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int[, ,] matrix = new int[sizeOfMatrix[0], sizeOfMatrix[1], sizeOfMatrix[2]];
    Console.WriteLine ("Элементы трехмерного массива: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                matrix [i,j,k] = new Random().Next(10,100);
                Console.WriteLine ($"A[{i},{j},{k}] = {matrix[i,j,k]}");
                }
            }
    }
}
InputArray();