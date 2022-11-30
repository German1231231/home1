// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите c = ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > a)
{
    max = b;
}
if (c > max)
{
    max = c;
}

Console.Write("Max = ");
Console.WriteLine(max);
