// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

Console.Write("Задайте минимальное положительное трехзначное число: ");
int minNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте максимальное положительное трехзначное число: ");
int maxNumber = Convert.ToInt32(Console.ReadLine());

if ((minNumber<100 || minNumber > 999) || (maxNumber<100 || maxNumber > 999) || (minNumber >= maxNumber)) 
{
    Console.WriteLine("Заданы некорректные значения.");
    Console.WriteLine("");
    goto Link1;
}

int[] array = CreateArrayRnd(sizeArr, minNumber, maxNumber);

PrintArray(array);

int result = NumberEvenNumbers(array);

Console.Write($" => {result}.");

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

int NumberEvenNumbers(int[] arr) 
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;           
    }
    return count;
}
