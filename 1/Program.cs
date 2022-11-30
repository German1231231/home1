// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b = ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
int min = a;

if(a < b)
{
   max = b;
   min = a; 
}

else
{
    max = a;
    min = b;
}

Console.Write("Max = ");
Console.WriteLine(max);
Console.Write("Min = ");
Console.WriteLine(min);
