Console.WriteLine("Введите любое целое число:"); 
int n = Convert.ToInt32(Console.ReadLine()); //Ввод числа

//Создание методов:

int[] PosArray(int number) //Метод для N > 0
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = i + 1;
        //Console.Write($"{array[i]} ");
    }
    return array;
}

int[] ConsArray(int number) //Метод для N <= 0
{
    int[] array = new int[number + 2];
    for (int i = 0; i < number + 2; i++)
    {
        array[i] = -i + 1;
        //Console.Write($"{array[i]} ");
    }
    return array;
}

int[] Cubes(int[] array)//Метод, принимающий numbers[] и выдающий массив заполненный элементами numbers[], в 3-й степени.
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[i] * array[i] * array[i];
        //Console.Write($"{result[i]} ");
    }
    return result;
}

void PrintResult(int [] resultarray)//Метод вывода результата в консоль
 {
	string ToPrint = String.Empty;
	for (int i = 0; i < resultarray.Length; i++)
    {
        ToPrint = ToPrint +" " + resultarray [i];
    }
    Console.WriteLine(ToPrint);
 }

//Инициализация массива для дальнейшей работы:

int[] numbers;

//Проверка числа на знак (+ или -):

if (n > 0) //Построение массива numbers[N] с колличеством символов N и заполнение его числами от 1 до N
{
    numbers = PosArray(n);
}
else //Построение массива numbers[N] с колличеством символов |N|+2 и заполнение его числами от 1 до N
{
    n = -n;
    numbers = ConsArray(n);
}

int[] cubes = Cubes(numbers); //Обращение к методу и создание массива кубов

PrintResult(cubes);//Вывод результата (массив cubes[]) через метод