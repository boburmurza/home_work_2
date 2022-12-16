//  34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество 

//чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();

// }


// int Summ(int[] array)
// {
//     int summ = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//             summ += 1;
//     }
//     return summ;
// }

// Console.Write("введите размер массива := ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(size);
// ShowArray(array);
// Console.WriteLine($" {Summ(array)}");

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
//  int[] CreateArray(int size)
//  {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(1, 124);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();

// }


// int Summ(int[] array)
// {
//     int summ = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >10||99<array[i] )
//             summ += 1 ;
//     }
//     return summ;
// }


// int size = 123;
// int[] array = CreateArray(size);
// ShowArray(array);
// Console.WriteLine($" {Summ(array)}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] CreateArray(int size,int min_element,int max_element)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min_element, max_element);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();

// }


// int Summ(int[] array)
// {
//     int summ = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 != 0){
//             if (array[i]<0)
//              array[i]*=1;
//              summ += array[i];}
//     }
//     return summ;
// }

// Console.Write("введите минимальный элемент массива := ");
// int min_element = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите максимальный элемент массива := ");
// int max_element = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите размер массива := ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(size,min_element,max_element);
// ShowArray(array);
// Console.WriteLine($" {Summ(array)}");
//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76double[] CreateArray(int num, int min, int max){

//  double [] RandomArray (int size, double minValue, double maxValue){
//     double [] arr = new double [size];
//     for(int i = 0; i < size; i++){
//        arr[i] = minValue + new Random().NextDouble()*(maxValue-minValue);
//     }
//     return arr;
// }
// void ShowArray(double [] array){
//     for(int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
// }
// void Diff(double [] arr){
//     double min = arr[0];
//     double max = arr[0];
//     for(int i = 0; i < arr.Length; i++){
//         if(arr[i] <= min){
//             min = arr[i];
//             i++;
//         }
//         if(arr[i] >= max){
//             max = arr[i];
//             i++;
//         }
//     }
//     double difference=(max-min);
//     Console.WriteLine($"разнича между макс элементом и минимальным -> {difference}");
// }
// Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение элемента массива: ");
// double min = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите максимальное значение элемента массива: ");
// double max = Convert.ToDouble(Console.ReadLine());
// double [] array = RandomArray(size, min, max);
// ShowArray(array);
// Diff(array);
// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
int[] CreateArray(int size,int min_element,int max_element)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min_element , max_element);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();

}
void Couples (int [] array ) {
  

  int couples= array.Length-1;
  for (int i = 0; i <= couples; i++){
  if (i<couples){
      array[i]=array[i]*array[couples];
      couples-=1;
  }
  Console.Write($"{array[i]} ");
  }
}
Console.Write("введите минимальный элемент массива := ");
int min_element = Convert.ToInt32(Console.ReadLine());
Console.Write("введите максимальный элемент массива := ");
int max_element = Convert.ToInt32(Console.ReadLine());
Console.Write("введите размер массива := ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size,min_element,max_element);
ShowArray(array);
Console.WriteLine();
Console.Write(" новый массив := ");
Console.Write("[");
Couples(array);
Console.Write("]");