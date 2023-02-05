/*Задача 6
Написать метод, который в консоль выводит таблицу умножения. На вход метод получает число, до которого выводит таблицу умножения. 
В консоли должна появиться таблица. Например, если на вход пришло число 5, то получим:
Важно: 
В последней строке между числами ровно по одному пробелу должно выводиться. 
В каждом столбце числа должны быть выровнены по правому краю.*/

static void ShowTableOfMultiply(int number)
{
    for (int i = 0; i <= number; i++)
    {
        for (int k = 0; k <= number; k++)
        {
            string tmpString = "";
            string separation = " ";
            if (k == 0)
            {
                tmpString = $"{i}";
                if (tmpString.Length == String.Format($"{number}").Length)
                {
                    separation = "";
                }
            }
            else if (i == 0)
            {
                tmpString = $"{k}";

            }
            else
            {
                tmpString = $"{i * k}";
            }
            if (i != number)
            {
                if (tmpString.Length != String.Format($"{(number) * k}").Length)
                {
                    for (int z = 0; z < (String.Format($"{(number) * k}").Length - tmpString.Length); z++)
                    {
                        separation += " ";
                    }
                }
            }
            System.Console.Write(separation + tmpString);
        }
        System.Console.WriteLine();
    }
}