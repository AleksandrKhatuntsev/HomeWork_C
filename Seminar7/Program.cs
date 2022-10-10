//Задача 47: Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами, округлёнными до одного знака.

void Zadacha47()
{

    Console.Write("Введите колличество строк:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите колличество столбцов:");
    int columns = Convert.ToInt32(Console.ReadLine());
    double[,] numbers = new double[rows, columns];
    Random random = new Random();
    FillArrayDouble(numbers);
    PrintArrayDouble(numbers);
    
}
//Задача 50: Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

void Zadacha50()
{
    Console.WriteLine("Введите номер строки:");
    int n_rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца:");
    int n_columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine();
    if (n_rows < rows && n_columns < columns) Console.WriteLine($"Число: " + numbers[n_rows - 1, n_columns - 1]);
    else Console.WriteLine("Числа не существует");
}
//Задача 52: Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

void Zadacha52()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);

for (int j = 0; j < columns; j++)
     {
        double sum = 0;
        int count = 0;
         for (int i = 0; i < rows; i++)
         {
             
             sum = sum + numbers[i,j];
             count++;;
             //Console.WriteLine(count);
         }
         sum = sum / count;
         Console.WriteLine($"Среднее арифметическое {j + 1} столбца: " + Math.Round(sum, 2));
     }


}








void FillArray(int[,] numbers, int Min = 0, int Max = 10)
 {
    
     Random random = new Random();
     int rows = numbers.GetLength(0);
     int columns = numbers.GetLength(1);
      for (int i = 0; i < rows; i++)
     {
         for (int j = 0; j < columns; j++)
         {
             numbers[i, j] = random.Next(Min, Max);
        }
     }
 }

 void PrintArray(int[,] numbers)
 {
     int rows = numbers.GetLength(0);
     int columns = numbers.GetLength(1);
     for (int i = 0; i < rows; i++)
     {
         for (int j = 0; j < columns; j++)
         {
             Console.Write(numbers[i, j] + "\t");
         }
         Console.WriteLine();
     }
 }
 void FillArrayDouble(double[,] numbers, int Min = -10, int Max = 10)
 {
    
     Random random = new Random();
     int rows = numbers.GetLength(0);
     int columns = numbers.GetLength(1);
      for (int i = 0; i < rows; i++)
     {
         for (int j = 0; j < columns; j++)
         {
             numbers[i, j] = random.NextDouble();
        }
     }
 }

 void PrintArrayDouble(double[,] numbers)
 {
     int rows = numbers.GetLength(0);
     int columns = numbers.GetLength(1);
     for (int i = 0; i < rows; i++)
     {
         for (int j = 0; j < columns; j++)
         {
             Console.Write(Math.Round(numbers[i, j], 1) + "\t");
         }
         Console.WriteLine();
     }
 }
 Zadacha52();