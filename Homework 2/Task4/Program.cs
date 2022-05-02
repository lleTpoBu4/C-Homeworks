Console.WriteLine("Введите целое число.");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 7 == 0 && n % 23 == 0)
Console.WriteLine($"Число {n} кратно 7 и 23 одновременно.");
else
Console.WriteLine($"Число {n} не кратно 7 и 23 одновременно.");