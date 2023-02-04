void GetArray()
{
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число, до модуля которого будут генерироваться числа в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
double[,] arr = new double[m, n];
for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round((new Random().NextDouble() * 2 - 1) * N, 1);
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }    
}

GetArray();