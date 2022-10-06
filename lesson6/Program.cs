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

Zadacha42();


