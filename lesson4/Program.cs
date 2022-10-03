//Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
void testZadacha25(){
    Console.WriteLine("Задача 25:");
    Console.WriteLine("Введите число A:");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B:");
    int numberB = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Zadacha25(numberA, numberB));
}

int Zadacha25(int numberA, int numberB){    
    int count = 1;
    int result = numberA;
    while(count<numberB)
    {
        result = result*numberA;
        count++;        
    }
    return result;
}

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
void testZadacha27(){
    Console.WriteLine("Задача 27:");
    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Zadacha27(number));
}

int Zadacha27(int number){    
    int result = 0;
    while(number>0)
    {
        result = result + number%10;
        number = number/10;        
    }
    return result;
}

//Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
void testZadacha29(){
    Console.WriteLine("Задача 29:");
    int[] arr = new int[8];
    arr = Zadacha29(arr);
    for(int i =0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

int[] Zadacha29(int[] arr){
    Random rand = new Random();
    for(int i = 0; i < arr.Length; i++){
        arr[i] = rand.Next(-1000 , 1000);
    }
    int number = 0;
    for(int i = 0; i < arr.Length-1; i++){
        for(int x = i+1; x<arr.Length; x++)
        {
            if(Math.Abs(arr[i]) > Math.Abs(arr[x]))
            {
                number = arr[i];
                arr[i] = arr[x];
                arr[x] = number;
            }
        }
    }

    return arr;

}



//testZadacha25();
//testZadacha27();
testZadacha29();