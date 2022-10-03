
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
void Zadacha10(){
    Console.WriteLine("Задача 10:");
    Console.WriteLine("Введите трехзначное число:");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 99 && number < 1000){
        int numberX = (number%100)/10;
        Console.WriteLine($"{numberX} вторая цифра числа {number}");
    }
    else
    {
        Console.WriteLine($"число {number} не является трехзначным");
    }
    
    
}
//Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
void Zadacha13(){
    Console.WriteLine("Задача 13:");
    Console.WriteLine("Введите число:");
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    if (number/100 > 0)
    {
        while (number > 999)
        {
            number = number/10;
        }
        Console.WriteLine("третья цифра в заданном числе " + number%10);
    }
    else
    {
        Console.WriteLine("нет третьей цифры в заданном числе");
    }
}
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void Zadacha15(){
    Console.WriteLine("Задача 15:");
    Console.WriteLine("Введите число обозначающее день недели(1-7):");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Это выходной?");
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

//Zadacha10();
//Zadacha13();
//Zadacha15();

