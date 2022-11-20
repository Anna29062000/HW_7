void FillArrayRandom(int[,] array, int line, int column) // заполенение двумерного массива
{
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    } 
}

void PrintArray(int[,] array, int line, int column) // вывод двумерного массива
{
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N:");
int n = Convert.ToInt32(Console.ReadLine());

int line = 9;
int column = 10;

int[,] array = new int[line, column];

FillArrayRandom(array, line, column);
PrintArray(array, line, column);

if (m < line && n < column)
{
    Console.WriteLine($"Элемент массива на позиции [{m}, {n}]: {array[m, n]}");
}
else
{
    Console.WriteLine("Элемента с такой позицией нет");
}