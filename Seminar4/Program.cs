/*

// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int EvenNumbers(int size, int min, int max)
{
    int[] a = new int[size];
    int count = 0;
    for(int i = 0; i < size; i++)
    {
        a[i] = new Random().Next(min,max);
        Console.Write(a[i] + " " );
        if (a[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
    Console.WriteLine(count);
}
Console.WriteLine("Введите длину массива : ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Четных чисел - " + (EvenNumbers(size, min, max)));
Console.WriteLine();

*/

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*

int EvenNumbers(int size, int min, int max)
{
    int[] a = new int[size];
    int sum = 0;
    for(int i = 0; i < size; i++)
    {
    a[i] = new Random().Next(min,max);
    Console.Write(a[i] + " " );
        if (i % 2 != 0)
        {
            sum = sum +a[i];
        }
    }
    return sum;
    Console.WriteLine(sum);
}

Console.WriteLine("Введите длину массива : ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Cумма чисел на нечетных позициях - " + (EvenNumbers(size, min, max)));
Console.WriteLine();

*/

/*

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] Array = new int[5];

void ElementDifferences(int[] Array)
{
    for(int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i] +" ");
    }
}

for(int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(1,25);
}

 int max = Array[0];
 int min = Array[0];
 int difference = 0;
 for(int i = 0; i < Array.Length; i++)
 {
     if(Array[i] > max)
     max = Array[i];

     if(Array[i] < min)
     min = Array[i];

    difference = max - min;
 }
Console.WriteLine($"Maксимальное значения в массиве: {max} ");
Console.WriteLine($"Mинимальное значения в массиве: {min} ");
Console.WriteLine($"Разница между значениями: {difference} ");

ElementDifferences(Array);

*/