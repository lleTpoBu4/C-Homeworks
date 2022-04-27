//Ругается, но работает. Как MVP сойдёт.
//Думаю, неплохо для первого кода =)
Console.WriteLine("Введите любое число: ");
string first = Console.ReadLine();
Console.WriteLine("Введите второе любое число: ");
string second = Console.ReadLine();
double a = Double.Parse(first);
double b = Double.Parse(second);
string max = "Максимальное число";
string min = "Минимальное число";
if (a > b)
{
    Console.WriteLine($"{max} = {a} {min} = {b}");
}
else
{
    if (a == b)
    {
        Console.WriteLine("Введёные числа равны");
    }
    else
    {
        Console.WriteLine($"{max} = {b} {min} = {a}");
    }
}