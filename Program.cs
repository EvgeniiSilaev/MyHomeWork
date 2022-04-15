/*

// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Первое чесло: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе чесло: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
    Console.WriteLine("Большее число  " + num1);
else 
    Console.WriteLine("Большее число  " + num2);



// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Первое чесло: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе чесло: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Третье чесло: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1 > num3)
{
    if(num1 >num3)
        Console.WriteLine("Большее число  " + num1);
    else 
        Console.WriteLine("Большее число  " + num3);
}
else
{
    if(num2 >num3)
        Console.WriteLine("Большее число  " + num2);
    else 
        Console.WriteLine("Большее число  " + num3);
} 
 

// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
    Console.WriteLine(num +" да четное число");
else 
    Console.WriteLine(num +" не четное число");



// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int entrance = 1;

while(entrance <= num)
    if(entrance % 2 == 0)
    {
        Console.Write(entrance +".");
        entrance ++;
    }
    else
        entrance ++; 

*/