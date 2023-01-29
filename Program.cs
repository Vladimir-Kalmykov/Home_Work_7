// // Задача №1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);
// double[,] numbers = new double[rows, columns];
// RandomNumbers(numbers);
// PrintArray(numbers);

// void RandomNumbers(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-10, 10)) / 2;
//         }
//     }
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "|");
//         }
//         Console.WriteLine("");
//     }
// }

// // Задача №2. Напишите программу, которая на вход принимает число, и проверяет есть ли такое число в двумерном массиве, а также возвращает сообщение о том, что оно найдено или же указание, что такого элемента нет.
// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// Console.Write("Введите число которое нужно найти: ");
// int namber = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);


// if (FindNamber(array,namber))
// {
//     Console.WriteLine("Число найдено");
// }
// else
// {
//     Console.WriteLine("Число не найдено");
// }

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);

//         }
//     }
//     return result;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// bool FindNamber (int[,] arra,int nam)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i,j] == nam)return true;
//         }
        
//     }
//     return false;
// }

// // Задача №3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);

//         }
//     }
//     return result;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// for (int j = 0; j < array.GetLength(1); j++)
// {
//     double sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         sum += array[i, j];
//     }
//     Console.Write($"{sum / array.GetLength(0)}");
// }