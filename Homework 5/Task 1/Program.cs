//Инициализация массива
int[] array = new int[20];

int[] RandomArray(int[] arr) //Метод для заполнение массива случайными элементами, удовлетворяющими условиям (от 100 до 999)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 999);
    }
    return arr;
}

int NumOfEven(int[] IncomeArr)//Метод для нахождения колличества чётных элементов в массиве (счётчик)
{
    int n = 0;
    for (int i = 0; i < IncomeArr.Length; i++)
    {
        if (IncomeArr [i] % 2 == 0)
        n = n + 1;
    }
    return n;
}

void PrintArray(int[] IncomeArray)//метод вывода элементов массива в консоль
{
    string ToPrint = "Массив: ";
    for (int i = 0; i < IncomeArray.Length; i++)
    {
        //Console.Write($"{array[i]} ");
        ToPrint = ToPrint + " " + IncomeArray[i];
    }
    Console.WriteLine(ToPrint);
}

void PrintTheAnswer (int n)//Метод вывода ответа (показаний счётчика) в консоль
{
    if (n == 1)
    {
        Console.WriteLine($"В массиве {n} чётный элемент");
    }
    else
    if (1 < n && n < 5)
    {
        Console.WriteLine($"В массиве {n} чётных элемента");
    }
    else
    {
        Console.WriteLine($"В массиве {n} чётных элементов");
    }
}

array = RandomArray(array);
PrintArray(array);
int EvenNumbers = NumOfEven(array);
PrintTheAnswer (EvenNumbers);
