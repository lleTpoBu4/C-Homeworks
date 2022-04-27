//Ввод данных с типом отличным от запрашиваемого, 
//а так же оставление пустого значения в поле ввода не рассматривается.
Console.WriteLine("Введите любое число: ");
double a = Double.Parse(Console.ReadLine());
if (a < 0)
a = -a;

if (a%2 > 0)
{
    Console.WriteLine("Число нечётное");
}
else
{
    Console.WriteLine("Число чётное");
}