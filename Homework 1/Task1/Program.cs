//Ругается, но работает. Как MVP сойдёт.
//Думаю, неплохо для первого кода =)
Console.WriteLine("Введите любое число: ");
double a = Double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе любое число: ");
double b = Double.Parse(Console.ReadLine());
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