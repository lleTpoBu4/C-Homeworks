int[,] Array = new int[6, 8]; // Инициализируем массив
const int cellWidth = 3; // Задаём размер ячейки элемента массива при выводе в консоль

int[,] RandomArray2D(int[,] arr) // Метод для заполнение массива случайными элементами (от 0 до 99)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = new Random().Next(0, 100);
    }
    return arr;
}

void Print2DArray(int[,] IncomingArray) // Метод вывода элементов 2D массива в консоль в виде матрицы
{
    string ToPrint = String.Empty;
    for (int i = 0; i < IncomingArray.GetLength(0); i++)
    {
        ToPrint = String.Empty;
        for (int j = 0; j < IncomingArray.GetLength(1); j++)
            ToPrint = ToPrint + " " + ($"{IncomingArray[i, j],cellWidth}");
        Console.WriteLine(ToPrint);
    }
}

void RowMinElementsSum(int[,] IncomingArray) // Метод нахождения строки с минимальной суммой элементов
{
    int minimumSum = 0;
    for (int i = 0; i < IncomingArray.GetLength(1); i++)
    {
        minimumSum = minimumSum + IncomingArray[0, i];
    }
    Console.WriteLine($"Сумма элементов 0-й строки: {minimumSum}");
    int minRowIndex = 0;
    int currentSum = 0;
    for (int i = 1; i < IncomingArray.GetLength(0); i++)
    {
        for (int j = 0; j < IncomingArray.GetLength(1); j++)
        {
            currentSum = currentSum + IncomingArray[i, j];
        }
        Console.WriteLine($"Сумма элементов {i}-й строки: {currentSum}");
        if (currentSum >= minimumSum)
            {
                currentSum = 0;
                continue;
            }
        else
        {
            minimumSum = currentSum;
            currentSum = 0;
            minRowIndex = i;
        }
    }
    Console.WriteLine($"Строка с минимальной суммой элементов: {minRowIndex}");
}

Array = RandomArray2D(Array);
Print2DArray(Array);
Console.WriteLine();
RowMinElementsSum(Array);