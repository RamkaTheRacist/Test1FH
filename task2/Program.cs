﻿/*Задача 2
Написать метод/функцию, который/которая на вход принимает число (float), а на выходе получает число, округленное до пятерок.
Пример:
27 => 25, 27.8 => 30, 41.7 => 40.*/

static float RoundNumberToFive(float number)
{
    float remainder = number % 5;
    if (remainder >= 2.5)
    {
        return number - remainder + 5;
    }
    return number - remainder;
}