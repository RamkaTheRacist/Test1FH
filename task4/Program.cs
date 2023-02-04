/*Задача 4
Написать метод/функцию, который/которая на вход принимает целое число, а на выходе возвращает то, является ли число простым (не имеет делителей кроме 1 и самого себя).*/

// Перебор делителей

static bool ifSimpleNumber(int number)
{
    if (number <= 1)
    {
        return false;
    }
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }
    return true;
}

