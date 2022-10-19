//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void Zadacha54(){
    Console.WriteLine("Задача 54:");
    int lines = 10;
    int rows = 8;  
    int[,] numbers = FillNewArray(lines,rows);
    PrintArray(numbers);
    Console.WriteLine("--------");
    numbers = SortArray(numbers);
    PrintArray(numbers);
}

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void Zadacha56(){
    Console.WriteLine("Задача 56:");
    int lines = 6;
    int rows = 8;  
    int[,] numbers = FillNewArray(lines,rows);
    PrintArray(numbers);
    Console.WriteLine("--------");
    int[] result = new int[rows];
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < lines; j++)
        {
            sum += numbers[j,i];
        }
        result[i] = sum;
        sum = 0;
    }
    int minSum = 0;
    for (int i = 1; i < rows; i++)
    {
        if (result[i] < result[minSum])
        {
            minSum = i;
        }
    }
    Console.WriteLine($"Минимальная сумма элементов находится в строке с индексом {minSum}. Сумма ее элементов равна {result[minSum]}");
}

//Задача 58: Напишите программу, которая заполнит спирально массив 4 на 4.
void Zadacha58(){
    Console.WriteLine("Задача 58:");
    int[,] numbers = new int[10,10];    
    int count = 0;
    int x = 0;
    int y = 0;
    int road = 1;       
    int lines = numbers.GetLength(0);
    int rows = numbers.GetLength(1);
    while(count < lines*rows){
        count++;
        if (road == 1)
        {
            numbers[x,y] = count;
            if(y+1 >= rows)
                {
                    road = 2;
                    x++;
                    continue;
                }
            else if (numbers[x,y+1] != 0)
            {
                    road = 2;
                    x++;
                    continue;
                }
            
            y++;
        }
        if (road == 2)
        {
            numbers[x,y] = count;
            if(x+1 >= rows)
                {
                    road = 3;
                    y--;
                    continue;
                }
            else if (numbers[x+1,y] != 0)
            {
                    road = 3;
                    y--;
                    continue;
                }
            
            x++;
        }
        if (road == 3)
        {
            numbers[x,y] = count;
            if(y-1 < 0)
                {
                    road = 4;
                    x--;
                    continue;
                }
            else if (numbers[x,y-1] != 0)
            {
                    road = 4;
                    x--;
                    continue;
                }
            
            y--;
        }
        if (road == 4)
        {
            numbers[x,y] = count;
            if (numbers[x-1,y] != 0)
            {
                    road = 1;
                    y++;
                    continue;
                }
            
            x--;
        }        
        
    }    
    PrintArray(numbers);
}

int[,] FillNewArray(int lines, int rows){
    int[,] numbers = new int[lines , rows];
    Random rand = new Random();
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            numbers[i,j] = rand.Next(1,100);
        }
    }
    return numbers;
}

void PrintArray(int[,] arr){
    int lines = arr.GetLength(0);
    int rows = arr.GetLength(1);
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }   
    
}

int[,] SortArray(int[,] numbers){
    int lines = numbers.GetLength(0);
    int rows = numbers.GetLength(1);
    int number = 0;
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < rows-1; j++)
        {
            for (int k = j+1; k < rows; k++)
            {
                if(numbers[i,j] > numbers[i,k]){
                    (numbers[i,j] , numbers[i,k]) = (numbers[i,k] , numbers[i,j]);
                }
            }
        }
    }
    return numbers;
}

//Zadacha54();
//Zadacha56();
Zadacha58();