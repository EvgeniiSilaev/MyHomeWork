// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*

int AmountOfNaturalElements(int num1, int num2)
{
    if (num2 == num1)
    {
        return num2;
    } 
    return num1 + AmountOfNaturalElements(num1 + 1, num2);
    
}
Console.Write("Enter M values: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N values: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AmountOfNaturalElements(num1,num2));

*/

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

/*

int NumberSum(int num)
{
    if (num < 1) 
    {
        return 0;
    }    
    return NumberSum(num / 10) + num % 10;
}
Console.Write("Enter the number: ");
int Num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sum of digits of the back number: " + NumberSum(Num));

*/