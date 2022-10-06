//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void Zadacha34(){
    Console.WriteLine("Задача 34:");    
    int[] arr = FillRandomArray(100 , 1000);
    int count = FindCountEven(arr);
    PrintArray(arr);
    Console.WriteLine($"Количество положительных чисел равно: {count}");
}

//Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.

void Zadacha36(){
    Console.WriteLine("Задача 36:");    
    int[] arr = FillRandomArray(-10000 , 10000);
    int sum = FindSumOdd(arr);
    PrintArray(arr);
    Console.WriteLine($"Сумма нечетных чисел равна: {sum}");
}

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void Zadacha38(){
    Console.WriteLine("Задача 38:");    
    double[] arr = FillRandomDoubleArray();
    double diff = DiffArrayMaxMin(arr);
    PrintDoubleArray(arr);
    Console.WriteLine($"Разница между максимальным и минимальным числом массива равна: {diff}");
}

int[] FillRandomArray(int min, int max){
    Random rand = new Random();
    int size = rand.Next(1 , 100);
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(min , max);
    }
    return arr;
}

double[] FillRandomDoubleArray(){
    Random rand = new Random();
    int size = rand.Next(1 , 100);
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.NextDouble()*1000000;
    }
    return arr;
}


int FindCountEven(int[] arr){
    int size = arr.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if(arr[i]%2 == 0){
            count++;
        }
    }
    return count;
}

void PrintArray(int[] arr){
    int size = arr.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        count++;
        Console.Write($"{arr[i]} ");
        if (count % 20 == 0){
            Console.WriteLine("");
        }
    }
    Console.WriteLine("");
}

void PrintDoubleArray(double[] arr){
    int size = arr.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        count++;
        Console.Write($"{arr[i]} ");
        if (count % 20 == 0){
            Console.WriteLine("");
        }
    }
    Console.WriteLine("");
}

int FindSumOdd(int[] arr){
    int sum = 0;
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        if(arr[i]%2 != 0){
            sum += arr[i];
        }
    }
    return sum;
}

double DiffArrayMaxMin(double[] arr){
    double min = arr[0];
    double max = arr[0];
    int length = arr.Length;
    for (int i = 1; i < length; i++)
    {
        if(arr[i] < min){
            min = arr[i];
        }
        else if(arr[i] > max){
            max = arr[i];
        }
    }
    return max - min;
}

//Zadacha34();
//Zadacha36();
Zadacha38();