//Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
void Zadacha64(){
    Console.WriteLine("Задача 64:");
    Console.WriteLine("Введите число M");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N");
    int n = Convert.ToInt32(Console.ReadLine());    
    if(m > n){
        (m , n) = (n , m);
    }
    Console.WriteLine($"натуральные числа кратные 3-ем в промежутке от {m} до {n} :");
    FindNaturalMultipleThree(m , n);
}

void FindNaturalMultipleThree(int min, int max){
    if(min%3 == 0){
        Console.WriteLine(min);
    }
    if(min > max){
        return;
    }
    min++;
    FindNaturalMultipleThree(min,max);
}

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
void Zadacha66(){
    Console.WriteLine("Задача 66:");
    Console.WriteLine("Введите число M");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N");
    int n = Convert.ToInt32(Console.ReadLine());    
    if(m > n){
        (m , n) = (n , m);
    }
    int sum = FindSumNatural(m , n);
    Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} равна {sum}");
}

int FindSumNatural(int min, int max, int sum = 0){
    if(min>max){
        return sum;
    }
    else{
    sum+=min;
    min++;
    return FindSumNatural(min, max, sum);    
    }
}

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
void Zadacha68(){
    Console.WriteLine("Задача 68:");
    Console.WriteLine("Введите неотрицательное число M");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите неотрицательное число N");
    int n = Convert.ToInt32(Console.ReadLine());
    int result = Akkerman(m , n);
    Console.WriteLine($"Результат вычисления функции Аккермана для чисел {m} и {n} равен {result}");
}

int Akkerman(int m, int n ){
    if(m==0){
        return n+1;
    }
    else if(m>0 && n == 0){
        return Akkerman(m-1, 1);
    }
    else if(m>0 && n>0){
        return Akkerman(m-1,Akkerman(m, n-1));
    }
    else
        return -1;
}
//Zadacha64();
//Zadacha66();
Zadacha68();