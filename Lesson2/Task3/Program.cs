﻿
// int n = 10;
int[] array = { 1, 5, 4, 7, 8, 35, 15, 3, 8, 7 };
int i = 0;

while (i < array.Length)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }

    i = i + 1;
}


