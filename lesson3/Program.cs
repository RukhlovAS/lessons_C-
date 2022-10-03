//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void Zadacha19(){
    Console.WriteLine("Задача 19:");
    Console.WriteLine("Введите пятизначное число:");
    int number = Convert.ToInt32(Console.ReadLine());    
    int[] arr = new int[5];
    int count = 0;
    int numberX = number;
    while(count < 5)
    {
        arr[4-count] = numberX%10;
        numberX = numberX/10;
        count ++;
    }
    if(arr[0] == arr[4] && arr[1] == arr[3])
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {number} не является палиндромом");
    }
}

//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
void Zadacha21(){
    Console.WriteLine("Задача 21:");
    int[,] arr = new int[2 , 3];
    for(int x=0; x<2; x++)
    {
        for(int y=0; y<3; y++)
        {
            Console.WriteLine($"Введите {y+1} координату {x+1} точки");
            arr[x , y] = Convert.ToInt32(Console.ReadLine());            
        }
    }
    double result = 1.0 * Math.Sqrt(Math.Pow((arr[0 , 0]- arr[1 , 0]),2) + Math.Pow((arr[0 , 1]- arr[1 , 1]),2) + Math.Pow((arr[0 , 2]- arr[1 , 2]),2));
    Console.WriteLine(result);
    
}

//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Zadacha23(){
    Console.WriteLine("Задача 23:");
    Console.WriteLine("Введите число (от 1 до N):");
    int number = Convert.ToInt32(Console.ReadLine());     
    if (number > 0)
    {
        int count = 1;
        while (count <= number)
        {
            Console.WriteLine($"{count} - {Math.Pow(count,3)}");
            count++;
        }
    }
    else
    {
        Console.WriteLine("неверный ввод");
    }
    
}
//Zadacha19();
//Zadacha21();
Zadacha23();
