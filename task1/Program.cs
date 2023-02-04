/*Задача 1
Написать метод/функцию, который/которая на вход принимает массив городов. В качестве результата возвращает строку, где города разделены запятыми, а в конце стоит точка. 
Пример:
«Москва, Санкт-Петербург, Воронеж.» */

static string ParseArray(string[] array)
{
    string result = "";
    if (array.Length > 0)
    {
        for (int i = 0; i < array.Length; i++)
        {
            
            result+=array[i];
            if(i == array.Length - 1){
                result+=".";
            }else{
                result+=", ";
            }

        }
    }
    return result;
}