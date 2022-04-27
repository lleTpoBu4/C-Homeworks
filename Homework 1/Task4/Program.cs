Console.Write("Введите любое натуральное число: ");
int n = Int32.Parse(Console.ReadLine());
int CurrentNumber;
for (CurrentNumber = 1; CurrentNumber <= n;)
{
    if (CurrentNumber % 2 == 0)
        {
            Console.Write($"{CurrentNumber}, ");
            CurrentNumber++;
        }
    else
        CurrentNumber++;
}