/*Задача 3
Написать метод/функцию, который/которая на вход принимает число (int), а на выходе выдает слово “компьютер” в падеже, 
соответствующем указанному количеству. Например, «25 компьютеров», «41 компьютер», «1048 компьютеров».*/

// v1 
//Math.Abs => понятное дело, что отрицательного количества нет, но как обрабатывать невалидные данные пока неизветно

static void TellHowMuchPC(int number)
{
    int tmpNumber = number;
    string lastLetters = "";
    if (Math.Abs(tmpNumber) > 100)
    {
        tmpNumber %= 100;
    }

    if ((Math.Abs(tmpNumber) > 4) && (Math.Abs(tmpNumber) < 21))
    {
        lastLetters = "ов";
    }
    else
    {
        tmpNumber %= 10;
        if ((Math.Abs(tmpNumber) > 1) && (Math.Abs(tmpNumber) < 5))
        {
            lastLetters = "а";
        }
        else if ((Math.Abs(tmpNumber) > 4) && (Math.Abs(tmpNumber) < 10) || (Math.Abs(tmpNumber) == 0))
        {
            lastLetters = "ов";
        }
    }
    System.Console.WriteLine($"{number} компьютер{lastLetters}");
}

//v2

static string TellHowMuchPCv2(int number)
{
    int tmpNumber = number;
    string lastLetters = "";
    if (Math.Abs(tmpNumber) > 100)
    {
        tmpNumber %= 100;
    }

    if ((Math.Abs(tmpNumber) > 4) && (Math.Abs(tmpNumber) < 21))
    {
        lastLetters = "ов";
    }
    else
    {
        tmpNumber %= 10;
        if ((Math.Abs(tmpNumber) > 1) && (Math.Abs(tmpNumber) < 5))
        {
            lastLetters = "а";
        }
        else if ((Math.Abs(tmpNumber) > 4) && (Math.Abs(tmpNumber) < 10) || (Math.Abs(tmpNumber) == 0))
        {
            lastLetters = "ов";
        }
    }
    return $"{number} компьютер{lastLetters}";
}

