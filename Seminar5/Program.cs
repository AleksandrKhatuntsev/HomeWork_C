 void FillArray(int[] numbers,
                    int minValue = 0,
                    int maxValue = 9)
{
     maxValue++;
     int size = numbers.Length;
     Random random = new Random();
     for (int i = 0; i < size; i++)
     {
         numbers[i] = random.Next(minValue ,maxValue);
     }
}

void FillArray2(double[] numbers,
                    int minValue = 0,
                    int maxValue = 9)
{
     maxValue++;
     int size = numbers.Length;
     Random random = new Random();
     for (int i = 0; i < size; i++)
     {
         numbers[i] = random.NextDouble();
     }
}

void PrintArray(int[] numbers)
     {
         for (int i = 0; i < numbers.Length; i++)
         {
             Console.Write(" " + numbers[i]);
         }
         Console.WriteLine();
     }

     void PrintArray2(double[] numbers)
     {
         for (int i = 0; i < numbers.Length; i++)
         {
             Console.Write(" " + numbers[i]);
         }
         Console.WriteLine();
     }

// void MaxMin(double[] numbers)
//     {
        
//         double max = numbers[0];
//         double min = numbers[0];
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             if (max < numbers[i]) max = numbers[i];

//         }
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             if (min > numbers[i]) min = numbers[i];

//         }
//         Console.WriteLine($"Разница" + (max - min));
//     }


 
 
 
 //Задача 34.Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
 //которая покажет количество чётных чисел в массиве.

void Zadacha34()
{
    int size = 10;
    int count = 0;
    int[] numbers = new int[size];
    FillArray(numbers, 99, 999);
    PrintArray(numbers);

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0) count++;
    }
    Console.WriteLine("Количество чётных чисел:" + count);
}






//Задача 36. Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов с нечётными индексами.

void Zadacha36()
{
    int size = 10;
    int sum = 0;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);

    for (int i = 1; i < numbers.Length; i = i +2)
    {
        sum = sum + numbers[i];
    }
    Console.WriteLine("Сумма нечетных элементов массива:" + sum);

}

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.


void Zadacha38()
{
    int size = 10;
    double[] numbers = new double[size];
    double max = numbers[0];
    double min = numbers[0];
    FillArray2(numbers, 10, 99);
    PrintArray2(numbers);
     for (int i = 0; i < numbers.Length; i++)
        {
            if (max < numbers[i]) max = numbers[i];
            else
            {
            if (numbers[i] > min) min = numbers[i];
            }
        }
       
        Console.WriteLine(max);
        Console.WriteLine(min);
        Console.WriteLine($"Разница: " + (max - min));
   
}

Zadacha38();