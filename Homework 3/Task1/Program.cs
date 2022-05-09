//Ввод числа
//Проверка на соответствие вводимого числа условию (пятизначное число)
//создание массива с элементами, соответствующими цифрам числа
//Создание функции проверки числа (является ли число палиндромом)
    //проверка элементов массива поочерёдно на соответствие друг другу, согласно условию
    //возврат результата проверки
//Обращение к функции
//Вывод ответа
Console.WriteLine("Введите число из диапазона от 10000 до 99999.");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 0) n = -n;//на всякий случай

int[] NumToArray(int n)//преобразование числа в массив
{
    string numbers = Convert.ToString(n);
    int[] array = new int[numbers.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = numbers[i] - '0';
    }
    return array;
}

bool IsNumPal(int[] arr)//проверка на палиндром
{
    bool Is = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == arr[arr.Length - 1 - i]) Is = true;
        else Is = false;
        if (Is == false) break;
    }
    return Is;
}

int[] arr = NumToArray(n);
bool YesOrNo = IsNumPal(arr);

if (n < 10000 || n > 99999)
{
    Console.WriteLine("Введённое число не соответствует условию задачи.");
}
else
{
    if (YesOrNo == true)
        Console.WriteLine("Введённое число является палиндромом.");
    else
        Console.WriteLine("Введённое число не является палиндромом.");
}
