//Инициализация массива
int[] array = new int[10];

int[] RandomArray(int[] arr) //Метод для заполнение массива случайными элементами (от 1 до 99)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 99);
    }
    return arr;
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

void PrintArrayOdd(int[] IncomeArray)//метод вывода нечётных элементов массива в консоль
{
    string ToPrint = "Элементы массива с нечётными позициями (индексом): ";
    for (int i = 1; i < IncomeArray.Length; i++)
    {
        if (i % 2 == 1)
        ToPrint = ToPrint + " " + IncomeArray[i];
    }
    Console.WriteLine(ToPrint);
}

int ArrayOddSumm(int[] IncomeArray)//Метод вычисления суммы элементов с нечётным индексом
{
    int summ = 0;
    for (int i = 1; i < IncomeArray.Length; i++)
    {
        if (i % 2 == 1)
        summ = summ + IncomeArray[i];
    }
    return summ;
}

array = RandomArray(array);
PrintArray(array);
PrintArrayOdd(array);
Console.WriteLine($"Сумма нечётных элементов масства: {ArrayOddSumm(array)}");