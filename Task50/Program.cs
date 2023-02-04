int[,] GetArray()
{
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
    return arr;     
}

void InOrNotinArray(int[,] nums)
{
    Console.Write("Введите число: ");
    int ch = Convert.ToInt32(Console.ReadLine());
    bool flag = false;
    for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                if (ch == nums[i, j])
                {
                    Console.WriteLine($"{ch}");
                    flag = true; 
                    break; 
                }
            }
        if (flag == true)
            break;
        }
    if (flag == false)
        Console.WriteLine("Такого числа в массиве нет");
}

InOrNotinArray(GetArray());
