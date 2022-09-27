// Задача 19. Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно полиндромом



// void Zadacha19()

// {
//     int [] arr = {1, 2, 3, 5, 1};
    
    
        
//            if (arr[0] == arr[4] && arr[1] == arr[3])
//             {
//                 Console.WriteLine("Число является полиндромом");
//             } 
            
             
//             else    Console.WriteLine("Число не является полиндромом");
            
            
        
        
       
     
       
        
// }
// Zadacha19();

// // Задача 23 Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N

// void Zadacha23()
// {
//     Console.WriteLine("Введите число");
//     int n = Convert.ToInt32(Console.ReadLine());
//     int count = 1;
    

//     while (count < n)
//     {
//         double i = Math.Pow(count, 3);
//         Console.Write($"{i} | ");

//         count++;
//     }
// }
// Zadacha23();

//Задача21 Напишите программу, которая принимает на 
//вход координаты двух точек и находит расстояние между ними в 3D пространстве.

void Zadacha21()
{
    int x_a = 1;
    int x_b = 2;
    int x_c = 3;

    int y_a = 4;
    int y_b = 5;
    int y_c = 6;

    double res = Math.Sqrt(Math.Pow(x_a - y_a, 2) + Math.Pow(x_b - y_b, 2) + Math.Pow(x_c - y_c, 2));
    
    Console.WriteLine(res);


}
Zadacha21();