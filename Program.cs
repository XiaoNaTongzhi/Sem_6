
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.Write("Введи несколько чисел через пробел: ");
// string m = Console.ReadLine()!;
// int[] array = m.Split(' ').Select(int.Parse).ToArray(); // в сети нашла

// int count = 0;
// for (int p = 0; p < array.Length; p++)
// {
//     if (array[p] > 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Из введённых чисел {count} положительных.");




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// y-y = (k1x + b1) - (k2x + b2)
// k1x + b1 - k2x - b2 = 0
// k1x - k2x = b2 - b1
// x (k1 - k2) = b2 - b1
// x = (b2 - b1)/(k1-k2)


// Console.Write("k1 (ноль нельзя) = ");
// double k1 = double.Parse(Console.ReadLine()!);

// Console.Write("b1 = ");
// double b1 = double.Parse(Console.ReadLine()!);

// Console.Write("k2 (ноль нельзя) = ");
// double k2 = double.Parse(Console.ReadLine()!);

// Console.Write("b2 = ");
// double b2 = double.Parse(Console.ReadLine()!);

// if (k1 == k2)
// {
//     Console.WriteLine("Прямые не пересекаются.");
// }
// else if (k1 == 0 || k2 == 0)
// {
//     Console.WriteLine("Не бывает прямых с нулевым k, введи другое число.");
// }
// else
// {
// double x = (b2 - b1) / (k1 - k2);
// double y = k1 * x + b1;
// Console.WriteLine($"Прямые пересекаются в точке x = {x}, y = {y}]");
// }






// ЗАДАЧИ С СЕМИНАРА

// // НА ВХОД 3 ЧИСЛА, МОЖЕТ ЛИ СУЩЕСТВОВАТЬ ТРЕУГОЛЬНИК 
// // Каждая сторона треугольника меньше суммы двух других сторон.

// Console.Write($"Первое число: ");
// int ab = int.Parse(Console.ReadLine()!);
// Console.Write($"Второе число: ");
// int bc = int.Parse(Console.ReadLine()!);
// Console.Write($"Третье число: ");
// int ca = int.Parse(Console.ReadLine()!);

// if (
// ab + bc > ca &&
// bc + ca > ab &&
// ca + ab > bc)
// {
//     Console.WriteLine("Такой треугольник существует.");
// }
// else
// {
//     Console.WriteLine("Такого треугольника НЕ существует.");
// }


// ДЕСЯТИЧНОЕ В ДВОИЧНОЕ (--)

// Console.Write($"Введи число: ");
// string aS = (Console.ReadLine()!);
// int a = int.Parse(aS);

// int[] array = new int[aS.Length];
// for (int i = array.Length - 1; i >= 0; i--)
// {
//     array[i] = a % 2;
// }
// Console.WriteLine(String.Join(", ", array));



// ДЕСЯТИЧНОЕ В ДВОИЧНОЕ ЧЕРЕЗ СТРОКУ (--)

// Console.Write($"Введи число: ");
// int a = int.Parse(Console.ReadLine()!);
// string dual = Convert.ToString(a);

// for (int i = dual.Length - 1; i >= 0; i--)
// {
//     dual = dual + Convert.ToString(a % 2);
//     a = a / 2;
// }

// Console.Write(dual);


// ДЕСЯТИЧНОЕ В ДВОИЧНОЕ ИЗ ВИДЕО

// Console.Write($"Введи число: ");
// int x = int.Parse(Console.ReadLine()!);
// string y = string.Empty;

// while (x > 0)
// {
//  int remainder = x % 2;
//  x = x / 2;
//  y = y + Convert.ToString(remainder);
// }
// Console.Write(y);

// string k = string.Empty;
// for (int i = y.Length - 1; i >=0; i--)
// {
//     k += y[i];
// }

// Console.WriteLine();
// Console.Write(k);




// ДВУМЕРНЫЕ МАССИВЫ
// ЗАДАЧИ С ЛЕКЦИИ


// string[,] table = new string [2,3]；
// int[,] matrix = new int [5,8]; // rкол-во строк, столбцов

// Обратиться к элементу: имя массива, индекс строки, индекс столбца
// table[0,0], table[0,1], table[0,2] 1-й, 2-й и 3-й столбик
// table[0,0], table[1,0], table[2,0] 1-я, 2-я и 3-я строчки


// string[,] table = new string[2, 5];
// table[1, 2] = "слово";



// // ***
// // ЗАПОЛНЕНИЕ МАТРИЦЫ

// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// Fillarray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// void Fillarray(int[,] mat)
// {
//     for (int i = 0; i < mat.GetLength(0); i++)
//     {
//         for (int j = 0; j < mat.GetLength(1); j++)
//         {
//             mat[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


