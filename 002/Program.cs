


void zadacha34()
{
    /*Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
   числами. Напишите программу, которая покажет количество чётных чисел в массиве.*/



    Console.WriteLine("Введите размер массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[size];
    FillArrayRandomNumbers(numbers);
    Console.WriteLine("Вот наш массив:  ");
    PrintArray(numbers);
    int count = 0;

    for (int a = 0; a < numbers.Length; a++)
        if (numbers[a] % 2 == 0)
            count++;

    Console.WriteLine($"Всего {numbers.Length} чисел {count} из них четные ");

    void FillArrayRandomNumbers(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(100, 1000);
        }

    }


    void PrintArray(int[] numbers)
    {

        Console.Write(" [ ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }

        Console.Write(" ] ");
        Console.WriteLine();
    }
}



//void zadacha36()
{
    /*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
    Найдите сумму элементов с нечётными индексами.*/

    Console.WriteLine("Введите  массив");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[size];
    FillArrayRandomNumbers(numbers);
    Console.WriteLine("Вот наш массив:  ");
    PrintArray(numbers);
    int sum = 0;

    for (int a = 0; a < numbers.Length; a += 2)
        sum = sum + numbers[a];


    Console.WriteLine($"Всего {numbers.Length} чисел, сумма элементов на не четных позициях = {sum}");

    void FillArrayRandomNumbers(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1, 10);
        }

    }


    void PrintArray(int[] numbers)
    {

        Console.Write(" [ ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }

        Console.Write(" ] ");
        Console.WriteLine();
    }




}


//void zadacha38()
{
    /*Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
    максимальным и минимальным элементов массива.*/

    Console.WriteLine("Введите размер массива");
    int size = Convert.ToInt32(Console.ReadLine());
    double [] numbers = new double [size];
    FillArrayRandomNumbers(numbers);
    Console.WriteLine("Вот наш массив:  ");
    PrintArray(numbers);
    double min = Int32.MaxValue;
    double max = Int32.MinValue;
    
    for (int a = 0; a < numbers.Length; a++)
    {
        if (numbers[a] > max)
        {
            max = numbers[a];
        }
        if (numbers[a] < min)
        {
            min = numbers[a];
        }

    }
    Console.WriteLine($"Всего {numbers.Length} чисел,максимальное значение = {max} минимальное значение = {min}");
    Console.WriteLine($"разница между максимальным и минимальным = {max-min}");
    
    void FillArrayRandomNumbers(double[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        
        
          {
            numbers[i] = Convert.ToDouble (new Random().Next(100, 1000)) / 100;
          }

    }


    void PrintArray(double[] numbers)
    {

        Console.Write(" [ ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }

        Console.Write(" ] ");
        Console.WriteLine();
    }






}


zadacha34();
//zadacha36();
//zadacha38();