//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Задача 2:");
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число:");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"{a} большее, {b} меньшее");
}
else
{
    Console.WriteLine($"{b} большее, {a} меньшее");
}


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Задача 4:");
Console.WriteLine("Введите число:");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число:");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число:");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine($"{max} является максимальным");

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Задача 6:");
Console.WriteLine("Введите число:");
a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine($"Число {a} является четным числом");
}
else
{
    Console.WriteLine($"Число {a} является нечетным числом");
}

//Задача 8: Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Задача 8:");
Console.WriteLine("Введите число N>0:");
int n = Convert.ToInt32(Console.ReadLine());
int count = 2;
while(count<=n)
{
    Console.WriteLine(count);
    count +=2;
}
