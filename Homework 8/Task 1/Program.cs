int[,] Array = new int[5, 5]; // Инициализируем массив
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

int[,] DescendingSort(int[,] IncomingArray) // Метод сортировки для каждой строки 2D массива по убыванию
{
    int min;
    for (int i = 0; i < IncomingArray.GetLength(0); i++)
    {
        for (int j = 0; j < IncomingArray.GetLength(1); j++)
        {
            for (int k = 0; k < IncomingArray.GetLength(1); k++)
            {
                if (IncomingArray[i, j] <= IncomingArray[i, k])
                    continue;
                else
                {
                    min = IncomingArray[i, k];
                    IncomingArray[i, k] = IncomingArray[i, j];
                    IncomingArray[i, j] = min;
                }
            }
        }
    }
    return IncomingArray;
}

Array = RandomArray2D(Array);
Print2DArray(Array);
int[,] SortArray = DescendingSort(Array);
Console.WriteLine();
Print2DArray(SortArray);