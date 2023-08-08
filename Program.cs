// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Task 34");

int[] CreateRandomArrT1(int size, int minVal, int maxVal)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minVal, maxVal + 1);
    }
    return arr;
}

void WriteArrT1(int[] arr)
{
    string arrEl = string.Join(", ", arr);
    Console.Write($"[{arrEl}]");
}

int GetEvenNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
Console.Write("Input a length of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min passible value: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max passible value: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

if (minVal > 99 && maxVal < 1000 && (minVal <= maxVal))
{

    int[] arrT1 = CreateRandomArrT1(m, minVal, maxVal);
    WriteArrT1(arrT1);
    Console.WriteLine($" -> {GetEvenNum(arrT1)}");
}
else
    Console.Write("Enter three digit numbers !");


/* // Задача 34: Для всех трехзначных чисел в том числе и отрицателны
// выводит только трехзначные числа но на любом интервале

Console.WriteLine("Task 34. For any elements");

int[] CreateRandomArr(int size, int minVal, int maxVal)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        while (true)
        {
            arr[i] = new Random().Next(minVal, maxVal + 1);
            if (Math.Abs(arr[i]) > 99 && Math.Abs(arr[i]) < 1000)
                break;
        }
    }
    return arr;
}

void WriteArr(int[] arr)
{
    string arrEl = string.Join(", ", arr);
    Console.Write($"[{arrEl}]");
}

int GetEvenNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
Console.Write("Input a length of array: ");
int len = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min passible value: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max passible value: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

if (minVal < -999) minVal = -999;
if (maxVal > 999) maxVal = 999;

if ((Math.Abs(minVal) < 100) && (Math.Abs(maxVal) < 100) || (minVal > maxVal))
    Console.Write("There are no three-digit numbers in this interval !");
else
{
    int[] arr = CreateRandomArr(len, minVal, maxVal);
    WriteArr(arr);
    Console.WriteLine($" -> {GetEvenNum(arr)}");
}
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("\nTask 36");

int[] CreateRandomArr(int size, int minVal, int maxVal)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minVal, maxVal + 1);
    }
    return arr;
}

void WriteArr(int[] arr)
{
    string arrEl = string.Join(", ", arr);
    Console.Write($"[{arrEl}]");
}

int GetIndex(int[] arr) 
{
    int sum = 0;
       for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum+=arr[i];
        }
        //i+=2 :D
        //sum+=arr[i] :D
    }
    return sum;
}
Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min passible value: ");
int MinVal = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max passible value: ");
int MaxVal = Convert.ToInt32(Console.ReadLine());

int[] arrT2 = CreateRandomArr(length, MinVal, MaxVal);
WriteArr(arrT2);
Console.WriteLine($" -> {GetIndex(arrT2)}");


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.WriteLine("\nTask 38");

double[] CreateArr(int size)
{
    double[] arr = new double[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter element {i + 1}: ");
        arr[i] = Convert.ToDouble(Console.ReadLine());
    }
    return arr;
}

void WriteArrT3(double[] arr)
{
    string arrEl = string.Join(", ", arr);
    Console.Write($"[{arrEl}] => ");
}

double GetMinMax(double[] arr)
{
    double max = arr[0];
    double min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
        else if (arr[i] < min)
            min = arr[i];
    }
    if (min < 0)
        Console.Write($"{max} - ({min}) = ");
    else
        Console.Write($"{max} - {min} = ");

    return max - min;
}

Console.Write("Input a length of array: ");
int lenT3  = Convert.ToInt32(Console.ReadLine());

double[] arrT3 = CreateArr(lenT3);
WriteArrT3(arrT3);
Console.WriteLine($"{GetMinMax(arrT3)}");

// заранее не подумала, что можно было каждое задание в свой 1 воид объеденить вместо того, чтобы переменные перемеиновывать
// но я не знаю если он будет жаловаться на воид внутри воида