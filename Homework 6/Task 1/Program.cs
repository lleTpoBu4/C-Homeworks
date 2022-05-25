
int[,] RandomArray2D(int[,] arr) // Метод для заполнение массива случайными элементами (от 0 до 9)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = new Random().Next(0, 10);
    }
    return arr;
}

void PrintArray(int[] IncomingArray)// Метод вывода элементов 1D массива в консоль
{
    string ToPrint = String.Empty;
    for (int i = 0; i < IncomingArray.Length; i++)
    {
        //Console.Write($"{array[i]} ");
        ToPrint = ToPrint + " " + IncomingArray[i];
    }
    Console.WriteLine(ToPrint);
}

void Print2DArray(int[,] IncomingArray)// Метод вывода элементов 2D массива в консоль в виде матрицы
{
    string ToPrint = String.Empty;
    for (int i = 0; i < IncomingArray.GetLength(0); i++)
    {
        ToPrint = String.Empty;
        for (int j = 0; j < IncomingArray.GetLength(1); j++)
            ToPrint = ToPrint + " " + IncomingArray[i, j];
        Console.WriteLine(ToPrint);
    }
}

int[,] FrequencyResult(int[] IncomingDictionary, int[,] matrix) // Метод частотного словаря для матрицы натуральных чисел от 0 до 9
{
    int[,] ResultArray = new int[10, 2];
    for (int k = 0; k < IncomingDictionary.Length; k++)
    {
        int count = 0;
        ResultArray[k, 0] = IncomingDictionary[k];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == IncomingDictionary[k]) count = count + 1;
            }
            ResultArray[k, 1] = count;
        }
    }
    return ResultArray;
}

void PrintDictionaryResult(int[,] array) // Метод вывода полученных результатов.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
     Console.WriteLine($"{array[i,0]} встречается {array[i,1]} раз");
    }
}

int[,] array = new int[5, 5]; // Создаём массив
int[] Dictionary = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // Создаём словарь символов
PrintArray(Dictionary);
Console.WriteLine();
array = RandomArray2D(array); //Заполняем массив случайными числами от 0 до 9
Print2DArray(array); //Выводим заполненный массив для проверки
Console.WriteLine();
int[,] Result = FrequencyResult(Dictionary, array); //Сравниваем искомый массив со словарём и получаем массив с результатами подсчёта
PrintDictionaryResult(Result); // Выводим результаты частотного анализа