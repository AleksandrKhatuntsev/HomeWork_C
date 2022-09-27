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

 void Zadacha27()
 {
     Console.Write("Введите число: ");
     int num = Convert.ToInt32(Console.ReadLine());
     int sum = 0;
     while ( num > 0)
     {
         int digit = num % 10;
         sum = sum + digit;
         num = num /= 10;
         
     }
     Console.WriteLine(sum);

 }
 Zadacha27();

// Задача 29 Напишите программу, которая задает массив из 8 случайных целых чисел и 
// выводит отсортированный по модулю массив

