// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

Link1:

Console.Write("Задайте количество элементов массива: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());

if (sizeArr < 1) 
{
    Console.WriteLine("Количетсво элементов массива должно быть больше нуля.");
    Console.WriteLine("");
    goto Link1;
}

Console.Write("Задайте минимальное число: ");
int minNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте максимальное число: ");
int maxNumber = Convert.ToInt32(Console.ReadLine());

if (minNumber >= maxNumber) 
{
    Console.WriteLine("Максимальное число должно быть больше минимального.");
    Console.WriteLine("");
    goto Link1;
}

int[] array = CreateArrayRnd(sizeArr, minNumber, maxNumber);

PrintArray(array);

SumOddElements(array);

int[] CreateArrayRnd(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

void SumOddElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) sum += arr[i];
    }
    
    Console.Write($" -> {sum}");
}