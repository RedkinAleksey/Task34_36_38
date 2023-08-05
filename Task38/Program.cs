// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

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

Console.Write("Задайте начальный элемент массива: ");
int minNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте конечный элемент массива: ");
int maxNumber = Convert.ToInt32(Console.ReadLine());

if (minNumber >= maxNumber) 
{
    Console.WriteLine("Конечный элемент массива должен быть больше начального.");
    Console.WriteLine("");
    goto Link1;
}

double[] array = CreateArrayRndDouble(sizeArr, minNumber, maxNumber);

PrintArrayDouble(array);

double max = DifferenceMaxElement(array);
double min = DifferenceMinElement(array);
double difference = Math.Round(max - min, 2);
Console.WriteLine($" => {max} - {min} = {difference}");

double DifferenceMinElement(double[] arr)
{   
    double minElement = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minElement)
        {
            minElement = arr[i];
        }
        minElement = Math.Round(minElement, 2);
    }
    return minElement;
}

double DifferenceMaxElement(double[] arr)
{   
    double maxElement = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxElement)
        {
            maxElement = arr[i];
        }
        maxElement = Math.Round(maxElement, 2);
    }
    return maxElement;
}

double[] CreateArrayRndDouble(int size, int min, int max)
{     
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
 }

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        double roundNum = Math.Round(arr[i], 2);
        if (i < arr.Length - 1) Console.Write($"{roundNum}; ");
        else Console.Write($"{roundNum}");
    }
    Console.Write("]");
}





