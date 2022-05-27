
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

(int, int) GetMinElementIndex(int[,] IncomingArray) //Метод получения индекса минимального элемента
{
    int min = IncomingArray[0, 0];
    int MinIndexRow = 0;
    int MinIndexCol = 0;
    for (int i = 0; i < IncomingArray.GetLength(0); i++)
    {
        for (int j = 0; j < IncomingArray.GetLength(1); j++)
        {
            if (IncomingArray[i, j] < min)
            {
                min = IncomingArray[i, j];
                MinIndexRow = i;
                MinIndexCol = j;
            }
        }
    }
    return (MinIndexRow, MinIndexCol);
}

int[,] ResizeArray(int[,] IncomingArray, int DelRow, int DelCol) // Метод вычитания строки и столбца массива с первым минимальным элементом
{
    int[,] ReturnableArray = new int[IncomingArray.GetLength(0) - 1, IncomingArray.GetLength(1) - 1];
    int k = 0;
    int n = 0;
    for (int i = 0; i < IncomingArray.GetLength(0); i++) //Закомментированые строки использовались для отладки
    {
        //Console.WriteLine($"New");
        if (i == DelRow)
        {
            continue;
        }
        else
        {
            if (k == ReturnableArray.GetLength(0))
                break;
            n = 0;
            for (int j = 0; j < IncomingArray.GetLength(1); j++)
            {
                //Console.WriteLine($"k = {k}, n = {n}");
                if (j == DelCol)
                {
                    continue;
                }
                else
                {
                    if (n == ReturnableArray.GetLength(0))
                        break;
                    ReturnableArray[k, n] = IncomingArray[i, j];
                    //Console.WriteLine($" {ReturnableArray[k, n]}");
                    n++;
                }
            }
            k++;
        }
    }
    return (ReturnableArray);
}


int[,] OriginalArray = new int[6, 6]; // Инициализируем массив
int IgnoreRow; // Переменная. содержащая индекс строки минимального элемента
int IgnoreCol; // Переменная. содержащая индекс столбца минимального элемента

OriginalArray = RandomArray2D(OriginalArray); //Заполняем массив

Print2DArray(OriginalArray); //Печатаем его

(IgnoreRow, IgnoreCol) = GetMinElementIndex(OriginalArray); //Находим индекс минимального элемента

Console.WriteLine();

Console.WriteLine($"cтрока - {IgnoreRow+1}, столбец - {IgnoreCol+1}");// Выводим номер строки и столбца с минимальным элементом
                                                                      //(с поправкой на общепринятую, а не программистскую нумерацию, начиная с 1)

int[,] GottenArray = new int[OriginalArray.GetLength(0) - 1, OriginalArray.GetLength(1) - 1]; //Создаём массив на 1 строку и 1 столбец меньше исходного

GottenArray = ResizeArray(OriginalArray, IgnoreRow, IgnoreCol); //Переписываем элементы первого массива в новый, игнорируя строку и столбец с минимальным элементом
Console.WriteLine();
Print2DArray(GottenArray); //Печатаем получившийся массив