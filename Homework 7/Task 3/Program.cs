int[,,] array = new int[5, 5, 5]; // Инициализируем 3D массив
const int cellWidth = 3;
const int cellWidthForIndex = 2;

void FillAndPrint(int[,,] IncomingArray) // Метод заполнения и печати, согласно условиям задачи
{
    int size = IncomingArray.GetLength(0) * IncomingArray.GetLength(1) * IncomingArray.GetLength(2);
    int count = 10;
    if (size > 180)
    {
        Console.WriteLine("Исходя из условий задачи, заполнение массива такого размера не возможно.");
    }
    else
    {
        string ToPrint = String.Empty;
        for (int i = 0; i < IncomingArray.GetLength(0); i++)
        {
            for (int j = 0; j < IncomingArray.GetLength(1); j++)
            {
                ToPrint = String.Empty;
                for (int k = 0; k < IncomingArray.GetLength(2); k++)
                {
                    if (count == 100) count = -count + 1;
                    IncomingArray[i, j, k] = count;
                    ToPrint = ToPrint + " " + ($"{IncomingArray[i, j, k],cellWidth} [{i,cellWidthForIndex},{j,cellWidthForIndex},{k,cellWidthForIndex}]");
                    count++;
                }
                Console.WriteLine(ToPrint);
            }
            Console.WriteLine();
        }
    }
}

FillAndPrint(array); // Передаём массив в метод, заполняем и выводим в консоль