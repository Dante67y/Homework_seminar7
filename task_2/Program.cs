// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает
// значение этого элемента или же указание, что такого элемента нет

// Поиск по координатам, вывод числа
int[,] CreateArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(1, 100);
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
    return matrix;
}

void CheckMatrix(int i, int j, int[,] matrix)
{
    if (i - 1 < matrix.GetLength(0) && j - 1 < matrix.GetLength(1) && i > 0 && j > 0)
        Console.WriteLine(matrix[i - 1, j - 1]);
    else Console.WriteLine("Элемент не существует.");
}
// Координаты вводятся со стороны пользователя начиная от 1:1 (нулевых строки и столбца нет)
Console.Write("Введите координаты: ");
int i = Convert.ToInt32(Console.ReadLine());
int j = Convert.ToInt32(Console.ReadLine());
CheckMatrix(i, j, CreateArray(4, 4));

// // Поиск числа, вывод координат

// int[,] CreateArray(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 100);
//             Console.Write(matrix[i, j] + " \t");
//         }
//         Console.WriteLine();
//     }
//     return matrix;
// }

// void CheckMatrix(int FindNumber, int[,] matrix)
// {
//     int i = 0, j = 0;
//     if (i < matrix.GetLength(0)) i++;
//     if (j < matrix.GetLength(1)) j++;
//     if (matrix[i, j] == FindNumber)
//         Console.WriteLine(string.Join(" ", i + 1, j + 1));
//     else Console.WriteLine("Элемент не существует.");
// }
// Console.Write("Введите количество строк в массиве: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число, которое нужно найти: ");
// int FindNumber = Convert.ToInt32(Console.ReadLine());
// CheckMatrix(CreateArray(4, 4));

// Попробовал вывести координаты искомого числа, не вышло
// Выдвёт ошибку: ...task_2\Program.cs(64,1): "error CS7036: Отсутствует аргумент, соответс твующий
// требуемому формальному параметру "matrix" из "CheckMatrix(int, int[*,*])".
