// // Задача 25 напишите цикл, который принимает на вход 2 числа (А и В) и возводит число
// // А в натуральную степень В.

// void Zadacha25()

// {
//     Console.Write("Введите первое число: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите второе число: ");
//     int b = Convert.ToInt32(Console.ReadLine());
//     int sum = 1;

//     for (int i = 1; i <= b; i++)
//     {
//         sum = sum * a;
//     }
//     Console.WriteLine(sum);
// }
// Zadacha25();

// Задача 27 Напишите программу, которая принимает на вход число и выдает сумму цифр в числе

//  void Zadacha27()
//  {
//      Console.Write("Введите число: ");
//      int num = Convert.ToInt32(Console.ReadLine());
//      int sum = 0;
//      while ( num > 0)
//      {
//          int digit = num % 10;
//          sum = sum + digit;
//          num = num /= 10;
         
//      }
//      Console.WriteLine(sum);

//  }
//  Zadacha27();

// Задача 29 Напишите программу, которая задает массив из 8 случайных целых чисел и 
// выводит отсортированный по модулю массив
Random random = new Random();
int size = 8;
int[] arr = new int[size];

void Zadacha29()
{
   Array ();
   
    for (int i = 0; i < size; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < size; j++)
        {
            if (Math.Abs(arr[j]) < Math.Abs(arr[minPosition])) minPosition = j;
        }
        int temporary  = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = temporary;
        Console.Write($"{arr[i]} | ");
    }


}
void Array ()
{
     for (int i = 0; i < size; i++)
   {
    arr[i] = random.Next(-20, 20);
   }
    //   for (int i = 0; i < size - 1; i++)
    //   {
    //       Console.Write(arr[i] + "\t");
    //   }
    // Console.WriteLine();
}
Zadacha29();