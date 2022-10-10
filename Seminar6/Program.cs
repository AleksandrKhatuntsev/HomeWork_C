//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

void Zadacha41()
{
    Console.WriteLine("Сколько чисел нужно ввести? ");
    int countNumbers = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    for (int i = 1; i <= countNumbers; i++)
    {
        Console.WriteLine($"Введите {i} число: ");
        int numbers = Convert.ToInt32(Console.ReadLine());
        if (numbers > 0) count++;
    }
    Console.WriteLine("Положительных чисел введено: " + count);

}

//Задача 43:Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
void Zadacha43()
{
    var (k1, b1) = (1, 4);
    var (k2, b2) = (5, -3);
    double x = Convert.ToDouble(b2 - b1) / Convert.ToDouble(k1 - k2);
    x = Math.Round(x, 3);
    double y = k1 * x + b1;
    y = Math.Round(y, 3);
    Console.WriteLine($"Точка пересечения А({x}, {y})");
    
}

Zadacha43();