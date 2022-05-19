
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. m = 3, n = 4.

/*

void Create2DArray(double[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * 100;
        }
    }
}
void PrintCreatedArray(double[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:F} , ");
        }
        Console.WriteLine();
    }
}
int strings = 4;
int column = 3;
double[,] array = new double [strings,column];

Create2DArray(array);
PrintCreatedArray(array);

*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*

void Create2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}

void PrintCreatedArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,-3}", array[i, j]);
        }
        Console.WriteLine();
    }
}
Console.Write("Enter size row of 2D matrix: ");
int strings = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the column size of the 2D array: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[strings, column];

void PositionInArray(int[,] array)
{
    Console.Write("Enter the string:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter column:");
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num1 < 0 | num1 > array.GetLength(0) | num2 < 0 | num2 > array.GetLength(1))
    {
        Console.WriteLine("Element does not exist");
    }
    else
    {
        Console.WriteLine("Array element value = {0}", array[num1, num2]);
    }
}

Create2DArray(array);
PrintCreatedArray(array);
PositionInArray(array);

*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*

void Create2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1,10);
        }
    }
}
void PrintCreatedArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine(); 
    }
}
string Average(int[,] array)
{
    string result = string.Empty;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        int count = 0;
        double aver = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
            count++;
        }
        aver = sum / count;
        result += aver.ToString() + " ; ";
        
    }
    return result;
    
}
int line = 3;
int column = 4;
int[,] MyArray = new int[line, column];
Create2DArray(MyArray);
PrintCreatedArray(MyArray);
Console.WriteLine($"Arithmetic mean of a column: {Average(MyArray)}");  

*/ 
