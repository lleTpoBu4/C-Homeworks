Console.WriteLine("Введите число из диапазона от 100 до 999.");
int n = Convert.ToInt32(Console.ReadLine());
int SecondNum()
{
    int second = n / 10 % 10;
    return second;
}
Console.WriteLine($"Второй символ введённого числа - {SecondNum()}");