// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

/*

int[,] CreatedArray(int size1, int size2)
{
    int[,] array = new int[size1, size2];
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }

    }
    return array;
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
void SortInAscendingOrder(int[,] size)

{
    for (int i = 0; i < size.GetLength(0); i++)
    {
        for (int j = 0; j < size.GetLength(1); j++)
        {
            for (int k = j + 1; k < size.GetLength(1); k++)
            {
                if (size[i, j] > size[i, k])
                {
                    int t = size[i, j];
                    size[i, j] = size[i, k];
                    size[i, k] = t;
                }
            }
        }
    }
}
int[,] Arr = CreatedArray(3, 4);
Console.WriteLine("Source array:");
PrintCreatedArray(Arr);
SortInAscendingOrder(Arr);
Console.WriteLine("Sort in ascending order:");
PrintCreatedArray(Arr);

*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*

int[,] CreatedArray(int size1, int size2)
{
    int[,] array = new int[size1, size2];
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }

    }
    return array;
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

int SmallestAmount(int[,] size)
{
    int sum = 0;
    int sumMin = 0;
    int num = 0;
    for (int i = 0; i < size.GetLength(0); i++)
    {
        for (int j = 0; j < size.GetLength(1); j++)
        {
            if (i == 0) 
            {
                sum += size[i, j];
                sumMin += size[i, j]; 
            }
            else sum += size[i, j]; 
        }
        if (sum < sumMin)
        {
            sumMin = sum;
            num = i;
        }
        sum = 0;
    }
    return num;
}
int[,] MyArr = CreatedArray(4,4);
PrintCreatedArray(MyArr);
Console.Write("Row with the smallest sum of elements: " + SmallestAmount(MyArr) + "  ");

*/

// Задача 62. Заполните спирально массив 4 на 4.

/*

void SpiralArray(int[,] array)
{
    int a = 1;
    int b = 1;
    int c = 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        array[0, i] = a;
        a++;
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        array[i, array.GetLength(1) - 1] = a;
        a++;
    }
    for (int i = array.GetLength(1) - 2; i >= 0; i--)
    {
        array[array.GetLength(0) - 1, i] = a;
        a++;
    }
    for (int i = array.GetLength(0) - 2; i > 0; i--)
    {
        array[i, 0] = a;
        a++;
    }

    while (a < array.GetLength(0) * array.GetLength(1))
    {
        while (array[b, c + 1] == 0)
        {
            array[b, c] = a;
            a++;
            c++;
        }
        while (array[b + 1, c] == 0)
        {
            array[b, c] = a;
            a++;
            b++;
        }
        while (array[b, c - 1] == 0)
        {
            array[b, c] = a;
            a++;
            c--;
        }
        while (array[b - 1, c] == 0)
        {
            array[b, c] = a;
            a++;
            b--;
        }
    }
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            if (array[x, y] == 0)
            {
                array[x, y] = a;
            }
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {

                Console.Write(array[i, j] + " ");
            }
            else
            {
                Console.Write(array[i, j] + " ");
            }
        }
        Console.WriteLine();
    }

}

int[,] NewArray = new int[4, 4];
SpiralArray(NewArray);
Console.WriteLine();

*/

