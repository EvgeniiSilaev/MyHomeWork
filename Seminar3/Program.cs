/*

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void isPal(int num)
{
    int num1=num;
    int num2;
    int num3=0;
    while(num1>0)
    {
        num2=num1%10;
        num3=num3*10+num2;
        num1=num1/10;
    }
    if (num3==num)
    {
        Console.Write("является палиндромом ");
    }
    else
    {
        Console.Write("Не является палиндромом " );
    }

}
Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
isPal(num);

*/

/*

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Кординаты точки 1 (x,y,z) , кординаты точки 2 (a,b,c)");
Console.Write("Введите кординаты (x): ");
double x = Convert.ToDouble (Console.ReadLine()); 
Console.Write("Введите кординаты (y): ");
double y = Convert.ToDouble (Console.ReadLine()); 
Console.Write("Введите кординаты (z): ");
double z = Convert.ToDouble (Console.ReadLine()); 
Console.Write("Введите кординаты (a): ");
double a = Convert.ToDouble (Console.ReadLine()); 
Console.Write("Введите кординаты (b): ");
double b = Convert.ToDouble (Console.ReadLine()); 
Console.Write("Введите кординаты (c): ");
double c = Convert.ToDouble (Console.ReadLine()); 
double linesegment = Math.Sqrt((x-a)*(x-a) + (y-b)*(y-b) + (z-c)*(z-c));
Console.WriteLine(" -> ");
Console.WriteLine(Math.Round(linesegment,2));

*/

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*

void Cube(int A)
{
    int a = 1;
    while(A>a || A == a)
    {
        int q = a*a*a;
        Console.WriteLine(A + " -> " + q);
        a++;
    } 
}
Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
Cube(num);

*/