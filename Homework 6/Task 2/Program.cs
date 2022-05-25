const int cellWidth = 4;

int[,] RandomArray2D(int[,] arr) // Метод для заполнения массива случайными элементами (от 0 до 9)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = new Random().Next(0, 10);
    }
    return arr;
}

void Print2DArray(int[,] IncomingArray)// Метод вывода элементов 2D массива в консоль в виде матрицы
{
    string ToPrint = String.Empty;
    for (int i = 0; i < IncomingArray.GetLength(0); i++)
    {
        ToPrint = String.Empty;
        for (int j = 0; j < IncomingArray.GetLength(1); j++)
            ToPrint = ToPrint + ($"{IncomingArray[i, j], cellWidth}");
        Console.WriteLine(ToPrint);
    }
}

void MatrixMultiplication(int[,] matrix1, int[,] matrix2)// Метод вычисления произведения 2х матриц и вывода ответа в консоль
{
    int[,] ResultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine("Такие матрицы нельзя перемножить.");
    }
    else
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int k = 0; k < matrix2.GetLength(1); k++)
            {
                int Result = 0;
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    Result = Result + (matrix1[i,j]* matrix2[j,k]);
                }
                ResultMatrix[i,k] = Result;
                //Console.WriteLine(Result);
            }
        }
        Print2DArray(ResultMatrix);
    }    
}

int[,] array1 = new int[3, 4]; // Создаём массив 1
int[,] array2 = new int[4, 5]; // Создаём массив 2

array1 = RandomArray2D(array1); //Заполняем массив 1 случайными числами от 0 до 9
Print2DArray(array1); //Выводим заполненный массив 1
Console.WriteLine();
array2 = RandomArray2D(array2); //Заполняем массив 2 случайными числами от 0 до 9
Print2DArray(array2); //Выводим заполненный массив 2
Console.WriteLine();
MatrixMultiplication(array1, array2); // Вычисляем произведения 2х матриц
