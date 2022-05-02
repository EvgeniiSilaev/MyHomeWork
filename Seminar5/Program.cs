
/*

// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int NaturalDegree (int A, int B)
{
    int a = A;
    int b = B;
    int num = 1;
    
    for(int i = 0;  i < b; i++)
    {
        num = num*a;
    }
    return num;
}
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = NaturalDegree(A,B);
Console.WriteLine(result);

*/

// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

/*

void Amount(int num)
 {
     int num1=num;
     int num2;
     int summa=0;
     while(num1>0)
     {
         num2=num1%10;
         num1=num1/10;
         summa=summa+num2;
     }
     Console.WriteLine(summa);
    
 }
 Console.WriteLine("Введите число ");
 int num = Convert.ToInt32(Console.ReadLine());
 Amount(num);
 */

 // Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*

 void Array()
{
    int[] array = new int[8];
    Random newRandom = new Random();
    Console.WriteLine( " " );
    for (int i = 0; i < array.Length; i++)
    {
    array[i] = newRandom.Next(0, 99);
    Console.Write("{0} ", array[i]);
    }
}
Array();

*/