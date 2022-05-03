//Ввод числа с преобразованием в int
//Проверка на положительность и инверсия при необходимости.
//нахождение количества символов
//если символов меньше 3, то сообщение: "третьей цифры нет"
//иначе - вывод третьей цифры.
Console.WriteLine("Введите целое число.");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 0) n = -n;
string numbers = Convert.ToString(n);
int[] array = new int[numbers.Length];
for (int i = 0; i < array.Length; i++)
{
    array[i] = numbers[i] - '0';
    Console.WriteLine(array[i]);
}
if (array.Length < 3)
    Console.WriteLine("Третьей цифры нет.");
else Console.WriteLine($"Третья цифра заданного числа - {array[2]}");