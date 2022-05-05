// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


/*
Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во элементов > 0: {count}");

*/

//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

/*

void Main(int n)
{
    int a = 0; 
    int i = 0;
    int[] b = new int[10];
  
     while (n >= 1)
    {
        a = n % 2;
        b[i] = a;
        n = n / 2;
        i++;
        
    }
    for(var j=i-1;j>=0;j--)
    {
        Console.Write(b[j]);
    }
    Console.WriteLine();
}
Console.Write("Введите число: ");
int num10 = Convert.ToInt32(Console.ReadLine());
Main(num10);


*/



