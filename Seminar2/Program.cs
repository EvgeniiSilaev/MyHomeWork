// Задача 10 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

/*

void secondNum(int num)
{
    int num2 = num/10;
    int second = num2%10;
    Console.WriteLine("Второе число: - " + second);
}
Console.WriteLine("Введите число: " );
int num = Convert.ToInt32(Console.ReadLine());
secondNum(num);

*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*

void threNum(int num)
{
    if(num/100<1)
    {
        Console.WriteLine("Третей цифры нет " );
    }
    else
    {
        while (num/100>10)
        num = num/10;
        int three = num%10;
        Console.WriteLine("Третья цифра равна " + three);             
    }
}
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
threNum(num);

*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*

void weekend(int day)
{
    if(day>7)
    {
        Console.WriteLine("Дня с таким номером нет");
    }
    else
    {
        if(day < 6)
            {
            Console.WriteLine("нет");
            }
        else
            {
            Console.WriteLine("да");
            }
    }          
}   
Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
weekend(day);

*/

        
                       
 