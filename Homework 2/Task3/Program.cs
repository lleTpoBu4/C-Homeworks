Console.WriteLine("Введите первое целое число.");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число.");
int b = Convert.ToInt32(Console.ReadLine()); 
int ost = b % a;
Console.WriteLine(ost);
if (ost == 0) 
Console.WriteLine($"Число {b} кратно числу {a}.");
else
Console.WriteLine($"Число {b} некратно числу {a}, остаток = {ost}");