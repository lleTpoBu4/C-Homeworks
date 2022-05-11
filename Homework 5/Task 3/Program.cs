//Инициализация массива
double[] array = new double[10];

double[] RandomArray(double[] arr) //Метод для заполнение массива случайными элементами (от -99 до 99)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100, 100) + new Random().NextDouble(); ;
    }
    return arr;
}

void PrintArray(double[] IncomeArray)//метод вывода элементов массива в консоль (с попыткой костыльного выравнивания в столбик)
{
    for (int i = 0; i < IncomeArray.Length; i++)
    {
        if (IncomeArray[i] < 0)
        {
            if (IncomeArray[i] > -10)
                Console.WriteLine($"- {-IncomeArray[i]}");
            else Console.WriteLine(IncomeArray[i]);
        }

        else
        {
            if (IncomeArray[i] < 10)
            Console.WriteLine($"  {IncomeArray[i]}");
            else Console.WriteLine($" {IncomeArray[i]}");
        }
    }
}

double ArrayMaxElement(double[] IncomeArray)//Метод вычисления максимального элемента массива
{
    double max = -100;
    for (int i = 1; i < IncomeArray.Length; i++)
    {
        if (IncomeArray[i] > max)
            max = IncomeArray[i];
    }
    return max;
}

double ArrayMinElement(double[] IncomeArray)//Метод вычисленияминимального элемента массива
{
    double min = 100;
    for (int i = 1; i < IncomeArray.Length; i++)
    {
        if (IncomeArray[i] < min)
            min = IncomeArray[i];
    }
    return min;
}

array = RandomArray(array);
Console.WriteLine("Массив:");
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Максимальный элемент массива: {ArrayMaxElement(array)}");
Console.WriteLine($"Минимальный элемент массива: {ArrayMinElement(array)}");
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {ArrayMaxElement(array) - ArrayMinElement(array)}");