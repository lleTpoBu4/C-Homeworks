int lines = 5; // Задаём количество строк
int[,] PascalTriangle = new int[lines, lines]; // Инициализируем 2D массив для заполнения с заданным размером
const int cellWidth = 4; // Вводим константу для фиксированного размера одного элемента при выводе массива в консоль

void FillPascalTriangle() // Метод для заполнения массива в виде прямоугольного треугольника
{
    for (int i = 0; i < lines; i++)
    {
        PascalTriangle[i, 0] = 1;
        PascalTriangle[i, i] = 1;
    }

    for (int i = 2; i < lines; i++)
    {
        for (int j = 1; j < i; j++)
        {
            PascalTriangle[i, j] = PascalTriangle[i - 1, j - 1] + PascalTriangle[i - 1, j];
        }
    }

}

void PrintTriangleArray(int[,] IncomingArray)// Метод вывода элементов массива в консоль игнорируя нулевые значения
{
    string ToPrint = String.Empty;
    for (int i = 0; i < IncomingArray.GetLength(0); i++)
    {
        ToPrint = String.Empty;
        for (int j = 0; j < IncomingArray.GetLength(1); j++)
        {
            if (IncomingArray[i, j] == 0)
            {
                ToPrint = ToPrint + "";
            }
            else
            {
            ToPrint = ToPrint + ($"{IncomingArray[i, j],cellWidth}");
            }
        }
        Console.WriteLine(ToPrint);
    }
}

FillPascalTriangle();
PrintTriangleArray(PascalTriangle);