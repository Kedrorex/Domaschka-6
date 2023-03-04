﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите числа: ");

string test = Console.ReadLine();
string[] temp = test.Split(new Char[] { ' ' });

System.Console.WriteLine($"[ {string.Join(", ", temp)} ] ");
int[] number = new int[temp.Length];
int positiv = 0;

for (int i = 0; i < number.Length; i++)
{
  number[i] = Convert.ToInt32(temp[i]);
  if (number[i] > 0)
  {
    positiv++;
  }
}

Console.WriteLine();
Console.WriteLine($"Чисел больше 0 : {positiv}");
