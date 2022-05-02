Console.WriteLine("Введите первое целое число.");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число.");
int m = Convert.ToInt32(Console.ReadLine());
if (n * n == m)
Console.WriteLine($"{m} является квадратом {n}");
else if (m * m == n)
Console.WriteLine($"{n} является квадратом {m}");
else
Console.WriteLine("Ни одно из чисел не является квадратом другого.");