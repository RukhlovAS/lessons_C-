void Zadacha42(){
    int number = 43;
    int result = 0;
    int count = 1;    
    while (number > 0)
    {    
        result = result + number%2 * count;
        number /= 2;
        count = count *10; 
    }
    Console.WriteLine(result);
}

//Zadacha42();

//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
void Zadacha41(){
    Console.WriteLine("Задача 41:");
    Console.WriteLine("Сколько чисел вы хотите ввести:");
    int length = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите {i+1} число:");
        int next = Convert.ToInt32(Console.ReadLine());
        if(next > 0){
            count++;
        }
    }
    Console.WriteLine($"Вы ввели {count} чисел больше 0");
}

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
void Zadacha43(){
    Random rand = new Random();
    double k1 = rand.Next(-10,10), k2 = rand.Next(-10,10), b1 = rand.Next(-10,10), b2 = rand.Next(-10,10);    
    double resultX = (b2 - b1) / (k1-k2);
    double resultY = k1*resultX + b1;
    Console.WriteLine($"точка A ({resultX};{resultY}) является точкой пересечения функции y ={k1}x + {b1} с функцией y ={k2}x + {b2}"); 
}


//Zadacha41();
Zadacha43();


