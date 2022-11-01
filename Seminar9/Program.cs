//Задача 64: Задайте значение N. Напишите программу, которая выведет все
//натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


// Console.WriteLine("Введите натуральное число больше 1:");
// int number = Convert.ToInt32(Console.ReadLine());

// void NumberCounter (int number)
// {
//     if (number < 0) Console.Write($"{number} не натуральное число");
//     if (number == 0) return;
//     Console.Write("{0,4}", number);
//     NumberCounter (number - 1);
// }

//NumberCounter(number);







// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.


// Console.WriteLine("Введите начальное число M:");
// int numberM = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите начальное число N:");
// int numberN = Convert.ToInt32(Console.ReadLine());

// void SumNumber (int numberM, int numberN, int sum)
// {
//     if (numberM > numberN) 
//     {
//         Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
//         return;
//     }
//     sum = sum + (numberM++);
//     SumNumber(numberM, numberN, sum);
// }

//SumNumber(numberM, numberN, 0);



//Задача 68: Напишите программу вычисления функции Аккермана с помощью
//рекурсии. Даны два неотрицательных числа m и n.
//m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите начальное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int numberN = Convert.ToInt32(Console.ReadLine());

int AKkermannFunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AKkermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AKkermannFunction(numberM - 1, AKkermannFunction(numberM, numberN - 1));
return AKkermannFunction(numberM, numberN);
}

Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AKkermannFunction(numberM, numberN)}");