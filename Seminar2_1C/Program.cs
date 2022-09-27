 //Задача 13
//  void Zadacha13()
//  {
//  Console.WriteLine("Введите число");
//   int num = Convert.ToInt32(Console.ReadLine());
//   num = Math.Abs(num);

//   if (num > 99)
//   {
//       while (num > 999)
//       {
//           num /= 10;
//       }
//       Console.WriteLine("Третья цифра числа " + num%10);
//   }

//   else
//   {
//       Console.WriteLine("Третьей цифры нет");
//   }
//  }
// Zadacha13();
// Задача 15 
//  void Zadacha15()
//  {
//  int day = 1;

//  if (day > 0 && day < 8)
//  {
//      if (day == 6 || day == 7)
//      {
//          Console.WriteLine("Выходной");
//      }
//      else
//      {
//          Console.WriteLine("Будний");
//      }
 
//  }
// }
// Zadacha15();

// Задача 10
void Zadacha10()
{
Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
     Console.WriteLine("Вторая цифра числа: " + (num / 10 % 10));
}
else 
{
    Console.WriteLine("Введено не трёхзначное число");
}
}
Zadacha10();