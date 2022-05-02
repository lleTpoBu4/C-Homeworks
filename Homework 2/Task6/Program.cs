Console.WriteLine("Введите целое число из диапазона от -1000 до -9999.");
int n = Convert.ToInt32(Console.ReadLine());
int result = -n / 10 % 10;
if (n < -9999 || n > -1000)
Console.WriteLine("Введённое число не соответствует условию задачи.");  
else 
Console.WriteLine($"{result} - вторая цифра этого числа.");