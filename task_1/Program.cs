// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

Console.Write("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[m, n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().NextDouble()*100;
        Console.Write(Math.Round(matrix[i, j],2) + " ");
    }
    Console.WriteLine();
}
