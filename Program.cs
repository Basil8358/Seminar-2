// Напишите программу, которая выводит случайное число из отрезка (10, 99) и показывает наибольщую цифру
// 78 -> 8
// 12 -> 2
// 85 -> 8

//  void ShowNumber(){
//     int num = new Random().Next(10, 100);
//     int firstNum = num /10;
//     int secondNum = num % 10;
//     Console.Write(num + " -> " );
//     if (firstNum > secondNum){
//         Console.WriteLine(firstNum);
// }
// else{
//     Console.WriteLine(secondNum);
// }
 // }

// ShowNumber();

// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int Number = new Random().Next(100, 1000);
// int a = NumberWithoutSecDig(Number);
// Console.WriteLine(a + " " + Number);

// int NumberWithoutSecDig(int Number){
//     int NewNumber = Number / 100 * 10 + Number % 10;
//     return NewNumber;
// }

// Напишите программу,которая на вход принимает два числа и выводить его (является ли оно кратным).

// void MultiNum(int a, int b){
//     if(b%a == 0){
//        Console.WriteLine(b + "кратно " + a);
// }else{
//        Console.WriteLine(b + " не кратно " + a + ", остаток " + b%a);
// }
// }

// Console.WriteLine("Введите последовательно два числа");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());

// MultiNum(num1, num2);

// Напишите программу, принимает на вход число 

//  void NumDiv(int a){
//      if (a%7 == 0 && a%23 == 0){
//          Console.WriteLine(a + " кратна 23 и 7 ");
//      }else{
//          Console.WriteLine(a + " не кратно23 и 7");
//      }
//  }

//  Console.WriteLine("Введите число: ");
//  NumDiv(Convert.ToInt32(Console.ReadLine()));

// 1) Напишите программу, которая принимает на вход трехзначное цисло и на выходе показывает вторую цифру этого числа.

// int Number = new Random().Next(100, 1000);
//  int a = NumberTwu(Number);
//  Console.WriteLine( a + " " + Number );

//   int NumberTwu(int Number){
//       int NewNumber = Number / 10 % 10;
//      return NewNumber;
//   }

// 2) Напишите программу, которая выводит третью цифру задонного числа или сообьщяет, что третьей цифры нет.
// int Number = new Random().Next(10, 1000);
//  int a = NumberThree(Number);
//  Console.WriteLine( a + " " + Number );
//  if (100 >= Number)
//    Console.WriteLine("третьей цифры нет");
//  int NumberThree(int Number){
//      int NewNumber = Number % 10;
//     return NewNumber;
//  }
 
// 3)Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, являеться ли этот день выходным.
//    int num = new Random().Next(1,7);{
//     Console.WriteLine("day off: ");
//        int day = Convert.ToInt32(Console.ReadLine());
//     if (day <= 1 || day <= 5){
//          Console.WriteLine("incorrect day");
//      }
//      if (day > 5 || day > 7){
//          Console.WriteLine("my day off");   }
// }