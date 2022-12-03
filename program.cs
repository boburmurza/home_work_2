// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
// int Test(int number){

//  Console.WriteLine( " вы ввели это число := "+number);
//  int hund = number/100;
//  int ten = number/10%10;
//     return ( ten);
// }
// Console.WriteLine("введите трехзначное число ");
// int number = Convert.ToInt32(Console.ReadLine());
//  int res = Test(number);

//  Console.WriteLine( "второе число :="+ res);


// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
// int Test(int number)
// {

//     Console.WriteLine(" вы ввели это число := " + number);
//     int hund = number / 100;
//     int ten = number / 10 % 10;
//     int one = number % 10;

//     return (one);
// }
// Console.WriteLine("введите трехзначное число ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 100)
// {
//     int res = Test(number);
//     Console.WriteLine("третее число :=" + res);
// }
// else {
//     Console.WriteLine(" вы ввели это число := " + number);
//     Console.WriteLine("введите трехзначное число ");
// }
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

void number(int num)
{
    if (num < 6) // проверка дня недели
     Console.WriteLine("нет уж , иди работать ");
    else
     Console.WriteLine(" ура выходной ");

}
Console.WriteLine("введите  число ");
int num = Convert.ToInt32(Console.ReadLine());//азпрашиваем ввод дня недели
 if (num < 8) //проверяем введенное число если оно больше  7 то программа выдает ошибку 
    number(num);
else 
Console.WriteLine(" ошибка, введите число от 1 до  7  ");