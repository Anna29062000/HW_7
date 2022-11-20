void FillArrayRandom(int[,] array, int m, int n) // заполенение двумерного массива
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    } 
}

void PrintArray(int[,] array, int m, int n) // вывод двумерного массива
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]}  ");
        }

        Console.WriteLine();
    }
}

void GetArithmeticMean(int[,] array, int m, int n) //поиск среднего арифмитического по столбцам
{
    double sum = 0;
    double mean = 0;

    for (int j = 0; j < n; j++)
    {
        for (int i = 0; i < m; i++ )
        {
            sum = sum + array[i, j];
        }

        mean = sum/m;
        Console.WriteLine($"Среднее арифмитическое столбца под индексом {j}: {mean} ");
        sum = 0;
    }
}

Console.WriteLine("Введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());


int[,] array = new int[m, n];

FillArrayRandom(array, m, n);
PrintArray(array, m, n);
GetArithmeticMean(array, m, n);
