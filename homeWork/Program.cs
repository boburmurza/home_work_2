// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
// void Palindrome(int number)
// {
//     int a = number / 10000;
//     int b = number / 1000 % 10;
//     int c = number / 10 % 10;
//     nint d = number % 10;
//     if ((a == d) && (b == c))
//         Console.Write("это число  палиндромом");
//     else Console.Write(" это число не палиндромом");
// }
// Console.Write("введите пятизначное число :=");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 1000)
//     Palindrome(number);
// else
//     Console.Write(" ошибка ,введите пятизначное число ");


// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// void Distance(int X1, int Y1, int X2, int Y2 ,int Z1,int Z2) {
//     double num = Math.Sqrt((X2 - X1)*(X2 - X1) + (Y2 - Y1)*(Y2 - Y1)+ (Z2 - Z1)*(Z2 - Z1));

//     Console.WriteLine("Расстояние =" + num);
// }

// Console.Write("Введите координату X1:");
// int X1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y1:");
// int Y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату X2:");
// int X2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y2:");
// int Y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y2:");
// int Z2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату X2:");
// int Z1 = Convert.ToInt32(Console.ReadLine());

// Distance(X1, Y1, X2, Y2 , Z1 , Z2);

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125
// int summ = 0;
// void Cube_nymber( int number){
//     for ( int i = 1 ; i <= number; i++){

//      Console.Write((i*i)*i+" ");
//    }


// }
// Console.Write("введите число := ");
// int number = Convert.ToInt32(Console.ReadLine());
// Cube_nymber(number);