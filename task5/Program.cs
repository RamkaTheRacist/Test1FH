/*Задача 5
Написать метод, который определяет, какие элементы присутствуют в двух экземплярах в каждом из массивов (= в двух и более, причем в каждом). 
На вход подаются два массива. На выходе массив с необходимыми совпадениями.
Пример:
[7, 17, 1, 9, 1, 17, 56, 56, 23], [56, 17, 17, 1, 23, 34, 23, 1, 8, 1]
На выходе [1, 17]*/

static int[] CheckArrays(int[] array1, int[] array2)
{
    if ((array1.Length) > 1 && (array2.Length > 1))
    {
        Stack<int> numbers = new Stack<int>();
        for (int i = 0; i < array1.Length; i++)
        {
            if (Array.IndexOf(array1, array1[i]) != Array.LastIndexOf(array1, array1[i]))
            {
                if ((Array.IndexOf(array2, array1[i]) != Array.LastIndexOf(array2, array1[i])) && (Array.IndexOf(array2, array1[i]) != -1))
                {
                    if (!numbers.Contains(array1[i]))
                    {
                        numbers.Push(array1[i]);
                    }
                }
            }
        }
        return numbers.ToArray();
    }
    return new int[0];  // временная обработка невалидных данных
}

