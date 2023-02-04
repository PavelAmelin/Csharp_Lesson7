Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число, до которого будут генерироваться числа в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m, n];
for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, N);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }

for (int i = 0; i < arr.GetLength(1); i++)
{
    double sum = 0; 
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        sum += arr[j, i];
    }
    double aver = sum / arr.GetLength(0);
    Console.Write($"{Math.Round(aver, 1)}; ");
}

