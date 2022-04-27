Console.Write("Введите число: ");
int n = Int32.Parse(Console.ReadLine());
int CurrentNumber = -n;

if (n > 0)
    for (; CurrentNumber <= n;)
        {
            Console.Write($"{CurrentNumber}, ");
            CurrentNumber++;
        }
else
     for (; CurrentNumber >= n;)
        {
            Console.Write($"{CurrentNumber}, ");
            CurrentNumber--;
        }