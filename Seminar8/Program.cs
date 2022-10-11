//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

void Zadacha54()
{

    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] numbers = new int[rows, columns];
    int[,] numbersNew = new int[rows, columns];
    FillArray(numbers, 0, 100);
    PrintArray(numbers);
    Sorting(numbers);
    Console.WriteLine("=========================================");
    PrintArray(numbers);
}
//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.


void Zadacha56()
{
    Random random = new Random();
    int rows = 4;
    int columns = 4;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers, 0, 10);
    PrintArray(numbers);
    int min = 1000;
    int temporary = 0;
    int str = 0;
    for (int i = 0; i < rows; i++)
     {
        temporary = 0;
         for (int j = 0; j < columns; j++)
         {
           temporary = temporary + numbers[i, j];
           Console.Write($" | {temporary} |");
                     
         }
             if (min > temporary) 
            {
                min = temporary;         
            } 

        Console.WriteLine();
               
     
     }
Console.WriteLine("Минимальный результат: " + min);
Console.WriteLine($"Строка с наименьшим результатом:  {str}");

}

//Задача 58: Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

void Zadacha58()
{    
    Random random = new Random();
    int rows = 4;
    int columns = 4;
    int[,] numbers = new int[rows, columns];
    FillArraySpiral(numbers, 0, 16);
    PrintArray(numbers);
}




void FillArray(int[,] numbers, int Min = -1000, int Max = 1000)
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

void Sorting(int[,] numbers)
{
    
     Random random = new Random();
     int rows = numbers.GetLength(0);
     int columns = numbers.GetLength(1);

  for (int i = 0; i < rows; i++)
     {
        for (int j = 0; j < columns; j++)
         {
            
            for (int k = 0; k < columns - 1; k++)
            {
                if (numbers[i, k] < numbers[i, k + 1])
                {
                    int temp = numbers[i, k + 1];
                    numbers[i, k + 1] = numbers[i, k];
                    numbers[i, k] = temp;
                }
            }
                        
             
         }
        
     }

}

 void FillArraySpiral(int[,] numbers, int Min = -1000, int Max = 1000)
 {
    
     Random random = new Random();
     int rows = numbers.GetLength(0);
     int columns = numbers.GetLength(1);
     int count = 0;
      for (int i = 0; i < 1; i++)
     {
         for (int j = 0; j < columns; j++)
         {
             numbers[i, j] = j + 1;
             count = numbers[i, columns - 1];
         }
         
     }
     
     for (int j = 3; j == 3; j++)
     {
         for (int i = 1; i < rows; i++)
         {
             numbers[i, j] = count + 1;
             count++;
             count = numbers[i, j];
             
         }
         
     }
     for (int i = 3; i == rows - 1; i++)
     {
         for (int j = 2; j >= 0; j--)
         {
             numbers[i, j] = count + 1;
             count++;
             count = numbers[i, j];
         }
         
     }
     for (int j = 0; j == 0; j++)
     {
         for (int i = 2; i >= 1; i--)
         {
             numbers[i, j] = count + 1;
             count++;
             count = numbers[i, j];
             
         }
     }
    for (int i = 1; i == rows - 3; i++)
        {
            for (int j = 1; j <= 2; j++)
            {
                numbers[i, j] = count + 1;
                count++;
                count = numbers[i, j];
            }
            
        }
        for (int j = 2; j == 2; j++)
     {
         for (int i = 2; i == 2; i--)
         {
             numbers[i, j] = count + 1;
             count++;
             count = numbers[i, j];
             
         }
     }
     for (int i = 2; i == rows - 2; i++)
        {
            for (int j = 1; j <= 1; j++)
            {
                numbers[i, j] = count + 1;
                count++;
                count = numbers[i, j];
            }
            
        }
 }
 Zadacha56();