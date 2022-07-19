// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

double[,] CreateMatr(int m, int n)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().NextDouble()*100;
        }
    }
    return matrix;
}

void PrintMatr(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(Math.Round(matrix[i, j],2) + " ");
        }
        Console.WriteLine();
    }
}
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
PrintMatr(CreateMatr(m, n));
