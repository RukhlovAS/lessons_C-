//Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
void Zadacha47(){
    Console.WriteLine("Задача 47:");
    int lines = 10;
    int rows = 8;  
    double[,] numbers = FillNewArray(lines,rows);
    PrintDoubleArray(numbers);
}

double[,] FillNewArray(int lines, int rows){
    double[,] numbers = new double[lines , rows];
    Random rand = new Random();
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            numbers[i,j] = Math.Round(rand.NextDouble()*100,1);
        }
    }
    return numbers;
}

int[,] FillNewArray2(int lines, int rows){
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

void PrintDoubleArray(double[,] arr){
    int rows = arr.GetLength(0);
    int lines = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < lines; j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }   
    
}

void PrintArray(int[,] arr){
    int rows = arr.GetLength(0);
    int lines = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < lines; j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }   
    
}

//Задача 50: Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
void Zadacha50(){
    Console.WriteLine("Задача 50:");
    int indexLines = 3;
    int indexRows = 3;
    double[,] numbers = FillNewArray(6,6);
    PrintDoubleArray(numbers);
    ArraySearchElement(numbers, indexLines, indexRows);

}

void ArraySearchElement(double[,] numbers, int index1, int index2){
    if ((numbers.GetLength(0) > index1) && (numbers.GetLength(1) > index2))
    {
        Console.WriteLine($"под индексом N[{index1} , {index2}] находится элемент со значением {numbers[index1,index2]}");
    } else{
        Console.WriteLine($"элемента с индексом N[{index1} , {index2}] не существует");
    }
}

//Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void Zadacha52(){
    Console.WriteLine("Задача 52:");
    int lines = 8;
    int rows = 6;    
    int[,] numbers = FillNewArray2(lines,rows);
    PrintArray(numbers);
    Console.WriteLine("--------");
    double[] result = new double[rows];
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < lines; j++)
        {
            sum += numbers[j,i];
        }
        result[i] = 1.0*sum/lines;
        sum = 0;
    }
    for (int i = 0; i < result.GetLength(0); i++)
    {
        Console.Write(result[i] + " ");
    }     

}

//Zadacha47();
//Zadacha50();
Zadacha52();