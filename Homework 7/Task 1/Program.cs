int[,] array = new int[4, 5]; //Создаём массив заданной размерности
const int cellWidth = 3; // Задаём размер ячейки элемента массива при выводе в консоль

void SpiralFilling() // Метод для заполнения массива по спирали числами, начиная с единицы, с шагом 1
{
    int NextStartForRow = 0;
    int NextStartForCol = 0;
    int NextEndForRow = array.GetLength(0);
    int NextEndForCol = array.GetLength(1);
    int value = 1;
    
    while (value < (array.GetLength(0) * array.GetLength(1))) //Закомментированные строки использовались для отладки
    {
        int i = 0;
        int j = 0;
        for (j = NextStartForCol; j < NextEndForCol; j++) // Столбец ++
        {
            i = NextStartForRow;
            if (value > array.GetLength(0) * array.GetLength(1)) break;
            //Console.WriteLine($"j++ [{i}, {j}] = {value}");
            array[i, j] = value;
            value++;
            //Console.WriteLine(value);
        }
        NextEndForCol = NextEndForCol - 1;
        //Console.WriteLine($"EndCol = {NextEndForCol}");

        for (i = NextStartForRow + 1; i < NextEndForRow; i++) // Строка ++
        {
            j = NextEndForCol;
            if (value > array.GetLength(0) * array.GetLength(1)) break;
            //Console.WriteLine($"i++ [{i}, {j}] = {value}");
            array[i, j] = value;
            value++;
            //Console.WriteLine(value);
        }
        NextEndForRow = NextEndForRow - 1;
        //Console.WriteLine($"EndRow = {NextEndForRow}");

        for (j = NextEndForCol-1; j >= NextStartForCol; j--) // Столбец --
        {
            i = NextEndForRow;
            if (value > array.GetLength(0) * array.GetLength(1)) break;
            //Console.WriteLine($"j-- [{i}, {j}] = {value}");
            array[i, j] = value;
            value++;
            //Console.WriteLine(value);
        }
        NextStartForCol++;
        //Console.WriteLine($"StartCol = {NextStartForCol}");

        for (i = NextEndForRow-1; i > NextStartForRow; i--) // Строка --
        {
            j = NextStartForCol - 1;
            if (value > array.GetLength(0) * array.GetLength(1)) break;
            //Console.WriteLine($"i-- [{i}, {j}] = {value}");
            array[i, j] = value;
            value++;
            //Console.WriteLine(value);
        }
        NextStartForRow++;
        //Console.WriteLine($"StartRow = {NextStartForRow}");
    }
}

void Print2DArray(int[,] IncomingArray)// Метод вывода элементов 2D массива в консоль в виде матрицы
{
    string ToPrint = String.Empty;
    for (int i = 0; i < IncomingArray.GetLength(0); i++)
    {
        ToPrint = String.Empty;
        for (int j = 0; j < IncomingArray.GetLength(1); j++)
            ToPrint = ToPrint + ($"{IncomingArray[i, j],cellWidth}");
        Console.WriteLine(ToPrint);
    }
}

SpiralFilling(); // Заполняем массив
Print2DArray(array); // Выводим на печать