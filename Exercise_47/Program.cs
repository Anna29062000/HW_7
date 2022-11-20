void FillArrayRandom(double[,] array, int m, int n) // заполенение двумерного массива
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * 100;
        }
    } 
}

void PrintArray(double[,] array, int m, int n) // вывод двумерного массива
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{Math.Round(array[i, j], 2)}  ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк в двумерном массиве:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в двумерном массиве:");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

FillArrayRandom(array, m, n);
PrintArray(array, m, n);

