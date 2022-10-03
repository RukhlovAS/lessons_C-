//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void Zadacha19(){
    Console.WriteLine("Задача 19:");
    Console.WriteLine("Введите пятизначное число:");
    int number = Convert.ToInt32(Console.ReadLine());
    Array arr = new Array[5];
    int count = 0;

    while(count < 5)
    {
        arr[4-count] = number%10;
        number = number/10;
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
    Array arr = new Array[2][3];
    for(int x=0; x<2; x++)
    {
        for(int y=0; x<3; y++)
        {
            Console.WriteLine($"Введите {y+1} координату {x+1} точки");
            arr[x][y] = Convert.ToInt32(Console.ReadLine());            
        }
    }
    
}

Zadacha19();
Zadacha21();
